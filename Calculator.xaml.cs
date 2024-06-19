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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    public partial class Calculator : Page
    {
        Frame MainFrame;

        public Calculator(Frame mainFrame)
        {
            InitializeComponent();
            this.MainFrame = mainFrame;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Fillingoptions(MainFrame, Frame1, Frame2, matr1, this, 1, Block, textblock);
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
            else
            {
                //  условие на то что размерности равны
                Block.Visibility = Visibility.Hidden;
                textblock.Visibility = Visibility.Hidden;
                NavigationService.Navigate(new Result_page(s, MainFrame,Block,textblock));
            }
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this));
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(MainFrame, Frame1, Frame2,Block, textblock);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }

        private void matr2_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Fillingoptions(MainFrame, Frame1, Frame2, matr2, this, 2, Block, textblock);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
    }
}