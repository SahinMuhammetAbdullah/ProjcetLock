using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjePilot.Forms
{
    public partial class LoginPage : Form
    {
        private const string ConnectionString = "Server=localhost;Database=projectlock;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(ConnectionString);
        MySqlCommand command;
        MySqlDataReader dataReader;
        string loginQuery = "SELECT * FROM Users " +
            "WHERE UserName = @UserName AND UserPassword = @UserPassword";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            this.Hide();
            registerPage.ShowDialog();
        }

        private void hideShow_CheckedChanged(object sender, EventArgs e)
        {
            loginUserPassword.UseSystemPasswordChar = hideShow.Checked;
            hideShow.Text = hideShow.Checked ? "Gizle" : "Göster";
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = loginUserName.Text;
                string password = loginUserPassword.Text;

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");
                    return;
                }

                using (connection)
                {
                    connection.Open();
                    
                    command = new MySqlCommand(loginQuery, connection);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@UserPassword", password);

                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            int userId = Convert.ToInt32(dataReader["UserId"]);
                            // Başarılı giriş durumunda MainPage formunu göster
                            MainPage mainPage = new MainPage(userId);
                            this.Hide();
                            mainPage.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}