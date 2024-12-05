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
        Database db = new Database();

        public Skills()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            updateDataGridView();
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].Width = 250;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            showEditing();
            disableButtons();
            clearFields();
            currentButton = "Add";
            label4.Text = "Добавление уровня";

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentButton = "Edit";
            label4.Text = "Редактирование уровня";

            showEditing();
            disableButtons();

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            name.Text = selectedRow.Cells[1].Value.ToString();
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

        private void clearFields()
        {
            name.Text = "";
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
        }

        private void hideEditing()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
        }

        private void updateDataGridView()
        {
            string query = "SELECT * FROM Skill";
            DataTable dt = db.executeQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void AddData()
        {
            string Name = name.Text;
            string query = "INSERT INTO Skill (Название) VALUES (@Name)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@Name", Name }
                };

            db.editData(query, parameters);
            updateDataGridView();
        }

        private void EditData()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            selectedRow.Cells[1].Value = name.Text.ToString();

            string Name = name.Text;
            int ID = int.Parse(selectedRow.Cells[0].Value.ToString());

            string query = "UPDATE Skill SET Название = @Name WHERE ID_Навык = @ID";

            var parameters = new Dictionary<string, object>
                {
                    { "@Name",  Name},
                    { "@ID", ID}
                };

            db.editData(query, parameters);
            updateDataGridView();
        }

        private void DeleteData()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            int ID = int.Parse(selectedRow.Cells[0].Value.ToString());

            string query = "DELETE FROM Skill WHERE ID_Навык = @ID";
            var parameters = new Dictionary<string, object>
            {
                { "@ID", ID }
            };

            db.editData(query, parameters);
            updateDataGridView();
        }
    }
}
