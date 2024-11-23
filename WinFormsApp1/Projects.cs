using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace WinFormsApp1
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Name";
            column1.HeaderText = "Название проекта";
            column1.DataPropertyName = "name";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Описание";
            column2.DataPropertyName = "description";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Дата создания";
            column3.DataPropertyName = "date_created";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Дата начала (план)";
            column4.DataPropertyName = "date_start_plan";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.HeaderText = "Дата начала (факт)";
            column5.DataPropertyName = "date_start_fact";

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.HeaderText = "Дата завершения (план)";
            column6.DataPropertyName = "date_end_plan";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.HeaderText = "Дата завершения (факт)";
            column7.DataPropertyName = "date_end_fact";

            column1.Width = 125;

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);
            dataGridView1.Columns.Add(column7);


            dataGridView1.Rows.Add("Аналитик", "50000.00", "32131", "312321", "12121", "fasfnjaf", "fsnuf");
            dataGridView1.Rows.Add("FrontEnd developer", "65000.00");
            dataGridView1.Rows.Add("BackEnd developer", "70000.00");


            //Команда проекта
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn teamColumn1 = new DataGridViewTextBoxColumn();
            teamColumn1.Name = "lastName";
            teamColumn1.HeaderText = "Фамилия";
            teamColumn1.DataPropertyName = "lastName";

            DataGridViewTextBoxColumn teamColumn2 = new DataGridViewTextBoxColumn();
            teamColumn2.Name = "firstName";
            teamColumn2.HeaderText = "Имя";
            teamColumn2.DataPropertyName = "firstName";

            DataGridViewTextBoxColumn teamColumn3 = new DataGridViewTextBoxColumn();
            teamColumn3.Name = "otche";
            teamColumn3.HeaderText = "Отчество";
            teamColumn3.DataPropertyName = "otche";

            teamColumn1.Width = 150;
            teamColumn2.Width = 150;
            teamColumn3.Width = 150;

            dataGridView2.Columns.Add(teamColumn1);
            dataGridView2.Columns.Add(teamColumn2);
            dataGridView2.Columns.Add(teamColumn3);
        }


    }
}
