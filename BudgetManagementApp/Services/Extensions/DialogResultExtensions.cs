using System.Windows.Forms;

namespace BudgetManagementApp.Services.Extensions
{
    public static class DialogResultExtensions
    {
        public static bool IsOkResponse(this DialogResult result)
        {
            return result == DialogResult.OK;
        }

        public static bool IsCancelResponse(this DialogResult result)
        {
            return result == DialogResult.Cancel;
        }

        public static bool IsYesResponse(this DialogResult result)
        {
            return result == DialogResult.Yes;
        }

        public static bool IsNoResponse(this DialogResult result)
        {
            return result == DialogResult.No;
        }

        public static bool IsAbortResponse(this DialogResult result)
        {
            return result == DialogResult.Abort;
        }

        public static bool IsIgnoreResponse(this DialogResult result)
        {
            return result == DialogResult.Ignore;
        }
    }
}
