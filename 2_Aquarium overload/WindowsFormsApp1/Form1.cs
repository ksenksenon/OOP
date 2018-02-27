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

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //расчет объема аквариума, жидкости и процента заполненности 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            try
            {
                aq1 = new Aquarium(Convert.ToDouble(x1.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(z1.Text), Convert.ToDouble(l1.Text));
                aq2 = new Aquarium(Convert.ToDouble(x2.Text), Convert.ToDouble(y2.Text), Convert.ToDouble(z2.Text), Convert.ToDouble(l2.Text));
                if (aq1.Input(Convert.ToDouble(x1.Text), Convert.ToDouble(y1.Text),Convert.ToDouble(z1.Text), Convert.ToDouble(l1.Text)) &&
                    aq2.Input(Convert.ToDouble(x2.Text), Convert.ToDouble(y2.Text), Convert.ToDouble(z2.Text), Convert.ToDouble(l2.Text)))
                {
                    listBox1.Items.Insert(0, "Объем аквариума: " + Convert.ToString(aq1.Size()));
                    listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));
                    listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(Math.Round(aq1.Percent(), 2)) + "%");
                   
                    listBox2.Items.Insert(0, "Объем аквариума: " + Convert.ToString(aq2.Size()));
                    listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                    listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(Math.Round(aq2.Percent(), 2)) + "%");
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                    if (aq1<aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                    else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                    else if (aq1==aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");

                }
                else {MessageBox.Show("Проверьте введенные данные!"); }
            }
            catch { MessageBox.Show("Некорректный ввод! "); }
        } 

        private void button2_Click(object sender, EventArgs e) //долить заданный объем воды
        {
            if (wvol.Text != "")
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Выберите аквариум!");
                }
                
                else
                if (radioButton1.Checked) //долить в 1
                {//проверка на возможность долить заданный объем воды в 1 аквариум

                    if (aq1.Vol_wat(Convert.ToDouble(wvol.Text)))
                    {
                        aq1 += Convert.ToDouble(wvol.Text);
                        l1.Text = Convert.ToString(Math.Round(aq1.L,2)); //новый уровень воды
                        listBox1.Items.RemoveAt(1);
                        listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));
                        listBox1.Items.RemoveAt(2);
                        listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(aq1.Percent() + "%"));
                        listBox3.Items.RemoveAt(0);
                        listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                        listBox3.Items.RemoveAt(1);
                        if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                        else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                        else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                    }
                    else MessageBox.Show("Превышение объема аквариума!", "Аквариум 1");
                }
                else if (radioButton2.Checked) //долить во 2
                {//проверка на возможность долить заданный объем воды во 2 аквариум

                    if (aq2.Vol_wat(Convert.ToDouble(wvol.Text)))
                    {
                        aq2 += Convert.ToDouble(wvol.Text);
                        l2.Text = Convert.ToString(Math.Round(aq2.L, 2)); //новый уровень воды
                        listBox2.Items.RemoveAt(1);
                        listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                        listBox2.Items.RemoveAt(2);
                        listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(aq2.Percent() + "%"));
                        listBox3.Items.RemoveAt(0);
                        listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                        listBox3.Items.RemoveAt(1);
                        if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                        else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                        else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                    }
                    else MessageBox.Show("Превышение объема аквариума!", "Аквариум 2");
                }               
            }
            else MessageBox.Show("Необходимо ввести значение!", "Объем воды");
        }
           
        
        private void button3_Click(object sender, EventArgs e)//вылить заданный объем воды
        { 
            if (wvol.Text != "")
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Выберите аквариум!");
                }
                
                else
                if (radioButton1.Checked) //вылить из 1
                {//проверка на возможность вылить заданный объем воды из 1 аквариума
                    if (aq1.Vol_wat_out(Convert.ToDouble(wvol.Text)))
                    {                       
                        aq1-=Convert.ToDouble(wvol.Text);
                        l1.Text = Convert.ToString(Math.Round(aq1.L,2)); //новый уровень воды
                        listBox1.Items.RemoveAt(1);
                        listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));
                        listBox1.Items.RemoveAt(2);
                        listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(aq1.Percent() + "%"));
                        listBox3.Items.RemoveAt(0);
                        listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                        listBox3.Items.RemoveAt(1);
                        if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                        else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                        else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                    }
                    else MessageBox.Show("Недостаточный объем воды!", "Аквариум 1");
                }

                else if (radioButton2.Checked) //вылить из 2
                {
                    if (aq2.Vol_wat_out(Convert.ToDouble(wvol.Text)))
                    {
                        aq2-=Convert.ToDouble(wvol.Text);
                        l2.Text = Convert.ToString(Math.Round(aq2.L,2)); //новый уровень воды
                        listBox2.Items.RemoveAt(1);
                        listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                        listBox2.Items.RemoveAt(2);
                        listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(aq2.Percent() + "%"));
                        listBox3.Items.RemoveAt(0);
                        listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                        listBox3.Items.RemoveAt(1);
                        if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                        else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                        else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                        }
                        else MessageBox.Show("Недостаточный объем воды!", "Аквариум 2");
                }
            }
            else MessageBox.Show("Необходимо ввести значение!", "Объем воды");
            
        }
        private void button4_Click(object sender, EventArgs e) //перелить все
        {
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Выберите аквариум!", "Переливание");
            }
            
            else
            if (radioButton3.Checked)//1->2
            {
               
                if (aq2.Vol_wat(aq1.Water()))
                {
                    double n_v = aq1 * aq2;
                    listBox2.Items.RemoveAt(1);
                    listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(n_v));
                    l2.Text = Convert.ToString(Math.Round(aq2.L,2)); 
                    l1.Text = Convert.ToString(Math.Round(aq1.L,2));
                    listBox2.Items.RemoveAt(2);
                    listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(aq2.Percent()) + "%");
                    listBox1.Items.RemoveAt(1);
                    listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));
                    listBox1.Items.RemoveAt(2);
                    listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(aq1.Percent()) + "%");
                    listBox3.Items.RemoveAt(0);
                    listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                    listBox3.Items.RemoveAt(1);
                    if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                    else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                    else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                }
                else MessageBox.Show("Превышение объема аквариума!", "Аквариум 2");
            }
            else
                if (radioButton4.Checked)
                {
                    if (aq1.Vol_wat(aq2.Water()))
                    {                  
                    double n_v = aq2 * aq1;
                    listBox1.Items.RemoveAt(1);
                    listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(n_v));
                    l2.Text = Convert.ToString(Math.Round(aq2.L,2)); //новый уровень воды во 2 акв
                    l1.Text = Convert.ToString(Math.Round(aq1.L,2));
                    listBox1.Items.RemoveAt(2);
                    listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(aq1.Percent()) + "%");
                    listBox2.Items.RemoveAt(1);
                    listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                    listBox2.Items.RemoveAt(2);
                    listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(aq2.Percent()) + "%");
                    listBox3.Items.RemoveAt(0);
                    listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                    listBox3.Items.RemoveAt(1);
                    if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                    else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                    else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                }
                    else MessageBox.Show("Превышение объема аквариума!", "Аквариум 1");
                }
        }
    

        private void button5_Click(object sender, EventArgs e) //перелить заданный объем воды
        {
            if (water.Text != "")
            {
                if (!radioButton3.Checked && !radioButton4.Checked)
                {
                    MessageBox.Show("Выберите аквариум!");
                }
                else
                if (radioButton3.Checked)//1->2
                {
                    if (aq1.Vol_wat_out(Convert.ToDouble(water.Text)))
                    {
                        if (aq2.Vol_wat(Convert.ToDouble(water.Text)))
                        {
                            aq2.Transfuse(aq1,aq2, Convert.ToDouble(water.Text));
                            listBox1.Items.RemoveAt(1);
                            listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));
                            l2.Text = Convert.ToString(Math.Round(aq2.L,2)); //новый уровень воды во 2 акв
                            l1.Text = Convert.ToString(Math.Round(aq1.L,2));
                            listBox1.Items.RemoveAt(2);
                            listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(aq1.Percent()) + "%");
                            listBox2.Items.RemoveAt(1);
                            listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                            listBox2.Items.RemoveAt(2);
                            listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(aq2.Percent()) + "%");
                            listBox3.Items.RemoveAt(0);
                            listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                            listBox3.Items.RemoveAt(1);
                            if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                            else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                            else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                        }
                        else MessageBox.Show("Превышение объема аквариума!", "Аквариум 2");
                    }
                    else MessageBox.Show("Недостаточный объем воды!", "Аквариум 1");

                }
                else if (radioButton4.Checked)//2->1
                {
                    if (aq2.Vol_wat_out(Convert.ToDouble(water.Text)))
                    {
                        if (aq1.Vol_wat(Convert.ToDouble(water.Text)))
                        {
                            aq1.Transfuse(aq2, aq1, Convert.ToDouble(water.Text));
                            listBox1.Items.RemoveAt(1);
                            listBox1.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq1.Water()));
                            l2.Text = Convert.ToString(Math.Round(aq2.L,2)); //новый уровень воды во 2 акв
                            l1.Text = Convert.ToString(Math.Round(aq1.L,2));
                            listBox1.Items.RemoveAt(2);
                            listBox1.Items.Insert(2, "Заполненность: " + Convert.ToString(aq1.Percent()) + "%");
                            listBox2.Items.RemoveAt(1);
                            listBox2.Items.Insert(1, "Объем налитой жидкости: " + Convert.ToString(aq2.Water()));
                            listBox2.Items.RemoveAt(2);
                            listBox2.Items.Insert(2, "Заполненность: " + Convert.ToString(aq2.Percent()) + "%");
                            listBox3.Items.RemoveAt(0);
                            listBox3.Items.Insert(0, "Разность объемов жидкостей: " + Convert.ToString(Math.Round(aq1 - aq2, 2)));
                            listBox3.Items.RemoveAt(1);
                            if (aq1 < aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 < объема жидкости Аквариума 2");
                            else if (aq1 > aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 > объема жидкости Аквариума 2");
                            else if (aq1 == aq2) listBox3.Items.Insert(1, "Объем жидкости Аквариума 1 = объему жидкости Аквариума 2");
                        }
                        else MessageBox.Show("Превышение объема аквариума!", "Аквариум 1");
                    }
                    else MessageBox.Show("Недостаточный объем воды!", "Аквариум 2");

                }
            }
            else MessageBox.Show("Необходимо ввести значение!", "Объем переливаемой воды");
        }

        private void x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void z1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void l1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void wvol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void water_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void x2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void y2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void z2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void l2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }
    }

    public class Aquarium
    {
        private double x, y, z, l;

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

        public double Water_in(double w_in) //доливаем заданный объем жидкости 
        {
            l+=Water_level(w_in);
            return Water(); //новый V жидкости в акв           
        }

        public bool Vol_wat(double w_in) //не превышает ли объем вливаемой жидкости объем аквариума
        {
            if (Math.Round(Water() + w_in, 2) <= Size()) return true;
            else return false;
        }

        public double Water_out(double w_out) //выливаем заданный объем жидкости
        {
            l -= Water_level(w_out);
            return Water(); //новый V жидкости в акв     
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
        
        public double Transfuse_all(Aquarium a1, Aquarium a2) //переливание всего объема из 1 во 2
        {
            a2.l = a2.Water_level(a2.Water()+a1.Water());
            a1.l = 0;
            return a1.Water() + a2.Water();//новый объем жидкости во 2 акв            
        }

        public bool Input(double x, double y, double z, double l) //проверка на корректность ввода
        {
            if ((l <= z)&&(x>0)&&(y>0)&&(z>0)&&(l>=0)) return true; 
            else return false;
        }

        public static Aquarium operator +(Aquarium a1, double w) //долить
        {          
            a1.l += a1.Water_level(w);
            return a1;
        }
        public static Aquarium operator -(Aquarium a1, double w) //вылить
        {
            a1.l -= a1.Water_level(w);
            return a1;
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
        public static double operator *(Aquarium a1, Aquarium a2) //перелить весь объем 1->2
        {
            a2.l = a2.Water_level(a2.Water() + a1.Water());
            a1.l = 0;
            return a1.Water() + a2.Water();
        }

    }
}


