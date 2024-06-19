using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
using static WpfApp1.MainWindow;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    /// 

    public partial class Calculator : Page
    {
        Frame MainFrame;
        Matrix matrix1,matrix2;
        int matrix_number;
        public Calculator(Frame mainFrame)
        {
            InitializeComponent();
            this.MainFrame = mainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            matrix_number = 1;
            var a = new Fillingoptions(MainFrame, Frame1, Frame2, matr1, this, 1, Block, textblock,ref matrix1);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;

        }
        private void Back_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Welcome(MainFrame));

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            String s = comboBox.Text;
            if(s.Length == 0 && Convert.ToString(matr1.Content) == "1 матрица" && Convert.ToString(matr2.Content) == "2 матрица") 
            {
                
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Не выбрана операция";
            }
            else if (Convert.ToString(matr1.Content) != "1 матрица" && Convert.ToString(matr2.Content) != "2 матрица")
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Матрицы не заполнены";
            }
            else if (Convert.ToString(matr1.Content) != "1 матрица" || Convert.ToString(matr2.Content) != "2 матрица")
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Не заполнена матрица";
            }
            else if (Global_Var.matrix1.N != Global_Var.matrix2.N)
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Разные размерности матриц";
            }
            else
            {
                //  условие на то что размерности равны
                if (s == "—")
                {
                    Global_Var.matrix_result = Global_Var.matrix1 - Global_Var.matrix2;
                }
                else if (s == "✚")
                {
                    Global_Var.matrix_result = Global_Var.matrix1 + Global_Var.matrix2;
                }
                else if (s == "×")
                {
                    Global_Var.matrix_result = Global_Var.matrix1 * Global_Var.matrix2;
                }
                Block.Visibility = Visibility.Hidden;
                textblock.Visibility = Visibility.Hidden;
                NavigationService.Navigate(new Result_page(s, MainFrame,Block,textblock,this));
            }
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this,Global_Var.matrix1));
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(MainFrame, Frame1, Frame2, Block, textblock, 1);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this, Global_Var.matrix2));
        }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(MainFrame, Frame1, Frame2, Block, textblock, 2);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Global_Var.matrix_copy = new Matrix(Global_Var.matrix1); 
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Global_Var.matrix1 = Global_Var.matrix_copy;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Global_Var.matrix_copy = new Matrix(Global_Var.matrix2);
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Global_Var.matrix2 = Global_Var.matrix_copy;
        }

        private void matr2_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            matrix_number = 2;
            var a = new Fillingoptions(MainFrame, Frame1, Frame2, matr2, this, 2, Block, textblock,ref matrix2);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
    }
}