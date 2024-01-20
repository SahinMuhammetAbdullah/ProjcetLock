namespace ProjePilot.Forms
{
    partial class RegisterPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.turnBack = new System.Windows.Forms.Button();
            this.newUserFirstName = new System.Windows.Forms.TextBox();
            this.newUserLastName = new System.Windows.Forms.TextBox();
            this.newUserName = new System.Windows.Forms.TextBox();
            this.newUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.hideShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // turnBack
            // 
            this.turnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.turnBack.Location = new System.Drawing.Point(761, 499);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(106, 34);
            this.turnBack.TabIndex = 0;
            this.turnBack.Text = "Geri dön";
            this.turnBack.UseVisualStyleBackColor = true;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // newUserFirstName
            // 
            this.newUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserFirstName.Location = new System.Drawing.Point(339, 103);
            this.newUserFirstName.Name = "newUserFirstName";
            this.newUserFirstName.Size = new System.Drawing.Size(177, 30);
            this.newUserFirstName.TabIndex = 1;
            // 
            // newUserLastName
            // 
            this.newUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserLastName.Location = new System.Drawing.Point(339, 178);
            this.newUserLastName.Name = "newUserLastName";
            this.newUserLastName.Size = new System.Drawing.Size(177, 30);
            this.newUserLastName.TabIndex = 2;
            // 
            // newUserName
            // 
            this.newUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserName.Location = new System.Drawing.Point(339, 249);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(177, 30);
            this.newUserName.TabIndex = 3;
            // 
            // newUserPassword
            // 
            this.newUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserPassword.Location = new System.Drawing.Point(339, 318);
            this.newUserPassword.Name = "newUserPassword";
            this.newUserPassword.Size = new System.Drawing.Size(177, 30);
            this.newUserPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(336, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(336, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(336, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(336, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre";
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register.Location = new System.Drawing.Point(376, 379);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(96, 35);
            this.register.TabIndex = 11;
            this.register.Text = "KAYDOL";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // hideShow
            // 
            this.hideShow.AutoSize = true;
            this.hideShow.BackColor = System.Drawing.Color.Transparent;
            this.hideShow.ForeColor = System.Drawing.SystemColors.Control;
            this.hideShow.Location = new System.Drawing.Point(522, 328);
            this.hideShow.Name = "hideShow";
            this.hideShow.Size = new System.Drawing.Size(67, 20);
            this.hideShow.TabIndex = 12;
            this.hideShow.Text = "göster";
            this.hideShow.UseVisualStyleBackColor = false;
            this.hideShow.CheckedChanged += new System.EventHandler(this.hideShow_CheckedChanged);
            // 
            // RegisterPage
            // 
            this.AcceptButton = this.turnBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjcetLock.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.turnBack;
            this.ClientSize = new System.Drawing.Size(879, 545);
            this.Controls.Add(this.hideShow);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserPassword);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.newUserLastName);
            this.Controls.Add(this.newUserFirstName);
            this.Controls.Add(this.turnBack);
            this.DoubleBuffered = true;
            this.Name = "RegisterPage";
            this.Text = "KAYIT OL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.TextBox newUserFirstName;
        private System.Windows.Forms.TextBox newUserLastName;
        private System.Windows.Forms.TextBox newUserName;
        private System.Windows.Forms.TextBox newUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.CheckBox hideShow;
    }
}