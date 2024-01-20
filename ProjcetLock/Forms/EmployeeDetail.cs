using MySql.Data.MySqlClient;
using ProjePilot.Forms;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProjcetLock.Forms
{
    public partial class EmployeeDetail : Form
    {
        private const string connectionString = "Server=localhost;Database=projectlock;Uid=root;Pwd='';";
        private int userId; 
        private int employeeId;
        private MySqlConnection connection = new MySqlConnection(connectionString);
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private string getDataQuery = "SELECT e.EmployeeId, e.EmployeeNumberOfTasksCompleted, e.EmployeeNumberOngoingTasks, t.TaskName, t.TaskBeginDate, t.ManDayValue, t.TaskEndDate, t.TaskState, p.ProjectName " +
                    "FROM projectlock.Task t " +
                    "LEFT JOIN projectlock.Employee e ON t.EmployeeId = e.EmployeeId " +
                    "LEFT JOIN projectlock.Project p ON p.TaskId = t.TaskId " +
                    "WHERE t.EmployeeId = @EmployeeId";
        string updateTaskQuery = "UPDATE Employee " +
                            "SET EmployeeNumberOfTasksCompleted = @EmployeeNumberOfTasksCompleted, EmployeeNumberOngoingTasks = @EmployeeNumberOngoingTasks " +
                            "WHERE EmployeeId = @EmployeeId";
        public EmployeeDetail(int userId, int employeeId)
        {
            InitializeComponent();
            this.userId = userId;
            this.employeeId = employeeId;
            
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(userId);
            this.Hide();
            employeePage.ShowDialog();
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            GetData();
        }
        void GetData()
        {
            try
            {
                dataTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Parametre kullanarak sorguyu oluştur
                    
                    command = new MySqlCommand(getDataQuery, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                employeeTaskList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex);
            }
        }

        private void updateTasks_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new MySqlCommand(updateTaskQuery, connection);
                    command.Parameters.AddWithValue("@EmployeeNumberOfTasksCompleted", (int)updateEmployeeNumberOfTasksCompleted.Value);
                    command.Parameters.AddWithValue("@EmployeeNumberOngoingTasks", (int)updateEmployeeNumberOngoingTasks.Value);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    command.ExecuteNonQuery();

                    GetData();
                    MessageBox.Show("Güncellendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen bir satır seçin." + ex, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
