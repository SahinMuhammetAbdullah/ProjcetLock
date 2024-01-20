namespace ProjePilot.Forms
{
    partial class MainPage
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
            this.logOut = new System.Windows.Forms.Button();
            this.projects = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logOut.Location = new System.Drawing.Point(1149, 661);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(125, 52);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Çıkış Yap";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // projects
            // 
            this.projects.BackColor = System.Drawing.SystemColors.Info;
            this.projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projects.Location = new System.Drawing.Point(210, 357);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(236, 85);
            this.projects.TabIndex = 1;
            this.projects.Text = "PROJELER";
            this.projects.UseVisualStyleBackColor = false;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // tasks
            // 
            this.tasks.BackColor = System.Drawing.SystemColors.Info;
            this.tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tasks.Location = new System.Drawing.Point(523, 357);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(236, 85);
            this.tasks.TabIndex = 2;
            this.tasks.Text = "GÖREVLER";
            this.tasks.UseVisualStyleBackColor = false;
            this.tasks.Click += new System.EventHandler(this.tasks_Click);
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.SystemColors.Info;
            this.employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employees.Location = new System.Drawing.Point(842, 357);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(236, 85);
            this.employees.TabIndex = 3;
            this.employees.Text = "ÇALIŞANLAR";
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(287, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "SİSTEME HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(360, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen yapacağınız işlemi seçiniz";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjcetLock.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.logOut;
            this.ClientSize = new System.Drawing.Size(1286, 725);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.logOut);
            this.DoubleBuffered = true;
            this.Name = "MainPage";
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button projects;
        private System.Windows.Forms.Button tasks;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}