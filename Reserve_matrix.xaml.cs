using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Reserve_matrix.xaml
    /// </summary>
    public partial class Reserve_matrix : Page
    {
        Frame MainFrame;
        public Page Calculatore; public int g;
        public Reserve_matrix(Frame MainFrame,int g)
        {
            InitializeComponent();
            this.MainFrame = MainFrame;
            this.g = g;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var b = matr1;
            var a = new Fillingoptions(MainFrame, Frame1, Frame2, matr1, this, g, Block, textblock);
            Frame1.Navigate(a);
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;

        }
        private void Back_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Welcome(MainFrame));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Convert.ToString(matr1.Content) != "1 матрица")
            { Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Не заполнена матрица";
            }
            else { NavigationService.Navigate(new Result_reservematrix(MainFrame,Block,textblock)); }
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
            var a = new Writetofile(MainFrame, Frame1, Frame2, Block, textblock);
            Frame1.Navigate(a);

        }
    }
}
