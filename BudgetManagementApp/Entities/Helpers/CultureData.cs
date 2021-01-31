using System.Globalization;

namespace BudgetManagementApp.Entities.Helpers
{
    public static class CultureData
    {
        public const string EnglishCultureName = "en-US";

        public const string SpanishCultureName = "es-ES";

        private static CultureInfo englishCulture = new CultureInfo(EnglishCultureName);

        private static CultureInfo spanishCulture = new CultureInfo(SpanishCultureName);

        public static CultureInfo GetEnglishCulture()
        {
            englishCulture ??= new CultureInfo(EnglishCultureName);

            return englishCulture;
        }

        public static CultureInfo GetSpanishSCulture()
        {
            spanishCulture ??= new CultureInfo(SpanishCultureName);

            return spanishCulture;
        }
    }
}