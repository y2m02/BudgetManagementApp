
namespace BudgetManagementApp.Forms.Projects
{
    partial class FrmProjectMaintenance
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
            this.LblProjectName = new System.Windows.Forms.Label();
            this.TxtProjectId = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblConstruction = new System.Windows.Forms.Label();
            this.TxtContruction = new System.Windows.Forms.TextBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjectName.Location = new System.Drawing.Point(13, 20);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(84, 24);
            this.LblProjectName.TabIndex = 42;
            this.LblProjectName.Text = "Nombre";
            // 
            // TxtProjectId
            // 
            this.TxtProjectId.Location = new System.Drawing.Point(366, 21);
            this.TxtProjectId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtProjectId.MaxLength = 99;
            this.TxtProjectId.Name = "TxtProjectId";
            this.TxtProjectId.ReadOnly = true;
            this.TxtProjectId.Size = new System.Drawing.Size(30, 27);
            this.TxtProjectId.TabIndex = 41;
            this.TxtProjectId.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(215, 456);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 52);
            this.BtnCancel.TabIndex = 40;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(82, 456);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 52);
            this.BtnSave.TabIndex = 39;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Location = new System.Drawing.Point(17, 57);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtProjectName.MaxLength = 99;
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(379, 27);
            this.TxtProjectName.TabIndex = 38;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.DtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpStartDate.Location = new System.Drawing.Point(17, 144);
            this.DtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpStartDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(379, 27);
            this.DtpStartDate.TabIndex = 43;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.Location = new System.Drawing.Point(13, 102);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(152, 24);
            this.LblStartDate.TabIndex = 45;
            this.LblStartDate.Text = "Fecha de inicio";
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndDate.Location = new System.Drawing.Point(13, 193);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(208, 24);
            this.LblEndDate.TabIndex = 48;
            this.LblEndDate.Text = "Fecha de finalización";
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.DtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEndDate.Location = new System.Drawing.Point(17, 237);
            this.DtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpEndDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(379, 27);
            this.DtpEndDate.TabIndex = 47;
            // 
            // LblConstruction
            // 
            this.LblConstruction.AutoSize = true;
            this.LblConstruction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConstruction.Location = new System.Drawing.Point(13, 287);
            this.LblConstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConstruction.Name = "LblConstruction";
            this.LblConstruction.Size = new System.Drawing.Size(137, 24);
            this.LblConstruction.TabIndex = 50;
            this.LblConstruction.Text = "Construcción";
            // 
            // TxtContruction
            // 
            this.TxtContruction.Location = new System.Drawing.Point(17, 324);
            this.TxtContruction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtContruction.MaxLength = 99;
            this.TxtContruction.Name = "TxtContruction";
            this.TxtContruction.Size = new System.Drawing.Size(379, 27);
            this.TxtContruction.TabIndex = 49;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.Location = new System.Drawing.Point(13, 370);
            this.LblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(66, 24);
            this.LblCost.TabIndex = 52;
            this.LblCost.Text = "Costo";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(17, 407);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtCost.MaxLength = 99;
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(379, 27);
            this.TxtCost.TabIndex = 51;
            // 
            // FrmProjectMaintenance
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(432, 534);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LblConstruction);
            this.Controls.Add(this.TxtContruction);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.DtpEndDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.TxtProjectId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtProjectName);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProjectMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProjectMaintenance";
            this.Load += new System.EventHandler(this.FrmProjectMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProjectName;
        public System.Windows.Forms.TextBox TxtProjectId;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.TextBox TxtProjectName;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.Label LblConstruction;
        public System.Windows.Forms.TextBox TxtContruction;
        private System.Windows.Forms.Label LblCost;
        public System.Windows.Forms.TextBox TxtCost;
        public System.Windows.Forms.DateTimePicker DtpStartDate;
        public System.Windows.Forms.DateTimePicker DtpEndDate;
    }
}