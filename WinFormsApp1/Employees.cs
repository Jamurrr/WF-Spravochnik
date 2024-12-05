using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Database db = new Database();
        public Employees()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            SaveButton.Visible = false;
            CancelButton.Visible = false;
            updateDataGridView();

            //Сотрудники
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;



            //Навыки
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Columns[0].Visible = false;




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
            DeleteData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            hideEditing();
            enableButtons();

            if (currentButton == "Add")
            {
                AddData();
            }

            if (currentButton == "Edit")
            {
                EditData();
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
            SaveButton.Visible = true;
            CancelButton.Visible = true;
        }

        private void hideEditing()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
            dataGridView2.Visible = true;
            groupBox2.Visible = false;
            SaveButton.Visible = false;
            CancelButton.Visible = false;
        }

        private void updateDataGridView()
        {
            string query = "SELECT * FROM Employee";
            DataTable dt = db.executeQuery(query);
            dataGridView1.DataSource = dt;

            string query2 = "SELECT * FROM Employee_Skill";
            DataTable dt2 = db.executeQuery(query2);
            dataGridView2.DataSource = dt2;
        }

        private void AddData()
        {
            

            string LastName = lastName.Text;
            string FirstName = firstName.Text;
            string SurName = surName.Text;
            DateTime DateBirth = dateBirth.Value;
            int Sertial = int.Parse(serial.Text);
            int NumberID = int.Parse(numberID.Text);
            string KemVidan = kemVidan.Text;
            DateTime DateVidan = dateVidan.Value;
            string AdresReg = adresReg.Text;
            string AdresFact = adresFact.Text;
            string Email = email.Text;
            string Telephone = telephone.Text;
            string Telegram = telephone.Text;
            string Job = job.Text;
            string LevelJob = levelJob.Text;




            string query = "INSERT INTO Employee (Фамилия, Имя, Отчество, Дата_Рождения, Серия_Паспорта, Номер_Паспорта, Кем_ выдан, Когда_выдан, Адрес_регистрации, Адрес_фактического_проживания, Телефон, Email, Telegram, ID_Уровень, ID_Должность)" +
                " VALUES (@LastName, @FirstName, @SurName, @DateBirth, @Sertial, @NumberID, @KemVidan, @DateVidan, @AdresReg, @AdresFact, @Telephone, @Email, @Telegram, @LevelJob, @Job)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@LastName", LastName },
                    {"@FirstName", FirstName },
                    {"@SurName", SurName },
                    {"@DateBirth", DateBirth },
                    {"@Sertial", Sertial },
                    {"@NumberID", NumberID },
                    {"@KemVidan", KemVidan },
                    {"@DateVidan", DateVidan },
                    {"@AdresReg", AdresReg },
                    {"@AdresFact", AdresFact },
                    {"@Telephone", Telephone },
                    {"@Email", Email },
                    {"@Telegram", Telegram },
                    {"@Job", Job },
                    {"@LevelJob", LevelJob }
   
                };

            db.editData(query, parameters);
            updateDataGridView();
        }

        private void EditData()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string LastName = lastName.Text;
            string FirstName = firstName.Text;
            string SurName = surName.Text;
            DateTime DateBirth = dateBirth.Value;
            int Sertial = int.Parse(serial.Text);
            int NumberID = int.Parse(numberID.Text);
            string KemVidan = kemVidan.Text;
            DateTime DateVidan = dateVidan.Value;
            string AdresReg = adresReg.Text;
            string AdresFact = adresFact.Text;
            string Email = email.Text;
            string Telephone = telephone.Text;
            string Telegram = telephone.Text;
            string Job = job.Text;
            string LevelJob = levelJob.Text;

            int ID = int.Parse(selectedRow.Cells[0].Value.ToString());

            string query = "UPDATE Employee SET Фамилия = @LastName, Имя = @FirstName, Отчество = @SurName, Дата_Рождения = @DateBirth, Серия_Паспорта = @Sertial, Номер_Паспорта = @NumberID, Кем_выдан = @KemVidan, Когда_выдан = @DateVidan, Адрес_регистрации = @AdresReg, Адрес_фактического_проживания = @AdresFact, Телефон = @Telephone, Email = @Email, Telegram = @Telegram, ID_Уровень = @LevelJob, ID_Должность = @Job" +
                " WHERE ID_Сотрудник = @ID";

            var parameters = new Dictionary<string, object>
                {
                    {"@LastName", LastName },
                    {"@FirstName", FirstName },
                    {"@SurName", SurName },
                    {"@DateBirth", DateBirth },
                    {"@Sertial", Sertial },
                    {"@NumberID", NumberID },
                    {"@KemVidan", KemVidan },
                    {"@DateVidan", DateVidan },
                    {"@AdresReg", AdresReg },
                    {"@AdresFact", AdresFact },
                    {"@Telephone", Telephone },
                    {"@Email", Email },
                    {"@Telegram", Telegram },
                    {"@Job", Job },
                    {"@LevelJob", LevelJob }
                };

            db.editData(query, parameters);
            updateDataGridView();
        }

        private void DeleteData()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            int ID = int.Parse(selectedRow.Cells[0].Value.ToString());

            string query = "DELETE FROM Employee WHERE ID_Сотрудник = @ID";
            var parameters = new Dictionary<string, object>
            {
                { "@ID", ID }
            };

            db.editData(query, parameters);
            updateDataGridView();
        }
    }
}
