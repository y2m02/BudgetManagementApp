
namespace BudgetManagementApp.Forms.SubTypes
{
    partial class FrmSubTypeMaintenance
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
            this.LblCategory = new System.Windows.Forms.Label();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtSubTypeId = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(13, 9);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(102, 24);
            this.LblCategory.TabIndex = 51;
            this.LblCategory.Text = "Categoría";
            // 
            // CbxCategory
            // 
            this.CbxCategory.BackColor = System.Drawing.SystemColors.Window;
            this.CbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxCategory.Location = new System.Drawing.Point(18, 45);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(426, 27);
            this.CbxCategory.Sorted = true;
            this.CbxCategory.TabIndex = 50;
            this.CbxCategory.SelectedIndexChanged += new System.EventHandler(this.CbxCategory_SelectedIndexChanged);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(13, 186);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(122, 24);
            this.LblDescription.TabIndex = 49;
            this.LblDescription.Text = "Descripción";
            // 
            // TxtSubTypeId
            // 
            this.TxtSubTypeId.Location = new System.Drawing.Point(411, 189);
            this.TxtSubTypeId.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtSubTypeId.MaxLength = 99;
            this.TxtSubTypeId.Name = "TxtSubTypeId";
            this.TxtSubTypeId.ReadOnly = true;
            this.TxtSubTypeId.Size = new System.Drawing.Size(33, 27);
            this.TxtSubTypeId.TabIndex = 48;
            this.TxtSubTypeId.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(227, 307);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(146, 62);
            this.BtnCancel.TabIndex = 47;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(78, 307);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(146, 62);
            this.BtnSave.TabIndex = 46;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(18, 230);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtDescription.MaxLength = 99;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(426, 27);
            this.TxtDescription.TabIndex = 45;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(13, 95);
            this.LblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(52, 24);
            this.LblType.TabIndex = 53;
            this.LblType.Text = "Tipo";
            // 
            // CbxType
            // 
            this.CbxType.BackColor = System.Drawing.SystemColors.Window;
            this.CbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxType.Location = new System.Drawing.Point(18, 131);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(426, 27);
            this.CbxType.Sorted = true;
            this.CbxType.TabIndex = 52;
            // 
            // FrmSubTypeMaintenance
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(462, 381);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.CbxType);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.CbxCategory);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtSubTypeId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDescription);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSubTypeMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSubTypeMaintenance";
            this.Load += new System.EventHandler(this.FrmSubTypeMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCategory;
        public System.Windows.Forms.ComboBox CbxCategory;
        private System.Windows.Forms.Label LblDescription;
        public System.Windows.Forms.TextBox TxtSubTypeId;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblType;
        public System.Windows.Forms.ComboBox CbxType;
    }
}