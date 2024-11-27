namespace WinFormsApp1
{
    partial class Employees
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
            groupBox2 = new GroupBox();
            minusButton = new Button();
            plusButton = new Button();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            CancelButton = new Button();
            SaveButton = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            levelJob = new ComboBox();
            label20 = new Label();
            button3 = new Button();
            job = new ComboBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            telegram = new TextBox();
            label16 = new Label();
            telephone = new TextBox();
            label15 = new Label();
            email = new TextBox();
            label14 = new Label();
            checkBox1 = new CheckBox();
            label13 = new Label();
            adresFact = new TextBox();
            label11 = new Label();
            adresReg = new TextBox();
            label10 = new Label();
            kemVidan = new TextBox();
            label9 = new Label();
            numberID = new TextBox();
            label7 = new Label();
            serial = new TextBox();
            label6 = new Label();
            surName = new TextBox();
            label5 = new Label();
            firstName = new TextBox();
            label12 = new Label();
            dateBirth = new DateTimePicker();
            label8 = new Label();
            dateVidan = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            lastName = new TextBox();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(minusButton);
            groupBox2.Controls.Add(plusButton);
            groupBox2.Controls.Add(dataGridView3);
            groupBox2.Location = new Point(9, 562);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(694, 123);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            // 
            // minusButton
            // 
            minusButton.FlatStyle = FlatStyle.System;
            minusButton.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            minusButton.Location = new Point(631, 72);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(35, 35);
            minusButton.TabIndex = 30;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // plusButton
            // 
            plusButton.FlatStyle = FlatStyle.System;
            plusButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            plusButton.Location = new Point(631, 22);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(35, 35);
            plusButton.TabIndex = 29;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = SystemColors.Control;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 10);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(608, 113);
            dataGridView3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 562);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(694, 123);
            dataGridView2.TabIndex = 40;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(730, 703);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 30;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(627, 703);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 29;
            SaveButton.Text = "OK";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 544);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 37;
            label2.Text = "Навыки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 36;
            label3.Text = "Сотрудники";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(levelJob);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(job);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(telegram);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(telephone);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(adresFact);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(adresReg);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(kemVidan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numberID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(serial);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(surName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(firstName);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateBirth);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateVidan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lastName);
            groupBox1.Location = new Point(9, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 507);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(425, 474);
            button4.Name = "button4";
            button4.Size = new Size(24, 23);
            button4.TabIndex = 54;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            // 
            // levelJob
            // 
            levelJob.FormattingEnabled = true;
            levelJob.Location = new Point(258, 474);
            levelJob.Name = "levelJob";
            levelJob.Size = new Size(161, 23);
            levelJob.TabIndex = 53;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(258, 456);
            label20.Name = "label20";
            label20.Size = new Size(126, 15);
            label20.TabIndex = 52;
            label20.Text = "Уровень специалиста";
            // 
            // button3
            // 
            button3.Location = new Point(187, 473);
            button3.Name = "button3";
            button3.Size = new Size(24, 23);
            button3.TabIndex = 51;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            // 
            // job
            // 
            job.FormattingEnabled = true;
            job.Location = new Point(26, 473);
            job.Name = "job";
            job.Size = new Size(155, 23);
            job.TabIndex = 50;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(26, 455);
            label19.Name = "label19";
            label19.Size = new Size(69, 15);
            label19.TabIndex = 49;
            label19.Text = "Должность";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 429);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 47;
            label18.Text = "Должность";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(490, 365);
            label17.Name = "label17";
            label17.Size = new Size(55, 15);
            label17.TabIndex = 46;
            label17.Text = "Telegram";
            // 
            // telegram
            // 
            telegram.Location = new Point(490, 383);
            telegram.Name = "telegram";
            telegram.Size = new Size(150, 23);
            telegram.TabIndex = 45;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(258, 365);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 44;
            label16.Text = "Телефон";
            // 
            // telephone
            // 
            telephone.Location = new Point(258, 383);
            telephone.Name = "telephone";
            telephone.Size = new Size(161, 23);
            telephone.TabIndex = 43;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 365);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 42;
            label15.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(26, 383);
            email.Name = "email";
            email.Size = new Size(155, 23);
            email.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 343);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 40;
            label14.Text = "Контакты";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(294, 19);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "Совпадает с адресом фактического проживания";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 280);
            label13.Name = "label13";
            label13.Size = new Size(192, 15);
            label13.TabIndex = 38;
            label13.Text = "Адрес фактического проживания";
            // 
            // adresFact
            // 
            adresFact.Location = new Point(26, 298);
            adresFact.Name = "adresFact";
            adresFact.Size = new Size(273, 23);
            adresFact.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 206);
            label11.Name = "label11";
            label11.Size = new Size(113, 15);
            label11.TabIndex = 36;
            label11.Text = "Адрес регистрации";
            // 
            // adresReg
            // 
            adresReg.Location = new Point(26, 224);
            adresReg.Name = "adresReg";
            adresReg.Size = new Size(273, 23);
            adresReg.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(258, 150);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 34;
            label10.Text = "Кем выдан";
            // 
            // kemVidan
            // 
            kemVidan.Location = new Point(258, 168);
            kemVidan.Name = "kemVidan";
            kemVidan.Size = new Size(212, 23);
            kemVidan.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(139, 150);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 32;
            label9.Text = "Номер паспорта";
            // 
            // numberID
            // 
            numberID.Location = new Point(139, 168);
            numberID.Name = "numberID";
            numberID.Size = new Size(99, 23);
            numberID.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 150);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 30;
            label7.Text = "Серия паспорта";
            // 
            // serial
            // 
            serial.Location = new Point(26, 168);
            serial.Name = "serial";
            serial.Size = new Size(95, 23);
            serial.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 38);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 28;
            label6.Text = "Отчество";
            // 
            // surName
            // 
            surName.Location = new Point(490, 56);
            surName.Name = "surName";
            surName.Size = new Size(150, 23);
            surName.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 38);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 26;
            label5.Text = "Имя";
            // 
            // firstName
            // 
            firstName.Location = new Point(258, 56);
            firstName.Name = "firstName";
            firstName.Size = new Size(161, 23);
            firstName.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 94);
            label12.Name = "label12";
            label12.Size = new Size(90, 15);
            label12.TabIndex = 24;
            label12.Text = "Дата рождения";
            // 
            // dateBirth
            // 
            dateBirth.CustomFormat = "d MMMM yyyy";
            dateBirth.Format = DateTimePickerFormat.Custom;
            dateBirth.Location = new Point(26, 112);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(155, 23);
            dateBirth.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(490, 150);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 16;
            label8.Text = "Когда выдан";
            // 
            // dateVidan
            // 
            dateVidan.CustomFormat = "d MMMM yyyy";
            dateVidan.Format = DateTimePickerFormat.Custom;
            dateVidan.Location = new Point(490, 168);
            dateVidan.Name = "dateVidan";
            dateVidan.Size = new Size(150, 23);
            dateVidan.TabIndex = 15;
            dateVidan.Value = new DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 10);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 12;
            label4.Text = "Персональные данные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Фамилия";
            // 
            // lastName
            // 
            lastName.Location = new Point(26, 56);
            lastName.Name = "lastName";
            lastName.Size = new Size(155, 23);
            lastName.TabIndex = 5;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(730, 245);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 42);
            DeleteButton.TabIndex = 34;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(730, 115);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 42);
            EditButton.TabIndex = 33;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(730, 45);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 42);
            AddButton.TabIndex = 32;
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
            dataGridView1.Location = new Point(9, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(694, 507);
            dataGridView1.TabIndex = 31;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 759);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView2);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Employees";
            Text = "Employees";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button minusButton;
        private Button plusButton;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private Button CancelButton;
        private Button SaveButton;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label12;
        private DateTimePicker dateBirth;
        private Label label8;
        private DateTimePicker dateVidan;
        private Label label4;
        private Label label1;
        private TextBox lastName;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox surName;
        private Label label5;
        private TextBox firstName;
        private Label label10;
        private TextBox kemVidan;
        private Label label9;
        private TextBox numberID;
        private Label label7;
        private TextBox serial;
        private CheckBox checkBox1;
        private Label label13;
        private TextBox adresFact;
        private Label label11;
        private TextBox adresReg;
        private Label label16;
        private TextBox telephone;
        private Label label15;
        private TextBox email;
        private Label label14;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox telegram;
        private Button button4;
        private ComboBox levelJob;
        private Label label20;
        private Button button3;
        private ComboBox job;
    }
}