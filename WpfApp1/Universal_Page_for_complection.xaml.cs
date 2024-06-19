using System;
using System.Collections.Generic;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp1.MainWindow;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Universal_Page_for_complection.xaml
    /// </summary>
    public partial class Universal_Page_for_complection : Page
    {
        private int a;
        public Frame Frame1, Frame2, mainframe;
        public Button matr1;
        public Page Calculatore;
        public int g;
        Rectangle Block;
        TextBlock textblock;
        Matrix matrix;

        public Universal_Page_for_complection(int a, Frame MainFrame, Frame Frame1, Frame Frame2, Button matr1, Page Calculatore, int g, Rectangle Block, TextBlock textblock, ref Matrix matrix)
        {
            InitializeComponent();
            this.a = a;
            this.Frame1 = Frame1;
            this.Frame2 = Frame2;
            this.mainframe = MainFrame;
            if (a == 2) Button_one.Content = "Готово";
            this.matr1 = matr1;
            this.Calculatore = Calculatore;
            this.g = g;
            this.Block = Block;
            this.textblock = textblock; 
            this.matrix = matrix;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textbox1.Text);
                if (float.Parse(textbox2.Text) <= float.MaxValue && float.Parse(textbox2.Text) >= float.MinValue && N < 10001)
                {
                    Frame1.Visibility = Visibility.Hidden;
                    Frame2.Visibility = Visibility.Hidden;
                    if (a == 1)
                    {
                        Block.Visibility = Visibility.Hidden;
                        textblock.Visibility = Visibility.Hidden;
                        float V = Convert.ToSingle(textbox2.Text);
                        if(g == 1)Global_Var.matrix1 = new Matrix(V, N);
                        else if(g == 2) Global_Var.matrix2 = new Matrix(V, N);
                        mainframe.Content = new Manual_filling(matr1, mainframe, Calculatore, g, N, V, g == 1 ? Global_Var.matrix1 : Global_Var.matrix2);
                    }
                    else if (a == 2)
                    {
                        Block.Visibility = Visibility.Hidden;
                        textblock.Visibility = Visibility.Hidden;
                        float V = Convert.ToSingle(textbox2.Text);
                        //matrix = new Matrix(V, N);//функция автоматического заполнения с передачей параметров V и N
                        if(g == 1)Global_Var.matrix1 = Matrix.random_input(V,N);
                        else if(g == 2) Global_Var.matrix2 = Matrix.random_input(V, N);
                        Frame1.Visibility = Visibility.Hidden;
                        Frame2.Visibility = Visibility.Hidden;
                        matr1.Content = g + " матрица";
                        matr1.ContextMenu.Visibility = Visibility.Visible;
                    }
                }
                else if (float.Parse(textbox2.Text) >= float.MaxValue && float.Parse(textbox2.Text) >= float.MinValue && N < 10001)
                {
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                    textblock.Text = "Превышено максимальное значение V";
                }
                else if (float.Parse(textbox2.Text) <= float.MaxValue && float.Parse(textbox2.Text) <= float.MinValue && N < 10001)
                {
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                    textblock.Text = "Значение V должно быть больше минимального значения float";
                }
                else if (float.Parse(textbox2.Text) <= float.MaxValue && float.Parse(textbox2.Text) >= float.MinValue && N >= 10001)
                {
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                    textblock.Text = "Размерность матрицы не должна превышать 10000";
                }
            }
            catch
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.FontSize = 25;
                string s1 = textbox1.Text;
                string s2 = textbox2.Text;
                if (s1.Length == 0 || s2.Length == 0)
                {
                    textblock.Text = "Заполните все поля";
                }
                else { textblock.Text = "Введены посторонние символы. Для элемента V в качестве разделения используйте запятую."; }
            }
        }



            private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Hidden;
            Frame2.Visibility = Visibility.Hidden;
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
    }
}
