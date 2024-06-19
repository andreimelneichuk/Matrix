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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Welcome(MainFrame);
            //MainFrame.Content= new MatrixView();
          
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = (Storyboard)FindResource("TextBoxAnimation");
            storyboard.Begin(animatedTextBox);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation reverseAnimation = new DoubleAnimation()
            {
                From = 50,
                To = 0,
                Duration = TimeSpan.FromSeconds(0.5)
            };
            animatedTextBox.BeginAnimation(TextBox.HeightProperty, reverseAnimation);
        }
    }
}
