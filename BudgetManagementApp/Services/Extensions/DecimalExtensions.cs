namespace BudgetManagementApp.Services.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToStringWithDecimals(this decimal number, int decimals = 2)
        {
            return number.ToString($"N{decimals}");
        }

        public static string ToStringWithDecimals(this decimal? number, int decimals = 2)
        {
            return number.GetValueOrDefault().ToStringWithDecimals(decimals);
        }
    }
}