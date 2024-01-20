using System;

namespace ProjePilot.Forms
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        private void LoginPage_Load(object sender, EventArgs e)
        {
            // İlgili kodları buraya ekleyin veya bu metodun içeriğini kullanmadığınız için silebilirsiniz.
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.loginUserName = new System.Windows.Forms.TextBox();
            this.loginUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hideShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login.Location = new System.Drawing.Point(551, 397);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(179, 41);
            this.login.TabIndex = 0;
            this.login.Text = "GİRİŞ YAP";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register.Location = new System.Drawing.Point(635, 453);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(131, 33);
            this.register.TabIndex = 1;
            this.register.Text = "KAYDOL";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // loginUserName
            // 
            this.loginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUserName.Location = new System.Drawing.Point(469, 268);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.Size = new System.Drawing.Size(350, 41);
            this.loginUserName.TabIndex = 2;
            // 
            // loginUserPassword
            // 
            this.loginUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUserPassword.Location = new System.Drawing.Point(469, 338);
            this.loginUserPassword.Name = "loginUserPassword";
            this.loginUserPassword.Size = new System.Drawing.Size(350, 41);
            this.loginUserPassword.TabIndex = 3;
            this.loginUserPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(466, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(466, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(479, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesabın yok mu ?";
            // 
            // hideShow
            // 
            this.hideShow.AutoSize = true;
            this.hideShow.BackColor = System.Drawing.Color.Transparent;
            this.hideShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hideShow.Location = new System.Drawing.Point(843, 356);
            this.hideShow.Name = "hideShow";
            this.hideShow.Size = new System.Drawing.Size(67, 20);
            this.hideShow.TabIndex = 7;
            this.hideShow.Text = "göster";
            this.hideShow.UseVisualStyleBackColor = false;
            this.hideShow.CheckedChanged += new System.EventHandler(this.hideShow_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjcetLock.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 652);
            this.Controls.Add(this.hideShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginUserPassword);
            this.Controls.Add(this.loginUserName);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoginPage";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox loginUserName;
        private System.Windows.Forms.TextBox loginUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hideShow;
    }
}