
namespace BudgetManagementApp.Forms.Projects
{
    partial class FrmBudgetManagement
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
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblConstruction = new System.Windows.Forms.Label();
            this.TxtConstruction = new System.Windows.Forms.TextBox();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.TxtEndDate = new System.Windows.Forms.TextBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.TxtStartDate = new System.Windows.Forms.TextBox();
            this.TxtProjectId = new System.Windows.Forms.TextBox();
            this.LblProjectName = new System.Windows.Forms.Label();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.Location = new System.Drawing.Point(389, 157);
            this.LblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(66, 24);
            this.LblCost.TabIndex = 65;
            this.LblCost.Text = "Costo";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(393, 189);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCost.MaxLength = 99;
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.ReadOnly = true;
            this.TxtCost.Size = new System.Drawing.Size(290, 27);
            this.TxtCost.TabIndex = 64;
            // 
            // LblConstruction
            // 
            this.LblConstruction.AutoSize = true;
            this.LblConstruction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConstruction.Location = new System.Drawing.Point(15, 157);
            this.LblConstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConstruction.Name = "LblConstruction";
            this.LblConstruction.Size = new System.Drawing.Size(137, 24);
            this.LblConstruction.TabIndex = 63;
            this.LblConstruction.Text = "Construcción";
            // 
            // TxtConstruction
            // 
            this.TxtConstruction.Location = new System.Drawing.Point(19, 189);
            this.TxtConstruction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConstruction.MaxLength = 99;
            this.TxtConstruction.Name = "TxtConstruction";
            this.TxtConstruction.ReadOnly = true;
            this.TxtConstruction.Size = new System.Drawing.Size(290, 27);
            this.TxtConstruction.TabIndex = 62;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndDate.Location = new System.Drawing.Point(389, 83);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(208, 24);
            this.LblEndDate.TabIndex = 61;
            this.LblEndDate.Text = "Fecha de finalización";
            // 
            // TxtEndDate
            // 
            this.TxtEndDate.Location = new System.Drawing.Point(393, 115);
            this.TxtEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEndDate.MaxLength = 99;
            this.TxtEndDate.Name = "TxtEndDate";
            this.TxtEndDate.ReadOnly = true;
            this.TxtEndDate.Size = new System.Drawing.Size(290, 27);
            this.TxtEndDate.TabIndex = 60;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.Location = new System.Drawing.Point(14, 83);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(152, 24);
            this.LblStartDate.TabIndex = 59;
            this.LblStartDate.Text = "Fecha de inicio";
            // 
            // TxtStartDate
            // 
            this.TxtStartDate.Location = new System.Drawing.Point(19, 115);
            this.TxtStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStartDate.MaxLength = 99;
            this.TxtStartDate.Name = "TxtStartDate";
            this.TxtStartDate.ReadOnly = true;
            this.TxtStartDate.Size = new System.Drawing.Size(290, 27);
            this.TxtStartDate.TabIndex = 58;
            // 
            // TxtProjectId
            // 
            this.TxtProjectId.Location = new System.Drawing.Point(654, 6);
            this.TxtProjectId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtProjectId.MaxLength = 99;
            this.TxtProjectId.Name = "TxtProjectId";
            this.TxtProjectId.ReadOnly = true;
            this.TxtProjectId.Size = new System.Drawing.Size(30, 27);
            this.TxtProjectId.TabIndex = 57;
            this.TxtProjectId.Visible = false;
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjectName.Location = new System.Drawing.Point(13, 9);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(63, 24);
            this.LblProjectName.TabIndex = 56;
            this.LblProjectName.Text = "Name";
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Location = new System.Drawing.Point(18, 41);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProjectName.MaxLength = 99;
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.ReadOnly = true;
            this.TxtProjectName.Size = new System.Drawing.Size(666, 27);
            this.TxtProjectName.TabIndex = 55;
            // 
            // FrmBudgetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LblConstruction);
            this.Controls.Add(this.TxtConstruction);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.TxtEndDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.TxtStartDate);
            this.Controls.Add(this.TxtProjectId);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.TxtProjectName);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBudgetManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBudgetManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBudgetManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label LblConstruction;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.Label LblStartDate;
        public System.Windows.Forms.TextBox TxtProjectId;
        private System.Windows.Forms.Label LblProjectName;
        public System.Windows.Forms.TextBox TxtCost;
        public System.Windows.Forms.TextBox TxtConstruction;
        public System.Windows.Forms.TextBox TxtEndDate;
        public System.Windows.Forms.TextBox TxtStartDate;
        public System.Windows.Forms.TextBox TxtProjectName;
    }
}