using System.Diagnostics;

string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
string batFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"StartConfig.bat");

Process process = new Process();
process.StartInfo.FileName = "cmd.exe";
process.StartInfo.Arguments = $"/c \"{batFilePath}\""; // 使用 /c 参数运行 cmd.exe 并指定要运行的 BAT 文件
process.Start();