using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Resources
{
    public static class StringResourcesHandler
    {
        public static string GetString(string name)
        {
            return StringResources
                .ResourceManager
                .GetString(name, StringResources.Culture);
        }
    }
}
