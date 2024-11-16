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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Справочники";
            listBox1.Items.Add("Сотрудники");
            listBox1.Items.Add("Должности");
            listBox1.Items.Add("Уровни");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Проверяем, что выбран элемент
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();

                if (selectedItem == "Уровни")
                {
                    LevelsForm newForm = new LevelsForm();
                    newForm.ShowDialog();
                }

            }
        }
    }
}
