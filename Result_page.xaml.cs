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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Result_page.xaml
    /// </summary>
    public partial class Result_page : Page
    {
        Rectangle Block;
        TextBlock textblock;
        Frame MainFrame;
        public Result_page(string operation,Frame MainFrame, Rectangle Block, TextBlock textblock)
        {
            InitializeComponent();
            textBlock.Text = operation;
            this.MainFrame = MainFrame;
            this.Block = Block;
            this.textblock = textblock;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(MainFrame, Frame1, Frame2,Block,textblock);
            Frame1.Navigate(a);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this));
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(MainFrame, Frame1, Frame2, Block, textblock);
            Frame1.Navigate(a);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatrixView(this));
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Frame1.Visibility = Visibility.Visible;
            Frame2.Visibility = Visibility.Visible;
            var a = new Writetofile(MainFrame, Frame1, Frame2, Block, textblock);
            Frame1.Navigate(a);
        }
    }
}
