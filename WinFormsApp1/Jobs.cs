using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Jobs : Form
    {
        string currentButton = "";
        public Jobs()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // Создание новой колонки
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Name";
            column1.HeaderText = "Название";
            column1.DataPropertyName = "name";
            dataGridView1.Columns.Add(column1);

            // Создание другой колонки
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Zp";
            column2.HeaderText = "Базовая зарплата";
            column2.DataPropertyName = "zp";
            dataGridView1.Columns.Add(column2);

            column1.Width = 125;
            column2.Width = 125;


            dataGridView1.Rows.Add("Аналитик", "50000.00");
            dataGridView1.Rows.Add("FrontEnd developer", "65000.00");
            dataGridView1.Rows.Add("BackEnd developer", "70000.00");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;

            AddButton.Enabled = false;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            currentButton = "Add";

            label4.Text = "Добавление уровня";

            name.Text = "";
            zp.Value = decimal.Parse("20000");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentButton = "Edit";
            label4.Text = "Редактирование уровня";

            dataGridView1.Visible = false;
            groupBox1.Visible = true;

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            name.Text = selectedRow.Cells[0].Value.ToString();
            zp.Value = decimal.Parse(selectedRow.Cells[1].Value.ToString());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;

            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;

            if (currentButton == "Add")
            {
                string Name = name.Text;
                decimal Zp = zp.Value;

                dataGridView1.Rows.Add(Name, Zp);
            }

            if (currentButton == "Edit")
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedRow.Cells[0].Value = name.Text;
                selectedRow.Cells[1].Value = zp.Value;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;

            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
    }
}
