using NHotkey;
using System.Windows.Forms;
using NHotkey;
using NHotkey.WindowsForms;
try
{
    HotkeyManager.Current.AddOrReplace("MyShortcut",Keys.Alt | Keys.F12,OnGlobalShortcutPressed);
}
catch (Exception ex)
{
    Console.WriteLine($"注册全局快捷键失败: {ex.Message}");
}

void OnGlobalShortcutPressed(object sender,HotkeyEventArgs e)
{
    Console.WriteLine("全局快捷键被按下");
    e.Handled = true;
}