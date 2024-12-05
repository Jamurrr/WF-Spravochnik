namespace WinFormsApp1
{
    partial class Projects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            dateEndFact = new DateTimePicker();
            label11 = new Label();
            dateStartFact = new DateTimePicker();
            label10 = new Label();
            dateEndPlan = new DateTimePicker();
            label9 = new Label();
            dateStartPlan = new DateTimePicker();
            label8 = new Label();
            dateCreate = new DateTimePicker();
            label7 = new Label();
            description = new TextBox();
            label4 = new Label();
            label1 = new Label();
            name = new TextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView3 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 9);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 23;
            label3.Text = "Проекты";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateEndFact);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dateStartFact);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateEndPlan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateStartPlan);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateCreate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(description);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(20, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 348);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(264, 293);
            label12.Name = "label12";
            label12.Size = new Size(173, 15);
            label12.TabIndex = 24;
            label12.Text = "Фактическая дата завершения";
            // 
            // dateEndFact
            // 
            dateEndFact.CustomFormat = "d MMMM yyyy";
            dateEndFact.Format = DateTimePickerFormat.Custom;
            dateEndFact.Location = new Point(264, 311);
            dateEndFact.Name = "dateEndFact";
            dateEndFact.Size = new Size(155, 23);
            dateEndFact.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(264, 235);
            label11.Name = "label11";
            label11.Size = new Size(145, 15);
            label11.TabIndex = 22;
            label11.Text = "Фактическая дата начала";
            // 
            // dateStartFact
            // 
            dateStartFact.CustomFormat = "d MMMM yyyy";
            dateStartFact.Format = DateTimePickerFormat.Custom;
            dateStartFact.Location = new Point(264, 253);
            dateStartFact.Name = "dateStartFact";
            dateStartFact.Size = new Size(155, 23);
            dateStartFact.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 293);
            label10.Name = "label10";
            label10.Size = new Size(202, 15);
            label10.TabIndex = 20;
            label10.Text = "Запланированная дата завершения";
            // 
            // dateEndPlan
            // 
            dateEndPlan.CustomFormat = "d MMMM yyyy";
            dateEndPlan.Format = DateTimePickerFormat.Custom;
            dateEndPlan.Location = new Point(26, 311);
            dateEndPlan.Name = "dateEndPlan";
            dateEndPlan.Size = new Size(155, 23);
            dateEndPlan.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 235);
            label9.Name = "label9";
            label9.Size = new Size(174, 15);
            label9.TabIndex = 18;
            label9.Text = "Запланированная дата начала";
            // 
            // dateStartPlan
            // 
            dateStartPlan.CustomFormat = "d MMMM yyyy";
            dateStartPlan.Format = DateTimePickerFormat.Custom;
            dateStartPlan.Location = new Point(26, 253);
            dateStartPlan.Name = "dateStartPlan";
            dateStartPlan.Size = new Size(155, 23);
            dateStartPlan.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(381, 51);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 16;
            label8.Text = "Дата создания";
            // 
            // dateCreate
            // 
            dateCreate.CustomFormat = "d MMMM yyyy";
            dateCreate.Format = DateTimePickerFormat.Custom;
            dateCreate.Location = new Point(381, 69);
            dateCreate.Name = "dateCreate";
            dateCreate.Size = new Size(197, 23);
            dateCreate.TabIndex = 15;
            dateCreate.Value = new DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 108);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 14;
            label7.Text = "Описание";
            // 
            // description
            // 
            description.Location = new Point(26, 129);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(552, 85);
            description.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 10);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // name
            // 
            name.Location = new Point(26, 69);
            name.Name = "name";
            name.Size = new Size(296, 23);
            name.TabIndex = 5;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(639, 631);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(551, 631);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "OK";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(731, 183);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 23);
            DeleteButton.TabIndex = 21;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(731, 96);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 23);
            EditButton.TabIndex = 20;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(731, 37);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 23);
            AddButton.TabIndex = 19;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(694, 348);
            dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 404);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 24;
            label2.Text = "Команда проекта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 434);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 25;
            label5.Text = "Ответственный:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 434);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 26;
            label6.Text = "label6";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(20, 463);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(587, 150);
            dataGridView2.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView3);
            groupBox2.Location = new Point(20, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(693, 186);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            button2.Location = new Point(632, 63);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 30;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button1.Location = new Point(632, 22);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 29;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = SystemColors.Control;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 7);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(606, 179);
            dataGridView3.TabIndex = 0;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 678);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "Projects";
            Text = "Проекты";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private Button CancelButton;
        private Button SaveButton;
        private Label label1;
        private TextBox name;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private TextBox description;
        private DateTimePicker dateCreate;
        private Label label8;
        private Label label9;
        private DateTimePicker dateStartPlan;
        private Label label10;
        private DateTimePicker dateEndPlan;
        private Label label12;
        private DateTimePicker dateEndFact;
        private Label label11;
        private DateTimePicker dateStartFact;
        private GroupBox groupBox2;
        private DataGridView dataGridView3;
        private Button button2;
        private Button button1;
    }
}