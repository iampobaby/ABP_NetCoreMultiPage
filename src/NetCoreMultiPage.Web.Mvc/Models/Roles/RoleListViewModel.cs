using System.Collections.Generic;
using NetCoreMultiPage.Roles.Dto;

namespace NetCoreMultiPage.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
