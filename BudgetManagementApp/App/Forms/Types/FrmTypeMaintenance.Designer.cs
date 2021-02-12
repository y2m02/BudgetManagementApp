
namespace BudgetManagementApp.Forms.Types
{
    partial class FrmTypeMaintenance
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
            this.LblTypeDescription = new System.Windows.Forms.Label();
            this.TxtTypeId = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTypeDescription
            // 
            this.LblTypeDescription.AutoSize = true;
            this.LblTypeDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeDescription.Location = new System.Drawing.Point(13, 99);
            this.LblTypeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTypeDescription.Name = "LblTypeDescription";
            this.LblTypeDescription.Size = new System.Drawing.Size(122, 24);
            this.LblTypeDescription.TabIndex = 42;
            this.LblTypeDescription.Text = "Descripción";
            // 
            // TxtTypeId
            // 
            this.TxtTypeId.Location = new System.Drawing.Point(411, 102);
            this.TxtTypeId.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtTypeId.MaxLength = 99;
            this.TxtTypeId.Name = "TxtTypeId";
            this.TxtTypeId.ReadOnly = true;
            this.TxtTypeId.Size = new System.Drawing.Size(33, 27);
            this.TxtTypeId.TabIndex = 41;
            this.TxtTypeId.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(218, 220);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(146, 62);
            this.BtnCancel.TabIndex = 40;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(69, 220);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(146, 62);
            this.BtnSave.TabIndex = 39;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(18, 143);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtDescription.MaxLength = 99;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(426, 27);
            this.TxtDescription.TabIndex = 38;
            // 
            // CbxCategory
            // 
            this.CbxCategory.BackColor = System.Drawing.SystemColors.Window;
            this.CbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxCategory.Location = new System.Drawing.Point(18, 55);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(426, 27);
            this.CbxCategory.Sorted = true;
            this.CbxCategory.TabIndex = 43;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(13, 19);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(102, 24);
            this.LblCategory.TabIndex = 44;
            this.LblCategory.Text = "Categoría";
            // 
            // FrmTypeMaintenance
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(468, 310);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.CbxCategory);
            this.Controls.Add(this.LblTypeDescription);
            this.Controls.Add(this.TxtTypeId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDescription);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTypeMaintenance";
            this.Text = "FrmTypeMaintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTypeMaintenance_FormClosing);
            this.Load += new System.EventHandler(this.FrmTypeMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTypeDescription;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.TextBox TxtTypeId;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ComboBox CbxCategory;
    }
}