
namespace BudgetManagementApp.Forms.AccountingMovements
{
    partial class FrmAccountingMovementMaintenance
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
            this.LblType = new System.Windows.Forms.Label();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.LblAmount = new System.Windows.Forms.Label();
            this.TxtAccountingMovementId = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.LblSubType = new System.Windows.Forms.Label();
            this.CbxSubType = new System.Windows.Forms.ComboBox();
            this.LblComment = new System.Windows.Forms.Label();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(13, 190);
            this.LblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(90, 24);
            this.LblType.TabIndex = 62;
            this.LblType.Text = "Sub-tipo";
            // 
            // CbxType
            // 
            this.CbxType.BackColor = System.Drawing.SystemColors.Window;
            this.CbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxType.Location = new System.Drawing.Point(18, 226);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(317, 27);
            this.CbxType.Sorted = true;
            this.CbxType.TabIndex = 61;
            this.CbxType.SelectedIndexChanged += new System.EventHandler(this.CbxType_SelectedIndexChanged);
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(13, 104);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(102, 24);
            this.LblCategory.TabIndex = 60;
            this.LblCategory.Text = "Categoría";
            // 
            // CbxCategory
            // 
            this.CbxCategory.BackColor = System.Drawing.SystemColors.Window;
            this.CbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxCategory.Location = new System.Drawing.Point(18, 140);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(317, 27);
            this.CbxCategory.Sorted = true;
            this.CbxCategory.TabIndex = 59;
            this.CbxCategory.SelectedIndexChanged += new System.EventHandler(this.CbxCategory_SelectedIndexChanged);
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.Location = new System.Drawing.Point(378, 9);
            this.LblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(94, 24);
            this.LblAmount.TabIndex = 58;
            this.LblAmount.Text = "Cantidad";
            // 
            // TxtAccountingMovementId
            // 
            this.TxtAccountingMovementId.Location = new System.Drawing.Point(300, 10);
            this.TxtAccountingMovementId.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtAccountingMovementId.MaxLength = 99;
            this.TxtAccountingMovementId.Name = "TxtAccountingMovementId";
            this.TxtAccountingMovementId.ReadOnly = true;
            this.TxtAccountingMovementId.Size = new System.Drawing.Size(33, 27);
            this.TxtAccountingMovementId.TabIndex = 57;
            this.TxtAccountingMovementId.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(363, 356);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(146, 62);
            this.BtnCancel.TabIndex = 56;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(214, 356);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(146, 62);
            this.BtnSave.TabIndex = 55;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(382, 51);
            this.TxtAmount.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtAmount.MaxLength = 99;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(318, 27);
            this.TxtAmount.TabIndex = 54;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(13, 9);
            this.LblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(67, 24);
            this.LblDate.TabIndex = 64;
            this.LblDate.Text = "Fecha";
            // 
            // DtpDate
            // 
            this.DtpDate.CustomFormat = "dd/MM/yyyy";
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate.Location = new System.Drawing.Point(17, 51);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(318, 27);
            this.DtpDate.TabIndex = 63;
            // 
            // LblSubType
            // 
            this.LblSubType.AutoSize = true;
            this.LblSubType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubType.Location = new System.Drawing.Point(13, 271);
            this.LblSubType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSubType.Name = "LblSubType";
            this.LblSubType.Size = new System.Drawing.Size(52, 24);
            this.LblSubType.TabIndex = 66;
            this.LblSubType.Text = "Tipo";
            // 
            // CbxSubType
            // 
            this.CbxSubType.BackColor = System.Drawing.SystemColors.Window;
            this.CbxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSubType.FormattingEnabled = true;
            this.CbxSubType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxSubType.Location = new System.Drawing.Point(18, 307);
            this.CbxSubType.Name = "CbxSubType";
            this.CbxSubType.Size = new System.Drawing.Size(317, 27);
            this.CbxSubType.Sorted = true;
            this.CbxSubType.TabIndex = 65;
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComment.Location = new System.Drawing.Point(378, 104);
            this.LblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(130, 24);
            this.LblComment.TabIndex = 68;
            this.LblComment.Text = "Comentarios";
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(382, 146);
            this.TxtComment.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtComment.MaxLength = 99;
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(318, 188);
            this.TxtComment.TabIndex = 67;
            // 
            // FrmAccountingMovementMaintenance
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(719, 426);
            this.Controls.Add(this.LblComment);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.LblSubType);
            this.Controls.Add(this.CbxSubType);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.CbxType);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.CbxCategory);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.TxtAccountingMovementId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtAmount);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAccountingMovementMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccountingMovementMaintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAccountingMovementMaintenance_FormClosing);
            this.Load += new System.EventHandler(this.FrmAccountingMovementMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblSubType;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.ComboBox CbxType;
        private System.Windows.Forms.ComboBox CbxCategory;
        private System.Windows.Forms.TextBox TxtAccountingMovementId;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.ComboBox CbxSubType;
        private System.Windows.Forms.TextBox TxtComment;
    }
}