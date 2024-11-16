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
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
        }
    }
}
