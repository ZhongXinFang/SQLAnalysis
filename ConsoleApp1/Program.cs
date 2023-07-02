using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace SQLReverseParameterization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一行参数化SQL查询（暂时只支持一行）：");
            string capturedQuery = Console.ReadLine();

            while (true)
            {
                var temp = Console.ReadLine();

                if (temp is not null && !string.IsNullOrWhiteSpace(temp))
                {
                    capturedQuery += temp;
                }
                else
                    break;
            }

            // 提取参数化查询和参数列表
            Match queryMatch = Regex.Match(capturedQuery,@"exec sp_executesql N'(.+)',N'(.+)'",RegexOptions.Singleline);
            if (!queryMatch.Success)
            {
                Console.WriteLine("无法解析输入的SQL查询。");
                return;
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

            Console.WriteLine("反参数化后的SQL查询：");
            Console.WriteLine(deParametrizedQuery);
        }

    }
}