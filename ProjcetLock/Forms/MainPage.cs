using System;
using System.Windows.Forms;

namespace ProjePilot.Forms
{
    public partial class MainPage : Form
    {
        private int userId;

        public MainPage(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private void projects_Click(object sender, EventArgs e)
        {
            ProjectPage projectPage = new ProjectPage(userId);
            this.Hide();
            projectPage.ShowDialog();
        }

        private void tasks_Click(object sender, EventArgs e)
        {
            TaskPage teskPage = new TaskPage(userId);
            this.Hide();
            teskPage.ShowDialog();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(userId);
            this.Hide();
            employeePage.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }
    }
}
