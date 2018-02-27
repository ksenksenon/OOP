using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        Aquarium aq1;  //объекты класса
        Aquarium aq2;
        Aquarium aq3;

        public int sec = 0;
        public double delta=0;
        public double time=0;

        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
            button6.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button4_Click(object sender, EventArgs e) //перелить все
        {
            //delta = 0;
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Выберите аквариум!", "Переливание");
            }

            else
            if (v.Text == "")
            { MessageBox.Show("Введите скорость переливания в литрах/сек!"); }
            else           
            {
                if (radioButton3.Checked)//1->2
                {
                    if (aq1.Water() == 0) { MessageBox.Show("Недостаточно воды для переливания!", "Аквариум 1"); }
                    else
                    if (aq2.Vol_wat(aq1.Water()))
                    {
                        //if (Convert.ToSingle(v.Text) > aq1.Water()) {MessageBox.Show("Некорректное значение скорости переливания"); return; }
                        //else
                        delta = aq2.Transfuse_all(aq1, aq2, Convert.ToSingle(v.Text));
                        time = aq2.T;//
                        timer1.Interval = 1000;
                        timer1.Start();

                    }
                    else MessageBox.Show("Превышение объема аквариума!", "Аквариум 2");
                }
                else
                    if (radioButton4.Checked)
                {
                    if (aq2.Water() == 0) { MessageBox.Show("Недостаточно воды для переливания!", "Аквариум 2"); }
                    else
                    if (aq1.Vol_wat(aq2.Water()))
                    {
                        delta = aq1.Transfuse_all(aq2, aq1, Convert.ToSingle(v.Text));
                        time = aq1.T;//
                        timer1.Interval = 1000;
                        timer1.Start();

                    }
                    else MessageBox.Show("Превышение объема аквариума!", "Аквариум 1");
                }
            }
        }
    
       
        private void button6_Click(object sender, EventArgs e)
        {
            aq1 = new Aquarium(Convert.ToDouble(x1.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(z1.Text), Convert.ToDouble(l1.Text));
            aq2 = new Aquarium(Convert.ToDouble(x2.Text), Convert.ToDouble(y2.Text), Convert.ToDouble(z2.Text), Convert.ToDouble(l2.Text));
            aq3 = new Aquarium(Convert.ToDouble(x3.Text), Convert.ToDouble(y3.Text), Convert.ToDouble(z3.Text), Convert.ToDouble(l3.Text));
            Graphics gr1,gr2,gr3; // Создаём переменную gr типа Graphics (холст для рисования)         
           
            Pen MyPen; // Создаем карандш MyPen типа Pen
            MyPen = new Pen(Color.Blue);
            //аквариум 1
            gr1 = pictureBox1.CreateGraphics(); // Инициализируем созданную переменную
            gr1.FillRectangle(Brushes.White, 10, 20, Convert.ToSingle(x1.Text)*10, Convert.ToSingle(z1.Text)*10); //фон1                               
            gr1.FillRectangle(Brushes.Blue, 10, (20 + (Convert.ToSingle(z1.Text) - Convert.ToSingle(l1.Text))*10), 
                Convert.ToSingle(x1.Text)*10, Convert.ToSingle(l1.Text)*10); //вода1
            //аквариум 2                                                               
            gr2 = pictureBox2.CreateGraphics();
            gr2.FillRectangle(Brushes.White, 10,20, Convert.ToSingle(x2.Text)*10, Convert.ToSingle(z2.Text)*10); //фон2
            gr2.FillRectangle(Brushes.Blue, 10, (20 + (Convert.ToSingle(z2.Text)- Convert.ToSingle(l2.Text))*10), 
                Convert.ToSingle(x2.Text)*10, Convert.ToSingle(l2.Text)*10); //вода2
            //аквариум 3
            gr3 = pictureBox3.CreateGraphics();
            gr3.FillRectangle(Brushes.White,10,20, Convert.ToSingle(x3.Text) * 10, Convert.ToSingle(z3.Text) * 10); //фон3
            gr3.FillRectangle(Brushes.Blue, 10, (20 +(Convert.ToSingle(z3.Text) - Convert.ToSingle(l3.Text)) * 10),
                Convert.ToSingle(x3.Text) * 10, Convert.ToSingle(l3.Text) * 10); //вода3
            button4.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
           
            if (radioButton3.Checked)//1->2
            {
                if (sec < time)
                {
                    aq2.Water_in(delta); aq1.Water_out(delta);
                    l1.Text = Convert.ToString(Math.Round(aq1.L, 2));
                    l2.Text = Convert.ToString(Math.Round(aq2.L, 2));
                    button6.PerformClick();

                }
                else
                {
                    aq2.Water_in(aq1.L);
                    aq1.Water_out(aq1.L);
                    l1.Text = Convert.ToString(Math.Round(aq1.L, 2));
                    l2.Text = Convert.ToString(Math.Round(aq2.L, 2));
                    button6.PerformClick();
                    button1.PerformClick();
                    sec = 0;
                    timer1.Stop(); 
                }
            }
            else if (radioButton4.Checked)
            {
                if (sec < time)
                {
                    aq1.Water_in(delta); aq2.Water_out(delta);
                    l1.Text = Convert.ToString(Math.Round(aq1.L, 2));
                    l2.Text = Convert.ToString(Math.Round(aq2.L, 2));
                    button6.PerformClick();
                }
                else
                {
                    aq1.Water_in(aq2.L);
                    aq2.Water_out(aq2.L);
                    l1.Text = Convert.ToString(Math.Round(aq1.L, 2));
                    l2.Text = Convert.ToString(Math.Round(aq2.L, 2));
                    button6.PerformClick();
                    button1.PerformClick();
                    sec = 0;
                    timer1.Stop(); 
                }
            }
            sec++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                aq1 = new Aquarium(Convert.ToDouble(x1.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(z1.Text), Convert.ToDouble(l1.Text));
                aq2 = new Aquarium(Convert.ToDouble(x2.Text), Convert.ToDouble(y2.Text), Convert.ToDouble(z2.Text), Convert.ToDouble(l2.Text));
                aq3 = new Aquarium(Convert.ToDouble(x3.Text), Convert.ToDouble(y3.Text), Convert.ToDouble(z3.Text), Convert.ToDouble(l3.Text));
                if (aq1.Input(Convert.ToDouble(x1.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(z1.Text), Convert.ToDouble(l1.Text)) &&
                 aq2.Input(Convert.ToDouble(x2.Text), Convert.ToDouble(y2.Text), Convert.ToDouble(z2.Text), Convert.ToDouble(l2.Text)) &&
                 aq3.Input(Convert.ToDouble(x3.Text), Convert.ToDouble(y3.Text), Convert.ToDouble(z3.Text), Convert.ToDouble(l3.Text)))
                {
                    listBox1.Items.Insert(0, "Объем аквариума 1: " + Convert.ToString(aq1.Size()));
                    listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));                   
                    listBox1.Items.Insert(2, "Объем аквариума 2: " + Convert.ToString(aq2.Size()));
                    listBox1.Items.Insert(3, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                    listBox1.Items.Insert(4, "Объем аквариума 3: " + Convert.ToString(aq3.Size()));
                    listBox1.Items.Insert(5, "Объем налитой жидкости: " + Convert.ToString(aq3.Water()));
                    
                    button6.Enabled = true;
                }
                else { MessageBox.Show("Размер аквариумов не должен превышать 22 ед. " +
                    "Уровень жидкости не должен превышать высоту аквариума"); }
            }
            catch { MessageBox.Show("Некорректный ввод! "); }
        }
    }

    public class Aquarium
    {
        private double x, y, z, l, t;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double L
        {
            get { return l; }
            set { l = value; }
        }
        public double T
        {
            get { return t; }
            set { t = value; }
        }


        public Aquarium(double x, double y, double z, double l) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.l = l;
        }


        public double Size() //объем аквариума
        {
            return Math.Round(x*y*z, 2);
        }

        public double Water() //объем воды
        {
            return Math.Round(x*y*l, 2);
        }

        public double Percent() //процент заполненности
        {
            return Math.Round(Water() / Size() * 100, 2);
        }

        public double Water_in(double delta) //доливаем заданный объем жидкости 
        {
            l+=delta;
            return l; //новый V жидкости в акв           
        }

        public bool Vol_wat(double w_in) //не превышает ли объем вливаемой жидкости объем аквариума
        {
            if (Math.Round(Water() + w_in, 2) <= Size()) return true;
            else return false;
        }

        public double Water_out(double delta) //выливаем заданный объем жидкости
        {
            l-=delta;
            return l; //новый V жидкости в акв     
        }

        public bool Vol_wat_out(double w_out)//не превышает ли объем выливаемой жидкости объем налитой жидкости
        {
            if (w_out <= Math.Round(Water(), 2)) return true;
            else return false;
        }

        public double Water_level(double vol) //уровень воды
        {
            return vol / (x *y);
        }

        public void Transfuse(Aquarium a1, Aquarium a2, double w)
        {//переливание заданного объема из 1 во 2
            a2.l = a2.Water_level(a2.Water() + w);
            a1.l = a1.Water_level(a1.Water() - w); 
        }
        
        public double Transfuse_all(Aquarium a1, Aquarium a2, double v) //переливание всего объема из 1 во 2
        {          
            double prev_v2 = a2.Water(); //объем до переливания
            double prev_lvl2 = a2.Water_level(a2.Water()); //уровень воды до переливания
            double n_v = a1.Water() + a2.Water();  //новый объем 2 акв
            t = Math.Abs(prev_v2 - n_v) / v;
            a2.l = a2.Water_level(n_v);
            double delta = Math.Abs(prev_lvl2 - a2.L) / t;
            a2.l = prev_lvl2;
            return delta;
        }

       
        public bool Input(double x, double y, double z, double l) //проверка на корректность ввода
        {
            if ((l <= z)&&(x>0)&&(x<=22)&&(y>0)&&(z>0)&&(z<=22)&&(l>=0)) return true; 
            else return false;
        }

        public static double operator +(Aquarium a1, double w) //долить
        {          
            a1.l += a1.Water_level(w);
            return a1.Water();
        }
        public static double operator -(Aquarium a1, double w) //вылить
        {
            a1.l -= a1.Water_level(w);
            return a1.Water();
        }
        public static double operator -(Aquarium a1, Aquarium a2) //разность объемов жидкостей
        {
            return Math.Abs(a1.Water()-a2.Water());
        }
        public static bool operator <(Aquarium a1, Aquarium a2) 
        {
            if (a1.Water() < a2.Water())
                return true;
            else return false;

        }
        public static bool operator >(Aquarium a1, Aquarium a2) 
        {
            if (a1.Water() > a2.Water())
                return true;
            else return false;
        }
        public static bool operator ==(Aquarium a1, Aquarium a2)
        {
            if (a1.Water() == a2.Water())
                return true;
            else return false;
        }
        public static bool operator !=(Aquarium a1, Aquarium a2)
        {
            if (a1.Water() != a2.Water())
                return true;
            else return false;
        }
        
       

    }
}


