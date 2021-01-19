
namespace BudgetManagementApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSubtypes = new System.Windows.Forms.Button();
            this.BtnTypes = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.BtnProjects = new System.Windows.Forms.Button();
            this.BtnBudgetManagement = new System.Windows.Forms.Button();
            this.TclBudgetManagement = new System.Windows.Forms.TabControl();
            this.TabProjects = new System.Windows.Forms.TabPage();
            this.TabCategories = new System.Windows.Forms.TabPage();
            this.TabTypes = new System.Windows.Forms.TabPage();
            this.LblPatientNameActivitiesPerformed = new System.Windows.Forms.Label();
            this.PnlActivitiesPerformed = new System.Windows.Forms.Panel();
            this.BtnDeleteActivity = new System.Windows.Forms.Button();
            this.BtnModifyActivity = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.DgvActivitiesList = new System.Windows.Forms.DataGridView();
            this.TabSubtypes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPatientNameInvoice = new System.Windows.Forms.Label();
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
            this.TclBudgetManagement.SuspendLayout();
            this.TabTypes.SuspendLayout();
            this.PnlActivitiesPerformed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivitiesList)).BeginInit();
            this.TabSubtypes.SuspendLayout();
            this.TabBudgetManagement.SuspendLayout();
            this.PnlInformation.SuspendLayout();
            this.PnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            // 
            // BtnSubtypes
            // 
            this.BtnSubtypes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSubtypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubtypes.Location = new System.Drawing.Point(0, 296);
            this.BtnSubtypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubtypes.Name = "BtnSubtypes";
            this.BtnSubtypes.Size = new System.Drawing.Size(253, 74);
            this.BtnSubtypes.TabIndex = 11;
            this.BtnSubtypes.Text = "Sub-partidas";
            this.BtnSubtypes.UseVisualStyleBackColor = false;
            // 
            // BtnTypes
            // 
            this.BtnTypes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTypes.Location = new System.Drawing.Point(0, 222);
            this.BtnTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTypes.Name = "BtnTypes";
            this.BtnTypes.Size = new System.Drawing.Size(253, 74);
            this.BtnTypes.TabIndex = 10;
            this.BtnTypes.Text = "Partidas";
            this.BtnTypes.UseVisualStyleBackColor = false;
            // 
            // BtnCategories
            // 
            this.BtnCategories.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCategories.Location = new System.Drawing.Point(0, 148);
            this.BtnCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Size = new System.Drawing.Size(253, 74);
            this.BtnCategories.TabIndex = 9;
            this.BtnCategories.Text = "Categorías";
            this.BtnCategories.UseVisualStyleBackColor = false;
            // 
            // BtnProjects
            // 
            this.BtnProjects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProjects.Location = new System.Drawing.Point(0, 74);
            this.BtnProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProjects.Name = "BtnProjects";
            this.BtnProjects.Size = new System.Drawing.Size(253, 74);
            this.BtnProjects.TabIndex = 8;
            this.BtnProjects.Text = "Proyectos";
            this.BtnProjects.UseVisualStyleBackColor = false;
            // 
            // BtnBudgetManagement
            // 
            this.BtnBudgetManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBudgetManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBudgetManagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBudgetManagement.Location = new System.Drawing.Point(0, 0);
            this.BtnBudgetManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBudgetManagement.Name = "BtnBudgetManagement";
            this.BtnBudgetManagement.Size = new System.Drawing.Size(253, 74);
            this.BtnBudgetManagement.TabIndex = 7;
            this.BtnBudgetManagement.Text = "Control de presupesto";
            this.BtnBudgetManagement.UseVisualStyleBackColor = false;
            // 
            // TclBudgetManagement
            // 
            this.TclBudgetManagement.Controls.Add(this.TabProjects);
            this.TclBudgetManagement.Controls.Add(this.TabCategories);
            this.TclBudgetManagement.Controls.Add(this.TabTypes);
            this.TclBudgetManagement.Controls.Add(this.TabSubtypes);
            this.TclBudgetManagement.Controls.Add(this.TabBudgetManagement);
            this.TclBudgetManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.TclBudgetManagement.Location = new System.Drawing.Point(253, 0);
            this.TclBudgetManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TclBudgetManagement.Name = "TclBudgetManagement";
            this.TclBudgetManagement.SelectedIndex = 0;
            this.TclBudgetManagement.Size = new System.Drawing.Size(1244, 904);
            this.TclBudgetManagement.TabIndex = 13;
            // 
            // TabProjects
            // 
            this.TabProjects.BackColor = System.Drawing.SystemColors.Control;
            this.TabProjects.Location = new System.Drawing.Point(4, 28);
            this.TabProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProjects.Name = "TabProjects";
            this.TabProjects.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProjects.Size = new System.Drawing.Size(1236, 872);
            this.TabProjects.TabIndex = 1;
            this.TabProjects.Text = "Proyectos";
            // 
            // TabCategories
            // 
            this.TabCategories.BackColor = System.Drawing.SystemColors.Control;
            this.TabCategories.Location = new System.Drawing.Point(4, 28);
            this.TabCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabCategories.Name = "TabCategories";
            this.TabCategories.Size = new System.Drawing.Size(1236, 872);
            this.TabCategories.TabIndex = 2;
            this.TabCategories.Text = "Categorías";
            // 
            // TabTypes
            // 
            this.TabTypes.BackColor = System.Drawing.SystemColors.Control;
            this.TabTypes.Controls.Add(this.LblPatientNameActivitiesPerformed);
            this.TabTypes.Controls.Add(this.PnlActivitiesPerformed);
            this.TabTypes.Location = new System.Drawing.Point(4, 28);
            this.TabTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Size = new System.Drawing.Size(1236, 872);
            this.TabTypes.TabIndex = 3;
            this.TabTypes.Text = "Partidas";
            // 
            // LblPatientNameActivitiesPerformed
            // 
            this.LblPatientNameActivitiesPerformed.AutoSize = true;
            this.LblPatientNameActivitiesPerformed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientNameActivitiesPerformed.Location = new System.Drawing.Point(8, 7);
            this.LblPatientNameActivitiesPerformed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPatientNameActivitiesPerformed.Name = "LblPatientNameActivitiesPerformed";
            this.LblPatientNameActivitiesPerformed.Size = new System.Drawing.Size(204, 24);
            this.LblPatientNameActivitiesPerformed.TabIndex = 33;
            this.LblPatientNameActivitiesPerformed.Text = "Nombre del paciente";
            // 
            // PnlActivitiesPerformed
            // 
            this.PnlActivitiesPerformed.Controls.Add(this.BtnDeleteActivity);
            this.PnlActivitiesPerformed.Controls.Add(this.BtnModifyActivity);
            this.PnlActivitiesPerformed.Controls.Add(this.btnAddActivity);
            this.PnlActivitiesPerformed.Controls.Add(this.DgvActivitiesList);
            this.PnlActivitiesPerformed.Location = new System.Drawing.Point(12, 36);
            this.PnlActivitiesPerformed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlActivitiesPerformed.Name = "PnlActivitiesPerformed";
            this.PnlActivitiesPerformed.Size = new System.Drawing.Size(1222, 734);
            this.PnlActivitiesPerformed.TabIndex = 32;
            // 
            // BtnDeleteActivity
            // 
            this.BtnDeleteActivity.Location = new System.Drawing.Point(381, 7);
            this.BtnDeleteActivity.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteActivity.Name = "BtnDeleteActivity";
            this.BtnDeleteActivity.Size = new System.Drawing.Size(188, 49);
            this.BtnDeleteActivity.TabIndex = 8;
            this.BtnDeleteActivity.Text = "Eliminar";
            this.BtnDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // BtnModifyActivity
            // 
            this.BtnModifyActivity.Location = new System.Drawing.Point(191, 7);
            this.BtnModifyActivity.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifyActivity.Name = "BtnModifyActivity";
            this.BtnModifyActivity.Size = new System.Drawing.Size(188, 49);
            this.BtnModifyActivity.TabIndex = 6;
            this.BtnModifyActivity.Text = "Modificar";
            this.BtnModifyActivity.UseVisualStyleBackColor = true;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(1, 7);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(188, 49);
            this.btnAddActivity.TabIndex = 5;
            this.btnAddActivity.Text = "Agregar";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            // 
            // DgvActivitiesList
            // 
            this.DgvActivitiesList.AllowUserToAddRows = false;
            this.DgvActivitiesList.AllowUserToDeleteRows = false;
            this.DgvActivitiesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvActivitiesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvActivitiesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActivitiesList.Location = new System.Drawing.Point(0, 62);
            this.DgvActivitiesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvActivitiesList.MultiSelect = false;
            this.DgvActivitiesList.Name = "DgvActivitiesList";
            this.DgvActivitiesList.ReadOnly = true;
            this.DgvActivitiesList.RowHeadersVisible = false;
            this.DgvActivitiesList.RowHeadersWidth = 51;
            this.DgvActivitiesList.RowTemplate.Height = 24;
            this.DgvActivitiesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvActivitiesList.Size = new System.Drawing.Size(598, 318);
            this.DgvActivitiesList.TabIndex = 9;
            // 
            // TabSubtypes
            // 
            this.TabSubtypes.BackColor = System.Drawing.SystemColors.Control;
            this.TabSubtypes.Controls.Add(this.panel1);
            this.TabSubtypes.Controls.Add(this.LblPatientNameInvoice);
            this.TabSubtypes.Location = new System.Drawing.Point(4, 28);
            this.TabSubtypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabSubtypes.Name = "TabSubtypes";
            this.TabSubtypes.Size = new System.Drawing.Size(1236, 872);
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
            // TabBudgetManagement
            // 
            this.TabBudgetManagement.BackColor = System.Drawing.SystemColors.Control;
            this.TabBudgetManagement.Controls.Add(this.PnlInformation);
            this.TabBudgetManagement.Location = new System.Drawing.Point(4, 28);
            this.TabBudgetManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabBudgetManagement.Name = "TabBudgetManagement";
            this.TabBudgetManagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabBudgetManagement.Size = new System.Drawing.Size(1236, 872);
            this.TabBudgetManagement.TabIndex = 0;
            this.TabBudgetManagement.Text = "Gestión de presupuesto";
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
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.TclBudgetManagement.ResumeLayout(false);
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            this.PnlActivitiesPerformed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivitiesList)).EndInit();
            this.TabSubtypes.ResumeLayout(false);
            this.TabSubtypes.PerformLayout();
            this.TabBudgetManagement.ResumeLayout(false);
            this.PnlInformation.ResumeLayout(false);
            this.PnlInformation.PerformLayout();
            this.PnlGender.ResumeLayout(false);
            this.PnlGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label LblPatientNameActivitiesPerformed;
        private System.Windows.Forms.Panel PnlActivitiesPerformed;
        private System.Windows.Forms.Button BtnDeleteActivity;
        private System.Windows.Forms.Button BtnModifyActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.DataGridView DgvActivitiesList;
        private System.Windows.Forms.TabPage TabSubtypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPatientNameInvoice;
    }
}