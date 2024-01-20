using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjePilot.Forms
{
    public partial class TaskPage : Form
    {
        private const string ConnectionString = "Server=localhost;Database=projectlock;Uid=root;Pwd='';";
        private int userId;
        MySqlConnection connection = new MySqlConnection(ConnectionString);
        MySqlCommand command;
        MySqlDataReader dataReader;
        DataTable dataTable;
        private int selectedEmployeeId;
        string getDataQuery = "SELECT T.TaskId, T.TaskName, T.TaskBeginDate, T.ManDayValue, T.TaskEndDate, T.TaskState, E.EmployeeFirstName, U.UserName " +
                    "FROM projectlock.Task T " +
                    "JOIN projectlock.Users U ON T.UserId = U.UserId " +
                    "JOIN projectlock.Employee E ON T.EmployeeId = E.EmployeeId " +
                    "WHERE T.UserId = @userId";
        string fillComboBoxQuery = "SELECT * FROM employee WHERE UserId = @userId";
        string addTaskQuery = "INSERT INTO Task (TaskName, TaskBeginDate, ManDayValue, TaskEndDate, TaskState, EmployeeId, UserId) " +
                                 "VALUES (@TaskName, @TaskBeginDate, @ManDayValue, @TaskEndDate, @TaskState, @EmployeeId, @UserId)";
        string isValidEmployeeIdQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeId = @EmployeeId AND UserId = @UserId";
        string deleteTaskQuery = "DELETE FROM task WHERE TaskId = @TaskId";
        string updateTaskQuery = "UPDATE Task " +
                             "SET TaskEndDate = @TaskEndDate, ManDayValue = @ManDayValue, TaskState = @TaskState " +
                             "WHERE TaskId = @TaskId";

        public TaskPage(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            fillComboBox();
            GetData();
        }

        void GetData()
        {
            try
            {
                dataTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    command = new MySqlCommand(getDataQuery, connection);
                    command.Parameters.AddWithValue("@userId", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                taskList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void fillComboBox()
        {
            try
            {
                connection.Open();
                // UserId ile eşleşen çalışanları getir
                command = new MySqlCommand(fillComboBoxQuery, connection);
                command.Parameters.AddWithValue("@userId", userId);

                using (dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int employeeId = dataReader.GetInt32(0);
                        string employeeName = dataReader.GetString(1);
                        addEmployeeToTask.Items.Add(new KeyValuePair<int, string>(employeeId, employeeName));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ComboBox doldurma hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            try
            {
                string taskName = addTaskName.Text;
                DateTime taskBeginDate = addTaskBeginDate.Value;
                int manDayValue = (int)addManDayValue.Value;
                DateTime taskEndDate = addTaskEndDate.Value;
                string taskState = addTaskState.Text;
                int employeeId = selectedEmployeeId;

                if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(taskState))
                {
                    MessageBox.Show("Liste boş olamaz.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    if (!IsValidEmployeeId(employeeId, connection))
                    {
                        MessageBox.Show("Geçerli bir çalışan seçilmelidir.");
                        return;
                    }

                    command = new MySqlCommand(addTaskQuery, connection);
                    command.Parameters.AddWithValue("@TaskName", taskName);
                    command.Parameters.AddWithValue("@TaskBeginDate", taskBeginDate);
                    command.Parameters.AddWithValue("@ManDayValue", manDayValue);
                    command.Parameters.AddWithValue("@TaskEndDate", taskEndDate);
                    command.Parameters.AddWithValue("@TaskState", taskState);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Başarıyla Kayıt Olundu");
                        addTaskName.Text = "";
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private bool IsValidEmployeeId(int employeeId, MySqlConnection connection)
        {
            try
            {
                using (command = new MySqlCommand(isValidEmployeeIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@UserId", userId);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir EmployeeId kontrolü sırasında hata oluştu: " + ex.Message);
                return false;
            }
        }
        private void TaskPage_Load(object sender, EventArgs e)
        {
            GetData();

        }
        private void turnBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(userId);
            this.Hide();
            mainPage.ShowDialog();

        }
        private void addEmployeeToTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addEmployeeToTask.SelectedItem != null)
            {
                if (addEmployeeToTask.SelectedItem is KeyValuePair<int, string> selectedEmployee)
                {
                    selectedEmployeeId = selectedEmployee.Key;
                    textBox3.Text = selectedEmployeeId.ToString();
                }
            }
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (taskList.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = taskList.SelectedRows[0].Index;

                    string columnName = "TaskId"; 

                    int taskId = Convert.ToInt32(taskList.Rows[selectedRowIndex].Cells[columnName].Value);

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();

                        command = new MySqlCommand(deleteTaskQuery, connection);
                        command.Parameters.AddWithValue("@TaskId", taskId);

                        command.ExecuteNonQuery();
                    }

                    GetData();
                    MessageBox.Show("Kayıt Silindi");
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Gorev bir Projeye bagimli once o Projeyi siliniz.");

            }

        }

        private void searcByTaskName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = "TaskName LIKE '" + searcByTaskName.Text + "%'";
                taskList.DataSource = dv;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata :" + ex);
            }
        }

        private void updateTask_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();



                int selectedRowIndex = taskList.SelectedRows[0].Index;
                string columnName = "TaskId";
                int taskId = Convert.ToInt32(taskList.Rows[selectedRowIndex].Cells[columnName].Value);



                using (MySqlCommand command = new MySqlCommand(updateTaskQuery, connection))
                {
                    command.Parameters.AddWithValue("@TaskEndDate", updateTaskEndDate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@ManDayValue", (int)updateManDayValue.Value);
                    command.Parameters.AddWithValue("@TaskState", updateTaskState.Text);
                    command.Parameters.AddWithValue("@TaskId", taskId);

                    command.ExecuteNonQuery();
                }

                GetData();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bir satır seçin." + ex, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }

        private void taskList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateTaskEndDate.Text = taskList.CurrentRow.Cells[4].Value.ToString();
            updateManDayValue.Text = taskList.CurrentRow.Cells[3].Value.ToString();
            updateTaskState.Text = taskList.CurrentRow.Cells[5].Value.ToString();
        }
    }
}