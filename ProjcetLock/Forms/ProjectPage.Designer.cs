namespace ProjePilot.Forms
{
    partial class ProjectPage
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
            this.turnBack = new System.Windows.Forms.Button();
            this.addProject = new System.Windows.Forms.Button();
            this.projectList = new System.Windows.Forms.DataGridView();
            this.searchByProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.addProjectBeginDate = new System.Windows.Forms.DateTimePicker();
            this.addTask = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteProject = new System.Windows.Forms.Button();
            this.taskId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changeTask = new System.Windows.Forms.ComboBox();
            this.updateProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updateProject = new System.Windows.Forms.Button();
            this.updateProjectName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            this.SuspendLayout();
            // 
            // turnBack
            // 
            this.turnBack.Location = new System.Drawing.Point(909, 529);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(92, 38);
            this.turnBack.TabIndex = 0;
            this.turnBack.Text = "geri don";
            this.turnBack.UseVisualStyleBackColor = true;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // addProject
            // 
            this.addProject.Location = new System.Drawing.Point(406, 390);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(88, 38);
            this.addProject.TabIndex = 1;
            this.addProject.Text = "kaydet";
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // projectList
            // 
            this.projectList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectList.Location = new System.Drawing.Point(12, 12);
            this.projectList.Name = "projectList";
            this.projectList.RowHeadersWidth = 51;
            this.projectList.RowTemplate.Height = 24;
            this.projectList.Size = new System.Drawing.Size(1010, 266);
            this.projectList.TabIndex = 2;
            this.projectList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectList_CellEnter);
            // 
            // searchByProjectName
            // 
            this.searchByProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchByProjectName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchByProjectName.Location = new System.Drawing.Point(199, 305);
            this.searchByProjectName.Name = "searchByProjectName";
            this.searchByProjectName.Size = new System.Drawing.Size(798, 25);
            this.searchByProjectName.TabIndex = 3;
            this.searchByProjectName.TextChanged += new System.EventHandler(this.searchByProjectName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Poroje Ismine Gore Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Poroje Ismi";
            // 
            // addProjectName
            // 
            this.addProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addProjectName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProjectName.Location = new System.Drawing.Point(207, 390);
            this.addProjectName.Name = "addProjectName";
            this.addProjectName.Size = new System.Drawing.Size(181, 25);
            this.addProjectName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proje Başlangıç Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proje Bitiş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yeni Proje Kaydı";
            // 
            // addProjectEndDate
            // 
            this.addProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addProjectEndDate.Location = new System.Drawing.Point(206, 455);
            this.addProjectEndDate.Name = "addProjectEndDate";
            this.addProjectEndDate.Size = new System.Drawing.Size(182, 22);
            this.addProjectEndDate.TabIndex = 12;
            // 
            // addProjectBeginDate
            // 
            this.addProjectBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addProjectBeginDate.Location = new System.Drawing.Point(207, 424);
            this.addProjectBeginDate.Name = "addProjectBeginDate";
            this.addProjectBeginDate.Size = new System.Drawing.Size(181, 22);
            this.addProjectBeginDate.TabIndex = 13;
            // 
            // addTask
            // 
            this.addTask.FormattingEnabled = true;
            this.addTask.Location = new System.Drawing.Point(207, 483);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(181, 24);
            this.addTask.TabIndex = 14;
            this.addTask.SelectedIndexChanged += new System.EventHandler(this.addTask_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gorev Ekle";
            // 
            // deleteProject
            // 
            this.deleteProject.Location = new System.Drawing.Point(905, 439);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(88, 38);
            this.deleteProject.TabIndex = 16;
            this.deleteProject.Text = "sil";
            this.deleteProject.UseVisualStyleBackColor = true;
            this.deleteProject.Click += new System.EventHandler(this.deleteProject_Click);
            // 
            // taskId
            // 
            this.taskId.HideSelection = false;
            this.taskId.Location = new System.Drawing.Point(178, 485);
            this.taskId.Name = "taskId";
            this.taskId.ReadOnly = true;
            this.taskId.Size = new System.Drawing.Size(23, 22);
            this.taskId.TabIndex = 17;
            this.taskId.TabStop = false;
            this.taskId.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(519, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Gorev Degistir";
            // 
            // changeTask
            // 
            this.changeTask.FormattingEnabled = true;
            this.changeTask.Location = new System.Drawing.Point(706, 452);
            this.changeTask.Name = "changeTask";
            this.changeTask.Size = new System.Drawing.Size(181, 24);
            this.changeTask.TabIndex = 26;
            this.changeTask.SelectedIndexChanged += new System.EventHandler(this.changeTask_SelectedIndexChanged);
            // 
            // updateProjectEndDate
            // 
            this.updateProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateProjectEndDate.Location = new System.Drawing.Point(705, 424);
            this.updateProjectEndDate.Name = "updateProjectEndDate";
            this.updateProjectEndDate.Size = new System.Drawing.Size(182, 22);
            this.updateProjectEndDate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(516, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Proje Güncelleme";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(519, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Proje Bitiş Tarihi";
            // 
            // updateProject
            // 
            this.updateProject.Location = new System.Drawing.Point(905, 390);
            this.updateProject.Name = "updateProject";
            this.updateProject.Size = new System.Drawing.Size(88, 38);
            this.updateProject.TabIndex = 18;
            this.updateProject.Text = "guncelle";
            this.updateProject.UseVisualStyleBackColor = true;
            this.updateProject.Click += new System.EventHandler(this.updateProject_Click);
            // 
            // updateProjectName
            // 
            this.updateProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateProjectName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateProjectName.Location = new System.Drawing.Point(706, 390);
            this.updateProjectName.Name = "updateProjectName";
            this.updateProjectName.ReadOnly = true;
            this.updateProjectName.Size = new System.Drawing.Size(181, 25);
            this.updateProjectName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(519, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Poroje Ismi";
            // 
            // ProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjcetLock.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 579);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.changeTask);
            this.Controls.Add(this.updateProjectEndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.updateProjectName);
            this.Controls.Add(this.updateProject);
            this.Controls.Add(this.taskId);
            this.Controls.Add(this.deleteProject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.addProjectBeginDate);
            this.Controls.Add(this.addProjectEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByProjectName);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.addProject);
            this.Controls.Add(this.turnBack);
            this.DoubleBuffered = true;
            this.Name = "ProjectPage";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.ProjectPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.DataGridView projectList;
        private System.Windows.Forms.TextBox searchByProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker addProjectEndDate;
        private System.Windows.Forms.DateTimePicker addProjectBeginDate;
        private System.Windows.Forms.ComboBox addTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteProject;
        private System.Windows.Forms.TextBox taskId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox changeTask;
        private System.Windows.Forms.DateTimePicker updateProjectEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateProject;
        private System.Windows.Forms.TextBox updateProjectName;
        private System.Windows.Forms.Label label11;
    }
}