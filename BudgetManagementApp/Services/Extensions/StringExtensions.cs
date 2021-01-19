namespace BudgetManagementApp.Services.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string str)
        {
            return 
                string.IsNullOrEmpty(str) ||
                string.IsNullOrWhiteSpace(str);
        }

        public static bool HasValue(this string str)
        {
            return !IsEmpty(str);
        }
    }
}
