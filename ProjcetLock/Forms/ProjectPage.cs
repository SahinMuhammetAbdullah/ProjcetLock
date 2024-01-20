using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace ProjePilot.Forms
{
    public partial class ProjectPage : Form
    {
        private int selectedTaskId;
        private int userId;

        private const string ConnectionString = "Server=localhost;Database=projectlock;Uid=root;Pwd='';Convert Zero Datetime = True;";

        private MySqlConnection connection;
        private MySqlCommand command;
        private DataTable dataTable;
        private MySqlDataReader dataReader;
        private DataView dataView;

        private string getDataQuery = "SELECT P.ProjectId, P.ProjectName, P.ProjectBeginDate, P.ProjectEndDate, U.UserName, T.TaskName, E.EmployeeFirstName " +
            "FROM projectlock.Project P " +
            "LEFT JOIN projectlock.Users U ON P.UserId = U.UserId " +
            "LEFT JOIN projectlock.Task T ON P.TaskId = T.TaskId " +
            "LEFT JOIN projectlock.Employee E ON P.UserId = E.UserId AND T.EmployeeId = E.EmployeeId  " +
            "WHERE P.UserId = @userId";
        private string fillComboBoxQuery = "SELECT * FROM Task WHERE UserId = @userId";
        private string addNewProjectQuery = "INSERT INTO Project (ProjectName, ProjectBeginDate, ProjectEndDate, TaskId, UserId) " +
            "VALUES (@ProjectName, @ProjectBeginDate, @ProjectEndDate, @TaskId, @UserId)";
        private string isValidTaskIdQuery = "SELECT COUNT(*) FROM task WHERE TaskId = @TaskId";
        private string getValidTaskIdFromDatabaseQuery = "SELECT TaskId FROM task LIMIT 1";
        private string deleteQuery = "DELETE FROM project WHERE ProjectId = @ProjectId";
        private string updateProjectQuery = "UPDATE Project " +
                                 "SET ProjectEndDate = @ProjectEndDate, TaskId = @TaskId " +
                                 "WHERE ProjectId = @ProjectId";

        public ProjectPage(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            connection = new MySqlConnection(ConnectionString);
            FillComboBox();
        }

        private void ProjectPage_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(userId);
            this.Hide();
            mainPage.ShowDialog();
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            AddNewProject();
        }

        private void GetData()
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

                projectList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FillComboBox()
        {
            try
            {
                command = new MySqlCommand(fillComboBoxQuery, connection);

                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int taskId = dataReader.GetInt32(0);
                    string taskName = dataReader.GetString(1);
                    addTask.Items.Add(new KeyValuePair<int, string>(taskId, taskName));
                    changeTask.Items.Add(new KeyValuePair<int, string>(taskId, taskName));

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filling combo box: " + ex.Message);
            }
        }

        private void AddNewProject()
        {
            try
            {
                string projectName = addProjectName.Text;
                DateTime projectBeginDate = addProjectBeginDate.Value;
                DateTime projectEndDate = addProjectEndDate.Value;
                int taskId = selectedTaskId;

                if (string.IsNullOrEmpty(projectName))
                {
                    MessageBox.Show("Project name cannot be empty.");
                    return;
                }
                if (addTask.SelectedItem != null)
                {
                    KeyValuePair<int, string> selectedTask = (KeyValuePair<int, string>)addTask.SelectedItem;
                    selectedTaskId = selectedTask.Key;
                }
                if (addTask.SelectedItem == null)
                {
                    MessageBox.Show("Geçerli bir Görev seçilmelidir.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    if (!IsValidTaskId(taskId, connection))
                    {
                        int validTasktId = GetValidTaskIdFromDatabase(connection);
                        if (validTasktId > 0)
                        {
                            taskId = validTasktId;
                        }
                        else
                        {
                            MessageBox.Show("No valid Project found.");
                            return;
                        }
                    }



                    command = new MySqlCommand(addNewProjectQuery, connection);
                    command.Parameters.AddWithValue("@ProjectName", projectName);
                    command.Parameters.AddWithValue("@ProjectBeginDate", projectBeginDate);
                    command.Parameters.AddWithValue("@ProjectEndDate", projectEndDate);
                    command.Parameters.AddWithValue("@TaskId", taskId);
                    command.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Project added successfully.");
                        addProjectName.Text = "";
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Error adding project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private bool IsValidTaskId(int taskId, MySqlConnection connection)
        {
            try
            {
                using (command = new MySqlCommand(isValidTaskIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", taskId);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking valid Task: " + ex.Message);
                return false;
            }
        }

        private int GetValidTaskIdFromDatabase(MySqlConnection connection)
        {
            try
            {
                using (command = new MySqlCommand(getValidTaskIdFromDatabaseQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No valid Task found.");
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting valid TaskId: " + ex.Message);
                return -1;
            }
        }

        private void addTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addTask.SelectedItem != null)
            {
                if (addTask.SelectedItem is KeyValuePair<int, string> selectedTask)
                {
                    selectedTaskId = selectedTask.Key;
                    taskId.Text = selectedTaskId.ToString();
                }
            }
        }
        private void changeTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changeTask.SelectedItem != null)
            {
                if (changeTask.SelectedItem is KeyValuePair<int, string> selectedTask)
                {
                    taskId.Text = selectedTask.Key.ToString();
                }
            }
        }


        private void deleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (projectList.SelectedRows.Count > 0)
                {

                    int selectedRowIndex = projectList.SelectedRows[0].Index;

                    string columnName = "ProjectId";

                    int projectId = Convert.ToInt32(projectList.Rows[selectedRowIndex].Cells[columnName].Value);

                    using (connection)
                    {
                        connection.Open();

                        command = new MySqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@ProjectId", projectId);

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
            catch (Exception ex)
            {
                MessageBox.Show("basarisiz oldu.\b" + ex);

            }

        }

        private void updateProject_Click(object sender, EventArgs e)
        {
            int taskId = selectedTaskId;



            if (changeTask.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedTask = (KeyValuePair<int, string>)changeTask.SelectedItem;
                selectedTaskId = selectedTask.Key;
            }
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();


                    if (!IsValidTaskId(taskId, connection))
                    {

                        int validTaskId = GetValidTaskIdFromDatabase(connection);

                        if (validTaskId > 0)
                        {
                            taskId = validTaskId;
                        }
                        else
                        {
                            MessageBox.Show("No valid Project found.");
                            return;
                        }
                    }

                    int selectedRowIndex = projectList.SelectedRows[0].Index;
                    string columnName = "ProjectId";
                    int projectId = Convert.ToInt32(projectList.Rows[selectedRowIndex].Cells[columnName].Value);



                    using (command = new MySqlCommand(updateProjectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProjectEndDate", updateProjectEndDate.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@ProjectId", projectId);
                        command.Parameters.AddWithValue("@TaskId", taskId);

                        command.ExecuteNonQuery();
                    }

                    GetData();
                    MessageBox.Show("Güncellendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen bir satır seçin."+ex, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void projectList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            updateProjectName.Text = projectList.CurrentRow.Cells[1].Value.ToString();
            updateProjectEndDate.Text = projectList.CurrentRow.Cells[3].Value.ToString();
            changeTask.Text = projectList.CurrentRow.Cells[5].Value.ToString();

        }

        private void searchByProjectName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataView = dataTable.DefaultView;
                dataView.RowFilter = "ProjectName LIKE '" + searchByProjectName.Text + "%'";
                projectList.DataSource = dataView;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata :" + ex);
            }
        }


    }
}