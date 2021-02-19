using BudgetManagementApp.Resources.Properties;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace BudgetManagementApp.Services
{
    public interface IAccessGranterService
    {
        void GrantAccess(string directory, FileSystemRights accessType);
        void CreateDatabaseDirectory(string directory);
    }

    public class AccessGranterService : IAccessGranterService
    {
        public void CreateDatabaseDirectory(string directory)
        {
            var exists = Directory.Exists(directory);

            if (!exists)
            {
                Directory.CreateDirectory(directory);

                using var sw = File.CreateText(Path.Combine(directory, "Read me.txt"));

                sw.WriteLine(StringResources.DoNotDeleteFolder);
                sw.WriteLine("");
                sw.WriteLine(StringResources.DoNotDeleteInfoMessage);
                sw.WriteLine(StringResources.DoNotDeleteWarning);
            }
        }

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
