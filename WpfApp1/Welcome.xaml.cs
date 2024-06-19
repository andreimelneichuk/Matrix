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
    /// Логика взаимодействия для Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        Frame MainFrame; public Page Calculatore; public int g;
        Page sender_page;
        public Welcome(Frame mainFrame)
        {
            InitializeComponent();
            this.MainFrame = mainFrame;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Calculator(MainFrame));
        }

        private void reservematrixclick_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reserve_matrix(MainFrame,1));
        }
    }
}
