using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    
    public partial class TrafficLightsForm : Form
    {
        public TrafficLightsForm()
        {
            InitializeComponent();
        }

        public Array uk = new Array();

        public void TrafficLightsForm_Load(object sender, EventArgs e)
        {
            typeComboBox.Text = "Пешеходный";
            statusComboBox.Text = "Движение запрещено";
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            typeComboBox.Enabled = false;
            statusComboBox.Enabled = false;
            drawTrafficLight.Enabled = false;
            changeStatus.Enabled = false;
        }

        private void kolButton_Click(object sender, EventArgs e) //Задать количество элементов в массиве указателей. Если количество меньше элементов, то элементы удаляются
        {
            Array.size = Convert.ToInt32(kolNumericUpDown.Value);
            if (!Array.TryToAdd())
            {
                for (int i = Array.size; i < Array.mas.Count; i++)
                {
                    Array.mas.Remove(dataGridView1.Rows[i].Tag as TrafficLights);
                }
            }
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            typeComboBox.Enabled = true;
            statusComboBox.Enabled = true;
            drawTrafficLight.Enabled = true;
            changeStatus.Enabled = true;
            UpdateDataGrid();
        }

        private void addButton_Click(object sender, EventArgs e) //Добавление элементов типа светофор
        {
            if (!Array.TryToAdd()) 
                { MessageBox.Show("Невозможно добавить еще светофоры из-за ограничения по размерности массива светофоров!", "Внимание"); return; }
            uk.status = statusComboBox.Text;
            uk.type = typeComboBox.Text;
            uk.Add();
            UpdateDataGrid();
        }

        private void UpdateDataGrid() //Обновление ДатаГрид
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Array.mas.Count; i++)
            {
                dataGridView1.Rows.Add(Array.mas[i].type, Array.mas[i].status);
                dataGridView1.Rows[i].Tag = Array.mas[i];
            }
            dataGridView1.ClearSelection();
        } 

        private void deleteButton_Click(object sender, EventArgs e) //Удаление элементов из массива указателей
        {
            if (dataGridView1.SelectedRows.Count == 0) { return; }
            Array.mas.Remove(dataGridView1.SelectedRows[0].Tag as TrafficLights);
            UpdateDataGrid();
        }

        private void changeStatus_Click(object sender, EventArgs e) //Изменение статуса элемента
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            (dataGridView1.SelectedRows[0].Tag as TrafficLights).color((dataGridView1.SelectedRows[0].Tag as TrafficLights).status); 
            (dataGridView1.SelectedRows[0].Tag as TrafficLights).ChangeState();        
            drawTrafficLight.PerformClick();
            UpdateDataGrid();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) // Установка комбобоксов
        {
            if (typeComboBox.Text == "Пешеходный")
            {
                statusComboBox.Items.Clear();
                statusComboBox.Items.Add("Движение запрещено");
                statusComboBox.Items.Add("Движение разрешено");
            }
            if (typeComboBox.Text == "Автомобильный")
            {
                statusComboBox.Items.Clear();
                statusComboBox.Items.Add("Движение запрещено");
                statusComboBox.Items.Add("Ожидание движения");
                statusComboBox.Items.Add("Движение разрешено");
                statusComboBox.Items.Add("Ожидание остановки");

            }
            if (typeComboBox.Text == "Со стрелкой")
            {
                statusComboBox.Items.Clear();
                statusComboBox.Items.Add("Движение запрещено");
                statusComboBox.Items.Add("Только поворот");
                statusComboBox.Items.Add("Движение и поворот разрешены");
                statusComboBox.Items.Add("Движение разрешено, поворот запрещен");
                statusComboBox.Items.Add("Ожидание остановки");
            }
            statusComboBox.Text = "Движение запрещено";
        }

        private void drawTrafficLight_Click(object sender, EventArgs e) //рисование
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            Graphics gr1;
            gr1 = pictureBox1.CreateGraphics();
            gr1.Clear(pictureBox1.BackColor);
            (dataGridView1.SelectedRows[0].Tag as TrafficLights).color((dataGridView1.SelectedRows[0].Tag as TrafficLights).status);
            (dataGridView1.SelectedRows[0].Tag as TrafficLights).Draw(gr1, (dataGridView1.SelectedRows[0].Tag as TrafficLights).status);
        }
    }
   
}
