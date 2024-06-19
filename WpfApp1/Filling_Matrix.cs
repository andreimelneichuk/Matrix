using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
namespace WpfApp1
{
    public unsafe class Node
    {
        public float data;
        public int position;// row * N + colum
        public Node? Down; // ссылка на элемент структуры снизу
        public Node? Right;// ссылка на следующий элемент в строке
        public Node()
        {
            data = 0;
            position = 0;
            Down = null;
            Right = null;
        }
    }
    public unsafe class List
    {
        public Node? head;
        public Node? tail;
        public List() { head = null; tail = null; }
    }
    public unsafe class Matrix
    {
        public float V;
        public int N;
        public List[] rows, colums;
        public Matrix(float v, int n)// конструктор
        {
            this.V = v;
            this.N = n;
            this.rows = new List[n];
            this.colums = new List[n];
            for (int i = 0; i < n; i++)
            {
                rows[i] = new List();
                colums[i] = new List();
            }
        }
        public Matrix(Matrix m)// копирование
        {
            this.V = m.V;
            this.N = m.N;
            this.rows = new List[m.N];
            this.colums = new List[m.N];

            for (int i = 0; i < m.N; i++)
            {
                rows[i] = new List();
                colums[i] = new List();
            }

            int row = 0, colum = 0;//номера строки и столбца соответсвтенно для перовй и второй матрицы соответственно

            while (row < m.N && (m.rows[row]).head == null) row++;
            Node? temp_node = row < m.N ? (m.rows[row]).head : null;// первый элемент матрицы
            colum = row < m.N ? temp_node.position % m.N : m.N; // условие ? если да : если нет

            while (temp_node != null)
            {
                Node? node_add = new Node();
                node_add.data = temp_node.data;
                node_add.position = temp_node.position;
                Node? temp_node2;
                //temp_node = (m.rows[row]).tail;
                temp_node2 = (rows[row]).head != null ? (rows[row]).tail : null;
                if (temp_node2 == null)
                {
                    //temp_node
                    (rows[row]).head = node_add;
                    (rows[row]).tail = node_add;
                    node_add.Right = null;
                }
                else
                {
                    temp_node2.Right = node_add;
                    node_add.Right = null;
                    (rows[row]).tail = node_add;
                }
                temp_node2 = (colums[colum]).tail;
                if (temp_node2 == null)
                {
                    (colums[colum]).head = node_add;
                    (colums[colum]).tail = node_add;
                    node_add.Down = null;
                }
                else
                {
                    temp_node2.Down = node_add;
                    node_add.Down = null;
                    (colums[colum]).tail = node_add;
                }
                search_element_by_rows(m, ref temp_node, ref row, ref colum);
            }
        }
        public static void Insert_element(Matrix m, Node node, int row, int colum)// вставка элемента в конец
        {
            Node temp_node;
            //temp_node = (m.rows[row]).tail;
            temp_node = (m.rows[row]).head != null ? (m.rows[row]).tail : null;
            if (temp_node == null)
            {
                //temp_node
                (m.rows[row]).head = node;
                (m.rows[row]).tail = node;
                node.Right = null;
            }
            else
            {
                temp_node.Right = node;
                node.Right = null;
                (m.rows[row]).tail = node;
            }
            temp_node = (m.colums[colum]).tail;
            if (temp_node == null)
            {
                (m.colums[colum]).head = node;
                (m.colums[colum]).tail = node;
                node.Down = null;
            }
            else
            {
                temp_node.Down = node;
                node.Down = null;
                (m.colums[colum]).tail = node;
            }

        }
        public static Matrix random_input(float v, int n)//рандомный ввод
        {
            Matrix m = new Matrix(v, n);// матрица  
            Random R = new();
            int rand;
            float k;
            for (int i = 0; i < m.N; i++)
            {
                for (int j = 0; j < m.N; j++)
                {
                    rand = R.Next(0, 5);
                    if (rand == 2)
                    {
                        Node node_add = new Node();
                        //k = ((float)R.Next(-100000,100000)) / 100;
                        node_add.data = R.Next(1, 100);
                        //node_add.data = k;
                        node_add.position = i * m.N + j;
                        Insert_element(m, node_add, i, j);
                    }
                }
            }

            return m;
        }



        public static void output(Matrix m)//вывод матрицы
        {
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
                    }
                    else
                    {
                        Console.Write(m.V + "\t");
                        j++;
                    }
                }
                if (i == row && j == colum)
                {
                    j++;
                    Console.Write(node.data + "\t");
                    search_element_by_rows(m, ref node, ref row, ref colum);
                }
            }
            while (i < m.N)
            {
                if (j == m.N)
                {
                    j = 0;
                    i++;
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(m.V + "\t");
                    j++;
                }
            }
        }
        public static void search_element_by_rows(Matrix m, ref Node node, ref int row, ref int colum)// преход к следующему ненулевому элементу по строке
        {
            if (node.Right == null)
            {
                row++;
                while (row < m.N && (m.rows[row]).head == null) row++;// строки не закончились и строка пустая ищес следующую
                if (row == m.N) node = null;                                               // если row = m.N значит что матрицу прошли
                else
                {
                    node = (m.rows[row]).head;
                    row = node.position / m.N;
                    colum = node.position % m.N;
                }
            }
            else
            {
                node = node.Right;
                row = node.position / m.N;
                colum = node.position % m.N;
            }
            //поиск номера столбца по адресу элемента и номеру строки ( тут в зависимости от того что никитина скажет)
        }
        public void hand_input(List<float[]> changed)//ручной ввод
        {
            
            Node node_add = new Node();
            float[] readlist = new float[3];
            int row = (int)readlist[1];
            int colum = (int)readlist[2];//ввод значения столбца
            node_add.data = readlist[0];//ввод значения матрицы
            node_add.position = row * N + colum;//определение позиции элемента
            Insert_element(this, node_add, row, colum);//вставка элемента
        }

        public static void insert_element(Matrix m, Node node, int row, int colum)// вставка элемента
        {
            Node? temp_node;//элемент для вставки
            temp_node = (m.rows[row]).head != null ? (m.rows[row]).head : null;// выбираем строку по которой пойдем
            if (temp_node == null)// если строка была пуста
            {
                (m.rows[row]).head = node;// голова строки равна элементу
                (m.rows[row]).tail = node;// хвост строки равен элементу
                node.Right = null;// ссылка на след элемент в строке пустая
            }
            else// если строка не пуста
            {
                while (temp_node.Right != null && ((temp_node.Right).position) % m.N < colum) temp_node = temp_node.Right;// пока не прошли строку или не нашли позицию для вставки переходим к след элементу

                if (temp_node.Right != null && node.position == (temp_node.Right).position)// если необходимо заменить элемент
                {
                    temp_node.Right.data = node.data;// меняем инф поле
                }
                else
                {
                    node.Right = temp_node.Right;
                    temp_node.Right = node;
                    if (temp_node == m.rows[row].head) m.rows[row].head = node;
                    if (node.Right == null) (m.rows[row]).tail = node;// изменяем хвост если вставляли в конец
                }
            }
            //temp_node = (m.colums[colum]).head;
            temp_node = (m.colums[colum]).head != null ? (m.colums[colum]).head : null;
            if (temp_node == null)
            {
                //m.colums[colum] = node;
                (m.colums[colum]).head = node;
                (m.colums[colum]).tail = node;
                node.Down = null;
            }
            else
            {
                while (temp_node.Down != null && ((temp_node.Down).position) / m.N < row) temp_node = temp_node.Down;
                if (temp_node.Down != null && node.position == temp_node.Right.position)
                {
                    temp_node.Down.data = node.data;
                }
                else
                {
                    node.Down = temp_node.Down;
                    temp_node.Down = node;
                    if (temp_node == m.colums[colum].head) m.colums[colum].head = node;
                    if (node.Right == null) (m.colums[colum]).tail = node;
                }

            }
        }
        public static Matrix file_input(string file_name)//заполнение матрицы из файла
        {
            try
            {
                StreamReader file = new StreamReader(file_name);//открываем файл для чтения
                string f = file.ReadLine();
                string[] digit = f.Split(' ');//разделение первой строки
                if (digit.Count() == 2)
                {
                    int k = 0;
                    int n = Convert.ToInt32(digit[k]);//берем значение N из файла
                    k++;
                    float v = float.Parse(digit[k]);//берем значение V из файла
                    Matrix M = new Matrix(v, n);
                    for (int i = 0; i < n; i++)
                    {
                        f = file.ReadLine();
                        digit = f.Split(' ');//разделение строки
                        if (digit.Length > n)
                        {
                            return null;
                        }
                        else
                        {
                            for (int j = 0; j < n; j++)
                            {
                                float dig = float.Parse(digit[j]);//один элемент
                                if (dig != v)//проверка на не повторяющийся элемент
                                {
                                    Node node_add = new Node();
                                    node_add.data = dig;//берем этот элемент
                                    node_add.position = i * n + j;//определяем его позицию
                                    Insert_element(M, node_add, i, j);//вставка элемента в узел
                                }
                            }
                        }
                    }
                    return M;
                }
                else
                {
                    return null;
                }
                file.Close();//закрываем файл
            }
            catch
            {
                return null;
            }
        }

        private static void search_element_by_colums(Matrix m, ref Node? node, ref int row, ref int colum)// преход к следующему ненулевому элементу по столбцу
        {
            if (node.Down == null)
            {
                colum++;
                while (colum < m.N && (m.colums[colum]).head == null) colum++;// строки не закончились и строка пустая ищес следу                                                       // если row = m.N значит что матрицу прошли
                if (colum == m.N) node = null;
                else
                {
                    node = (m.colums[colum]).head;
                    row = node.position / m.N;
                    colum = node.position % m.N;
                }
            }
            else
            {
                node = node.Down;
                row = node.position / m.N;
                colum = node.position % m.N;
            }
            //поиск номера строки по адресу элемента и номеру столбца ( тут в зависимости от того что никитина скажет)
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            
            Matrix m_result = new Matrix(m1.V + m2.V, m1.N >= m2.N ? m1.N : m2.N);
            int row1 = 0, colum1 = 0, row2 = 0, colum2 = 0, row_result = 0, colum_result = 0;//номера строки и столбца соответсвтенно для перовй и второй матрицы соответственно

            while (row1 < m1.N && (m1.rows[row1]).head == null) row1++;
            Node? node1 = row1 < m1.N ? (m1.rows[row1]).head : null;// первый элемент первой матрицы
            while (row2 < m2.N && (m2.rows[row2]).head == null) row2++;
            Node? node2 = row2 < m2.N ? (m2.rows[row2]).head : null;// первый элемент второй матрицы
                                                                    // имеем начальные элементы

            colum1 = row1 < m1.N ? node1.position % m1.N : m1.N; // условие ? если да : если нет
            colum2 = row2 < m2.N ? node2.position % m2.N : m2.N;

            while (node1 != null || node2 != null)// пока не прошли обе матрицы
            {
                //Node result_element = new Node();
                Node node_result = new Node();// элемент для записи в матрицу результата

                if (node1 == null && node2 != null) //если первая матрица закончилась, то идем только по второй матрице
                {
                    row_result = row2;// установка номера строки для записи в матрицу результата
                    colum_result = colum2;// установка номера столбца для записи в матрицу результата
                    node_result.data = node2.data + m1.V;
                    node_result.position = row_result * m_result.N + colum_result;
                    Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                    search_element_by_rows(m2, ref node2, ref row2, ref colum2);// поиск следующего ненулевого элмента во второй матрице
                }
                else if (node2 == null && node1 != null)// если вторая матрица закончилась, то идем только по первой матрице
                {
                    row_result = row1;// установка номера строки для записи в матрицу результата
                    colum_result = colum1;// установка номера столбца для записи в матрицу результата
                    node_result.data = node1.data + m2.V;
                    node_result.position = row_result * m_result.N + colum_result;
                    Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                    search_element_by_rows(m1, ref node1, ref row1, ref colum1);// поиск следующего ненулевого элмента в первой матрице
                }
                else if (node1 != null && node2 != null)// если обе матрицы не закончились
                {
                    if (row1 < row2)// работаем с элементом первой матрицы, если номер строки первой матрицы меньше втрой
                    {
                        row_result = row1;
                        colum_result = colum1;
                        node_result.data = node1.data + m2.V;
                        node_result.position = row_result * m_result.N + colum_result;
                        Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                        search_element_by_rows(m1, ref node1, ref row1, ref colum1);// поиск след элемента по строке
                    }
                    else if (row1 > row2)// работаем с элементом второй матрицы, если номер строки второй матрицы меньше второй
                    {
                        row_result = row2;
                        colum_result = colum2;
                        node_result.data = node2.data + m1.V;
                        node_result.position = row_result * m_result.N + colum_result;
                        Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                        search_element_by_rows(m2, ref node2, ref row2, ref colum2);
                    }
                    else// если номера строк равны, то проверяем стоблики
                    {
                        if (colum1 < colum2)// работаем с элементом первой матрицы
                        {
                            row_result = row1;
                            colum_result = colum1;
                            node_result.data = node1.data + m2.V;
                            node_result.position = row_result * m_result.N + colum_result;
                            Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                            search_element_by_rows(m1, ref node1, ref row1, ref colum1);
                        }
                        else if (colum1 > colum2)// работаем с элементом второй матрицы
                        {
                            row_result = row2;
                            colum_result = colum2;
                            node_result.data = node2.data + m1.V;
                            node_result.position = row_result * m_result.N + colum_result;
                            Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                            search_element_by_rows(m2, ref node2, ref row2, ref colum2);
                        }
                        else// если индексы ненулевых элементов равны
                        {
                            row_result = row1;
                            colum_result = colum1;
                            node_result.data = node1.data + node2.data;
                            node_result.position = row_result * m_result.N + colum_result;
                            Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                            search_element_by_rows(m1, ref node1, ref row1, ref colum1);
                            search_element_by_rows(m2, ref node2, ref row2, ref colum2);
                        }
                    }
                }
            }
            return m_result;
            
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            
            Matrix m_result = new Matrix(m1.V - m2.V, m1.N >= m2.N ? m1.N : m2.N);
            int row1 = 0, colum1 = 0, row2 = 0, colum2 = 0, row_result = 0, colum_result = 0;//номера строки и столбца соответсвтенно для перовй и второй матрицы соответственно
            while ((m1.rows[row1]).head == null && row1 < m1.N) row1++;
            Node? node1 = row1 < m1.N ? (m1.rows[row1]).head : null;// первый элемент первой матрицы
            while ((m2.rows[row2]).head == null && row2 < m2.N) row2++;
            Node? node2 = row2 < m2.N ? (m2.rows[row2]).head : null;// первый элемент второй матрицы
            colum1 = row1 < m1.N ? node1.position % m1.N : m1.N;
            colum2 = row2 < m2.N ? node2.position % m2.N : m2.N;

            while (node1 != null || node2 != null)// пока не прошли обе матрицы
            {
                Node node_result = new Node();// элемент для записи в матрицу результата

                if (node1 == null && node2 != null) //если первая матрица закончилась, то идем только по второй матрице
                {
                    row_result = row2;// установка номера строки для записи в матрицу результата
                    colum_result = colum2;// установка номера столбца для записи в матрицу результата
                    node_result.data = m1.V - node2.data;
                    node_result.position = row_result * m_result.N + colum_result;
                    Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                    search_element_by_rows(m2, ref node2, ref row2, ref colum2);// поиск следующего ненулевого элмента во второй матрице
                }
                else if (node2 == null && node1 != null)// если вторая матрица закончилась, то идем только по первой матрице
                {
                    row_result = row1;// установка номера строки для записи в матрицу результата
                    colum_result = colum1;// установка номера столбца для записи в матрицу результата
                    node_result.data = node1.data - m2.V;
                    node_result.position = row_result * m_result.N + colum_result;
                    Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                    search_element_by_rows(m1, ref node1, ref row1, ref colum1);// поиск следующего ненулевого элмента в первой матрице
                }
                else if (node1 != null && node2 != null)// если обе матрицы не закончились
                {
                    if (row1 < row2)// работаем с элементом первой матрицы
                    {
                        row_result = row1;
                        colum_result = colum1;
                        node_result.data = node1.data - m2.V;
                        node_result.position = row_result * m_result.N + colum_result;
                        Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                        search_element_by_rows(m1, ref node1, ref row1, ref colum1);
                    }
                    else if (row1 > row2)// работаем с элементом второй матрицы
                    {
                        row_result = row2;
                        colum_result = colum2;
                        node_result.data = m1.V - node2.data;
                        node_result.position = row_result * m_result.N + colum_result;
                        Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                        search_element_by_rows(m2, ref node2, ref row2, ref colum2);
                    }
                    else// если номера строк равны, то проверяем стоблики
                    {
                        if (colum1 < colum2)// работаем с элементом первой матрицы
                        {
                            row_result = row1;
                            colum_result = colum1;
                            node_result.data = node1.data - m2.V;
                            node_result.position = row_result * m_result.N + colum_result;
                            Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                            search_element_by_rows(m1, ref node1, ref row1, ref colum1);
                        }
                        else if (colum1 > colum2)// работаем с элементом второй матрицы
                        {
                            row_result = row2;
                            colum_result = colum2;
                            node_result.data = m1.V - node2.data;
                            node_result.position = row_result * m_result.N + colum_result;
                            Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                            search_element_by_rows(m2, ref node2, ref row2, ref colum2);
                        }
                        else// если индексы ненулевых элементов равны
                        {
                            row_result = row1;
                            colum_result = colum1;
                            node_result.data = node1.data - node2.data;
                            node_result.position = row_result * m_result.N + colum_result;
                            Insert_element(m_result, node_result, row_result, colum_result);// функция добавления элемента в матрицу результата
                            search_element_by_rows(m1, ref node1, ref row1, ref colum1);
                            search_element_by_rows(m2, ref node2, ref row2, ref colum2);
                        }
                    }
                }
            }
            return m_result;
            
        }

        public static float mul_row_on_colum(Matrix m1, Matrix m2, int row, int colum)
        {
            if ((m1.rows[row]).head == null || (m2.colums[colum]).head == null)
            {
                return 0;
            }
            else
            {
                Node? node_row = m1.rows[row].head;
                Node? node_colum = m2.colums[colum].head;
                float accumulator = 0;
                while (node_row != null && node_colum != null)
                {
                    if ((node_row.position) % m1.N < (node_colum.position) / m2.N)
                    {
                        if (node_row != null) node_row = node_row.Right;
                    }
                    else if ((node_row.position) % m1.N > (node_colum.position) / m2.N)
                    {
                        if (node_colum != null) node_colum = node_colum.Down;
                    }
                    else
                    {
                        accumulator += node_colum.data * node_row.data;
                        if (node_row != null) node_row = node_row.Right;
                        if (node_colum != null) node_colum = node_colum.Down;
                    }
                }
                return accumulator;
            }
        }

        public static Matrix operator *(Matrix m1, Matrix m2)// основная проблема с определением V в матрице результата
        {
            
            float data_result = 0;
            Matrix m_result = new Matrix(0, m1.N);
            //int k = m_result.N / 10;

            for (int i = 0; i < m1.N; i++)
            {
                for (int j = 0; j < m2.N; j++)
                {
                    data_result = mul_row_on_colum(m1, m2, i, j);
                    if (data_result != m_result.V)
                    {
                        //Node result_element;
                        Node node_result = new Node();// элемент для записи в матрицу результата
                        node_result.data = data_result;
                        node_result.position = i * m_result.N + j;
                        Insert_element(m_result, node_result, i, j);
                    }

                }
                //if(i % (m_result.N/100) == 0)Console.WriteLine(i / (m_result.N / 100));
            }
            return m_result;
            
        }



    }
    


}
