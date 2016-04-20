using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Jitbit.Utils;

namespace CsvToCSharpClass.Console
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Out = @"Tables\";
        public const string In = @"CSharp\";
        static void Main(string[] args)
        {
            string url = System.AppDomain.CurrentDomain.BaseDirectory + Out;
            DirectoryInfo folder = new DirectoryInfo (url);
            foreach (var item in folder.GetFiles("*.csv"))
            {
                string fileName = item.Name;
                Program.CsvFileToCSharpClass (url + fileName);
            }
            
        }


        public static void CsvFileToCSharpClass ( string filePath )
        {
            //读取所有的数据
            string[] lines = File.ReadAllLines (filePath);

            //类型
            string[] variableName = lines[0].Split (',').Select (str => str.Trim ()).ToArray ();
            //属性
            string[] typeName = lines[1].Split (',').Select (str => str.Trim ()).ToArray ();
            //注释
            string[] noteStr = lines[2].Split (',').Select (str => str.Trim ()).ToArray ();

            //类的名字
            string className = Path.GetFileNameWithoutExtension (filePath);
            className = className[0].ToString ().ToUpper() + className.Substring (1);

            //类的结构
            string code = "using UnityEngine;\nusing System.Collections;\nusing System.Collections.Generic;\n\n";
            code += String.Format ("/// <summary>\n/// {0}.cs——CSV信息类\n/// </summary>\n", className);
            code += String.Format ("{0}public class {1} {{ \n\n", "", className);

            Dictionary<string, string> dic = new Dictionary<string, string> ();
            dic.Add ("int[]", "List<int>");
            dic.Add ("float[]", "List<float>");
            dic.Add ("double[]", "List<double>");
            dic.Add ("string[]", "List<string>");
            dic.Add ("char[]", "List<char>");
            
            for (int i = 0; i < typeName.Length; i++)
            {
                code += String.Format ("\t/// <summary>\n\t/// {0}\n\t/// </summary>\n", noteStr[i]);

                string pattern = @"\d";
                MatchCollection matches = Regex.Matches (typeName[i], pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                
                string Name = typeName[i];
                if (matches.Count > 0)
                {
                    Name = typeName[i].Remove (matches[0].Index - 1);
                }
                Name = Name.Trim ();
                if (dic.ContainsKey(Name))
                {
                    Name = dic[Name];
                }

                code += String.Format ("{0}public {1} {2} {{ get; set; }}\n\n", "\t", Name, variableName[i]);
            }

            code += "}\n";

            string url = System.AppDomain.CurrentDomain.BaseDirectory + In;
            string CSharpFile = String.Format ("{0}{1}.cs", url, className);

            File.WriteAllText (CSharpFile, code);
        }
        
    }
}
