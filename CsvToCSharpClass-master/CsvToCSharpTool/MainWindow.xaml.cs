using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CsvToCSharpTool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Init ();
        }

        void Init ()
        {
            this.UrlStr.Drop += LstFile;
        }

        private void LstFile ( object sender, DragEventArgs e )
        {
             
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            
            string msg = "";

            var array = (System.Array)e.Data.GetData (DataFormats.FileDrop);
            for (int i = 0; i < array.Length; i++)
            {
                msg += array.GetValue (i).ToString ();
                if (i != array.Length - 1)
                {
                    msg += "\n";
                }
            }

           
            string fullName = array.GetValue (0).ToString ();
            FileInfo info = new FileInfo (fullName);
            string name = info.Name;
            string path = fullName.Replace (name, "");

            if (Directory.Exists (path + "C#"))
            {
                Directory.Delete (path + "C#", true);
            }
            Directory.CreateDirectory (path + "C#");

            for (int i = 0; i < array.Length; i++)
            {
                string filePath = array.GetValue (i).ToString ();

                CsvFileToCSharpClass (filePath, path + @"C#\");
            }
            
            MessageBox.Show ("恭喜你，转化成功！", "提示", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }
         
        private void CsvFileToCSharpClass ( string filePath, string outPath )
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
            string className = System.IO.Path.GetFileNameWithoutExtension (filePath);
            className = className[0].ToString ().ToUpper () + className.Substring (1);

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
                if (dic.ContainsKey (Name))
                {
                    Name = dic[Name];
                }

                code += String.Format ("{0}public {1} {2} {{ get; set; }}\n\n", "\t", Name, variableName[i]);
            }

            code += "}\n";
             
            string CSharpFile = String.Format ("{0}{1}.cs", outPath, className);

            File.WriteAllText (CSharpFile, code);
        }

        private void UrlStr_SelectionChanged ( object sender, SelectionChangedEventArgs e )
        {

        }
    }
}
