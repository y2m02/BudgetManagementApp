using BudgetManagementApp.Resources;
using System.ComponentModel;

namespace BudgetManagementApp.Entities.Helpers
{
    public class DisplayNameFromResources: DisplayNameAttribute
    {
        public DisplayNameFromResources(string resourceId) 
            : base(GetNameFromResources(resourceId))
        { }

        private static string GetNameFromResources(string resourceId)
        {
            return StringResourcesHandler.GetString(resourceId);
        }
    }
}
