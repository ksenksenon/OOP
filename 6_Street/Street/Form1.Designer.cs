namespace Street
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
            this.label1 = new System.Windows.Forms.Label();
            this.str_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.h_count = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.c_fl = new System.Windows.Forms.NumericUpDown();
            this.c_entr = new System.Windows.Forms.NumericUpDown();
            this.c_flat = new System.Windows.Forms.NumericUpDown();
            this.finf = new System.Windows.Forms.NumericUpDown();
            this.AddStreet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Streetss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.House = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.h_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_fl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_entr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_flat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название улицы:";
            // 
            // str_name
            // 
            this.str_name.Location = new System.Drawing.Point(15, 34);
            this.str_name.Name = "str_name";
            this.str_name.Size = new System.Drawing.Size(152, 20);
            this.str_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество домов:";
            // 
            // h_count
            // 
            this.h_count.Location = new System.Drawing.Point(15, 77);
            this.h_count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.h_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.h_count.Name = "h_count";
            this.h_count.Size = new System.Drawing.Size(120, 20);
            this.h_count.TabIndex = 4;
            this.h_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер дома:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество этажей:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Количество подъездов:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество квартир в подъезде:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Количество квартир на этаже:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(15, 195);
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 20);
            this.num.TabIndex = 11;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // c_fl
            // 
            this.c_fl.Location = new System.Drawing.Point(15, 248);
            this.c_fl.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.c_fl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.c_fl.Name = "c_fl";
            this.c_fl.Size = new System.Drawing.Size(120, 20);
            this.c_fl.TabIndex = 12;
            this.c_fl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // c_entr
            // 
            this.c_entr.Location = new System.Drawing.Point(15, 302);
            this.c_entr.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.c_entr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.c_entr.Name = "c_entr";
            this.c_entr.Size = new System.Drawing.Size(120, 20);
            this.c_entr.TabIndex = 13;
            this.c_entr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // c_flat
            // 
            this.c_flat.Location = new System.Drawing.Point(15, 350);
            this.c_flat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.c_flat.Name = "c_flat";
            this.c_flat.Size = new System.Drawing.Size(120, 20);
            this.c_flat.TabIndex = 14;
            this.c_flat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finf
            // 
            this.finf.Location = new System.Drawing.Point(15, 406);
            this.finf.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.finf.Name = "finf";
            this.finf.Size = new System.Drawing.Size(120, 20);
            this.finf.TabIndex = 15;
            this.finf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddStreet
            // 
            this.AddStreet.Location = new System.Drawing.Point(15, 117);
            this.AddStreet.Name = "AddStreet";
            this.AddStreet.Size = new System.Drawing.Size(120, 42);
            this.AddStreet.TabIndex = 17;
            this.AddStreet.Text = "Добавить улицу";
            this.AddStreet.UseVisualStyleBackColor = true;
            this.AddStreet.Click += new System.EventHandler(this.AddStreet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Streetss,
            this.House});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(192, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(195, 407);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Streetss
            // 
            this.Streetss.HeaderText = "Название улицы";
            this.Streetss.Name = "Streetss";
            this.Streetss.ReadOnly = true;
            // 
            // House
            // 
            this.House.HeaderText = "Количество домов";
            this.House.Name = "House";
            this.House.ReadOnly = true;
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(289, 440);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(98, 42);
            this.SaveFile.TabIndex = 19;
            this.SaveFile.Text = "Сохранить в файл";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить дом";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Осталось добавить:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "label9";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "Нарисовать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(575, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(749, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(924, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(1093, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(401, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(575, 269);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 150);
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(749, 269);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(150, 150);
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(924, 269);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(150, 150);
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(1093, 269);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(150, 150);
            this.pictureBox10.TabIndex = 29;
            this.pictureBox10.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 494);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddStreet);
            this.Controls.Add(this.finf);
            this.Controls.Add(this.c_flat);
            this.Controls.Add(this.c_entr);
            this.Controls.Add(this.c_fl);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.h_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.str_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Street";
            ((System.ComponentModel.ISupportInitialize)(this.h_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_fl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_entr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_flat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox str_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown h_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.NumericUpDown c_fl;
        private System.Windows.Forms.NumericUpDown c_entr;
        private System.Windows.Forms.NumericUpDown c_flat;
        private System.Windows.Forms.NumericUpDown finf;
        private System.Windows.Forms.Button AddStreet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Streetss;
        private System.Windows.Forms.DataGridViewTextBoxColumn House;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

