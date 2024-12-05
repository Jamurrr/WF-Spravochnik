using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class LevelsForm : Form
    {
        string currentButton = "";
        Database db = new Database();
        public LevelsForm()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            updateDataGridView();
            dataGridView1.Columns[0].Visible = false;
            //column1.Width = 125;
            //column2.Width = 125;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            showEditing();
            disableButtons();
            clearFields();
            currentButton = "Add";
            label4.Text = "Добавление уровня";

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

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentButton = "Edit";
            label4.Text = "Редактирование уровня";

            showEditing();
            disableButtons();

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            name.Text = selectedRow.Cells[1].Value.ToString();
            coef.Value = decimal.Parse(selectedRow.Cells[2].Value.ToString());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void clearFields()
        {
            name.Text = "";
            coef.Text = "";
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
            string query = "SELECT * FROM Level";
            DataTable dt = db.executeQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void AddData()
        {
            string Name = name.Text;
            decimal Coef = coef.Value;
            string query = "INSERT INTO Level (Название, Коэффициент) VALUES (@Name, @Coef)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@Name", Name },
                    {"@Coef", Coef }
                };

            db.editData(query, parameters);
            updateDataGridView();
        }

        private void EditData()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            selectedRow.Cells[1].Value = name.Text.ToString();
            selectedRow.Cells[2].Value = coef.Value;

            string Name = name.Text;
            decimal Coef = coef.Value;
            int ID = int.Parse(selectedRow.Cells[0].Value.ToString());

            string query = "UPDATE Level SET Название = @Name, Коэффициент = @Coef WHERE ID_Уровень = @ID";

            var parameters = new Dictionary<string, object>
                {
                    { "@Name",  Name},
                    { "@Coef", Coef},
                    { "@ID", ID}
                };

            db.editData(query, parameters);
            updateDataGridView();
        }

        private void DeleteData()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            int ID = int.Parse(selectedRow.Cells[0].Value.ToString());

            string query = "DELETE FROM Level WHERE ID_Уровень = @ID";
            var parameters = new Dictionary<string, object>
            {
                { "@ID", ID }
            };

            db.editData(query, parameters);
            updateDataGridView();
        }

    }
}
