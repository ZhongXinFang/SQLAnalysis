using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Service;
internal class WindowsQueue : NativeWindow
{
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == WM_CLIPBOARDUPDATE)
        {
            if (Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();
                string text = null!;
                var bmp = (Bitmap)image;
                try { text = mCodeService.InitQrForBitmap(bmp); } catch { }
                if (text != null)
                    ShowInfo(text);
            }
        }
        base.WndProc(ref m);
    }
    [System.Runtime.InteropServices.DllImport("user32.dll",SetLastError = true)]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    static extern bool AddClipboardFormatListener(IntPtr hwnd);

}
