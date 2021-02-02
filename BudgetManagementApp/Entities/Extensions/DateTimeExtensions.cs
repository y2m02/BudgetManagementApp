using System;

namespace BudgetManagementApp.Entities.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool IsGreaterThan(this DateTime dateTime, DateTime dateTime2)
        {
            return dateTime > dateTime2;
        }

        public static bool IsGreaterOrEqualTo(this DateTime dateTime, DateTime dateTime2)
        {
            return dateTime >= dateTime2;
        }

        public static bool IsLessThan(this DateTime dateTime, DateTime dateTime2)
        {
            return dateTime < dateTime2;
        }

        public static bool IsLessOrEqualTo(this DateTime dateTime, DateTime dateTime2)
        {
            return dateTime <= dateTime2;
        }
    }
}