using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Result_reservematrix.xaml
    /// </summary>
    public partial class Result_reservematrix : Page
    {
        Rectangle Block;
        TextBlock textblock;
        Frame mainframe;
        Page Reserve_matrix;
        int g;
        public Result_reservematrix(Frame Mainframe,Rectangle Block, TextBlock textblock,Page Reserve_matrix)
        {
            InitializeComponent();
            this.mainframe = Mainframe; 
            this.Block = Block;
            this.textblock = textblock; 
            this.Reserve_matrix = Reserve_matrix;   
        }

     
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this, Global_Var.matrix1));
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(mainframe, Frame1, Frame2, Block, textblock, 1);
            Frame1.Navigate(a);

        }
        private void Back_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Reserve_matrix);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this, Global_Var.matrix_result));
        }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(mainframe, Frame1, Frame2, Block, textblock, 3);
            Frame1.Navigate(a);

        }
        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new MatrixView(this, Global_Var.matrix_result));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new MatrixView(this, Global_Var.matrix1));
        }


    }
}
