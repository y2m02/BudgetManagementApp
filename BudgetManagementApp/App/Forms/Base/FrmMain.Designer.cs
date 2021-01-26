
namespace BudgetManagementApp.Forms.Base
{
    partial class FrmMain
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
            this.BtnSubtypes = new System.Windows.Forms.Button();
            this.BtnTypes = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.BtnProjects = new System.Windows.Forms.Button();
            this.BtnBudgetManagement = new System.Windows.Forms.Button();
            this.TclBudgetManagement = new System.Windows.Forms.TabControl();
            this.TabBudgetManagement = new System.Windows.Forms.TabPage();
            this.PnlInformation = new System.Windows.Forms.Panel();
            this.BtnCancelGeneralInfo = new System.Windows.Forms.Button();
            this.BtnModifyGeneralInfo = new System.Windows.Forms.Button();
            this.BtnSaveGeneralInfo = new System.Windows.Forms.Button();
            this.PnlGender = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.RbtMale = new System.Windows.Forms.RadioButton();
            this.RbtFemale = new System.Windows.Forms.RadioButton();
            this.DtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TabProjects = new System.Windows.Forms.TabPage();
            this.TabCategories = new System.Windows.Forms.TabPage();
            this.TxtCategoryId = new System.Windows.Forms.TextBox();
            this.LblCategoryFilter = new System.Windows.Forms.Label();
            this.BtnDeleteCategory = new System.Windows.Forms.Button();
            this.BtnModifyCategory = new System.Windows.Forms.Button();
            this.BtnNewCategory = new System.Windows.Forms.Button();
            this.TxtCategoryFilter = new System.Windows.Forms.TextBox();
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.LblCategoryDescription = new System.Windows.Forms.Label();
            this.TxtCategoryDescription = new System.Windows.Forms.TextBox();
            this.TabTypes = new System.Windows.Forms.TabPage();
            this.TabSubtypes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPatientNameInvoice = new System.Windows.Forms.Label();
            this.MsMainMenu = new System.Windows.Forms.MenuStrip();
            this.MiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MiLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.MiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtTypeId = new System.Windows.Forms.TextBox();
            this.LblTypeFilter = new System.Windows.Forms.Label();
            this.BtnDeleteType = new System.Windows.Forms.Button();
            this.BtnModifyType = new System.Windows.Forms.Button();
            this.BtnNewType = new System.Windows.Forms.Button();
            this.TxtTypeFilter = new System.Windows.Forms.TextBox();
            this.DgvTypes = new System.Windows.Forms.DataGridView();
            this.LblTypeCategory = new System.Windows.Forms.Label();
            this.TxtTypeCategory = new System.Windows.Forms.TextBox();
            this.LblTypeDescription = new System.Windows.Forms.Label();
            this.TxtTypeDescription = new System.Windows.Forms.TextBox();
            this.TxtTypeCategoryId = new System.Windows.Forms.TextBox();
            this.TclBudgetManagement.SuspendLayout();
            this.TabBudgetManagement.SuspendLayout();
            this.PnlInformation.SuspendLayout();
            this.PnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.TabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.TabTypes.SuspendLayout();
            this.TabSubtypes.SuspendLayout();
            this.MsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSubtypes
            // 
            this.BtnSubtypes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSubtypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubtypes.Location = new System.Drawing.Point(0, 324);
            this.BtnSubtypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubtypes.Name = "BtnSubtypes";
            this.BtnSubtypes.Size = new System.Drawing.Size(253, 74);
            this.BtnSubtypes.TabIndex = 11;
            this.BtnSubtypes.Text = "Sub-partidas";
            this.BtnSubtypes.UseVisualStyleBackColor = false;
            this.BtnSubtypes.Click += new System.EventHandler(this.BtnSubtypes_Click);
            // 
            // BtnTypes
            // 
            this.BtnTypes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTypes.Location = new System.Drawing.Point(0, 250);
            this.BtnTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTypes.Name = "BtnTypes";
            this.BtnTypes.Size = new System.Drawing.Size(253, 74);
            this.BtnTypes.TabIndex = 10;
            this.BtnTypes.Text = "Partidas";
            this.BtnTypes.UseVisualStyleBackColor = false;
            this.BtnTypes.Click += new System.EventHandler(this.BtnTypes_Click);
            // 
            // BtnCategories
            // 
            this.BtnCategories.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategories.Location = new System.Drawing.Point(0, 176);
            this.BtnCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Size = new System.Drawing.Size(253, 74);
            this.BtnCategories.TabIndex = 9;
            this.BtnCategories.Text = "Categorías";
            this.BtnCategories.UseVisualStyleBackColor = false;
            this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // BtnProjects
            // 
            this.BtnProjects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProjects.Location = new System.Drawing.Point(0, 102);
            this.BtnProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProjects.Name = "BtnProjects";
            this.BtnProjects.Size = new System.Drawing.Size(253, 74);
            this.BtnProjects.TabIndex = 8;
            this.BtnProjects.Text = "Proyectos";
            this.BtnProjects.UseVisualStyleBackColor = false;
            this.BtnProjects.Click += new System.EventHandler(this.BtnProjects_Click);
            // 
            // BtnBudgetManagement
            // 
            this.BtnBudgetManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBudgetManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBudgetManagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBudgetManagement.Location = new System.Drawing.Point(0, 28);
            this.BtnBudgetManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBudgetManagement.Name = "BtnBudgetManagement";
            this.BtnBudgetManagement.Size = new System.Drawing.Size(253, 74);
            this.BtnBudgetManagement.TabIndex = 7;
            this.BtnBudgetManagement.Text = "Control de presupesto";
            this.BtnBudgetManagement.UseVisualStyleBackColor = false;
            this.BtnBudgetManagement.Click += new System.EventHandler(this.BtnBudgetManagement_Click);
            // 
            // TclBudgetManagement
            // 
            this.TclBudgetManagement.Controls.Add(this.TabBudgetManagement);
            this.TclBudgetManagement.Controls.Add(this.TabProjects);
            this.TclBudgetManagement.Controls.Add(this.TabCategories);
            this.TclBudgetManagement.Controls.Add(this.TabTypes);
            this.TclBudgetManagement.Controls.Add(this.TabSubtypes);
            this.TclBudgetManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.TclBudgetManagement.Location = new System.Drawing.Point(253, 28);
            this.TclBudgetManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TclBudgetManagement.Name = "TclBudgetManagement";
            this.TclBudgetManagement.SelectedIndex = 0;
            this.TclBudgetManagement.Size = new System.Drawing.Size(1244, 876);
            this.TclBudgetManagement.TabIndex = 13;
            this.TclBudgetManagement.Click += new System.EventHandler(this.TclBudgetManagement_Click);
            // 
            // TabBudgetManagement
            // 
            this.TabBudgetManagement.BackColor = System.Drawing.SystemColors.Control;
            this.TabBudgetManagement.Controls.Add(this.PnlInformation);
            this.TabBudgetManagement.Location = new System.Drawing.Point(4, 28);
            this.TabBudgetManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabBudgetManagement.Name = "TabBudgetManagement";
            this.TabBudgetManagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabBudgetManagement.Size = new System.Drawing.Size(1236, 844);
            this.TabBudgetManagement.TabIndex = 0;
            this.TabBudgetManagement.Text = "Control de presupuesto";
            // 
            // PnlInformation
            // 
            this.PnlInformation.Controls.Add(this.BtnCancelGeneralInfo);
            this.PnlInformation.Controls.Add(this.BtnModifyGeneralInfo);
            this.PnlInformation.Controls.Add(this.BtnSaveGeneralInfo);
            this.PnlInformation.Controls.Add(this.PnlGender);
            this.PnlInformation.Controls.Add(this.DtpAdmissionDate);
            this.PnlInformation.Controls.Add(this.DtpBirthDate);
            this.PnlInformation.Controls.Add(this.NudAge);
            this.PnlInformation.Controls.Add(this.label9);
            this.PnlInformation.Controls.Add(this.label8);
            this.PnlInformation.Controls.Add(this.label3);
            this.PnlInformation.Controls.Add(this.label1);
            this.PnlInformation.Controls.Add(this.TxtName);
            this.PnlInformation.Location = new System.Drawing.Point(8, 18);
            this.PnlInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlInformation.Name = "PnlInformation";
            this.PnlInformation.Size = new System.Drawing.Size(1365, 701);
            this.PnlInformation.TabIndex = 31;
            // 
            // BtnCancelGeneralInfo
            // 
            this.BtnCancelGeneralInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelGeneralInfo.Location = new System.Drawing.Point(1088, 83);
            this.BtnCancelGeneralInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelGeneralInfo.Name = "BtnCancelGeneralInfo";
            this.BtnCancelGeneralInfo.Size = new System.Drawing.Size(124, 62);
            this.BtnCancelGeneralInfo.TabIndex = 38;
            this.BtnCancelGeneralInfo.Text = "Cancelar";
            this.BtnCancelGeneralInfo.UseVisualStyleBackColor = true;
            // 
            // BtnModifyGeneralInfo
            // 
            this.BtnModifyGeneralInfo.Location = new System.Drawing.Point(1088, 158);
            this.BtnModifyGeneralInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnModifyGeneralInfo.Name = "BtnModifyGeneralInfo";
            this.BtnModifyGeneralInfo.Size = new System.Drawing.Size(124, 62);
            this.BtnModifyGeneralInfo.TabIndex = 35;
            this.BtnModifyGeneralInfo.Text = "Modificar";
            this.BtnModifyGeneralInfo.UseVisualStyleBackColor = true;
            // 
            // BtnSaveGeneralInfo
            // 
            this.BtnSaveGeneralInfo.Location = new System.Drawing.Point(1088, 14);
            this.BtnSaveGeneralInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSaveGeneralInfo.Name = "BtnSaveGeneralInfo";
            this.BtnSaveGeneralInfo.Size = new System.Drawing.Size(124, 62);
            this.BtnSaveGeneralInfo.TabIndex = 35;
            this.BtnSaveGeneralInfo.Text = "Guardar";
            this.BtnSaveGeneralInfo.UseVisualStyleBackColor = true;
            this.BtnSaveGeneralInfo.Visible = false;
            // 
            // PnlGender
            // 
            this.PnlGender.Controls.Add(this.label12);
            this.PnlGender.Controls.Add(this.RbtMale);
            this.PnlGender.Controls.Add(this.RbtFemale);
            this.PnlGender.Location = new System.Drawing.Point(4, 172);
            this.PnlGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGender.Name = "PnlGender";
            this.PnlGender.Size = new System.Drawing.Size(306, 81);
            this.PnlGender.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Género";
            // 
            // RbtMale
            // 
            this.RbtMale.AutoCheck = false;
            this.RbtMale.AutoSize = true;
            this.RbtMale.Checked = true;
            this.RbtMale.Location = new System.Drawing.Point(9, 40);
            this.RbtMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtMale.Name = "RbtMale";
            this.RbtMale.Size = new System.Drawing.Size(103, 23);
            this.RbtMale.TabIndex = 0;
            this.RbtMale.TabStop = true;
            this.RbtMale.Text = "Masculino";
            this.RbtMale.UseVisualStyleBackColor = true;
            // 
            // RbtFemale
            // 
            this.RbtFemale.AutoCheck = false;
            this.RbtFemale.AutoSize = true;
            this.RbtFemale.Location = new System.Drawing.Point(158, 40);
            this.RbtFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtFemale.Name = "RbtFemale";
            this.RbtFemale.Size = new System.Drawing.Size(102, 23);
            this.RbtFemale.TabIndex = 1;
            this.RbtFemale.Text = "Femenino";
            this.RbtFemale.UseVisualStyleBackColor = true;
            // 
            // DtpAdmissionDate
            // 
            this.DtpAdmissionDate.CustomFormat = "dd/MM/yyyy";
            this.DtpAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAdmissionDate.Location = new System.Drawing.Point(544, 50);
            this.DtpAdmissionDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpAdmissionDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DtpAdmissionDate.Name = "DtpAdmissionDate";
            this.DtpAdmissionDate.Size = new System.Drawing.Size(508, 27);
            this.DtpAdmissionDate.TabIndex = 24;
            this.DtpAdmissionDate.Visible = false;
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.DtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpBirthDate.Location = new System.Drawing.Point(6, 292);
            this.DtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpBirthDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(508, 27);
            this.DtpBirthDate.TabIndex = 20;
            this.DtpBirthDate.Visible = false;
            // 
            // NudAge
            // 
            this.NudAge.Location = new System.Drawing.Point(6, 370);
            this.NudAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NudAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(508, 27);
            this.NudAge.TabIndex = 21;
            this.NudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAge.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 338);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha de registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(9, 50);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtName.MaxLength = 99;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(511, 27);
            this.TxtName.TabIndex = 17;
            // 
            // TabProjects
            // 
            this.TabProjects.BackColor = System.Drawing.SystemColors.Control;
            this.TabProjects.Location = new System.Drawing.Point(4, 28);
            this.TabProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProjects.Name = "TabProjects";
            this.TabProjects.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProjects.Size = new System.Drawing.Size(1236, 842);
            this.TabProjects.TabIndex = 1;
            this.TabProjects.Text = "Proyectos";
            // 
            // TabCategories
            // 
            this.TabCategories.BackColor = System.Drawing.SystemColors.Control;
            this.TabCategories.Controls.Add(this.TxtCategoryId);
            this.TabCategories.Controls.Add(this.LblCategoryFilter);
            this.TabCategories.Controls.Add(this.BtnDeleteCategory);
            this.TabCategories.Controls.Add(this.BtnModifyCategory);
            this.TabCategories.Controls.Add(this.BtnNewCategory);
            this.TabCategories.Controls.Add(this.TxtCategoryFilter);
            this.TabCategories.Controls.Add(this.DgvCategories);
            this.TabCategories.Controls.Add(this.LblCategoryDescription);
            this.TabCategories.Controls.Add(this.TxtCategoryDescription);
            this.TabCategories.Location = new System.Drawing.Point(4, 28);
            this.TabCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabCategories.Name = "TabCategories";
            this.TabCategories.Size = new System.Drawing.Size(1236, 844);
            this.TabCategories.TabIndex = 2;
            this.TabCategories.Text = "Categorías";
            // 
            // TxtCategoryId
            // 
            this.TxtCategoryId.Location = new System.Drawing.Point(278, 22);
            this.TxtCategoryId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtCategoryId.MaxLength = 99;
            this.TxtCategoryId.Name = "TxtCategoryId";
            this.TxtCategoryId.ReadOnly = true;
            this.TxtCategoryId.Size = new System.Drawing.Size(30, 27);
            this.TxtCategoryId.TabIndex = 37;
            this.TxtCategoryId.Visible = false;
            // 
            // LblCategoryFilter
            // 
            this.LblCategoryFilter.AutoSize = true;
            this.LblCategoryFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryFilter.Location = new System.Drawing.Point(398, 111);
            this.LblCategoryFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoryFilter.Name = "LblCategoryFilter";
            this.LblCategoryFilter.Size = new System.Drawing.Size(77, 24);
            this.LblCategoryFilter.TabIndex = 34;
            this.LblCategoryFilter.Text = "Buscar";
            this.LblCategoryFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDeleteCategory
            // 
            this.BtnDeleteCategory.Enabled = false;
            this.BtnDeleteCategory.Location = new System.Drawing.Point(569, 37);
            this.BtnDeleteCategory.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteCategory.Name = "BtnDeleteCategory";
            this.BtnDeleteCategory.Size = new System.Drawing.Size(116, 44);
            this.BtnDeleteCategory.TabIndex = 33;
            this.BtnDeleteCategory.Text = "Eliminar";
            this.BtnDeleteCategory.UseVisualStyleBackColor = true;
            this.BtnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategory_Click);
            // 
            // BtnModifyCategory
            // 
            this.BtnModifyCategory.Enabled = false;
            this.BtnModifyCategory.Location = new System.Drawing.Point(451, 37);
            this.BtnModifyCategory.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifyCategory.Name = "BtnModifyCategory";
            this.BtnModifyCategory.Size = new System.Drawing.Size(116, 44);
            this.BtnModifyCategory.TabIndex = 32;
            this.BtnModifyCategory.Text = "Modificar";
            this.BtnModifyCategory.UseVisualStyleBackColor = true;
            this.BtnModifyCategory.Click += new System.EventHandler(this.BtnModifyCategory_Click);
            // 
            // BtnNewCategory
            // 
            this.BtnNewCategory.Location = new System.Drawing.Point(333, 37);
            this.BtnNewCategory.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNewCategory.Name = "BtnNewCategory";
            this.BtnNewCategory.Size = new System.Drawing.Size(116, 44);
            this.BtnNewCategory.TabIndex = 31;
            this.BtnNewCategory.Text = "Nuevo";
            this.BtnNewCategory.UseVisualStyleBackColor = true;
            this.BtnNewCategory.Click += new System.EventHandler(this.BtnNewCategory_Click);
            // 
            // TxtCategoryFilter
            // 
            this.TxtCategoryFilter.Location = new System.Drawing.Point(483, 108);
            this.TxtCategoryFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoryFilter.MaxLength = 99;
            this.TxtCategoryFilter.Name = "TxtCategoryFilter";
            this.TxtCategoryFilter.Size = new System.Drawing.Size(201, 27);
            this.TxtCategoryFilter.TabIndex = 29;
            this.TxtCategoryFilter.TextChanged += new System.EventHandler(this.TxtCategoryFilter_TextChanged);
            // 
            // DgvCategories
            // 
            this.DgvCategories.AllowUserToAddRows = false;
            this.DgvCategories.AllowUserToDeleteRows = false;
            this.DgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Location = new System.Drawing.Point(17, 145);
            this.DgvCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvCategories.MultiSelect = false;
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.ReadOnly = true;
            this.DgvCategories.RowHeadersVisible = false;
            this.DgvCategories.RowHeadersWidth = 51;
            this.DgvCategories.RowTemplate.Height = 24;
            this.DgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategories.Size = new System.Drawing.Size(667, 356);
            this.DgvCategories.TabIndex = 28;
            this.DgvCategories.SelectionChanged += new System.EventHandler(this.DgvCategories_SelectionChanged);
            // 
            // LblCategoryDescription
            // 
            this.LblCategoryDescription.AutoSize = true;
            this.LblCategoryDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoryDescription.Location = new System.Drawing.Point(13, 22);
            this.LblCategoryDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoryDescription.Name = "LblCategoryDescription";
            this.LblCategoryDescription.Size = new System.Drawing.Size(122, 24);
            this.LblCategoryDescription.TabIndex = 27;
            this.LblCategoryDescription.Text = "Descripción";
            // 
            // TxtCategoryDescription
            // 
            this.TxtCategoryDescription.Location = new System.Drawing.Point(18, 54);
            this.TxtCategoryDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoryDescription.MaxLength = 99;
            this.TxtCategoryDescription.Name = "TxtCategoryDescription";
            this.TxtCategoryDescription.ReadOnly = true;
            this.TxtCategoryDescription.Size = new System.Drawing.Size(290, 27);
            this.TxtCategoryDescription.TabIndex = 26;
            // 
            // TabTypes
            // 
            this.TabTypes.BackColor = System.Drawing.SystemColors.Control;
            this.TabTypes.Controls.Add(this.TxtTypeCategoryId);
            this.TabTypes.Controls.Add(this.LblTypeDescription);
            this.TabTypes.Controls.Add(this.TxtTypeDescription);
            this.TabTypes.Controls.Add(this.TxtTypeId);
            this.TabTypes.Controls.Add(this.LblTypeFilter);
            this.TabTypes.Controls.Add(this.BtnDeleteType);
            this.TabTypes.Controls.Add(this.BtnModifyType);
            this.TabTypes.Controls.Add(this.BtnNewType);
            this.TabTypes.Controls.Add(this.TxtTypeFilter);
            this.TabTypes.Controls.Add(this.DgvTypes);
            this.TabTypes.Controls.Add(this.LblTypeCategory);
            this.TabTypes.Controls.Add(this.TxtTypeCategory);
            this.TabTypes.Location = new System.Drawing.Point(4, 28);
            this.TabTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Size = new System.Drawing.Size(1236, 844);
            this.TabTypes.TabIndex = 3;
            this.TabTypes.Text = "Partidas";
            // 
            // TabSubtypes
            // 
            this.TabSubtypes.BackColor = System.Drawing.SystemColors.Control;
            this.TabSubtypes.Controls.Add(this.panel1);
            this.TabSubtypes.Controls.Add(this.LblPatientNameInvoice);
            this.TabSubtypes.Location = new System.Drawing.Point(4, 28);
            this.TabSubtypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabSubtypes.Name = "TabSubtypes";
            this.TabSubtypes.Size = new System.Drawing.Size(1236, 842);
            this.TabSubtypes.TabIndex = 4;
            this.TabSubtypes.Text = "Sub-partidas";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 734);
            this.panel1.TabIndex = 35;
            // 
            // LblPatientNameInvoice
            // 
            this.LblPatientNameInvoice.AutoSize = true;
            this.LblPatientNameInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientNameInvoice.Location = new System.Drawing.Point(8, 7);
            this.LblPatientNameInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPatientNameInvoice.Name = "LblPatientNameInvoice";
            this.LblPatientNameInvoice.Size = new System.Drawing.Size(204, 24);
            this.LblPatientNameInvoice.TabIndex = 34;
            this.LblPatientNameInvoice.Text = "Nombre del paciente";
            // 
            // MsMainMenu
            // 
            this.MsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiFile,
            this.MiLanguages});
            this.MsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMainMenu.Name = "MsMainMenu";
            this.MsMainMenu.Size = new System.Drawing.Size(1497, 28);
            this.MsMainMenu.TabIndex = 15;
            this.MsMainMenu.Text = "menuStrip1";
            // 
            // MiFile
            // 
            this.MiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiClose});
            this.MiFile.Name = "MiFile";
            this.MiFile.Size = new System.Drawing.Size(73, 24);
            this.MiFile.Text = "Archivo";
            // 
            // MiClose
            // 
            this.MiClose.Name = "MiClose";
            this.MiClose.Size = new System.Drawing.Size(121, 26);
            this.MiClose.Text = "Salir";
            this.MiClose.Click += new System.EventHandler(this.MiClose_Click);
            // 
            // MiLanguages
            // 
            this.MiLanguages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiSpanish,
            this.MiEnglish});
            this.MiLanguages.Name = "MiLanguages";
            this.MiLanguages.Size = new System.Drawing.Size(76, 24);
            this.MiLanguages.Text = "Idiomas";
            // 
            // MiSpanish
            // 
            this.MiSpanish.Name = "MiSpanish";
            this.MiSpanish.Size = new System.Drawing.Size(144, 26);
            this.MiSpanish.Text = "Español";
            this.MiSpanish.Click += new System.EventHandler(this.MiSpanish_Click);
            // 
            // MiEnglish
            // 
            this.MiEnglish.Name = "MiEnglish";
            this.MiEnglish.Size = new System.Drawing.Size(144, 26);
            this.MiEnglish.Text = "Inglés";
            this.MiEnglish.Click += new System.EventHandler(this.MiEnglish_Click);
            // 
            // TxtTypeId
            // 
            this.TxtTypeId.Location = new System.Drawing.Point(281, 97);
            this.TxtTypeId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtTypeId.MaxLength = 99;
            this.TxtTypeId.Name = "TxtTypeId";
            this.TxtTypeId.ReadOnly = true;
            this.TxtTypeId.Size = new System.Drawing.Size(30, 27);
            this.TxtTypeId.TabIndex = 46;
            this.TxtTypeId.Visible = false;
            // 
            // LblTypeFilter
            // 
            this.LblTypeFilter.AutoSize = true;
            this.LblTypeFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeFilter.Location = new System.Drawing.Point(401, 133);
            this.LblTypeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTypeFilter.Name = "LblTypeFilter";
            this.LblTypeFilter.Size = new System.Drawing.Size(77, 24);
            this.LblTypeFilter.TabIndex = 45;
            this.LblTypeFilter.Text = "Buscar";
            this.LblTypeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDeleteType
            // 
            this.BtnDeleteType.Enabled = false;
            this.BtnDeleteType.Location = new System.Drawing.Point(572, 37);
            this.BtnDeleteType.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteType.Name = "BtnDeleteType";
            this.BtnDeleteType.Size = new System.Drawing.Size(116, 44);
            this.BtnDeleteType.TabIndex = 44;
            this.BtnDeleteType.Text = "Eliminar";
            this.BtnDeleteType.UseVisualStyleBackColor = true;
            this.BtnDeleteType.Click += new System.EventHandler(this.BtnDeleteType_Click);
            // 
            // BtnModifyType
            // 
            this.BtnModifyType.Enabled = false;
            this.BtnModifyType.Location = new System.Drawing.Point(454, 37);
            this.BtnModifyType.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifyType.Name = "BtnModifyType";
            this.BtnModifyType.Size = new System.Drawing.Size(116, 44);
            this.BtnModifyType.TabIndex = 43;
            this.BtnModifyType.Text = "Modificar";
            this.BtnModifyType.UseVisualStyleBackColor = true;
            this.BtnModifyType.Click += new System.EventHandler(this.BtnModifyType_Click);
            // 
            // BtnNewType
            // 
            this.BtnNewType.Location = new System.Drawing.Point(336, 37);
            this.BtnNewType.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNewType.Name = "BtnNewType";
            this.BtnNewType.Size = new System.Drawing.Size(116, 44);
            this.BtnNewType.TabIndex = 42;
            this.BtnNewType.Text = "Nuevo";
            this.BtnNewType.UseVisualStyleBackColor = true;
            this.BtnNewType.Click += new System.EventHandler(this.BtnNewType_Click);
            // 
            // TxtTypeFilter
            // 
            this.TxtTypeFilter.Location = new System.Drawing.Point(486, 130);
            this.TxtTypeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTypeFilter.MaxLength = 99;
            this.TxtTypeFilter.Name = "TxtTypeFilter";
            this.TxtTypeFilter.Size = new System.Drawing.Size(201, 27);
            this.TxtTypeFilter.TabIndex = 41;
            this.TxtTypeFilter.TextChanged += new System.EventHandler(this.TxtTypeFilter_TextChanged);
            // 
            // DgvTypes
            // 
            this.DgvTypes.AllowUserToAddRows = false;
            this.DgvTypes.AllowUserToDeleteRows = false;
            this.DgvTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTypes.Location = new System.Drawing.Point(21, 179);
            this.DgvTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvTypes.MultiSelect = false;
            this.DgvTypes.Name = "DgvTypes";
            this.DgvTypes.ReadOnly = true;
            this.DgvTypes.RowHeadersVisible = false;
            this.DgvTypes.RowHeadersWidth = 51;
            this.DgvTypes.RowTemplate.Height = 24;
            this.DgvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTypes.Size = new System.Drawing.Size(667, 356);
            this.DgvTypes.TabIndex = 40;
            this.DgvTypes.SelectionChanged += new System.EventHandler(this.DgvTypes_SelectionChanged);
            // 
            // LblTypeCategory
            // 
            this.LblTypeCategory.AutoSize = true;
            this.LblTypeCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeCategory.Location = new System.Drawing.Point(16, 22);
            this.LblTypeCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTypeCategory.Name = "LblTypeCategory";
            this.LblTypeCategory.Size = new System.Drawing.Size(102, 24);
            this.LblTypeCategory.TabIndex = 39;
            this.LblTypeCategory.Text = "Categoría";
            // 
            // TxtTypeCategory
            // 
            this.TxtTypeCategory.Location = new System.Drawing.Point(21, 54);
            this.TxtTypeCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTypeCategory.MaxLength = 99;
            this.TxtTypeCategory.Name = "TxtTypeCategory";
            this.TxtTypeCategory.ReadOnly = true;
            this.TxtTypeCategory.Size = new System.Drawing.Size(290, 27);
            this.TxtTypeCategory.TabIndex = 38;
            // 
            // LblTypeDescription
            // 
            this.LblTypeDescription.AutoSize = true;
            this.LblTypeDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeDescription.Location = new System.Drawing.Point(16, 96);
            this.LblTypeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTypeDescription.Name = "LblTypeDescription";
            this.LblTypeDescription.Size = new System.Drawing.Size(122, 24);
            this.LblTypeDescription.TabIndex = 48;
            this.LblTypeDescription.Text = "Descripción";
            // 
            // TxtTypeDescription
            // 
            this.TxtTypeDescription.Location = new System.Drawing.Point(21, 128);
            this.TxtTypeDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTypeDescription.MaxLength = 99;
            this.TxtTypeDescription.Name = "TxtTypeDescription";
            this.TxtTypeDescription.ReadOnly = true;
            this.TxtTypeDescription.Size = new System.Drawing.Size(290, 27);
            this.TxtTypeDescription.TabIndex = 47;
            // 
            // TxtTypeCategoryId
            // 
            this.TxtTypeCategoryId.Location = new System.Drawing.Point(281, 23);
            this.TxtTypeCategoryId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtTypeCategoryId.MaxLength = 99;
            this.TxtTypeCategoryId.Name = "TxtTypeCategoryId";
            this.TxtTypeCategoryId.ReadOnly = true;
            this.TxtTypeCategoryId.Size = new System.Drawing.Size(30, 27);
            this.TxtTypeCategoryId.TabIndex = 49;
            this.TxtTypeCategoryId.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 904);
            this.Controls.Add(this.BtnSubtypes);
            this.Controls.Add(this.BtnTypes);
            this.Controls.Add(this.BtnCategories);
            this.Controls.Add(this.BtnProjects);
            this.Controls.Add(this.BtnBudgetManagement);
            this.Controls.Add(this.TclBudgetManagement);
            this.Controls.Add(this.MsMainMenu);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MsMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TclBudgetManagement.ResumeLayout(false);
            this.TabBudgetManagement.ResumeLayout(false);
            this.PnlInformation.ResumeLayout(false);
            this.PnlInformation.PerformLayout();
            this.PnlGender.ResumeLayout(false);
            this.PnlGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.TabCategories.ResumeLayout(false);
            this.TabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            this.TabSubtypes.ResumeLayout(false);
            this.TabSubtypes.PerformLayout();
            this.MsMainMenu.ResumeLayout(false);
            this.MsMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSubtypes;
        private System.Windows.Forms.Button BtnTypes;
        private System.Windows.Forms.Button BtnCategories;
        private System.Windows.Forms.Button BtnProjects;
        private System.Windows.Forms.Button BtnBudgetManagement;
        private System.Windows.Forms.TabControl TclBudgetManagement;
        private System.Windows.Forms.TabPage TabBudgetManagement;
        private System.Windows.Forms.Panel PnlInformation;
        private System.Windows.Forms.Button BtnCancelGeneralInfo;
        private System.Windows.Forms.Button BtnModifyGeneralInfo;
        private System.Windows.Forms.Button BtnSaveGeneralInfo;
        private System.Windows.Forms.Panel PnlGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton RbtMale;
        private System.Windows.Forms.RadioButton RbtFemale;
        private System.Windows.Forms.DateTimePicker DtpAdmissionDate;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.NumericUpDown NudAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TabPage TabProjects;
        private System.Windows.Forms.TabPage TabCategories;
        private System.Windows.Forms.TabPage TabTypes;
        private System.Windows.Forms.TabPage TabSubtypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPatientNameInvoice;
        private System.Windows.Forms.Label LblCategoryDescription;
        private System.Windows.Forms.TextBox TxtCategoryDescription;
        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.TextBox TxtCategoryFilter;
        private System.Windows.Forms.Button BtnDeleteCategory;
        private System.Windows.Forms.Button BtnModifyCategory;
        private System.Windows.Forms.Button BtnNewCategory;
        private System.Windows.Forms.Label LblCategoryFilter;
        public System.Windows.Forms.TextBox TxtCategoryId;
        private System.Windows.Forms.MenuStrip MsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MiFile;
        private System.Windows.Forms.ToolStripMenuItem MiClose;
        private System.Windows.Forms.ToolStripMenuItem MiLanguages;
        private System.Windows.Forms.ToolStripMenuItem MiSpanish;
        private System.Windows.Forms.ToolStripMenuItem MiEnglish;
        private System.Windows.Forms.Label LblTypeDescription;
        private System.Windows.Forms.TextBox TxtTypeDescription;
        public System.Windows.Forms.TextBox TxtTypeId;
        private System.Windows.Forms.Label LblTypeFilter;
        private System.Windows.Forms.Button BtnDeleteType;
        private System.Windows.Forms.Button BtnModifyType;
        private System.Windows.Forms.Button BtnNewType;
        private System.Windows.Forms.TextBox TxtTypeFilter;
        private System.Windows.Forms.DataGridView DgvTypes;
        private System.Windows.Forms.Label LblTypeCategory;
        private System.Windows.Forms.TextBox TxtTypeCategory;
        public System.Windows.Forms.TextBox TxtTypeCategoryId;
    }
}