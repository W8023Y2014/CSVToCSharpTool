using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DelectFile
{
    class Program
    {
        static void Main ( string[] args )
        {
            string url = System.AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo folder = new DirectoryInfo (url);
            FileInfo[] FileInfoArray = folder.GetFiles ("*.meta", SearchOption.AllDirectories);
            for (int i = FileInfoArray.Length - 1; i > -1; i--)
            {
                FileInfoArray[i].Delete ();
            }
             
        }
    }
}
