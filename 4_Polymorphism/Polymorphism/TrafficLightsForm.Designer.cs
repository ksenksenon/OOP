namespace Polymorphism
{
    partial class TrafficLightsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawTrafficLight = new System.Windows.Forms.Button();
            this.changeStatus = new System.Windows.Forms.Button();
            this.kolNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TypeLights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kolButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(399, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 370);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // drawTrafficLight
            // 
            this.drawTrafficLight.Location = new System.Drawing.Point(399, 17);
            this.drawTrafficLight.Name = "drawTrafficLight";
            this.drawTrafficLight.Size = new System.Drawing.Size(114, 40);
            this.drawTrafficLight.TabIndex = 1;
            this.drawTrafficLight.Text = "Нарисовать";
            this.drawTrafficLight.UseVisualStyleBackColor = true;
            this.drawTrafficLight.Click += new System.EventHandler(this.drawTrafficLight_Click);
            // 
            // changeStatus
            // 
            this.changeStatus.Location = new System.Drawing.Point(537, 17);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(114, 40);
            this.changeStatus.TabIndex = 2;
            this.changeStatus.Text = "Смена состояния";
            this.changeStatus.UseVisualStyleBackColor = true;
            this.changeStatus.Click += new System.EventHandler(this.changeStatus_Click);
            // 
            // kolNumericUpDown
            // 
            this.kolNumericUpDown.Location = new System.Drawing.Point(178, 26);
            this.kolNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kolNumericUpDown.Name = "kolNumericUpDown";
            this.kolNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.kolNumericUpDown.TabIndex = 3;
            this.kolNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Пешеходный",
            "Автомобильный",
            "Со стрелкой"});
            this.typeComboBox.Location = new System.Drawing.Point(15, 370);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(114, 21);
            this.typeComboBox.TabIndex = 5;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(135, 370);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(229, 21);
            this.statusComboBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeLights,
            this.State});
            this.dataGridView1.Location = new System.Drawing.Point(15, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(349, 274);
            this.dataGridView1.TabIndex = 7;
            // 
            // TypeLights
            // 
            this.TypeLights.FillWeight = 24.36548F;
            this.TypeLights.HeaderText = "Тип светофора";
            this.TypeLights.Name = "TypeLights";
            this.TypeLights.ReadOnly = true;
            this.TypeLights.Width = 120;
            // 
            // State
            // 
            this.State.FillWeight = 175.6345F;
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 226;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 397);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 38);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить новый светофор";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(135, 397);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(229, 38);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить выбранный светофор";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Статус";
            // 
            // kolButton
            // 
            this.kolButton.Location = new System.Drawing.Point(289, 17);
            this.kolButton.Name = "kolButton";
            this.kolButton.Size = new System.Drawing.Size(75, 40);
            this.kolButton.TabIndex = 12;
            this.kolButton.Text = "Задать";
            this.kolButton.UseVisualStyleBackColor = true;
            this.kolButton.Click += new System.EventHandler(this.kolButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Размер массива светофоров:";
            // 
            // TrafficLightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kolButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.kolNumericUpDown);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.drawTrafficLight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TrafficLightsForm";
            this.Text = "Traffic Lights";
            this.Load += new System.EventHandler(this.TrafficLightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button drawTrafficLight;
        private System.Windows.Forms.Button changeStatus;
        private System.Windows.Forms.NumericUpDown kolNumericUpDown;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kolButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeLights;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}

