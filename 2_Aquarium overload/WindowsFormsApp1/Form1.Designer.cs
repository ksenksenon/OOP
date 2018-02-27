namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.z2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.TextBox();
            this.z1 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.wvol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.water = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Уровень жидкости";
            // 
            // l2
            // 
            this.l2.Location = new System.Drawing.Point(101, 104);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(73, 20);
            this.l2.TabIndex = 14;
            this.l2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l2_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Высота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ширина";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Длина";
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(9, 104);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(73, 20);
            this.z2.TabIndex = 10;
            this.z2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.z2_KeyPress_1);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(101, 49);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(73, 20);
            this.y2.TabIndex = 9;
            this.y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y2_KeyPress_1);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(9, 49);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(73, 20);
            this.x2.TabIndex = 8;
            this.x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x2_KeyPress_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.x2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.y2);
            this.groupBox2.Controls.Add(this.z2);
            this.groupBox2.Controls.Add(this.l2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(248, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 144);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Аквариум 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.x1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.y1);
            this.groupBox1.Controls.Add(this.z1);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 144);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аквариум 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Длина";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(9, 49);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(73, 20);
            this.x1.TabIndex = 8;
            this.x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Уровень жидкости";
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(101, 49);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(73, 20);
            this.y1.TabIndex = 9;
            this.y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y1_KeyPress);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(9, 104);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(73, 20);
            this.z1.TabIndex = 10;
            this.z1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.z1_KeyPress);
            // 
            // l1
            // 
            this.l1.Location = new System.Drawing.Point(101, 104);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(73, 20);
            this.l1.TabIndex = 14;
            this.l1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.l1_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Высота";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Рассчитать объем";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 56);
            this.listBox1.TabIndex = 20;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(248, 192);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(210, 56);
            this.listBox2.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Долить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "Вылить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // wvol
            // 
            this.wvol.Location = new System.Drawing.Point(17, 113);
            this.wvol.Name = "wvol";
            this.wvol.Size = new System.Drawing.Size(100, 20);
            this.wvol.TabIndex = 26;
            this.wvol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wvol_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Введите объем воды:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.water);
            this.groupBox3.Location = new System.Drawing.Point(726, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 274);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перелить:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 49);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 34;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2 => 1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1 => 2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 38);
            this.button5.TabIndex = 32;
            this.button5.Text = "Перелить указанный объем";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Объем переливаемой воды:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 38);
            this.button4.TabIndex = 31;
            this.button4.Text = "Перелить все";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // water
            // 
            this.water.Location = new System.Drawing.Point(11, 178);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(100, 20);
            this.water.TabIndex = 30;
            this.water.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.water_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.wvol);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(498, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 274);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите аквариум:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Аквариум 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Аквариум 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(15, 259);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(443, 43);
            this.listBox3.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 320);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Aquarium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox l2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.TextBox l1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox wvol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox water;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox listBox3;
    }
}

