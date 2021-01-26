
namespace BudgetManagementApp.Forms.Categories
{
    partial class FrmCategoryMaintenance
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtCategoryId = new System.Windows.Forms.TextBox();
            this.LblCategoryDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(263, 105);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 52);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(130, 105);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 52);
            this.BtnSave.TabIndex = 34;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(50, 46);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtDescription.MaxLength = 99;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(379, 27);
            this.TxtDescription.TabIndex = 33;
            // 
            // TxtCategoryId
            // 
            this.TxtCategoryId.Location = new System.Drawing.Point(455, 15);
            this.TxtCategoryId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtCategoryId.MaxLength = 99;
            this.TxtCategoryId.Name = "TxtCategoryId";
            this.TxtCategoryId.ReadOnly = true;
            this.TxtCategoryId.Size = new System.Drawing.Size(30, 27);
            this.TxtCategoryId.TabIndex = 36;
            this.TxtCategoryId.Visible = false;
            // 
            // LblCategoryDescription
            // 
            this.LblCategoryDescription.AutoSize = true;
            this.LblCategoryDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryDescription.Location = new System.Drawing.Point(46, 9);
            this.LblCategoryDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoryDescription.Name = "LblCategoryDescription";
            this.LblCategoryDescription.Size = new System.Drawing.Size(122, 24);
            this.LblCategoryDescription.TabIndex = 37;
            this.LblCategoryDescription.Text = "Descripción";
            // 
            // FrmCategoryMaintenance
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(498, 208);
            this.Controls.Add(this.LblCategoryDescription);
            this.Controls.Add(this.TxtCategoryId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDescription);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCategoryMaintenance";
            this.Text = "FrmCategoryMaintenance";
            this.Load += new System.EventHandler(this.FrmCategoryMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.TextBox TxtCategoryId;
        public System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblCategoryDescription;
    }
}