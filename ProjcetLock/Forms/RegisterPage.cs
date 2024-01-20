using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjePilot.Forms
{
    public partial class RegisterPage : Form
    {
        private const string ConnectionString = "Server=localhost;Database=projectlock;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(ConnectionString);
        MySqlCommand command;

        string registerQuery = "INSERT INTO Users (UserFirstName, UserLastName, UserName, UserPassword) " +
                        "VALUES (@UserFirstName, @UserLastName, @UserName, @UserPassword)";

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {
                string userFirstName = this.newUserFirstName.Text;
                string userLastName = this.newUserLastName.Text;
                string userName = this.newUserName.Text;
                string userPassword = this.newUserPassword.Text;

                if (string.IsNullOrEmpty(userFirstName) || string.IsNullOrEmpty(userLastName))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");
                    return;
                }

                using (connection)
                {
                    connection.Open();

                    command = new MySqlCommand(registerQuery, connection);
                    command.Parameters.AddWithValue("@UserFirstName", userFirstName);
                    command.Parameters.AddWithValue("@UserLastName", userLastName);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserPassword", userPassword);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Başarıyla Kayıt Olundu");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hideShow_CheckedChanged(object sender, EventArgs e)
        {
            if (hideShow.CheckState == CheckState.Checked)
            {
                newUserPassword.UseSystemPasswordChar = true;
                hideShow.Text = "Gizle";
            }
            else if (hideShow.CheckState == CheckState.Unchecked)
            {
                newUserPassword.UseSystemPasswordChar = false;
                hideShow.Text = "Göster";
            }
        }
    }
}
