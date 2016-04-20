using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace DeleteFile
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
        }

        public void OpenFile ()
        {
            FolderBrowserDialog fb = new FolderBrowserDialog ();
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Url.Text = fb.SelectedPath;
            }
        }

        private void DelectFile (string str)
        {
            this.FileType.Text = str;
            
            DirectoryInfo folder = new DirectoryInfo (this.Url.Text);

            FileInfo[] FileInfoArray = null;
            if ((bool)this.Include.IsChecked)
            {
                FileInfoArray = folder.GetFiles ("*." + str, SearchOption.AllDirectories);
            }
            else {
                FileInfoArray = folder.GetFiles ("*." + str, SearchOption.TopDirectoryOnly);
            }
            if (FileInfoArray.Length == 0)
            {
                System.Windows.MessageBox.Show ("很遗憾，未能找到你要删除的文件", "提示", MessageBoxButton.OK);
                return;
            }

            for (int i = FileInfoArray.Length - 1; i > -1; i--)
            {
                FileInfoArray[i].Delete ();
            }

            System.Windows.MessageBox.Show ("恭喜你，删除完毕", "提示", MessageBoxButton.OK);
        }

        private void OpenDia_Click ( object sender, RoutedEventArgs e )
        {
            OpenFile ();
        }

        private void Delect_Click ( object sender, RoutedEventArgs e )
        {
            string s = this.FileType.Text.ToLower ().Replace (".", "");
            DelectFile (s);
        }

        private void FileType_TextChanged ( object sender, TextChangedEventArgs e )
        {

        }
    }
}
