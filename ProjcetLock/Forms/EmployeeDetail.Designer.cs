using System.Windows.Forms;

namespace ProjcetLock.Forms
{
    partial class EmployeeDetail
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
            this.employeeTaskList = new System.Windows.Forms.DataGridView();
            this.turnBack = new System.Windows.Forms.Button();
            this.updateEmployeeNumberOfTasksCompleted = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateTasks = new System.Windows.Forms.Button();
            this.updateEmployeeNumberOngoingTasks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOfTasksCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOngoingTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeTaskList
            // 
            this.employeeTaskList.BackgroundColor = System.Drawing.Color.Silver;
            this.employeeTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTaskList.Location = new System.Drawing.Point(12, 12);
            this.employeeTaskList.Name = "employeeTaskList";
            this.employeeTaskList.RowHeadersWidth = 51;
            this.employeeTaskList.RowTemplate.Height = 24;
            this.employeeTaskList.Size = new System.Drawing.Size(949, 286);
            this.employeeTaskList.TabIndex = 0;
            // 
            // turnBack
            // 
            this.turnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turnBack.Location = new System.Drawing.Point(812, 547);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(149, 74);
            this.turnBack.TabIndex = 1;
            this.turnBack.Text = "Geri Don";
            this.turnBack.UseVisualStyleBackColor = true;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // updateEmployeeNumberOfTasksCompleted
            // 
            this.updateEmployeeNumberOfTasksCompleted.Location = new System.Drawing.Point(268, 368);
            this.updateEmployeeNumberOfTasksCompleted.Name = "updateEmployeeNumberOfTasksCompleted";
            this.updateEmployeeNumberOfTasksCompleted.Size = new System.Drawing.Size(181, 22);
            this.updateEmployeeNumberOfTasksCompleted.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(30, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Biten Proje Sayısı Güncelle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(25, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(503, 33);
            this.label12.TabIndex = 53;
            this.label12.Text = "Biten/Devam Eden Proje Sayısı Güncelleme";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(30, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Devam Eden Proje Adedi Güncelle";
            // 
            // updateTasks
            // 
            this.updateTasks.Location = new System.Drawing.Point(477, 365);
            this.updateTasks.Name = "updateTasks";
            this.updateTasks.Size = new System.Drawing.Size(88, 38);
            this.updateTasks.TabIndex = 51;
            this.updateTasks.Text = "guncelle";
            this.updateTasks.UseVisualStyleBackColor = true;
            this.updateTasks.Click += new System.EventHandler(this.updateTasks_Click);
            // 
            // updateEmployeeNumberOngoingTasks
            // 
            this.updateEmployeeNumberOngoingTasks.Location = new System.Drawing.Point(268, 396);
            this.updateEmployeeNumberOngoingTasks.Name = "updateEmployeeNumberOngoingTasks";
            this.updateEmployeeNumberOngoingTasks.Size = new System.Drawing.Size(181, 22);
            this.updateEmployeeNumberOngoingTasks.TabIndex = 57;
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjcetLock.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 633);
            this.Controls.Add(this.updateEmployeeNumberOngoingTasks);
            this.Controls.Add(this.updateEmployeeNumberOfTasksCompleted);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.updateTasks);
            this.Controls.Add(this.turnBack);
            this.Controls.Add(this.employeeTaskList);
            this.DoubleBuffered = true;
            this.Name = "EmployeeDetail";
            this.Text = "ÇALIŞAN DETAYLARI";
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOfTasksCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOngoingTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeTaskList;
        private System.Windows.Forms.Button turnBack;
        private NumericUpDown updateEmployeeNumberOfTasksCompleted;
        private Label label10;
        private Label label12;
        private Label label13;
        private Button updateTasks;
        private NumericUpDown updateEmployeeNumberOngoingTasks;
    }
}