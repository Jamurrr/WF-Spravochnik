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
    public partial class LevelsForm : Form
    {
        string currentButton = "";
        public LevelsForm()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // Создание новой колонки
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Name";
            column1.HeaderText = "Наименование";
            column1.DataPropertyName = "name";
            dataGridView1.Columns.Add(column1);

            // Создание другой колонки
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Coef";
            column2.HeaderText = "Коэффициент";
            column2.DataPropertyName = "coef";
            dataGridView1.Columns.Add(column2);

            column1.Width = 125;
            column2.Width = 125;


            dataGridView1.Rows.Add("Junior", "1.0");
            dataGridView1.Rows.Add("Middle", "1.5");
            dataGridView1.Rows.Add("Senior", "2.0");

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
            coef.Value = decimal.Parse("1");
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
                decimal Coef = coef.Value;

                dataGridView1.Rows.Add(Name, Coef);
            }

            if (currentButton == "Edit")
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedRow.Cells[0].Value = name.Text;
                selectedRow.Cells[1].Value = coef.Value;
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

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                currentButton = "Edit";
                label4.Text = "Редактирование уровня";

                dataGridView1.Visible = false;
                groupBox1.Visible = true;

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                name.Text = selectedRow.Cells[0].Value.ToString();
                coef.Value = decimal.Parse(selectedRow.Cells[1].Value.ToString());


            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для редактирования.", "Редактирование");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Удаление строки");
            }

        }
    }
}
