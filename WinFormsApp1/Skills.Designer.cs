﻿namespace WinFormsApp1
{
    partial class Skills
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 19);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 17;
            label3.Text = "Навыки";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(23, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 380);
            groupBox1.TabIndex = 16;
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
            CancelButton.Location = new Point(166, 140);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(85, 140);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "OK";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // name
            // 
            name.Location = new Point(16, 58);
            name.Name = "name";
            name.Size = new Size(211, 23);
            name.TabIndex = 5;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(299, 200);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 23);
            DeleteButton.TabIndex = 15;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(299, 102);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 23);
            EditButton.TabIndex = 14;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(299, 47);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 23);
            AddButton.TabIndex = 13;
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
            dataGridView1.Location = new Point(23, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(250, 380);
            dataGridView1.TabIndex = 12;
            // 
            // Skills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "Skills";
            Text = "Навыки";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}