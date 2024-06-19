using APE.WPF.Controls.DynamicGrid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
using System.Windows.Threading;
using static WpfApp1.MainWindow;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Manual_filling.xaml
    /// </summary>

    public partial class Manual_filling : Page
    {
        public Button matr1;
        Frame mainframe;
        Page Calculatore;
        int g; int N;
        float V;
        Matrix matrix;
        List<float[]> changed = new List<float[]>();

        public Manual_filling(Button matr1, Frame MainFrame, Page Calculatore, int g,int N,float V,Matrix matrix)
        {
            InitializeComponent();
            this.matr1 = matr1;
            this.mainframe = MainFrame;
            this.Calculatore = Calculatore;
            this.g = g;
            this.N = N;
            this.matrix = matrix; 
            this.V = V;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Block.Visibility = Visibility.Hidden;
                textblock.Visibility = Visibility.Hidden;
                if (Convert.ToInt32(textbox1.Text) <= N && Convert.ToInt32(textbox2.Text) <= N && float.Parse(textbox3.Text) <= float.MaxValue && float.Parse(textbox3.Text) >= float.MinValue)
                { 
                    int i = Convert.ToInt32(textbox1.Text);
                    int j = Convert.ToInt32(textbox2.Text);
                    float data = float.Parse(textbox3.Text);
                    /*float[] chnge = new float[3];
                    chnge[1] = float.Parse(textbox1.Text);
                    chnge[2] = float.Parse(textbox2.Text);
                    chnge[0] = float.Parse(textbox3.Text);*/
                    Node node_ad = new Node();
                    node_ad.position = i * matrix.N + j;
                    node_ad.data = data;
                    Matrix.insert_element(matrix, node_ad, i, j);
                    //changed.Add(chnge);
                    Block.Visibility = Visibility.Visible;
                    Block.Fill = new SolidColorBrush(Color.FromArgb(255, 189, 134, 240));
                    textblock.Visibility = Visibility.Visible;
                    textblock.Text = "Значение сохранено.";
                }
                else if (Convert.ToInt32(textbox1.Text) > N || Convert.ToInt32(textbox2.Text) > N && float.Parse(textbox3.Text) <= float.MaxValue && float.Parse(textbox3.Text) >= float.MinValue)
                {
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                    if (Convert.ToInt32(textbox1.Text) > N)
                        textblock.Text = "Превышено значение i.";
                    else textblock.Text = "Превышено значение j.";
                }
                else if (Convert.ToInt32(textbox1.Text) <= N && Convert.ToInt32(textbox2.Text) <= N && float.Parse(textbox3.Text) >= float.MaxValue && float.Parse(textbox3.Text) >= float.MinValue)
                {
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                    textblock.Text = "Значение не должно превышать максимальное значение float.";
                }
                else if (Convert.ToInt32(textbox1.Text) <= N && Convert.ToInt32(textbox2.Text) <= N && float.Parse(textbox3.Text) <= float.MaxValue && float.Parse(textbox3.Text) <= float.MinValue)
                {
                    Block.Visibility = Visibility.Visible;
                    textblock.Visibility = Visibility.Visible;
                    textblock.Text = "Значение не должно быть меньше минимального значения float.";
                }
            }
            catch
            {
                Block.Visibility = Visibility.Visible;
                textblock.Visibility = Visibility.Visible;
                textblock.FontSize = 25;
                string s1 = textbox1.Text;
                string s2 = textbox2.Text;
                string s3 = textbox3.Text;
                if(s1.Length == 0|| s2.Length == 0|| s3.Length == 0)
                {
                    textblock.Text = "Заполните все поля";
                }
                else textblock.Text = "Введены посторонние символы. Для элемента V в качестве разделения используйте запятую.";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            matr1.Content = g + " матрица";
            matr1.ContextMenu.Visibility = Visibility.Visible;
            NavigationService.Navigate(Calculatore);
            matrix = new Matrix(V, N);
            matrix.hand_input(changed);
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Block.Visibility = Visibility.Hidden;
            textblock.Visibility = Visibility.Hidden;
        }
    }
}
