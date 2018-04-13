using System.Collections.Generic;
using NetCoreMultiPage.Roles.Dto;
using NetCoreMultiPage.Users.Dto;

namespace NetCoreMultiPage.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
