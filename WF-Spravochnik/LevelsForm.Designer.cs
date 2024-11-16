namespace WinFormsApp1
{
    partial class LevelsForm
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
            dataGridView1 = new DataGridView();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            groupBox1 = new GroupBox();
            CancelButton = new Button();
            SaveButton = new Button();
            label2 = new Label();
            label1 = new Label();
            coef = new TextBox();
            name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(250, 380);
            dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(300, 44);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 42);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(300, 114);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 42);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(300, 244);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 42);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(coef);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(29, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 380);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(144, 270);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(50, 270);
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
            label2.Location = new Point(50, 170);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 8;
            label2.Text = "Коэффициент";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 87);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 7;
            label1.Text = "Наименование";
            // 
            // coef
            // 
            coef.Location = new Point(50, 188);
            coef.Name = "coef";
            coef.Size = new Size(150, 23);
            coef.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(50, 105);
            name.Name = "name";
            name.Size = new Size(150, 23);
            name.TabIndex = 5;
            // 
            // LevelsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 461);
            Controls.Add(groupBox1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "LevelsForm";
            Text = "Уровни";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
        private GroupBox groupBox1;
        private Button CancelButton;
        private Button SaveButton;
        private Label label2;
        private Label label1;
        private TextBox coef;
        private TextBox name;
    }
}