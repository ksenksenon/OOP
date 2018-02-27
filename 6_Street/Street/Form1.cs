using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Street
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label9.Text = "0";
            button1.Enabled = false;
            SaveFile.Enabled = false;
            button2.Enabled = false;
        }

        public Str h = new Str();

        private void AddStreet_Click(object sender, EventArgs e) //добавление улицы
        {
            Str s = new Str(str_name.Text, Convert.ToInt32(h_count.Value));
            if (!s.IsNameEmpty())
            {
                if (!s.CorrectStreet(str_name.Text) && (Convert.ToInt32(dataGridView1.RowCount) > 0))
                {
                    MessageBox.Show("Некорректное название улицы!", "Внимание!"); return;
                }
                else
                {
                    s.AddStreet();
                    dataGridView1.Rows.Add(s.Name, s.Count);
                    UpdateDataGrid();
                    label9.Text = h_count.Value.ToString();
                    button1.Enabled = true;
                }
            }
            else MessageBox.Show("Ошибка ввода!", "Внимание!");
            
        }

        private void UpdateDataGrid() //Обновление ДатаГрид
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Str.list_street.Count; i++)
            {
                dataGridView1.Rows.Add(Str.list_street[i].Name, Str.list_street[i].Count);
                dataGridView1.Rows[i].Tag = Str.list_street[i];
            }
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e) //добавление дома
        {
            if (dataGridView1.SelectedRows.Count == 0) { MessageBox.Show("Пожалуйста, выберите улицу!"); return; }           
          
            if ((dataGridView1.SelectedRows[0].Tag as Str).adding((dataGridView1.SelectedRows[0].Tag as Str).list_house.Count))
            {
                int number = Convert.ToInt32(num.Value);
                int count_floor = Convert.ToInt32(c_fl.Value);
                int count_entrance = Convert.ToInt32(c_entr.Value);
                int flat_entrance = Convert.ToInt32(c_flat.Value);
                int flat_floor = Convert.ToInt32(finf.Value);
                if (!(dataGridView1.SelectedRows[0].Tag as Str).CorrectHouse(number) && (dataGridView1.SelectedRows[0].Tag as Str).Count > 0)
                {
                    MessageBox.Show("Некорректный номер дома!", "Внимание!"); return;
                }
                else
                {
                    label9.Text = (dataGridView1.SelectedRows[0].Tag as Str).Counter().ToString();
                    (dataGridView1.SelectedRows[0].Tag as Str).AddHouse(number, count_floor, count_entrance, flat_entrance, flat_floor);
                    SaveFile.Enabled = true;
                    button2.Enabled = true;
                }
            }
            else
            {
                label9.Text = "0";
                MessageBox.Show("Превышение возможного количества домов!", "Внимание!");
            }
           
        }


        private void SaveFile_Click(object sender, EventArgs e) //сохранение в файл
        {
            foreach (Str obj in Str.list_street)
                if (obj.CountOfHouse())
                {
                    obj.Writing();
                }
                else
                {
                    MessageBox.Show ("Добавьте оставшиеся дома!"); return;
                } 
            Process.Start(Application.StartupPath + @"\Streets.txt");
        }

       
        private void button2_Click(object sender, EventArgs e) //рисование
        {
            
            List<PictureBox> picture = new List<PictureBox>();
           
            picture.Add(pictureBox1);
            picture.Add(pictureBox2);
            picture.Add(pictureBox3);
            picture.Add(pictureBox4);
            picture.Add(pictureBox5);
            picture.Add(pictureBox6);
            picture.Add(pictureBox7);
            picture.Add(pictureBox8);
            picture.Add(pictureBox9);
            picture.Add(pictureBox10);

            for (int i = 0; i < picture.Count; i++)
            {
                Graphics gr = picture[i].CreateGraphics();
                gr.Clear(pictureBox1.BackColor);
            }

            for (int i = 0; i < (dataGridView1.SelectedRows[0].Tag as Str).list_house.Count; i++)
            {
                Graphics gr = picture[i].CreateGraphics();
                gr.Clear(picture[i].BackColor);
                (dataGridView1.SelectedRows[0].Tag as Str).list_house[i].draw(gr);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label9.Text = ((dataGridView1.SelectedRows[0].Tag as Str).Count - (dataGridView1.SelectedRows[0].Tag as Str).list_house.Count).ToString();
        }
    }
}
