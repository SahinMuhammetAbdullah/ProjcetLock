using MySql.Data.MySqlClient;
using ProjcetLock.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjePilot.Forms
{
    public partial class EmployeePage : Form
    {
        private const string ConnectionString = "Server=localhost;Database=projectlock;Uid=root;Pwd='';";
        private int userId;
        private int employeeId;
        MySqlConnection connection = new MySqlConnection(ConnectionString);
        MySqlCommand command;
        DataTable dataTable;
        DataView dataView;
        string addEmployeeQuery = "INSERT INTO Employee (EmployeeFirstName, EmployeeLastName, UserId) " +
                        "VALUES (@EmployeeFirstName, @EmployeeLastName, @UserId)";
        string getDataQuery = "SELECT E.EmployeeId, E.EmployeeFirstName, E.EmployeeLastName, U.UserName " +
            "FROM projectlock.employee E " +
            "JOIN projectlock.users U ON E.UserId = U.UserId " +
            "WHERE E.UserId = @userId";
        string deleteEmployeeQuery = "DELETE FROM Employee WHERE EmployeeId = @EmployeeId";
        string updateEmployeeQuery = "UPDATE Employee " +
                    "SET EmployeeFirstName = @EmployeeFirstName, EmployeeLastName = @EmployeeLastName " +
                    "WHERE EmployeeId = @EmployeeId";
        public EmployeePage(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            
        }
        private void newEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeFirstName = addEmployeeFirstName.Text;
                string employeeLastName = addEmployeeLastName.Text;

                if (string.IsNullOrEmpty(employeeFirstName) || string.IsNullOrEmpty(employeeLastName))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    try
                    {
                        command = new MySqlCommand(addEmployeeQuery, connection);
                        command.Parameters.AddWithValue("@EmployeeFirstName", employeeFirstName);
                        command.Parameters.AddWithValue("@EmployeeLastName", employeeLastName);
                        command.Parameters.AddWithValue("@UserId", userId); // Corrected parameter name

                        // Execute the query
                        command.ExecuteNonQuery();

                        
                        MessageBox.Show("Başarıyla Kayıt Olundu");
                        // Optionally, you can clear the textboxes after successful insertion
                        addEmployeeFirstName.Text = "";
                        addEmployeeLastName.Text = "";
                        GetData();

                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(""+ex);
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex);
            }
        }

        void GetData()
        {
            try
            {
                dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Parametre kullanarak sorguyu oluştur
                    MySqlCommand command = new MySqlCommand(getDataQuery, connection);
                    command.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                employeeList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            GetData();
            updateEmployeeFirstName.Text = "";
            updateEmployeeLastName.Text = "";
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(userId);
            this.Hide();
            mainPage.ShowDialog();
        }

        private void employeeList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            updateEmployeeFirstName.Text = employeeList.CurrentRow.Cells[1].Value.ToString();
            updateEmployeeLastName.Text = employeeList.CurrentRow.Cells[2].Value.ToString();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeList.SelectedRows.Count > 0)
                {
                    // DataGridView'de seçili satır varsa
                    int selectedRowIndex = employeeList.SelectedRows[0].Index;

                    // Doğru sütun adını bulun
                    string columnName = "EmployeeId"; // Bu adı DataGridView'de bulunan sütun adıyla değiştirin

                    int employeeId = Convert.ToInt32(employeeList.Rows[selectedRowIndex].Cells[columnName].Value);

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(deleteEmployeeQuery, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);
                            command.ExecuteNonQuery();
                        }
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
                MessageBox.Show("Bu Calisan bir goreve bagimli once o gorevi siliniz. : " + ex);
            }


        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = employeeList.SelectedRows[0].Index;

                string columnName = "EmployeeId"; // Bu adı DataGridView'de bulunan sütun adıyla değiştirin

                employeeId = Convert.ToInt32(employeeList.Rows[selectedRowIndex].Cells[columnName].Value);
                
                command = new MySqlCommand(updateEmployeeQuery, connection);
                command.Parameters.AddWithValue("@EmployeeFirstName", updateEmployeeFirstName.Text);
                command.Parameters.AddWithValue("@EmployeeLastName", updateEmployeeLastName.Text);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                GetData();
                MessageBox.Show("Guncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searcByEmplyeeFirstName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataView = dataTable.DefaultView;
                dataView.RowFilter = "EmployeeFirstName LIKE '" + searcByEmplyeeFirstName.Text + "%'";
                employeeList.DataSource = dataView;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata :" + ex);
            }
            
        }

        private void goToEmployeeDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = employeeList.SelectedRows[0].Index;

                // Doğru sütun adını bulun
                string columnName = "EmployeeId"; // Bu adı DataGridView'de bulunan sütun adıyla değiştirin

                int employeeId = Convert.ToInt32(employeeList.Rows[selectedRowIndex].Cells[columnName].Value);
                EmployeeDetail employeeDetail = new EmployeeDetail(userId, employeeId);
                this.Hide();
                employeeDetail.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Calisan secilemedi");
            }
            
        }
    }
}

