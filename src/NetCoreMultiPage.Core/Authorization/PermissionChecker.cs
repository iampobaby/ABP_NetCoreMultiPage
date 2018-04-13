using Abp.Authorization;
using NetCoreMultiPage.Authorization.Roles;
using NetCoreMultiPage.Authorization.Users;

namespace NetCoreMultiPage.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
