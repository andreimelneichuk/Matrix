
using APE.WPF.Controls.DynamicGrid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
{

    public partial class MatrixView : Page
    {
        List<float[]> changed = new List<float[]>();
        Page sender_page;
        int i;
        Dictionary<string, bool> changes = new Dictionary<string, bool>();
        Matrix m;
        public MatrixView(Page sender_page,Matrix matrix)
        {
            //var random = new Random();
            var dataItems = new List<SampleGridItem>();
            m = matrix;

            int i = 0, j = 0;
            int row = 0, colum = 0;//номера строки и столбца соответсвтенно для перовй и второй матрицы соответственно
            while (row < matrix.N && (matrix.rows[row]).head == null)
            {
                row++;
            }
            Node node = row < matrix.N ? (matrix.rows[row]).head : null;// первый элемент матрицы
            colum = row < matrix.N ? node.position % matrix.N : matrix.N; // условие ? если да : если нет
            while (node != null)
            {
                while (i != row || j != colum)
                {
                    if (j == matrix.N)
                    {
                        j = 0;
                        System.Diagnostics.Debug.WriteLine("");
                        i++;
                    }
                    else
                    {
                        dataItems.Add(
                        new SampleGridItem()
                        {

                            ProductionDate = string.Format("{0}", j),
                            ProductName = string.Format(" {0}", i),
                            ProductionCount = matrix.V
                        });
                        System.Diagnostics.Debug.Write(matrix.V+"\t");
                        j++;
                    }
                }
                if (i == row && j == colum)
                {

                    dataItems.Add(
                        new SampleGridItem()
                        {

                            ProductionDate = string.Format("{0}", j),
                            ProductName = string.Format(" {0}", i),
                            ProductionCount = node.data
                        }) ;
                    System.Diagnostics.Debug.Write(node.data + "\t");
                    Matrix.search_element_by_rows(matrix, ref node, ref row, ref colum);
                    j++;
                }
            }
            while (i < matrix.N)
            {
                if (j == matrix.N)
                {
                    j = 0;
                    i++;
                    System.Diagnostics.Debug.WriteLine("");
                }
                else
                {
                    dataItems.Add(
                        new SampleGridItem()
                        {

                            ProductionDate = string.Format("{0}", j),
                            ProductName = string.Format(" {0}", i),
                            ProductionCount = matrix.V
                        });
                    System.Diagnostics.Debug.Write(matrix.V + "\t");
                    j++;
                }
            }
            this.DataContext = dataItems;
            this.sender_page = sender_page;
            this.InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(sender_page);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            button1_Copy1.Visibility = Visibility.Visible;
            float[] chnge = new float[3];
            TextBox child = sender as TextBox;
            Grid parent = child.Parent as Grid;
            UIElementCollection children = parent.Children;
            TextBox Row_i = children.OfType<TextBox>().Single(Child => Child.Name == "Row_i");
            TextBox Row_j = children.OfType<TextBox>().Single(Child => Child.Name == "Row_j");
            TextBox Data = children.OfType<TextBox>().Single(Child => Child.Name == "Data");
            chnge[1] = Convert.ToInt32(Row_i.Text);
            chnge[2] = Convert.ToInt32(Row_j.Text);
            try
            {
                string s = chnge[1] + " " + chnge[2];
                if (changes.ContainsKey(s))
                {
                    changes.Remove(s);
                }
                if (changes.Count == 0)
                {
                    button1_Copy1.Background = new SolidColorBrush(Color.FromArgb(255, 82, 55, 250));
                    button1_Copy1.Content = "Сохранить";
                    button1_Copy1.IsEnabled = true;
                    button1_Copy1.Width = 250;
                }
            Node nd = new Node();
            nd.position = (int)chnge[1] * m.N + (int)chnge[2];
        
            chnge[0] = float.Parse(Data.Text);
            nd.data = chnge[0];
            changed.Add(chnge);
            Matrix.insert_element(m, nd, Convert.ToInt32(Row_i.Text), Convert.ToInt32(Row_j.Text));
            //Matrix.insert_element(m, nd, 0, 0);

            }
            catch
            {
                button1_Copy1.Background = new SolidColorBrush(Color.FromArgb(255,255,155,170));
                button1_Copy1.Width = 450;
                button1_Copy1.Content = "Неверный формат числа";
                button1_Copy1.IsEnabled= false;
                string s = chnge[1]+" "+chnge[2];
                if (!changes.ContainsKey(s))
                {
                    changes.Add(s, true);
                }
            }
            Adress.Visibility = Visibility.Visible;
            BorderAdress.Visibility = Visibility.Visible;
            Adress.Text = Additionnsl_Operations.Physical_location(m, (int)chnge[1], (int)chnge[2]);
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            //вызов функции изменений
        }

        private void border_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*Border border = sender as Border;
            UIElement children = border.Child;
            Grid grid = children as Grid;
            UIElementCollection childrens = grid.Children;
            TextBox Row_i = childrens.OfType<TextBox>().Single(Child => Child.Name == "Row_i");
            TextBox Row_j = childrens.OfType<TextBox>().Single(Child => Child.Name == "Row_j");
            TextBox Data = childrens.OfType<TextBox>().Single(Child => Child.Name == "Data");

            TextBox popupTextBox = new TextBox();
            popupTextBox.Text = "Показано по нажатию правой кнопки мыши";
            popupTextBox.Width = 200;
            popupTextBox.Height = 30;
            popupTextBox.Margin = new Thickness(e.GetPosition(this).X, e.GetPosition(this).Y, 0, 0);
            popupTextBox.Visibility = Visibility.Visible;
            grid.Children.Add(popupTextBox);*/
        }

        private void Adress_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Adress.Visibility = Visibility.Visible;
            BorderAdress.Visibility = Visibility.Visible;
            float[] chnge = new float[3];
            TextBox child = sender as TextBox;
            Grid parent = child.Parent as Grid;
            UIElementCollection children = parent.Children;
            TextBox Row_i = children.OfType<TextBox>().Single(Child => Child.Name == "Row_i");
            TextBox Row_j = children.OfType<TextBox>().Single(Child => Child.Name == "Row_j");
            TextBox Data = children.OfType<TextBox>().Single(Child => Child.Name == "Data");
            chnge[1] = Convert.ToInt32(Row_i.Text);
            chnge[2] = Convert.ToInt32(Row_j.Text);
            Adress.Text = Additionnsl_Operations.Physical_location(m, (int)chnge[1], (int)chnge[2]);
        }
    }
}
