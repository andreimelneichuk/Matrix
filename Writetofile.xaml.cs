using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Writetofile.xaml
    /// </summary>
    public partial class Writetofile : Page
    {
        Rectangle Block;
        TextBlock textblock;
        public Frame mainframe, frame1, frame2;
        public Writetofile(Frame MainFrame,Frame Frame1, Frame Frame2,Rectangle Block, TextBlock textblock)
        {
            InitializeComponent();
            this.frame1 = Frame1;
            this.frame2 = Frame2;
            this.mainframe = MainFrame;
            this.Block = Block;
            this.textblock = textblock;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            
            string Namefile = namefile.Text;
            string s = Filepath.Text;
            if (s.Length == 0 || Namefile.Length == 0)
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Не заполнены поля";
            }
        }

        private void buttlonclose_click(object sender, RoutedEventArgs e)
        {
            frame1.Visibility = Visibility.Hidden;
            frame2.Visibility = Visibility.Hidden;
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }

        private void buttoncllick1_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = Filepath.Text; // Use current value for initial dir
            dialog.Title = "Select a Directory"; // instead of default "Save As"
            dialog.Filter = "Directory|*.this.directory"; // Prevents displaying files
            dialog.FileName = "select"; // Filename will then be "select.this.directory"
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
                // Remove fake filename from resulting path
                path = path.Replace("\\select.this.directory", "");
                path = path.Replace(".this.directory", "");
                // If user has changed the filename, create the new directory
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                // Our final value is in path
                Filepath.Text = path;
            }
        }
    }
}
