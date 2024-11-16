namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            projectsToolStripMenuItem = new ToolStripMenuItem();
            jobsToolStripMenuItem = new ToolStripMenuItem();
            levelsToolStripMenuItem = new ToolStripMenuItem();
            skillsToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(369, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, projectsToolStripMenuItem, jobsToolStripMenuItem, levelsToolStripMenuItem, skillsToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(195, 22);
            employeesToolStripMenuItem.Text = "Сотрудники";
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
            // 
            // projectsToolStripMenuItem
            // 
            projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            projectsToolStripMenuItem.Size = new Size(195, 22);
            projectsToolStripMenuItem.Text = "Проекты";
            projectsToolStripMenuItem.Click += projectsToolStripMenuItem_Click;
            // 
            // jobsToolStripMenuItem
            // 
            jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            jobsToolStripMenuItem.Size = new Size(195, 22);
            jobsToolStripMenuItem.Text = "Должности";
            jobsToolStripMenuItem.Click += jobsToolStripMenuItem_Click;
            // 
            // levelsToolStripMenuItem
            // 
            levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            levelsToolStripMenuItem.Size = new Size(195, 22);
            levelsToolStripMenuItem.Text = "Уровни специалистов";
            levelsToolStripMenuItem.Click += levelsToolStripMenuItem_Click;
            // 
            // skillsToolStripMenuItem
            // 
            skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            skillsToolStripMenuItem.Size = new Size(195, 22);
            skillsToolStripMenuItem.Text = "Навыки";
            skillsToolStripMenuItem.Click += skillsToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 271);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Главная";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem jobsToolStripMenuItem;
        private ToolStripMenuItem levelsToolStripMenuItem;
        private ToolStripMenuItem skillsToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}
