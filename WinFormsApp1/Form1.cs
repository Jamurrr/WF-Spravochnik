namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees newForm = new Employees();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Show();
            newForm.ShowDialog();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects newForm = new Projects();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Show();
            newForm.ShowDialog();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jobs newForm = new Jobs();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Show();
            newForm.ShowDialog();
        }

        private void levelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelsForm newForm = new LevelsForm();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Show();
            newForm.ShowDialog();
        }

        private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Skills newForm = new Skills();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Show();
            newForm.ShowDialog();
        }
    }
}
