using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
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
    /// Логика взаимодействия для Fillingoptions.xaml
    /// </summary>
    public partial class Fillingoptions : Page
    {
        public int a = 0, g;
        public Frame Frame1, Frame2, MainFrame;
        public Button matr1;
        public Page Calculatore;
        Rectangle Block;
        TextBlock textblock;

        public Fillingoptions(Frame MainFrame, Frame frame1, Frame frame2, Button matr1, Page Calculatore, int g, Rectangle block, TextBlock textblock)
        {
            InitializeComponent();
            this.Frame1 = frame1;
            this.Frame2 = frame2;
            this.MainFrame = MainFrame;
            this.matr1 = matr1;
            this.Calculatore = Calculatore;
            this.g = g;
            this.Block = block;
            this.textblock = textblock;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            a = 1;
            button1.Background = new SolidColorBrush(Color.FromArgb(255, 32, 84, 180));
            button2.Background = new SolidColorBrush(Color.FromArgb(255, 56, 126, 255));
            button3.Background = new SolidColorBrush(Color.FromArgb(255, 56, 126, 255));
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            a = 2;
            button1.Background = new SolidColorBrush(Color.FromArgb(255, 56, 126, 255));
            button2.Background = new SolidColorBrush(Color.FromArgb(255, 32, 84, 180));
            button3.Background = new SolidColorBrush(Color.FromArgb(255, 56, 126, 255));
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            a = 3;
            button1.Background = new SolidColorBrush(Color.FromArgb(255, 56, 126, 255));
            button2.Background = new SolidColorBrush(Color.FromArgb(255, 56, 126, 255));
            button3.Background = new SolidColorBrush(Color.FromArgb(255, 32, 84, 180));
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.Text = "Не выбран вариант заполнения";
            }
            else if (a == 1 || a == 2)
            {
                NavigationService.Navigate(new Universal_Page_for_complection(a, MainFrame, Frame1, Frame2, matr1, Calculatore, g, Block, textblock));
            }
            else if (a == 3)
            {
                NavigationService.Navigate(new Selectfile(Frame1, Frame2, matr1, g,Block,textblock));
            }
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Frame1.Visibility = Visibility.Hidden;
            Frame2.Visibility = Visibility.Hidden;
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
    }
}
