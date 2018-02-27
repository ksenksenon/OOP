using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixData
{
    public partial class Form1 : Form
    {
        MatrixData m = new MatrixData();
        MatrixData mm = new MatrixData();
       
        public int size = 0;
        public int rang = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button8.Enabled = false;
           
            button3.Enabled = false;
            button7.Enabled = false;
            button5.Enabled = false;
            button10.Enabled = false;
            button6.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("По отдельности");
            comboBox1.Items.Add("Строкой");
            comboBox2.Items.Add("По отдельности");
            comboBox2.Items.Add("Строкой");
        }

        private void button2_Click(object sender, EventArgs e) //задать размер матрицы для dataGridview 1
        {           
            if (Convert.ToInt32(n.Value) != 0)
            {
                button1.Enabled = true;
                button8.Enabled = true;
                button3.Enabled = true;
                button7.Enabled = true;
                dataGridView1.ColumnCount = Convert.ToInt32(n.Value);
                dataGridView1.RowCount = Convert.ToInt32(n.Value);
                for (int i = 0; i < Convert.ToInt32(n.Value); ++i)
                    for (int j = 0; j < Convert.ToInt32(n.Value); ++j)
                       dataGridView1.Rows[i].Cells[j].ReadOnly = true;

                int N = Convert.ToInt32(n.Value);
                rang = m.K;
                m.K = N; 
                int min;
                if (rang > Convert.ToInt32(n.Value)) min = Convert.ToInt32(n.Value);
                else min = rang;
                for (int i = 0; i < min; ++i)
                    for (int j = 0; j <= i; ++j)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            m.Add(dataGridView1.Rows[i].Cells[j].Value.ToString(), i, j);
                        }
                rang = min;
            }
            else MessageBox.Show("Размер матрицы должен быть больше 0!", "Ошибка!");
        }

        private bool EmptyDataGrid(DataGridView d)
        {
            if (d.RowCount > 0) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e) //добавить объекты в матрицу 1
        {
           
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (dataGridView1.CurrentCell.RowIndex < dataGridView1.CurrentCell.ColumnIndex)
                {
                    MessageBox.Show("Данная ячейка недоступна", "Внимание!");
                    return;
                }
                else
                {//добавить в матрицу 
                if (comboBox1.Text == "") { MessageBox.Show("Выберите способ добавления элементов!", "Внимание!"); return; }
                if (comboBox1.Text.ToString() == "По отдельности")
                {
                    m.Add(Convert.ToByte(day.Value),
                    Convert.ToByte(month.Value),
                    Convert.ToByte(year.Value),
                    dataGridView1.CurrentCell.RowIndex,
                    dataGridView1.CurrentCell.ColumnIndex);
                           
                }
                else
                if (comboBox1.Text.ToString() == "Строкой")
                {
                try
                {
                    m.Add(textBox1.Text, dataGridView1.CurrentCell.RowIndex,
                    dataGridView1.CurrentCell.ColumnIndex);                                     
                }
                catch
                {
                    MessageBox.Show("Некорректно введенная строка!!!!!");
                    m.Add("01.01.00", dataGridView1.CurrentCell.RowIndex,
                    dataGridView1.CurrentCell.ColumnIndex);                          
                }
                       
                }
                dataGridView1.CurrentCell.Value = m.PrintValue(dataGridView1.CurrentCell.RowIndex, dataGridView1.CurrentCell.ColumnIndex);
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Количество выделенных ячеек должно быть равно 1!", "Внимание!");
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e) //сравнить 2 даты
        {
            if (dataGridView1.SelectedCells.Count == 2)
            {
                int i1 = dataGridView1.SelectedCells[0].RowIndex;
                int j1 = dataGridView1.SelectedCells[0].ColumnIndex;
                int i2 = dataGridView1.SelectedCells[1].RowIndex;
                int j2 = dataGridView1.SelectedCells[1].ColumnIndex;
                if (dataGridView1.Rows[i1].Cells[j1].Value == null || dataGridView1.Rows[i2].Cells[j2].Value == null)
                {
                    MessageBox.Show("Нельзя сравнивать пустые ячейки!");
                }
                else
                if (m.srR(i1, j1, i2, j2))
                {
                    listBox1.Items.Insert(0, m.obj[i1, j1].ret() + " = " + m.obj[i2, j2].ret());
                }
                else
                if (m.sr(i1,j1,i2,j2))
                {
                    listBox1.Items.Insert(0, m.obj[i1,j1].ret() + " < " + m.obj[i2, j2].ret());
                }
                else listBox1.Items.Insert(0, m.obj[i1, j1].ret() + " > " + m.obj[i2, j2].ret());
                
            }
            else MessageBox.Show("Выберите 2 ячейки матрицы","Ошибка!");
        }

        private bool full(DataGridView d)
        {
            int count = 0;
            int size = 0;
            for (int i = 0; i < d.RowCount; i++)
                for (int j = 0; j < d.ColumnCount; j++)
                {
                    if (i >= j)
                    {
                        size++;
                        if (d.Rows[i].Cells[j].Value != null)
                            count++;
                    }
                }
            if (count == size) return true; else return false;
        }

        private void button4_Click(object sender, EventArgs e) //задать размер 2 матрицы
        {
            if (Convert.ToInt32(n2.Value) != 0)
            {
                button5.Enabled = true;
                button10.Enabled = true;
                button6.Enabled = true;
                dataGridView2.ColumnCount = Convert.ToInt32(n2.Value);
                dataGridView2.RowCount = Convert.ToInt32(n2.Value);
                for (int i = 0; i < Convert.ToInt32(n2.Value); ++i)
                    for (int j = 0; j < Convert.ToInt32(n2.Value); ++j)
                            dataGridView2.Rows[i].Cells[j].ReadOnly = true;                     
                int N1 = Convert.ToInt32(n2.Value);
                rang = mm.K;
                mm.K = N1;
                int min;
                if (rang > Convert.ToInt32(n2.Value)) min = Convert.ToInt32(n2.Value);
                else min = rang;
                for (int i = 0; i < min; ++i)
                    for (int j = 0; j <= i; ++j)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            mm.Add(dataGridView2.Rows[i].Cells[j].Value.ToString(), i, j);
                        }
                rang = min;
            }
            else MessageBox.Show("Размер матрицы должен быть больше 0!", "Ошибка!");
        }

        private void button5_Click(object sender, EventArgs e) //добавить элементы во 2 матрицу
        {          
            if (dataGridView2.SelectedCells.Count == 1)
            {
                if (dataGridView2.CurrentCell.RowIndex < dataGridView2.CurrentCell.ColumnIndex)
                {
                    MessageBox.Show("Данная ячейка недоступна", "Внимание!");
                    return;
                }
                else
                {//добавить в матрицу 
                    if (comboBox2.Text == "") { MessageBox.Show("Выберите способ добавления элементов!", "Внимание!"); return; }
                    if (comboBox2.Text.ToString() == "По отдельности")
                    {
                         mm.Add(Convert.ToByte(d2.Value),
                         Convert.ToByte(m2.Value),
                         Convert.ToByte(y2.Value),
                         dataGridView2.CurrentCell.RowIndex,
                         dataGridView2.CurrentCell.ColumnIndex);
  
                    }
                    else
                    if (comboBox2.Text.ToString() == "Строкой")
                    {
                    try
                    {
                        mm.Add(textBox2.Text, dataGridView2.CurrentCell.RowIndex, dataGridView2.CurrentCell.ColumnIndex);                       
                    }
                    catch
                    {
                        MessageBox.Show("Некорректно введенная строка!");
                        mm.Add("01.01.00", dataGridView2.CurrentCell.RowIndex,
                        dataGridView2.CurrentCell.ColumnIndex);
                    }                      
                    }
                    dataGridView2.CurrentCell.Value = mm.PrintValue(dataGridView2.CurrentCell.RowIndex, dataGridView2.CurrentCell.ColumnIndex);
                    dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[dataGridView2.CurrentCell.ColumnIndex].ReadOnly = true;
                }

            }
            else
            {
                MessageBox.Show("Количество выделенных ячеек должно быть равно 1!", "Внимание!");
            }
        }

        private void button6_Click(object sender, EventArgs e) //сравнение для 2 матрицы
        {
            if (dataGridView2.SelectedCells.Count == 2)
            {
                int i1 = dataGridView2.SelectedCells[0].RowIndex;
                int j1 = dataGridView2.SelectedCells[0].ColumnIndex;
                int i2 = dataGridView2.SelectedCells[1].RowIndex;
                int j2 = dataGridView2.SelectedCells[1].ColumnIndex;
                if (dataGridView2.Rows[i1].Cells[j1].Value ==null  || dataGridView2.Rows[i2].Cells[j2].Value == null)
                {
                    MessageBox.Show("Нельзя сравнивать пустые ячейки!");
                }
                else
                if (mm.srR(i1, j1, i2, j2))
                {
                    listBox2.Items.Insert(0, mm.obj[i1, j1].ret() + " = " + mm.obj[i2, j2].ret());
                }
                else
                if (mm.sr(i1, j1, i2, j2))
                {
                    listBox2.Items.Insert(0, mm.obj[i1, j1].ret() + " < " + mm.obj[i2, j2].ret());
                }
                else listBox2.Items.Insert(0, mm.obj[i1, j1].ret() + " > " + mm.obj[i2, j2].ret());

            }
            else MessageBox.Show("Выберите 2 ячейки матрицы", "Ошибка!");
        }

        private void button7_Click(object sender, EventArgs e) //сравнение матриц
        {
            listBox3.Items.Clear();
            if (m.CorrectSize(mm))
            {
                if (full(dataGridView1) && full(dataGridView2) || EmptyDataGrid(dataGridView1) && !EmptyDataGrid(dataGridView2) || !EmptyDataGrid(dataGridView1) && EmptyDataGrid(dataGridView2))
                {
                    if (m == mm) listBox3.Items.Insert(0, "Матрицы равны");
                    else listBox3.Items.Insert(0, "Матрицы не равны");
                }
                else MessageBox.Show("Заполните матрицу!");
            }
            else MessageBox.Show("Матрицы должны быть одинакового размера!");
        }

        private void button8_Click(object sender, EventArgs e) //очистить матрицу 1
        {
            if (full(dataGridView1))
            {
                m.Clear();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (m.CorrectInput(i,j,dataGridView1.ColumnCount))
                        {                           
                            dataGridView1.Rows[i].Cells[j].Value = m.PrintValue(i, j);
                        }
            }
            else MessageBox.Show("Заполните все возможные ячейки матрицы!");
        }

        private void button10_Click(object sender, EventArgs e) //очистить матрицу 2
        {
            if (full(dataGridView2))
            {
                mm.Clear();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (mm.CorrectInput(i, j, dataGridView2.ColumnCount))
                        {
                            dataGridView2.Rows[i].Cells[j].Value = mm.PrintValue(i, j);
                        }
            }
            else MessageBox.Show("Заполните все возможные ячейки матрицы!");
        }

        private void button9_Click(object sender, EventArgs e) //копирование
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Выберите матрицу для копирования!", "Внимание!");
            }
            else
            if (radioButton1.Checked) // 1->2
            {
                if (m.CorrectSize(mm))
                {
                    if (full(dataGridView1))
                    {
                        m.CopyMatrix(m,mm);
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                            for (int j = 0; j < dataGridView2.ColumnCount; j++)
                                if (mm.CorrectInput(i, j, dataGridView2.ColumnCount))
                                {
                                    dataGridView2.Rows[i].Cells[j].Value = mm.PrintValue(i, j);
                                }
                    }
                    else MessageBox.Show("Заполните матрицу!");
                }
                else MessageBox.Show("Матрицы должны быть одинакового размера!", "Внимание!");
            }
            else
            if (radioButton2.Checked) // 2->1
            {
                if (m.CorrectSize(mm))
                {
                    if (full(dataGridView2))
                    {
                        mm.CopyMatrix(mm,m);
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                                if (m.CorrectInput(i, j, dataGridView1.ColumnCount))
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = m.PrintValue(i, j);
                                }
                    }
                    else MessageBox.Show("Заполните матрицу!");
                }
                else MessageBox.Show("Матрицы должны быть одинакового размера!", "Внимание!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
    }

    public class MatrixData
    {
        private int k;
        public Data[,] obj;
       
        public MatrixData()
        {

        }

        public int K
        {
            get
            {
                return k;
            }
            set
            {
                obj = new Data[value, value];
                k = value;
            }
        }

        public bool CorrectInput(int i, int j, int k) //проверка корректности ввода
        {
            if (i < k && j < k && i >= j)
                return true;
            else return false;
        }

        public bool CorrectSize(MatrixData m2) //проверка на одинаковый размер матриц
        {
            if (k == m2.k) return true;
            else return false;
        }

        public void Add(string str, int i, int j)
        {
            obj[i, j] = new Data();
            obj[i, j].setAll(str);
        }

        public void Add(byte d, byte m, byte y, int i, int j) // добавить в матрицу элемент типа Дата
        {
            obj[i, j] = new Data(d, m, y);
        }

        public string PrintValue(int i, int j) //вывести в dataGridview
        {
            return obj[i, j].ret();
        }

        public bool sr(int i1, int j1, int i2, int j2) //сравнить даты
        {
            if (obj[i1, j1] < obj[i2, j2]) return true;
            else return false;
        }

        public bool srR(int i1, int j1, int i2, int j2)
        {
            if (obj[i1, j1] == obj[i2, j2]) return true;
            else return false;
        }

        public static bool operator ==(MatrixData m1, MatrixData m2) //сравнение матриц на полное равенство
        {
            int count = 0;
            int size = 0;
            if (m1.k == m2.k)
            {
                for (int i = 0; i < m1.k; i++)
                    for (int j = 0; j < m1.k; j++)
                    {
                        if (i>=j)
                        {
                            size++;
                            if (m1.obj[i, j] == m2.obj[i, j])
                                count++;
                        }
                    }
            }

            if (count == size) return true; else return false;
        }

        public static bool operator !=(MatrixData m1, MatrixData m2)
        {
            int count = 0;
            int size = 0;
            if (m1.k == m2.k)
            {
                for (int i = 0; i < m1.k; i++)
                    for (int j = 0; j < m1.k; j++)
                    {
                        if (i >= j)
                        {
                            size++;
                            if (m1.obj[i, j] != m2.obj[i, j])
                                count++;
                        }
                    }
            }

            if (count == size) return true; else return false;
        }

        public void Clear() //очистить
        {
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                {
                    if (i >= j)
                    {
                        obj[i, j] = new Data(1, 1, 0);
                    }
                }
        }

        public void CopyMatrix(MatrixData m1, MatrixData m2) //копирование
        {
            for (int i = 0; i < m2.k; i++)
                for (int j = 0; j < m2.k; j++)
                {
                    if (i >= j)
                    {
                        byte d = Convert.ToByte(m1.obj[i, j].Day);
                        byte m = Convert.ToByte(m1.obj[i, j].Month);
                        byte y = Convert.ToByte(m1.obj[i, j].Year);

                        m2.obj[i, j] = new Data(d, m, y);                     
                    }
                }
        }

    }

    public class Data
    {
        public string Day, Month, Year;

        public Data()
        { }

        public Data(byte day, byte month, byte year) //конструктор
        {
            Day = "01"; Month = "01"; Year = "00";
            if (!Correct(day, month, year)) { MessageBox.Show("Некорректные данные!"); }
            else
            {
                setDay(day);
                setMonth(month);
                setYear(year);
            }
        }

        public string ret()
        {
            string s = Day + "." + Month + "." + Year;
            return s;
        }

        public void setDay(byte d) //задать день
        {
            if (d > 0 && d <= 31) Day = Convert.ToString(d);
            if (Day.Length == 1)
            {
                Day = "0" + Day;
            }
        }

        public void setMonth(byte m) //задаь месяц
        {
            if (m >= 1 && m <= 12) Month = Convert.ToString(m);
            if (Month.Length == 1)
            {
                Month = "0" + Month;
            }
        }

        public void setYear(byte y) //задать год
        {
            if (y<100) Year = Convert.ToString(y);
            if (Year.Length == 1)
            {
                Year = "0" + Year;
            }
        }

        public void setAll(byte d, byte m, byte y) //задать все параметры сразу
        {
            if (d > 0 && d <= 31) Day = Convert.ToString(d);
            if (Day.Length == 1)
            {
                Day = "0" + Day;
            }
            if (m >= 1 && m <= 12) Month = Convert.ToString(m);
            if (Month.Length == 1)
            {
                Month = "0" + Month;
            }
            if (y < 100) Year = Convert.ToString(y);
            if (Year.Length == 1)
            {
                Year = "0" + Year;
            }
        }

        public void setAll(string dmy) //считать дату строкой
        {
           
            string[] c = dmy.Split(new char[] { '.' });
            if (Correct(Convert.ToByte(c[0]), Convert.ToByte(c[1]), Convert.ToByte(c[2])))
            {
                setDay(Convert.ToByte(c[0]));
                setMonth(Convert.ToByte(c[1]));
                setYear(Convert.ToByte(c[2]));
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
                Day = "01"; Month = "01"; Year = "00";
            }
        }

        public bool Correct(byte day, byte month, byte year) //корректность ввода
        {       
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if (day < 1 || day > 31 || year > 99) { return false; } else { return true; }
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (day < 1 || day > 30 || year > 99) { return false; } else { return true; }
                    }
                case 2:
                    {
                        if (day < 1 || day > 28 || year > 99) { return false; } else { return true; }
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        public static bool operator <(Data d1, Data d2)
        {
            if (Convert.ToByte(d1.Year) < Convert.ToByte(d2.Year)) return true;
            else if (Convert.ToByte(d1.Month) < Convert.ToByte(d2.Month)) return true;
            else if (Convert.ToByte(d1.Day) < Convert.ToByte(d2.Day)) return true;
            else return false;
        }
        public static bool operator >(Data d1, Data d2)
        {
            if (Convert.ToByte(d1.Year) > Convert.ToByte (d2.Year)) return true;
            else if (Convert.ToByte(d1.Month) > Convert.ToByte(d2.Month)) return true;
            else if (Convert.ToByte(d1.Day) > Convert.ToByte(d2.Day)) return true;
            else return false;
        }

        public static bool operator ==(Data d1, Data d2)
        {
            if (d1.Year == d2.Year && d1.Day == d2.Day && d1.Month == d2.Month) return true;
            else return false;
        }
        public static bool operator !=(Data d1, Data d2)
        {
            if (d1.Year != d2.Year || d1.Day != d2.Day || d1.Month != d2.Month) return true;
            else return false;
        }

    }

}
