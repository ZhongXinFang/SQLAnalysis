using MainForm.Services.ListBox;
using NHotkey;
using NHotkey.WindowsForms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using TextCopy;
namespace WinFormsApp2;
public partial class Form1 : Form
{
    private readonly ListBoxService mListBoxService = new();

    public Form1()
    {
        InitializeComponent();
        try
        {
            HotkeyManager.Current.AddOrReplace("MyShortcut",Keys.Alt | Keys.Space,OnGlobalShortcutPressed);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"注册全局快捷键失败,无法使用\r\n 错误信息: {ex.Message}");
            Close();
        }
    }

    /// <summary>
    /// 获取剪贴板内容，如果是SQL Server的参数化查询，则反参数化后返回
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnGlobalShortcutPressed(object sender,HotkeyEventArgs e)
    {
        string? clipboardText = ClipboardService.GetText();
        if (!string.IsNullOrWhiteSpace(clipboardText))
        {
            var res = Service(clipboardText);
            if (res is not null)
            {
                ClipboardService.SetText(res);
                ListBoxAddService(clipboardText,res);
            }
            else
            {
                ListBoxAddService(clipboardText,"无法处理语句");
            }
        }
        e.Handled = true;
    }
    private void ListBoxAddService(string originalSQL,string newSQL)
    {
        originalSQL = originalSQL ?? throw new ArgumentNullException(nameof(originalSQL));
        newSQL = newSQL ?? throw new ArgumentNullException(nameof(newSQL));

        if (string.IsNullOrWhiteSpace(originalSQL))
            throw new ArgumentException("message",nameof(originalSQL));
        if (string.IsNullOrWhiteSpace(newSQL))
            throw new ArgumentException("message",nameof(newSQL));

        mListBoxService.Add(new ListBoxModel() { OriginalSQL = originalSQL,NewSQL = newSQL });
        listBox1.DataSource = null;
        listBox1.DataSource = mListBoxService.Data;
        listBox1.DisplayMember = nameof(ListBoxModel.Name);
        listBox1.ValueMember = nameof(ListBoxModel.Id);
    }
    private static string? Service(string data)
    {
        string capturedQuery = data;
        while (true)
        {
            var temp = Console.ReadLine();
            if (temp is not null && !string.IsNullOrWhiteSpace(temp))
                capturedQuery += temp;
            else
                break;
        }

        // 提取参数化查询和参数列表
        Match queryMatch = Regex.Match(capturedQuery,@"exec sp_executesql N'(.+)',N'(.+)'",RegexOptions.Singleline);
        if (!queryMatch.Success)
        {
            // 无法解析
            MessageBox.Show("ERROR");
            return null;
        }

        string parametrizedQuery = queryMatch.Groups[1].Value.Replace("''","'");
        string parametersString = queryMatch.Groups[2].Value;

        Dictionary<string,string> parameterDictionary = new Dictionary<string,string>();

        // 匹配参数名称和值（包括空字符串）
        Match parameterMatch = Regex.Match(capturedQuery,@"(@\w+)=N'((?:''|[^'])*)'",RegexOptions.Singleline);

        while (parameterMatch.Success)
        {
            parameterDictionary.Add(parameterMatch.Groups[1].Value,$"'{parameterMatch.Groups[2].Value}'");
            parameterMatch = parameterMatch.NextMatch();
        }

        string deParametrizedQuery = Regex.Replace(parametrizedQuery,@"\@\w+",m => parameterDictionary.ContainsKey(m.Value) ? parameterDictionary[m.Value] : m.Value);

        Console.WriteLine($"反参数化后的SQL查询：{deParametrizedQuery}");
        return deParametrizedQuery;
    }

    #region 剪切板监听
    private const int WM_CLIPBOARDUPDATE = 0x031D;
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        AddClipboardFormatListener(Handle);
    }
    protected override void OnHandleDestroyed(EventArgs e)
    {
        RemoveClipboardFormatListener(Handle);
        base.OnHandleDestroyed(e);
    }

    /// <summary>
    /// 剪贴板内容发生变化时触发此方法
    /// </summary>
    /// <param name="m"></param>
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_CLIPBOARDUPDATE)
        {
            // 暂时屏蔽此功能
            //string clipboardText = System.Windows.Forms.Clipboard.GetText();
            //var res = Service(clipboardText);
            //if (res is not null)
            //{
            //    var formatter = new BasicSQLFormatter.SQLFormatter(res);
            //    var formattedSql = formatter.Format();
            //    if (!string.IsNullOrWhiteSpace(formattedSql))
            //    {
            //        ClipboardService.SetText(formattedSql);
            //    }
            //}
        }
        base.WndProc(ref m);
    }

    [DllImport("user32.dll",SetLastError = true)]
    private static extern bool AddClipboardFormatListener(IntPtr hwnd);

    [DllImport("user32.dll",SetLastError = true)]
    private static extern bool RemoveClipboardFormatListener(IntPtr hwnd);
    #endregion
    private void listBox1_SelectedIndexChanged(object sender,EventArgs e)
    {
        //ListBoxModel? res = (ListBoxModel)listBox1.SelectedValue;
        Guid? id = listBox1.SelectedValue as Guid?;
        if (id is null)
            return;
        ListBoxModel? res = mListBoxService.Data.FirstOrDefault(x => x.Id == id);
        if (res is null)
            throw new Exception("ID IS NOT ?");
        textBox1.Text = res.OriginalSQL;
        textBox2.Text = res.NewSQL;
    }
}
