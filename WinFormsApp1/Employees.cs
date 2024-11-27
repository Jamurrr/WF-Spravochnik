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
    public partial class Employees : Form
    {
        private string currentButton = "";
        public Employees()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            //Сотрудники
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Фамилия";
            column1.HeaderText = "Фамилия";
            column1.DataPropertyName = "Фамилия";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Имя";
            column2.HeaderText = "Имя";
            column2.DataPropertyName = "Имя";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Отчество";
            column3.HeaderText = "Отчество";
            column3.DataPropertyName = "Отчество";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "Дата рождения";
            column4.HeaderText = "Дата рождения";
            column4.DataPropertyName = "Дата рождения";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "Серия паспорта";
            column5.HeaderText = "Серия паспорта";
            column5.DataPropertyName = "Серия паспорта";

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "Номер паспорта";
            column6.HeaderText = "Номер паспорта";
            column6.DataPropertyName = "Номер паспорта";

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.Name = "Кем выдан";
            column7.HeaderText = "Кем выдан";
            column7.DataPropertyName = "Кем выдан";

            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.Name = "Когда выдан";
            column8.HeaderText = "Когда выдан";
            column8.DataPropertyName = "Когда выдан";

            DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
            column7.Name = "Адрес регистрации";
            column7.HeaderText = "Адрес регистрации";
            column7.DataPropertyName = "Адрес регистрации";

            DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn();
            column7.Name = "Адрес фактического проживания";
            column7.HeaderText = "Адрес фактического проживания";
            column7.DataPropertyName = "Адрес фактического проживания";

            DataGridViewTextBoxColumn column11 = new DataGridViewTextBoxColumn();
            column11.Name = "Email";
            column11.HeaderText = "Email";
            column11.DataPropertyName = "Email";

            DataGridViewTextBoxColumn column12 = new DataGridViewTextBoxColumn();
            column12.Name = "Телефон";
            column12.HeaderText = "Телефон";
            column12.DataPropertyName = "Телефон";

            DataGridViewTextBoxColumn column13 = new DataGridViewTextBoxColumn();
            column13.Name = "Telegram";
            column13.HeaderText = "Telegram";
            column13.DataPropertyName = "Telegram";

            DataGridViewTextBoxColumn column14 = new DataGridViewTextBoxColumn();
            column14.Name = "Должность";
            column14.HeaderText = "Должность";
            column14.DataPropertyName = "Должность";

            DataGridViewTextBoxColumn column15 = new DataGridViewTextBoxColumn();
            column15.Name = "Уровень специалиста";
            column15.HeaderText = "Уровень специалиста";
            column15.DataPropertyName = "Уровень специалиста";

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);
            dataGridView1.Columns.Add(column7);
            dataGridView1.Columns.Add(column8);
            dataGridView1.Columns.Add(column9);
            dataGridView1.Columns.Add(column10);
            dataGridView1.Columns.Add(column11);
            dataGridView1.Columns.Add(column12);
            dataGridView1.Columns.Add(column13);
            dataGridView1.Columns.Add(column14);
            dataGridView1.Columns.Add(column15);

            dataGridView1.Rows.Add("Фаррахрв", "Айрат", "Нуруллаевич", "7 ноября 2003", "1221", "111000", "Кем-то выдан", "1 января 2010", "Тюмень", "Нижневартовск", "a@gmail.com", "+79192324344", "@lox228", "Бомжара", "Высший");

            //Навыки
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn skillColumn1 = new DataGridViewTextBoxColumn();
            skillColumn1.Name = "Навык";
            skillColumn1.HeaderText = "Навык";
            skillColumn1.DataPropertyName = "Навык";

            DataGridViewTextBoxColumn skillColumn2 = new DataGridViewTextBoxColumn();
            skillColumn2.Name = "Уровень освоения";
            skillColumn2.HeaderText = "Уровень освоения";
            skillColumn2.DataPropertyName = "Уровень освоения";

            dataGridView2.Columns.Add(skillColumn1);
            dataGridView2.Columns.Add(skillColumn2);

            //Редактирование навыков
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn skillEditColumn1 = new DataGridViewTextBoxColumn();
            skillEditColumn1.Name = "Навык";
            skillEditColumn1.HeaderText = "Навык";
            skillEditColumn1.DataPropertyName = "Навык";

            DataGridViewTextBoxColumn skillEditColumn2 = new DataGridViewTextBoxColumn();
            skillEditColumn2.Name = "Уровень освоения";
            skillEditColumn2.HeaderText = "Уровень освоения";
            skillEditColumn2.DataPropertyName = "Уровень освоения";

            dataGridView3.Columns.Add(skillEditColumn1);
            dataGridView3.Columns.Add(skillEditColumn2);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            currentButton = "Add";

            showEditing();
            disableButtons();
            clearFields();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentButton = "Edit";

            showEditing();
            disableButtons();

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            lastName.Text = selectedRow.Cells[0].Value.ToString();
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
                string LastName = lastName.Text;
                dataGridView1.Rows.Add(LastName);
            }

            if (currentButton == "Edit")
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[0].Value = lastName.Text;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            hideEditing();
            enableButtons();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            lastName.Text = "";
            firstName.Text = "";
            surName.Text = "";
            dateBirth.Text = "";
            serial.Text = "";
            numberID.Text = "";
            kemVidan.Text = "";
            dateVidan.Text = "";
            adresReg.Text = "";
            adresFact.Text = "";
            email.Text = "";
            telegram.Text = "";
            telephone.Text = "";
            job.Text = "";
            levelJob.Text = "";
            checkBox1.Checked = false;
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
