
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
            this.TclBudgetManagement = new System.Windows.Forms.TabControl();
            this.TabProjects = new System.Windows.Forms.TabPage();
            this.BtnBudgetManagement = new System.Windows.Forms.Button();
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblConstruction = new System.Windows.Forms.Label();
            this.TxtConstruction = new System.Windows.Forms.TextBox();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.TxtEndDate = new System.Windows.Forms.TextBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.TxtStartDate = new System.Windows.Forms.TextBox();
            this.TxtProjectId = new System.Windows.Forms.TextBox();
            this.LblProjectFilter = new System.Windows.Forms.Label();
            this.BtnDeleteProject = new System.Windows.Forms.Button();
            this.BtnModifyProject = new System.Windows.Forms.Button();
            this.BtnNewProject = new System.Windows.Forms.Button();
            this.TxtProjectFilter = new System.Windows.Forms.TextBox();
            this.DgvProjects = new System.Windows.Forms.DataGridView();
            this.LblProjectName = new System.Windows.Forms.Label();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
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
            this.TxtTypeCategoryId = new System.Windows.Forms.TextBox();
            this.LblTypeDescription = new System.Windows.Forms.Label();
            this.TxtTypeDescription = new System.Windows.Forms.TextBox();
            this.TxtTypeId = new System.Windows.Forms.TextBox();
            this.LblTypeFilter = new System.Windows.Forms.Label();
            this.BtnDeleteType = new System.Windows.Forms.Button();
            this.BtnModifyType = new System.Windows.Forms.Button();
            this.BtnNewType = new System.Windows.Forms.Button();
            this.TxtTypeFilter = new System.Windows.Forms.TextBox();
            this.DgvTypes = new System.Windows.Forms.DataGridView();
            this.LblTypeCategory = new System.Windows.Forms.Label();
            this.TxtTypeCategory = new System.Windows.Forms.TextBox();
            this.TabSubtypes = new System.Windows.Forms.TabPage();
            this.TxtSubTypeTypeId = new System.Windows.Forms.TextBox();
            this.LblSubTypeTypeDescription = new System.Windows.Forms.Label();
            this.TxtSubTypeTypeDescription = new System.Windows.Forms.TextBox();
            this.TxtSubTypeCategoryId = new System.Windows.Forms.TextBox();
            this.LblSubTypeDescription = new System.Windows.Forms.Label();
            this.TxtSubTypeDescription = new System.Windows.Forms.TextBox();
            this.TxtSubTypeId = new System.Windows.Forms.TextBox();
            this.LblSubTypeFilter = new System.Windows.Forms.Label();
            this.BtnDeleteSubType = new System.Windows.Forms.Button();
            this.BtnModifySubType = new System.Windows.Forms.Button();
            this.BtnNewSubType = new System.Windows.Forms.Button();
            this.TxtSubTypeFilter = new System.Windows.Forms.TextBox();
            this.DgvSubTypes = new System.Windows.Forms.DataGridView();
            this.LblSubTypeCategory = new System.Windows.Forms.Label();
            this.TxtSubTypeCategory = new System.Windows.Forms.TextBox();
            this.MsMainMenu = new System.Windows.Forms.MenuStrip();
            this.MiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MiLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.MiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.TclBudgetManagement.SuspendLayout();
            this.TabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjects)).BeginInit();
            this.TabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.TabTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTypes)).BeginInit();
            this.TabSubtypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubTypes)).BeginInit();
            this.MsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSubtypes
            // 
            this.BtnSubtypes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSubtypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubtypes.Location = new System.Drawing.Point(0, 250);
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
            this.BtnTypes.Location = new System.Drawing.Point(0, 176);
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
            this.BtnCategories.Location = new System.Drawing.Point(0, 102);
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
            this.BtnProjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProjects.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProjects.Location = new System.Drawing.Point(0, 28);
            this.BtnProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProjects.Name = "BtnProjects";
            this.BtnProjects.Size = new System.Drawing.Size(253, 74);
            this.BtnProjects.TabIndex = 8;
            this.BtnProjects.Text = "Proyectos";
            this.BtnProjects.UseVisualStyleBackColor = false;
            this.BtnProjects.Click += new System.EventHandler(this.BtnProjects_Click);
            // 
            // TclBudgetManagement
            // 
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
            // TabProjects
            // 
            this.TabProjects.AutoScroll = true;
            this.TabProjects.BackColor = System.Drawing.SystemColors.Control;
            this.TabProjects.Controls.Add(this.BtnBudgetManagement);
            this.TabProjects.Controls.Add(this.LblCost);
            this.TabProjects.Controls.Add(this.TxtCost);
            this.TabProjects.Controls.Add(this.LblConstruction);
            this.TabProjects.Controls.Add(this.TxtConstruction);
            this.TabProjects.Controls.Add(this.LblEndDate);
            this.TabProjects.Controls.Add(this.TxtEndDate);
            this.TabProjects.Controls.Add(this.LblStartDate);
            this.TabProjects.Controls.Add(this.TxtStartDate);
            this.TabProjects.Controls.Add(this.TxtProjectId);
            this.TabProjects.Controls.Add(this.LblProjectFilter);
            this.TabProjects.Controls.Add(this.BtnDeleteProject);
            this.TabProjects.Controls.Add(this.BtnModifyProject);
            this.TabProjects.Controls.Add(this.BtnNewProject);
            this.TabProjects.Controls.Add(this.TxtProjectFilter);
            this.TabProjects.Controls.Add(this.DgvProjects);
            this.TabProjects.Controls.Add(this.LblProjectName);
            this.TabProjects.Controls.Add(this.TxtProjectName);
            this.TabProjects.Location = new System.Drawing.Point(4, 28);
            this.TabProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProjects.Name = "TabProjects";
            this.TabProjects.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabProjects.Size = new System.Drawing.Size(1236, 844);
            this.TabProjects.TabIndex = 1;
            this.TabProjects.Text = "Proyectos";
            // 
            // BtnBudgetManagement
            // 
            this.BtnBudgetManagement.Enabled = false;
            this.BtnBudgetManagement.Location = new System.Drawing.Point(365, 64);
            this.BtnBudgetManagement.Margin = new System.Windows.Forms.Padding(1);
            this.BtnBudgetManagement.Name = "BtnBudgetManagement";
            this.BtnBudgetManagement.Size = new System.Drawing.Size(189, 44);
            this.BtnBudgetManagement.TabIndex = 55;
            this.BtnBudgetManagement.Text = "Manejar presupuesto";
            this.BtnBudgetManagement.UseVisualStyleBackColor = true;
            this.BtnBudgetManagement.Click += new System.EventHandler(this.BtnBudgetManagement_Click);
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.Location = new System.Drawing.Point(383, 264);
            this.LblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(66, 24);
            this.LblCost.TabIndex = 54;
            this.LblCost.Text = "Costo";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(387, 296);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCost.MaxLength = 99;
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.ReadOnly = true;
            this.TxtCost.Size = new System.Drawing.Size(290, 27);
            this.TxtCost.TabIndex = 53;
            // 
            // LblConstruction
            // 
            this.LblConstruction.AutoSize = true;
            this.LblConstruction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConstruction.Location = new System.Drawing.Point(9, 264);
            this.LblConstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConstruction.Name = "LblConstruction";
            this.LblConstruction.Size = new System.Drawing.Size(137, 24);
            this.LblConstruction.TabIndex = 52;
            this.LblConstruction.Text = "Construcción";
            // 
            // TxtConstruction
            // 
            this.TxtConstruction.Location = new System.Drawing.Point(13, 296);
            this.TxtConstruction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConstruction.MaxLength = 99;
            this.TxtConstruction.Name = "TxtConstruction";
            this.TxtConstruction.ReadOnly = true;
            this.TxtConstruction.Size = new System.Drawing.Size(290, 27);
            this.TxtConstruction.TabIndex = 51;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndDate.Location = new System.Drawing.Point(383, 190);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(208, 24);
            this.LblEndDate.TabIndex = 50;
            this.LblEndDate.Text = "Fecha de finalización";
            // 
            // TxtEndDate
            // 
            this.TxtEndDate.Location = new System.Drawing.Point(387, 222);
            this.TxtEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEndDate.MaxLength = 99;
            this.TxtEndDate.Name = "TxtEndDate";
            this.TxtEndDate.ReadOnly = true;
            this.TxtEndDate.Size = new System.Drawing.Size(290, 27);
            this.TxtEndDate.TabIndex = 49;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.Location = new System.Drawing.Point(8, 190);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(152, 24);
            this.LblStartDate.TabIndex = 48;
            this.LblStartDate.Text = "Fecha de inicio";
            // 
            // TxtStartDate
            // 
            this.TxtStartDate.Location = new System.Drawing.Point(13, 222);
            this.TxtStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStartDate.MaxLength = 99;
            this.TxtStartDate.Name = "TxtStartDate";
            this.TxtStartDate.ReadOnly = true;
            this.TxtStartDate.Size = new System.Drawing.Size(290, 27);
            this.TxtStartDate.TabIndex = 47;
            // 
            // TxtProjectId
            // 
            this.TxtProjectId.Location = new System.Drawing.Point(648, 113);
            this.TxtProjectId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtProjectId.MaxLength = 99;
            this.TxtProjectId.Name = "TxtProjectId";
            this.TxtProjectId.ReadOnly = true;
            this.TxtProjectId.Size = new System.Drawing.Size(30, 27);
            this.TxtProjectId.TabIndex = 46;
            this.TxtProjectId.Visible = false;
            // 
            // LblProjectFilter
            // 
            this.LblProjectFilter.AutoSize = true;
            this.LblProjectFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjectFilter.Location = new System.Drawing.Point(390, 25);
            this.LblProjectFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectFilter.Name = "LblProjectFilter";
            this.LblProjectFilter.Size = new System.Drawing.Size(77, 24);
            this.LblProjectFilter.TabIndex = 45;
            this.LblProjectFilter.Text = "Buscar";
            this.LblProjectFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDeleteProject
            // 
            this.BtnDeleteProject.Enabled = false;
            this.BtnDeleteProject.Location = new System.Drawing.Point(247, 64);
            this.BtnDeleteProject.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteProject.Name = "BtnDeleteProject";
            this.BtnDeleteProject.Size = new System.Drawing.Size(116, 44);
            this.BtnDeleteProject.TabIndex = 44;
            this.BtnDeleteProject.Text = "Eliminar";
            this.BtnDeleteProject.UseVisualStyleBackColor = true;
            this.BtnDeleteProject.Click += new System.EventHandler(this.BtnDeleteProject_Click);
            // 
            // BtnModifyProject
            // 
            this.BtnModifyProject.Enabled = false;
            this.BtnModifyProject.Location = new System.Drawing.Point(129, 64);
            this.BtnModifyProject.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifyProject.Name = "BtnModifyProject";
            this.BtnModifyProject.Size = new System.Drawing.Size(116, 44);
            this.BtnModifyProject.TabIndex = 43;
            this.BtnModifyProject.Text = "Modificar";
            this.BtnModifyProject.UseVisualStyleBackColor = true;
            this.BtnModifyProject.Click += new System.EventHandler(this.BtnModifyProject_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Location = new System.Drawing.Point(11, 64);
            this.BtnNewProject.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(116, 44);
            this.BtnNewProject.TabIndex = 42;
            this.BtnNewProject.Text = "Nuevo";
            this.BtnNewProject.UseVisualStyleBackColor = true;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // TxtProjectFilter
            // 
            this.TxtProjectFilter.Location = new System.Drawing.Point(475, 22);
            this.TxtProjectFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProjectFilter.MaxLength = 99;
            this.TxtProjectFilter.Name = "TxtProjectFilter";
            this.TxtProjectFilter.Size = new System.Drawing.Size(201, 27);
            this.TxtProjectFilter.TabIndex = 41;
            this.TxtProjectFilter.TextChanged += new System.EventHandler(this.TxtProjectFilter_TextChanged);
            // 
            // DgvProjects
            // 
            this.DgvProjects.AllowUserToAddRows = false;
            this.DgvProjects.AllowUserToDeleteRows = false;
            this.DgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjects.Location = new System.Drawing.Point(11, 336);
            this.DgvProjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvProjects.MultiSelect = false;
            this.DgvProjects.Name = "DgvProjects";
            this.DgvProjects.ReadOnly = true;
            this.DgvProjects.RowHeadersVisible = false;
            this.DgvProjects.RowHeadersWidth = 51;
            this.DgvProjects.RowTemplate.Height = 24;
            this.DgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProjects.Size = new System.Drawing.Size(667, 356);
            this.DgvProjects.TabIndex = 40;
            this.DgvProjects.SelectionChanged += new System.EventHandler(this.DgvProjects_SelectionChanged);
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjectName.Location = new System.Drawing.Point(7, 116);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(63, 24);
            this.LblProjectName.TabIndex = 39;
            this.LblProjectName.Text = "Name";
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Location = new System.Drawing.Point(12, 148);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProjectName.MaxLength = 99;
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.ReadOnly = true;
            this.TxtProjectName.Size = new System.Drawing.Size(666, 27);
            this.TxtProjectName.TabIndex = 38;
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
            // TabSubtypes
            // 
            this.TabSubtypes.BackColor = System.Drawing.SystemColors.Control;
            this.TabSubtypes.Controls.Add(this.TxtSubTypeTypeId);
            this.TabSubtypes.Controls.Add(this.LblSubTypeTypeDescription);
            this.TabSubtypes.Controls.Add(this.TxtSubTypeTypeDescription);
            this.TabSubtypes.Controls.Add(this.TxtSubTypeCategoryId);
            this.TabSubtypes.Controls.Add(this.LblSubTypeDescription);
            this.TabSubtypes.Controls.Add(this.TxtSubTypeDescription);
            this.TabSubtypes.Controls.Add(this.TxtSubTypeId);
            this.TabSubtypes.Controls.Add(this.LblSubTypeFilter);
            this.TabSubtypes.Controls.Add(this.BtnDeleteSubType);
            this.TabSubtypes.Controls.Add(this.BtnModifySubType);
            this.TabSubtypes.Controls.Add(this.BtnNewSubType);
            this.TabSubtypes.Controls.Add(this.TxtSubTypeFilter);
            this.TabSubtypes.Controls.Add(this.DgvSubTypes);
            this.TabSubtypes.Controls.Add(this.LblSubTypeCategory);
            this.TabSubtypes.Controls.Add(this.TxtSubTypeCategory);
            this.TabSubtypes.Location = new System.Drawing.Point(4, 28);
            this.TabSubtypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabSubtypes.Name = "TabSubtypes";
            this.TabSubtypes.Size = new System.Drawing.Size(1236, 844);
            this.TabSubtypes.TabIndex = 4;
            this.TabSubtypes.Text = "Sub-partidas";
            // 
            // TxtSubTypeTypeId
            // 
            this.TxtSubTypeTypeId.Location = new System.Drawing.Point(286, 97);
            this.TxtSubTypeTypeId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtSubTypeTypeId.MaxLength = 99;
            this.TxtSubTypeTypeId.Name = "TxtSubTypeTypeId";
            this.TxtSubTypeTypeId.ReadOnly = true;
            this.TxtSubTypeTypeId.Size = new System.Drawing.Size(30, 27);
            this.TxtSubTypeTypeId.TabIndex = 64;
            this.TxtSubTypeTypeId.Visible = false;
            // 
            // LblSubTypeTypeDescription
            // 
            this.LblSubTypeTypeDescription.AutoSize = true;
            this.LblSubTypeTypeDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTypeTypeDescription.Location = new System.Drawing.Point(21, 96);
            this.LblSubTypeTypeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSubTypeTypeDescription.Name = "LblSubTypeTypeDescription";
            this.LblSubTypeTypeDescription.Size = new System.Drawing.Size(77, 24);
            this.LblSubTypeTypeDescription.TabIndex = 63;
            this.LblSubTypeTypeDescription.Text = "Partida";
            // 
            // TxtSubTypeTypeDescription
            // 
            this.TxtSubTypeTypeDescription.Location = new System.Drawing.Point(26, 128);
            this.TxtSubTypeTypeDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSubTypeTypeDescription.MaxLength = 99;
            this.TxtSubTypeTypeDescription.Name = "TxtSubTypeTypeDescription";
            this.TxtSubTypeTypeDescription.ReadOnly = true;
            this.TxtSubTypeTypeDescription.Size = new System.Drawing.Size(290, 27);
            this.TxtSubTypeTypeDescription.TabIndex = 62;
            // 
            // TxtSubTypeCategoryId
            // 
            this.TxtSubTypeCategoryId.Location = new System.Drawing.Point(286, 23);
            this.TxtSubTypeCategoryId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtSubTypeCategoryId.MaxLength = 99;
            this.TxtSubTypeCategoryId.Name = "TxtSubTypeCategoryId";
            this.TxtSubTypeCategoryId.ReadOnly = true;
            this.TxtSubTypeCategoryId.Size = new System.Drawing.Size(30, 27);
            this.TxtSubTypeCategoryId.TabIndex = 61;
            this.TxtSubTypeCategoryId.Visible = false;
            // 
            // LblSubTypeDescription
            // 
            this.LblSubTypeDescription.AutoSize = true;
            this.LblSubTypeDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTypeDescription.Location = new System.Drawing.Point(21, 170);
            this.LblSubTypeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSubTypeDescription.Name = "LblSubTypeDescription";
            this.LblSubTypeDescription.Size = new System.Drawing.Size(122, 24);
            this.LblSubTypeDescription.TabIndex = 60;
            this.LblSubTypeDescription.Text = "Descripción";
            // 
            // TxtSubTypeDescription
            // 
            this.TxtSubTypeDescription.Location = new System.Drawing.Point(26, 202);
            this.TxtSubTypeDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSubTypeDescription.MaxLength = 99;
            this.TxtSubTypeDescription.Name = "TxtSubTypeDescription";
            this.TxtSubTypeDescription.ReadOnly = true;
            this.TxtSubTypeDescription.Size = new System.Drawing.Size(290, 27);
            this.TxtSubTypeDescription.TabIndex = 59;
            // 
            // TxtSubTypeId
            // 
            this.TxtSubTypeId.Location = new System.Drawing.Point(286, 171);
            this.TxtSubTypeId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtSubTypeId.MaxLength = 99;
            this.TxtSubTypeId.Name = "TxtSubTypeId";
            this.TxtSubTypeId.ReadOnly = true;
            this.TxtSubTypeId.Size = new System.Drawing.Size(30, 27);
            this.TxtSubTypeId.TabIndex = 58;
            this.TxtSubTypeId.Visible = false;
            // 
            // LblSubTypeFilter
            // 
            this.LblSubTypeFilter.AutoSize = true;
            this.LblSubTypeFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTypeFilter.Location = new System.Drawing.Point(406, 207);
            this.LblSubTypeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSubTypeFilter.Name = "LblSubTypeFilter";
            this.LblSubTypeFilter.Size = new System.Drawing.Size(77, 24);
            this.LblSubTypeFilter.TabIndex = 57;
            this.LblSubTypeFilter.Text = "Buscar";
            this.LblSubTypeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDeleteSubType
            // 
            this.BtnDeleteSubType.Enabled = false;
            this.BtnDeleteSubType.Location = new System.Drawing.Point(577, 37);
            this.BtnDeleteSubType.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteSubType.Name = "BtnDeleteSubType";
            this.BtnDeleteSubType.Size = new System.Drawing.Size(116, 44);
            this.BtnDeleteSubType.TabIndex = 56;
            this.BtnDeleteSubType.Text = "Eliminar";
            this.BtnDeleteSubType.UseVisualStyleBackColor = true;
            this.BtnDeleteSubType.Click += new System.EventHandler(this.BtnDeleteSubType_Click);
            // 
            // BtnModifySubType
            // 
            this.BtnModifySubType.Enabled = false;
            this.BtnModifySubType.Location = new System.Drawing.Point(459, 37);
            this.BtnModifySubType.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifySubType.Name = "BtnModifySubType";
            this.BtnModifySubType.Size = new System.Drawing.Size(116, 44);
            this.BtnModifySubType.TabIndex = 55;
            this.BtnModifySubType.Text = "Modificar";
            this.BtnModifySubType.UseVisualStyleBackColor = true;
            this.BtnModifySubType.Click += new System.EventHandler(this.BtnModifySubType_Click);
            // 
            // BtnNewSubType
            // 
            this.BtnNewSubType.Location = new System.Drawing.Point(341, 37);
            this.BtnNewSubType.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNewSubType.Name = "BtnNewSubType";
            this.BtnNewSubType.Size = new System.Drawing.Size(116, 44);
            this.BtnNewSubType.TabIndex = 54;
            this.BtnNewSubType.Text = "Nuevo";
            this.BtnNewSubType.UseVisualStyleBackColor = true;
            this.BtnNewSubType.Click += new System.EventHandler(this.BtnNewSubType_Click);
            // 
            // TxtSubTypeFilter
            // 
            this.TxtSubTypeFilter.Location = new System.Drawing.Point(491, 204);
            this.TxtSubTypeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSubTypeFilter.MaxLength = 99;
            this.TxtSubTypeFilter.Name = "TxtSubTypeFilter";
            this.TxtSubTypeFilter.Size = new System.Drawing.Size(201, 27);
            this.TxtSubTypeFilter.TabIndex = 53;
            this.TxtSubTypeFilter.TextChanged += new System.EventHandler(this.TxtSubTypeFilter_TextChanged);
            // 
            // DgvSubTypes
            // 
            this.DgvSubTypes.AllowUserToAddRows = false;
            this.DgvSubTypes.AllowUserToDeleteRows = false;
            this.DgvSubTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSubTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvSubTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSubTypes.Location = new System.Drawing.Point(26, 253);
            this.DgvSubTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvSubTypes.MultiSelect = false;
            this.DgvSubTypes.Name = "DgvSubTypes";
            this.DgvSubTypes.ReadOnly = true;
            this.DgvSubTypes.RowHeadersVisible = false;
            this.DgvSubTypes.RowHeadersWidth = 51;
            this.DgvSubTypes.RowTemplate.Height = 24;
            this.DgvSubTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSubTypes.Size = new System.Drawing.Size(667, 356);
            this.DgvSubTypes.TabIndex = 52;
            this.DgvSubTypes.SelectionChanged += new System.EventHandler(this.DgvSubTypes_SelectionChanged);
            // 
            // LblSubTypeCategory
            // 
            this.LblSubTypeCategory.AutoSize = true;
            this.LblSubTypeCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTypeCategory.Location = new System.Drawing.Point(21, 22);
            this.LblSubTypeCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSubTypeCategory.Name = "LblSubTypeCategory";
            this.LblSubTypeCategory.Size = new System.Drawing.Size(102, 24);
            this.LblSubTypeCategory.TabIndex = 51;
            this.LblSubTypeCategory.Text = "Categoría";
            // 
            // TxtSubTypeCategory
            // 
            this.TxtSubTypeCategory.Location = new System.Drawing.Point(26, 54);
            this.TxtSubTypeCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSubTypeCategory.MaxLength = 99;
            this.TxtSubTypeCategory.Name = "TxtSubTypeCategory";
            this.TxtSubTypeCategory.ReadOnly = true;
            this.TxtSubTypeCategory.Size = new System.Drawing.Size(290, 27);
            this.TxtSubTypeCategory.TabIndex = 50;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1497, 904);
            this.Controls.Add(this.BtnSubtypes);
            this.Controls.Add(this.BtnTypes);
            this.Controls.Add(this.BtnCategories);
            this.Controls.Add(this.BtnProjects);
            this.Controls.Add(this.TclBudgetManagement);
            this.Controls.Add(this.MsMainMenu);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MsMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TclBudgetManagement.ResumeLayout(false);
            this.TabProjects.ResumeLayout(false);
            this.TabProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjects)).EndInit();
            this.TabCategories.ResumeLayout(false);
            this.TabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTypes)).EndInit();
            this.TabSubtypes.ResumeLayout(false);
            this.TabSubtypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubTypes)).EndInit();
            this.MsMainMenu.ResumeLayout(false);
            this.MsMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSubtypes;
        private System.Windows.Forms.Button BtnTypes;
        private System.Windows.Forms.Button BtnCategories;
        private System.Windows.Forms.Button BtnProjects;
        private System.Windows.Forms.TabControl TclBudgetManagement;
        private System.Windows.Forms.TabPage TabProjects;
        private System.Windows.Forms.TabPage TabCategories;
        private System.Windows.Forms.TabPage TabTypes;
        private System.Windows.Forms.TabPage TabSubtypes;
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
        public System.Windows.Forms.TextBox TxtSubTypeTypeId;
        private System.Windows.Forms.Label LblSubTypeTypeDescription;
        private System.Windows.Forms.TextBox TxtSubTypeTypeDescription;
        public System.Windows.Forms.TextBox TxtSubTypeCategoryId;
        private System.Windows.Forms.Label LblSubTypeDescription;
        private System.Windows.Forms.TextBox TxtSubTypeDescription;
        public System.Windows.Forms.TextBox TxtSubTypeId;
        private System.Windows.Forms.Label LblSubTypeFilter;
        private System.Windows.Forms.Button BtnDeleteSubType;
        private System.Windows.Forms.Button BtnModifySubType;
        private System.Windows.Forms.Button BtnNewSubType;
        private System.Windows.Forms.TextBox TxtSubTypeFilter;
        private System.Windows.Forms.DataGridView DgvSubTypes;
        private System.Windows.Forms.Label LblSubTypeCategory;
        private System.Windows.Forms.TextBox TxtSubTypeCategory;
        public System.Windows.Forms.TextBox TxtProjectId;
        private System.Windows.Forms.Label LblProjectFilter;
        private System.Windows.Forms.Button BtnDeleteProject;
        private System.Windows.Forms.Button BtnModifyProject;
        private System.Windows.Forms.Button BtnNewProject;
        private System.Windows.Forms.TextBox TxtProjectFilter;
        private System.Windows.Forms.DataGridView DgvProjects;
        private System.Windows.Forms.Label LblProjectName;
        private System.Windows.Forms.TextBox TxtProjectName;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblConstruction;
        private System.Windows.Forms.TextBox TxtConstruction;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.TextBox TxtEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.TextBox TxtStartDate;
        private System.Windows.Forms.Button BtnBudgetManagement;
    }
}