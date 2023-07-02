using System.Runtime.InteropServices;

namespace WinFormsApp2;
public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private const int WM_CLIPBOARDUPDATE = 0x031D;

    [DllImport("user32.dll",SetLastError = true)]
    private static extern bool AddClipboardFormatListener(IntPtr hwnd);

    [DllImport("user32.dll",SetLastError = true)]
    private static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

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

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_CLIPBOARDUPDATE)
        {
            // 剪贴板内容发生变化时触发此方法
            string clipboardText = Clipboard.GetText();
            Console.WriteLine("Clipboard content changed: " + clipboardText);
            MessageBox.Show("Clipboard content changed: " + clipboardText);
        }
        base.WndProc(ref m);
    }
}
