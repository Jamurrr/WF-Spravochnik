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
            label4 = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            label1 = new Label();
            name = new TextBox();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(20, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 323);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
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
            // CancelButton
            // 
            CancelButton.Location = new Point(147, 165);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(32, 165);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "OK";
            SaveButton.UseVisualStyleBackColor = true;
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
            DeleteButton.Location = new Point(741, 251);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 42);
            DeleteButton.TabIndex = 21;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(741, 121);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 42);
            EditButton.TabIndex = 20;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(741, 51);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 42);
            AddButton.TabIndex = 19;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
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
            dataGridView1.Size = new Size(694, 323);
            dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 383);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 24;
            label2.Text = "Команда";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 425);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 25;
            label5.Text = "Ответственный:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 425);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 26;
            label6.Text = "label6";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(20, 467);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(450, 150);
            dataGridView2.TabIndex = 27;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 658);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "Projects";
            Text = "Проекты";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
    }
}