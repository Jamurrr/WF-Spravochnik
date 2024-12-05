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
        string currentButton = "";
        public Projects()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            //Проекты
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


            //Изменение команды проекта
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn editTeamColumn1 = new DataGridViewTextBoxColumn();
            editTeamColumn1.Name = "Отвественный";
            editTeamColumn1.HeaderText = "Ответственный";
            editTeamColumn1.DataPropertyName = "руководитель";

            DataGridViewTextBoxColumn editTeamColumn2 = new DataGridViewTextBoxColumn();
            editTeamColumn2.Name = "lastName";
            editTeamColumn2.HeaderText = "Фамилия";
            editTeamColumn2.DataPropertyName = "lastName";

            DataGridViewTextBoxColumn editTeamColumn3 = new DataGridViewTextBoxColumn();
            editTeamColumn3.Name = "firstName";
            editTeamColumn3.HeaderText = "Имя";
            editTeamColumn3.DataPropertyName = "firstName";

            DataGridViewTextBoxColumn editTeamColumn4 = new DataGridViewTextBoxColumn();
            editTeamColumn4.Name = "otche";
            editTeamColumn4.HeaderText = "Отчество";
            editTeamColumn4.DataPropertyName = "otche";

            dataGridView3.Columns.Add(editTeamColumn1);
            dataGridView3.Columns.Add(editTeamColumn2);
            dataGridView3.Columns.Add(editTeamColumn3);
            dataGridView3.Columns.Add(editTeamColumn4);


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            label4.Text = "Добавление проекта";
            currentButton = "Add";

            showEditing();
            disableButtons();
            clearFields();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentButton = "Edit";
            label4.Text = "Редактирование проекта";

            showEditing();
            disableButtons();

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
            hideEditing();
            enableButtons();

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
            hideEditing();
            enableButtons();
        }

        private void clearFields()
        {
            name.Text = "";
            description.Text = "";
            dateCreate.Value = DateTime.Now;
            dateStartPlan.Value = DateTime.Now;
            dateEndPlan.Value = DateTime.Now;
            dateStartFact.Value = DateTime.Now;
            dateEndFact.Value = DateTime.Now;
        }

        private void disableButtons()
        {
            AddButton.Enabled = false;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void enableButtons()
        {
            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void showEditing()
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            dataGridView2.Visible = false;
            groupBox2.Visible = true;

            if (currentButton == "Add")
            {
                dateStartFact.Visible = false;
                dateEndFact.Visible = false;
                label8.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
            }
            else
            {
                dateCreate.Visible = true;
                dateStartFact.Visible = true;
                dateEndFact.Visible = true;
                label8.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
            }
        }

        private void hideEditing()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
            dataGridView2.Visible = true;
            groupBox2.Visible = false;
        }
    }
}
