
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
            this.LblIncomeFilter = new System.Windows.Forms.Label();
            this.BtnDeleteIncome = new System.Windows.Forms.Button();
            this.BtnModifyIncome = new System.Windows.Forms.Button();
            this.BtnNewIncome = new System.Windows.Forms.Button();
            this.TxtIncomeFilter = new System.Windows.Forms.TextBox();
            this.DgvIncomes = new System.Windows.Forms.DataGridView();
            this.LblExpenseFilter = new System.Windows.Forms.Label();
            this.BtnDeleteExpense = new System.Windows.Forms.Button();
            this.BtnModifyExpense = new System.Windows.Forms.Button();
            this.BtnNewExpense = new System.Windows.Forms.Button();
            this.TxtExpenseFilter = new System.Windows.Forms.TextBox();
            this.DgvExpenses = new System.Windows.Forms.DataGridView();
            this.TxtIncomeId = new System.Windows.Forms.TextBox();
            this.TxtExpenseId = new System.Windows.Forms.TextBox();
            this.LblTotalIncomes = new System.Windows.Forms.Label();
            this.LblTotalExpenses = new System.Windows.Forms.Label();
            this.PnlBySubTypes = new System.Windows.Forms.Panel();
            this.PnlByTypes = new System.Windows.Forms.Panel();
            this.DgvIncomesByTypes = new System.Windows.Forms.DataGridView();
            this.DgvExpensesByTypes = new System.Windows.Forms.DataGridView();
            this.LblGroupedByType = new System.Windows.Forms.Label();
            this.PnlByCategories = new System.Windows.Forms.Panel();
            this.LblGroupedByCategory = new System.Windows.Forms.Label();
            this.DgvIncomesByCategories = new System.Windows.Forms.DataGridView();
            this.DgvExpensesByCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpenses)).BeginInit();
            this.PnlBySubTypes.SuspendLayout();
            this.PnlByTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncomesByTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpensesByTypes)).BeginInit();
            this.PnlByCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncomesByCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpensesByCategories)).BeginInit();
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
            // LblIncomeFilter
            // 
            this.LblIncomeFilter.AutoSize = true;
            this.LblIncomeFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncomeFilter.Location = new System.Drawing.Point(401, 56);
            this.LblIncomeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIncomeFilter.Name = "LblIncomeFilter";
            this.LblIncomeFilter.Size = new System.Drawing.Size(77, 24);
            this.LblIncomeFilter.TabIndex = 71;
            this.LblIncomeFilter.Text = "Buscar";
            this.LblIncomeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDeleteIncome
            // 
            this.BtnDeleteIncome.Enabled = false;
            this.BtnDeleteIncome.Location = new System.Drawing.Point(253, 47);
            this.BtnDeleteIncome.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteIncome.Name = "BtnDeleteIncome";
            this.BtnDeleteIncome.Size = new System.Drawing.Size(116, 44);
            this.BtnDeleteIncome.TabIndex = 70;
            this.BtnDeleteIncome.Text = "Eliminar";
            this.BtnDeleteIncome.UseVisualStyleBackColor = true;
            this.BtnDeleteIncome.Click += new System.EventHandler(this.BtnDeleteIncome_Click);
            // 
            // BtnModifyIncome
            // 
            this.BtnModifyIncome.Enabled = false;
            this.BtnModifyIncome.Location = new System.Drawing.Point(135, 47);
            this.BtnModifyIncome.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifyIncome.Name = "BtnModifyIncome";
            this.BtnModifyIncome.Size = new System.Drawing.Size(116, 44);
            this.BtnModifyIncome.TabIndex = 69;
            this.BtnModifyIncome.Text = "Modificar";
            this.BtnModifyIncome.UseVisualStyleBackColor = true;
            this.BtnModifyIncome.Click += new System.EventHandler(this.BtnModifyIncome_Click);
            // 
            // BtnNewIncome
            // 
            this.BtnNewIncome.Location = new System.Drawing.Point(17, 47);
            this.BtnNewIncome.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNewIncome.Name = "BtnNewIncome";
            this.BtnNewIncome.Size = new System.Drawing.Size(116, 44);
            this.BtnNewIncome.TabIndex = 68;
            this.BtnNewIncome.Text = "Nuevo";
            this.BtnNewIncome.UseVisualStyleBackColor = true;
            this.BtnNewIncome.Click += new System.EventHandler(this.BtnNewIncome_Click);
            // 
            // TxtIncomeFilter
            // 
            this.TxtIncomeFilter.Location = new System.Drawing.Point(486, 53);
            this.TxtIncomeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIncomeFilter.MaxLength = 99;
            this.TxtIncomeFilter.Name = "TxtIncomeFilter";
            this.TxtIncomeFilter.Size = new System.Drawing.Size(201, 27);
            this.TxtIncomeFilter.TabIndex = 67;
            this.TxtIncomeFilter.TextChanged += new System.EventHandler(this.TxtIncomeFilter_TextChanged);
            // 
            // DgvIncomes
            // 
            this.DgvIncomes.AllowUserToAddRows = false;
            this.DgvIncomes.AllowUserToDeleteRows = false;
            this.DgvIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvIncomes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIncomes.Location = new System.Drawing.Point(17, 97);
            this.DgvIncomes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvIncomes.MultiSelect = false;
            this.DgvIncomes.Name = "DgvIncomes";
            this.DgvIncomes.ReadOnly = true;
            this.DgvIncomes.RowHeadersVisible = false;
            this.DgvIncomes.RowHeadersWidth = 51;
            this.DgvIncomes.RowTemplate.Height = 24;
            this.DgvIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIncomes.Size = new System.Drawing.Size(667, 356);
            this.DgvIncomes.TabIndex = 66;
            this.DgvIncomes.SelectionChanged += new System.EventHandler(this.DgvIncomes_SelectionChanged);
            // 
            // LblExpenseFilter
            // 
            this.LblExpenseFilter.AutoSize = true;
            this.LblExpenseFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpenseFilter.Location = new System.Drawing.Point(1094, 56);
            this.LblExpenseFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExpenseFilter.Name = "LblExpenseFilter";
            this.LblExpenseFilter.Size = new System.Drawing.Size(77, 24);
            this.LblExpenseFilter.TabIndex = 77;
            this.LblExpenseFilter.Text = "Buscar";
            this.LblExpenseFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDeleteExpense
            // 
            this.BtnDeleteExpense.Enabled = false;
            this.BtnDeleteExpense.Location = new System.Drawing.Point(946, 47);
            this.BtnDeleteExpense.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDeleteExpense.Name = "BtnDeleteExpense";
            this.BtnDeleteExpense.Size = new System.Drawing.Size(116, 44);
            this.BtnDeleteExpense.TabIndex = 76;
            this.BtnDeleteExpense.Text = "Eliminar";
            this.BtnDeleteExpense.UseVisualStyleBackColor = true;
            this.BtnDeleteExpense.Click += new System.EventHandler(this.BtnDeleteExpense_Click);
            // 
            // BtnModifyExpense
            // 
            this.BtnModifyExpense.Enabled = false;
            this.BtnModifyExpense.Location = new System.Drawing.Point(828, 47);
            this.BtnModifyExpense.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModifyExpense.Name = "BtnModifyExpense";
            this.BtnModifyExpense.Size = new System.Drawing.Size(116, 44);
            this.BtnModifyExpense.TabIndex = 75;
            this.BtnModifyExpense.Text = "Modificar";
            this.BtnModifyExpense.UseVisualStyleBackColor = true;
            this.BtnModifyExpense.Click += new System.EventHandler(this.BtnModifyExpense_Click);
            // 
            // BtnNewExpense
            // 
            this.BtnNewExpense.Location = new System.Drawing.Point(710, 47);
            this.BtnNewExpense.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNewExpense.Name = "BtnNewExpense";
            this.BtnNewExpense.Size = new System.Drawing.Size(116, 44);
            this.BtnNewExpense.TabIndex = 74;
            this.BtnNewExpense.Text = "Nuevo";
            this.BtnNewExpense.UseVisualStyleBackColor = true;
            this.BtnNewExpense.Click += new System.EventHandler(this.BtnNewExpense_Click);
            // 
            // TxtExpenseFilter
            // 
            this.TxtExpenseFilter.Location = new System.Drawing.Point(1179, 53);
            this.TxtExpenseFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtExpenseFilter.MaxLength = 99;
            this.TxtExpenseFilter.Name = "TxtExpenseFilter";
            this.TxtExpenseFilter.Size = new System.Drawing.Size(201, 27);
            this.TxtExpenseFilter.TabIndex = 73;
            this.TxtExpenseFilter.TextChanged += new System.EventHandler(this.TxtExpenseFilter_TextChanged);
            // 
            // DgvExpenses
            // 
            this.DgvExpenses.AllowUserToAddRows = false;
            this.DgvExpenses.AllowUserToDeleteRows = false;
            this.DgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExpenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpenses.Location = new System.Drawing.Point(710, 97);
            this.DgvExpenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvExpenses.MultiSelect = false;
            this.DgvExpenses.Name = "DgvExpenses";
            this.DgvExpenses.ReadOnly = true;
            this.DgvExpenses.RowHeadersVisible = false;
            this.DgvExpenses.RowHeadersWidth = 51;
            this.DgvExpenses.RowTemplate.Height = 24;
            this.DgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExpenses.Size = new System.Drawing.Size(667, 356);
            this.DgvExpenses.TabIndex = 72;
            this.DgvExpenses.SelectionChanged += new System.EventHandler(this.DgvExpenses_SelectionChanged);
            // 
            // TxtIncomeId
            // 
            this.TxtIncomeId.Location = new System.Drawing.Point(16, 13);
            this.TxtIncomeId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtIncomeId.MaxLength = 99;
            this.TxtIncomeId.Name = "TxtIncomeId";
            this.TxtIncomeId.ReadOnly = true;
            this.TxtIncomeId.Size = new System.Drawing.Size(30, 27);
            this.TxtIncomeId.TabIndex = 78;
            this.TxtIncomeId.Visible = false;
            // 
            // TxtExpenseId
            // 
            this.TxtExpenseId.Location = new System.Drawing.Point(710, 13);
            this.TxtExpenseId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtExpenseId.MaxLength = 99;
            this.TxtExpenseId.Name = "TxtExpenseId";
            this.TxtExpenseId.ReadOnly = true;
            this.TxtExpenseId.Size = new System.Drawing.Size(30, 27);
            this.TxtExpenseId.TabIndex = 79;
            this.TxtExpenseId.Visible = false;
            // 
            // LblTotalIncomes
            // 
            this.LblTotalIncomes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblTotalIncomes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalIncomes.Location = new System.Drawing.Point(299, 456);
            this.LblTotalIncomes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalIncomes.Name = "LblTotalIncomes";
            this.LblTotalIncomes.Size = new System.Drawing.Size(385, 24);
            this.LblTotalIncomes.TabIndex = 80;
            this.LblTotalIncomes.Text = "Total Ingresos";
            this.LblTotalIncomes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTotalExpenses
            // 
            this.LblTotalExpenses.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblTotalExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalExpenses.Location = new System.Drawing.Point(891, 455);
            this.LblTotalExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalExpenses.Name = "LblTotalExpenses";
            this.LblTotalExpenses.Size = new System.Drawing.Size(486, 24);
            this.LblTotalExpenses.TabIndex = 81;
            this.LblTotalExpenses.Text = "Total Egresos";
            this.LblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlBySubTypes
            // 
            this.PnlBySubTypes.Controls.Add(this.TxtIncomeId);
            this.PnlBySubTypes.Controls.Add(this.LblTotalExpenses);
            this.PnlBySubTypes.Controls.Add(this.DgvIncomes);
            this.PnlBySubTypes.Controls.Add(this.TxtExpenseId);
            this.PnlBySubTypes.Controls.Add(this.LblTotalIncomes);
            this.PnlBySubTypes.Controls.Add(this.LblExpenseFilter);
            this.PnlBySubTypes.Controls.Add(this.TxtIncomeFilter);
            this.PnlBySubTypes.Controls.Add(this.BtnDeleteExpense);
            this.PnlBySubTypes.Controls.Add(this.BtnNewIncome);
            this.PnlBySubTypes.Controls.Add(this.BtnModifyExpense);
            this.PnlBySubTypes.Controls.Add(this.BtnModifyIncome);
            this.PnlBySubTypes.Controls.Add(this.BtnNewExpense);
            this.PnlBySubTypes.Controls.Add(this.TxtExpenseFilter);
            this.PnlBySubTypes.Controls.Add(this.BtnDeleteIncome);
            this.PnlBySubTypes.Controls.Add(this.DgvExpenses);
            this.PnlBySubTypes.Controls.Add(this.LblIncomeFilter);
            this.PnlBySubTypes.Location = new System.Drawing.Point(19, 248);
            this.PnlBySubTypes.Name = "PnlBySubTypes";
            this.PnlBySubTypes.Size = new System.Drawing.Size(1397, 485);
            this.PnlBySubTypes.TabIndex = 82;
            // 
            // PnlByTypes
            // 
            this.PnlByTypes.Controls.Add(this.LblGroupedByType);
            this.PnlByTypes.Controls.Add(this.DgvIncomesByTypes);
            this.PnlByTypes.Controls.Add(this.DgvExpensesByTypes);
            this.PnlByTypes.Location = new System.Drawing.Point(19, 739);
            this.PnlByTypes.Name = "PnlByTypes";
            this.PnlByTypes.Size = new System.Drawing.Size(1388, 407);
            this.PnlByTypes.TabIndex = 83;
            // 
            // DgvIncomesByTypes
            // 
            this.DgvIncomesByTypes.AllowUserToAddRows = false;
            this.DgvIncomesByTypes.AllowUserToDeleteRows = false;
            this.DgvIncomesByTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvIncomesByTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvIncomesByTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIncomesByTypes.Location = new System.Drawing.Point(17, 37);
            this.DgvIncomesByTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvIncomesByTypes.MultiSelect = false;
            this.DgvIncomesByTypes.Name = "DgvIncomesByTypes";
            this.DgvIncomesByTypes.ReadOnly = true;
            this.DgvIncomesByTypes.RowHeadersVisible = false;
            this.DgvIncomesByTypes.RowHeadersWidth = 51;
            this.DgvIncomesByTypes.RowTemplate.Height = 24;
            this.DgvIncomesByTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIncomesByTypes.Size = new System.Drawing.Size(667, 356);
            this.DgvIncomesByTypes.TabIndex = 66;
            // 
            // DgvExpensesByTypes
            // 
            this.DgvExpensesByTypes.AllowUserToAddRows = false;
            this.DgvExpensesByTypes.AllowUserToDeleteRows = false;
            this.DgvExpensesByTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExpensesByTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvExpensesByTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpensesByTypes.Location = new System.Drawing.Point(710, 37);
            this.DgvExpensesByTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvExpensesByTypes.MultiSelect = false;
            this.DgvExpensesByTypes.Name = "DgvExpensesByTypes";
            this.DgvExpensesByTypes.ReadOnly = true;
            this.DgvExpensesByTypes.RowHeadersVisible = false;
            this.DgvExpensesByTypes.RowHeadersWidth = 51;
            this.DgvExpensesByTypes.RowTemplate.Height = 24;
            this.DgvExpensesByTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExpensesByTypes.Size = new System.Drawing.Size(667, 356);
            this.DgvExpensesByTypes.TabIndex = 72;
            // 
            // LblGroupedByType
            // 
            this.LblGroupedByType.AutoSize = true;
            this.LblGroupedByType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGroupedByType.Location = new System.Drawing.Point(579, 6);
            this.LblGroupedByType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGroupedByType.Name = "LblGroupedByType";
            this.LblGroupedByType.Size = new System.Drawing.Size(234, 24);
            this.LblGroupedByType.TabIndex = 82;
            this.LblGroupedByType.Text = "Agrupados por partidas";
            this.LblGroupedByType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlByCategories
            // 
            this.PnlByCategories.Controls.Add(this.LblGroupedByCategory);
            this.PnlByCategories.Controls.Add(this.DgvIncomesByCategories);
            this.PnlByCategories.Controls.Add(this.DgvExpensesByCategories);
            this.PnlByCategories.Location = new System.Drawing.Point(19, 1152);
            this.PnlByCategories.Name = "PnlByCategories";
            this.PnlByCategories.Size = new System.Drawing.Size(1388, 407);
            this.PnlByCategories.TabIndex = 84;
            // 
            // LblGroupedByCategory
            // 
            this.LblGroupedByCategory.AutoSize = true;
            this.LblGroupedByCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGroupedByCategory.Location = new System.Drawing.Point(579, 6);
            this.LblGroupedByCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGroupedByCategory.Name = "LblGroupedByCategory";
            this.LblGroupedByCategory.Size = new System.Drawing.Size(234, 24);
            this.LblGroupedByCategory.TabIndex = 82;
            this.LblGroupedByCategory.Text = "Agrupados por partidas";
            this.LblGroupedByCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvIncomesByCategories
            // 
            this.DgvIncomesByCategories.AllowUserToAddRows = false;
            this.DgvIncomesByCategories.AllowUserToDeleteRows = false;
            this.DgvIncomesByCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvIncomesByCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvIncomesByCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIncomesByCategories.Location = new System.Drawing.Point(17, 37);
            this.DgvIncomesByCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvIncomesByCategories.MultiSelect = false;
            this.DgvIncomesByCategories.Name = "DgvIncomesByCategories";
            this.DgvIncomesByCategories.ReadOnly = true;
            this.DgvIncomesByCategories.RowHeadersVisible = false;
            this.DgvIncomesByCategories.RowHeadersWidth = 51;
            this.DgvIncomesByCategories.RowTemplate.Height = 24;
            this.DgvIncomesByCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIncomesByCategories.Size = new System.Drawing.Size(667, 356);
            this.DgvIncomesByCategories.TabIndex = 66;
            // 
            // DgvExpensesByCategories
            // 
            this.DgvExpensesByCategories.AllowUserToAddRows = false;
            this.DgvExpensesByCategories.AllowUserToDeleteRows = false;
            this.DgvExpensesByCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExpensesByCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvExpensesByCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpensesByCategories.Location = new System.Drawing.Point(710, 37);
            this.DgvExpensesByCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvExpensesByCategories.MultiSelect = false;
            this.DgvExpensesByCategories.Name = "DgvExpensesByCategories";
            this.DgvExpensesByCategories.ReadOnly = true;
            this.DgvExpensesByCategories.RowHeadersVisible = false;
            this.DgvExpensesByCategories.RowHeadersWidth = 51;
            this.DgvExpensesByCategories.RowTemplate.Height = 24;
            this.DgvExpensesByCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExpensesByCategories.Size = new System.Drawing.Size(667, 356);
            this.DgvExpensesByCategories.TabIndex = 72;
            // 
            // FrmBudgetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1449, 789);
            this.Controls.Add(this.PnlByCategories);
            this.Controls.Add(this.PnlByTypes);
            this.Controls.Add(this.PnlBySubTypes);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpenses)).EndInit();
            this.PnlBySubTypes.ResumeLayout(false);
            this.PnlBySubTypes.PerformLayout();
            this.PnlByTypes.ResumeLayout(false);
            this.PnlByTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncomesByTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpensesByTypes)).EndInit();
            this.PnlByCategories.ResumeLayout(false);
            this.PnlByCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncomesByCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpensesByCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label LblConstruction;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblProjectName;
        private System.Windows.Forms.Label LblIncomeFilter;
        private System.Windows.Forms.Button BtnDeleteIncome;
        private System.Windows.Forms.Button BtnModifyIncome;
        private System.Windows.Forms.Button BtnNewIncome;
        private System.Windows.Forms.TextBox TxtIncomeFilter;
        private System.Windows.Forms.DataGridView DgvIncomes;
        private System.Windows.Forms.Label LblExpenseFilter;
        private System.Windows.Forms.Button BtnDeleteExpense;
        private System.Windows.Forms.Button BtnModifyExpense;
        private System.Windows.Forms.Button BtnNewExpense;
        private System.Windows.Forms.TextBox TxtExpenseFilter;
        private System.Windows.Forms.DataGridView DgvExpenses;
        public System.Windows.Forms.TextBox TxtIncomeId;
        public System.Windows.Forms.TextBox TxtExpenseId;
        private System.Windows.Forms.TextBox TxtProjectId;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtConstruction;
        private System.Windows.Forms.TextBox TxtEndDate;
        private System.Windows.Forms.TextBox TxtStartDate;
        private System.Windows.Forms.TextBox TxtProjectName;
        private System.Windows.Forms.Label LblTotalIncomes;
        private System.Windows.Forms.Label LblTotalExpenses;
        private System.Windows.Forms.Panel PnlBySubTypes;
        private System.Windows.Forms.Panel PnlByTypes;
        private System.Windows.Forms.Label LblGroupedByType;
        private System.Windows.Forms.DataGridView DgvIncomesByTypes;
        private System.Windows.Forms.DataGridView DgvExpensesByTypes;
        private System.Windows.Forms.Panel PnlByCategories;
        private System.Windows.Forms.Label LblGroupedByCategory;
        private System.Windows.Forms.DataGridView DgvIncomesByCategories;
        private System.Windows.Forms.DataGridView DgvExpensesByCategories;
    }
}