namespace WinFormsApp1
{
    partial class Jobs
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
            zp = new NumericUpDown();
            CancelButton = new Button();
            SaveButton = new Button();
            label2 = new Label();
            label1 = new Label();
            name = new TextBox();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 20);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 11;
            label3.Text = "Должности";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(zp);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(20, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 380);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // zp
            // 
            zp.DecimalPlaces = 2;
            zp.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            zp.Location = new Point(50, 188);
            zp.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            zp.Name = "zp";
            zp.Size = new Size(150, 23);
            zp.TabIndex = 11;
            zp.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(139, 270);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(39, 270);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "OK";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 170);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 8;
            label2.Text = "Заработная плата";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 87);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // name
            // 
            name.Location = new Point(50, 105);
            name.Name = "name";
            name.Size = new Size(150, 23);
            name.TabIndex = 5;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(299, 248);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 42);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(299, 118);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 42);
            EditButton.TabIndex = 8;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(299, 48);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 42);
            AddButton.TabIndex = 7;
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
            dataGridView1.Location = new Point(20, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(250, 380);
            dataGridView1.TabIndex = 6;
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
            // Jobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "Jobs";
            Text = "Должности";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private NumericUpDown zp;
        private Button CancelButton;
        private Button SaveButton;
        private Label label2;
        private Label label1;
        private TextBox name;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private DataGridView dataGridView1;
        private Label label4;
    }
}