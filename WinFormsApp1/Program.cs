using NHotkey.WindowsForms;
using NHotkey;

namespace WinFormsApp1;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        try
        {
            HotkeyManager.Current.AddOrReplace("MyShortcut",Keys.Alt | Keys.F12,OnGlobalShortcutPressed);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ע��ȫ�ֿ�ݼ�ʧ��: {ex.Message}");
        }

        void OnGlobalShortcutPressed(object sender,HotkeyEventArgs e)
        {
            Console.WriteLine("ȫ�ֿ�ݼ�������");
            e.Handled = true;
        }
    }
}