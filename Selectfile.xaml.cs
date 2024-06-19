using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Selectfile.xaml
    /// </summary>

    public partial class Selectfile : Page
    {
        Frame Frame1, Frame2;
        Button matr1;
        int g;
        Rectangle Block;
        TextBlock textblock;
        public Selectfile(Frame Frame1, Frame Frame2, Button matr1, int g, Rectangle Block, TextBlock textblock)
        {
            InitializeComponent();
            this.Frame1 = Frame1;
            this.Frame2 = Frame2;
            this.matr1 = matr1;
            this.g = g;
            this.Block = Block;
            this.textblock = textblock;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var filepatch2 = textbox1.Text;
            if (File.Exists(filepatch2))
            {
                string ext = System.IO.Path.GetExtension(filepatch2);
                if (ext == ".txt")
                {
                    Frame1.Visibility = Visibility.Hidden;
                    Frame2.Visibility = Visibility.Hidden;
                    matr1.Content = g + " матрица";
                    matr1.ContextMenu.Visibility = Visibility.Visible;
                    Block.Visibility = Visibility.Hidden;
                    textblock.Visibility = Visibility.Hidden;
                    //функция вызова заполнения из файла
                }
                else
                {
                    textblock.Text = "Файл с неподходящим расширением";
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                }
            }
            else
            {
                textblock.Text = "Такого файла не существует";
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Hidden;
            Frame2.Visibility = Visibility.Hidden;
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttoncllick1_Click(object sender, RoutedEventArgs e)
        {
            //Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            bool? response = dialog.ShowDialog();
            if (response == true)
            {
                string filepath = dialog.FileName;
                textbox1.Text = filepath;
            }


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
