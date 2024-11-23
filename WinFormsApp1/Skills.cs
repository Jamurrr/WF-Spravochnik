using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Skills : Form
    {
        string currentButton = "";

        public Skills()
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

            column1.Width = 250;

            dataGridView1.Rows.Add("Аналитик", "50000.00");
            dataGridView1.Rows.Add("FrontEnd developer", "65000.00");
            dataGridView1.Rows.Add("BackEnd developer", "70000.00");
            string connectionString = "Data Source=SERVER_NAME;Initial Catalog=DATABASE_NAME;Integrated Security=True;";
            // Или если требуется авторизация:
            // string connectionString = "Data Source=SERVER_NAME;Initial Catalog=DATABASE_NAME;User ID=USERNAME;Password=PASSWORD;";

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
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentButton = "Edit";
            label4.Text = "Редактирование уровня";

            dataGridView1.Visible = false;
            groupBox1.Visible = true;

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            name.Text = selectedRow.Cells[0].Value.ToString();
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

                dataGridView1.Rows.Add(Name);
            }

            if (currentButton == "Edit")
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedRow.Cells[0].Value = name.Text;
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
