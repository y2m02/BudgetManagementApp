using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace BudgetManagementApp.Services
{
    public interface IAccessGranterService
    {
        void GrantAccess(string directory, FileSystemRights accessType);
    }

    public class AccessGranterService : IAccessGranterService
    {
        public void GrantAccess(string directory, FileSystemRights accessType)
        {
            var dInfo = new DirectoryInfo(directory);
            var dSecurity = dInfo.GetAccessControl();

            dSecurity.AddAccessRule(
                new FileSystemAccessRule(
                    new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    accessType,
                    InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                    PropagationFlags.NoPropagateInherit,
                    AccessControlType.Allow
                )
            );

            dInfo.SetAccessControl(dSecurity);
        }
    }
}
