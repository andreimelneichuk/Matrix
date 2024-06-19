using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Additionnsl_Operations
    {
        public static void Input(Matrix m, string file_name)//запись матрицы в файл
        {
            StreamWriter file = new StreamWriter(file_name);//открываем файл для записи
            file.Write(m.N + " " + m.V);//записываем в первую строку количество элементов N и значение V
            file.WriteLine();//переход на следующую строку
            int i = 0, j = 0;
            int row = 0, colum = 0;//номера строки и столбца соответсвтенно для перовй и второй матрицы соответственно
            while (row < m.N && (m.rows[row]).head == null)
            {
                row++;
            }
            Node node = row < m.N ? (m.rows[row]).head : null;// первый элемент матрицы
            colum = row < m.N ? node.position % m.N : m.N; // условие ? если да : если нет
            while (node != null)
            {
                while (i != row || j != colum)
                {
                    if (j == m.N)
                    {
                        j = 0;
                        i++;
                        if (i != m.N)
                        {
                            file.WriteLine();
                        }
                    }
                    else
                    {
                        if (j == m.N - 1)
                        {
                            file.Write(m.V);
                        }
                        else
                        {
                            file.Write(m.V + " ");
                        }
                        j++;
                    }
                }
                if (i == row && j == colum)
                {
                    if (j == m.N - 1)
                    {
                        file.Write(node.data);
                    }
                    else
                    {
                        file.Write(node.data + " ");
                    }
                    Matrix.search_element_by_rows(m, ref node, ref row, ref colum);
                    j++;
                }
            }
            while (i < m.N)
            {
                if (j == m.N)
                {
                    j = 0;
                    i++;
                    if (i != m.N)
                    {
                        file.WriteLine();
                    }
                }
                else
                {
                    if (j == m.N - 1)
                    {
                        file.Write(m.V);
                    }
                    else
                    {
                        file.Write(m.V + " ");
                    }
                    j++;
                }
            }
            file.Close();
        }

        public static void Edit(Matrix m, List<float[]> changed)//редактирование матрицы
        {
            int i = 0, j = 0;
            int row = 0, colum = 0;//номера строки и столбца соответсвтенно для перовй и второй матрицы соответственно
            float[] readlist = changed.First<float[]>();
            float i_edit = readlist[1];
            float j_edit = readlist[2];
            while (row < m.N && (m.rows[row]).head == null)
            {
                row++;
            }
            Node node = row < m.N ? (m.rows[row]).head : null;// первый элемент матрицы
            colum = row < m.N ? node.position % m.N : m.N; // условие ? если да : если нет
            while (node != null)
            {
                while (i != row || j != colum)
                {
                    if (j == m.N)
                    {
                        j = 0;
                        i++;
                    }
                    else
                    {
                        if (i == i_edit && j == j_edit)
                        {
                            Node node_add = new Node();
                            node_add.data = readlist[0];
                            node_add.position = (int)i_edit * m.N + (int)j_edit;
                            Matrix.Insert_element(m, node_add, (int)i_edit, (int)j_edit);
                        }
                        j++;
                    }
                }
                if (i == row && j == colum)
                {
                    if (i == i_edit && j == j_edit)
                    {
                        node.data = readlist[0];
                    }
                    j++;
                    Matrix.search_element_by_rows(m, ref node, ref row, ref colum);
                }
            }
            while (i < m.N)
            {
                if (j == m.N)
                {
                    j = 0;
                    i++;
                }
                else
                {
                    if (i == i_edit && j == j_edit)
                    {
                        Node node_add = new Node();
                        node_add.data = readlist[0];
                        node_add.position = (int)i_edit * m.N + (int)j_edit;
                        Matrix.Insert_element(m, node_add, (int)i_edit, (int)j_edit);
                    }
                    j++;
                }
            }
        }
        public static string Physical_location(Matrix m, int i_phys, int j_phys)//поиск физического расположение элемента матрицы в памяти
        {
            Node temp_node = m.rows[i_phys].head;
            while (temp_node != null && temp_node.position % m.N < j_phys) temp_node = temp_node.Right;

            if (temp_node.position % m.N == j_phys && temp_node.position / m.N == i_phys)
            {

                GCHandle handle = GCHandle.Alloc(temp_node.data, GCHandleType.Pinned);
                IntPtr address = handle.AddrOfPinnedObject();
                //Matrix.search_element_by_rows(m, ref node, ref row, ref colum);
                handle.Free();
                return "0x" + address.ToInt64().ToString();//возвращаем его
            }
            else
            {
                return "null";
            }
        }
    }
}
