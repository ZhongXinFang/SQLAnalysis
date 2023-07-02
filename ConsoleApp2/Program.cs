using System;
using TextCopy;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 写入剪切板
            //await ClipboardService.SetTextAsync("你好，世界！");

            // 读取剪切板
            string clipboardText = await ClipboardService.GetTextAsync();
            Console.WriteLine("剪切板内容: " + clipboardText);
        }
    }
} 