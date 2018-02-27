namespace MatrixData
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
            this.day = new System.Windows.Forms.NumericUpDown();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.m2 = new System.Windows.Forms.NumericUpDown();
            this.d2 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).BeginInit();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(166, 98);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(65, 20);
            this.day.TabIndex = 0;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(253, 98);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(65, 20);
            this.month.TabIndex = 1;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(340, 98);
            this.year.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(65, 20);
            this.year.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(26, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(307, 230);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "День:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Месяц:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Год:";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(24, 45);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(76, 20);
            this.n.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Размер матрицы:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Задать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Сравнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(515, 145);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(307, 230);
            this.dataGridView2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Размер матрицы:";
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(515, 46);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(76, 20);
            this.n2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Год:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Месяц:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "День:";
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(836, 98);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(65, 20);
            this.y2.TabIndex = 17;
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(749, 98);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(65, 20);
            this.m2.TabIndex = 16;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(662, 98);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(65, 20);
            this.d2.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 37);
            this.button4.TabIndex = 24;
            this.button4.Text = "Задать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(717, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 38);
            this.button5.TabIndex = 23;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(847, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 38);
            this.button6.TabIndex = 25;
            this.button6.Text = "Сравнить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(361, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 95);
            this.listBox1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Результат:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(844, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Результат:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(847, 280);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(107, 95);
            this.listBox2.TabIndex = 28;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 43);
            this.button7.TabIndex = 30;
            this.button7.Text = "Сравнение матриц";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(198, 393);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(197, 43);
            this.listBox3.TabIndex = 31;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(324, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 38);
            this.button8.TabIndex = 32;
            this.button8.Text = "Очистить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(420, 393);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 43);
            this.button9.TabIndex = 33;
            this.button9.Text = "Копировать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(594, 397);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 => 2";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(594, 420);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2 => 1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(820, 30);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 38);
            this.button10.TabIndex = 36;
            this.button10.Text = "Очистить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Способ добавления:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Дата:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(844, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Дата:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(847, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(512, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Способ добавления:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(515, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 462);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Name = "Form1";
            this.Text = "MatrixData";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.NumericUpDown m2;
        private System.Windows.Forms.NumericUpDown d2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

