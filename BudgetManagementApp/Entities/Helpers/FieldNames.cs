namespace BudgetManagementApp.Entities.Helpers
{
    public static class FieldNames
    {
        // Categories
        public static string CategoryId => "CategoryId";
        public static string Category => "Category";
        public static string CategoryDescription => "CategoryDescription";

        // Types
        public static string TypeId => "TypeId";
        public static string Type => "Type";
        public static string TypeDescription => "TypeDescription";

        // SubTypes
        public static string SubTypeId => "SubTypeId";
        public static string SubType => "SubType";

        // Projects
        public static string ProjectId => "ProjectId";
        public static string Project => "Project";
        public static string Name => "Name";
        public static string StartDate => "StartDate";
        public static string EndDate => "EndDate";
        public static string Construction => "Construction";
        public static string Cost => "Cost";

        // Accounting Movements
        public static string Income => "Income";
        public static string Incomes => "Incomes";
        public static string Expense => "Expense";
        public static string Expenses => "Expenses";
        public static string Date => "Date";
        public static string Amount => "Amount";
        public static string Comment => "Comment";

        // Others
        public static string Id => "Id";
        public static string Description => "Description";
        public static string InUse => "InUse";
        public static string DeletedOn => "DeletedOn";
        public static string Action => "Action";
        public static string Today => "Today";
    }
}
