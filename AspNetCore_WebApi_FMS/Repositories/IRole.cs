using System;
using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface IRole
    {
        Role AddRole(Role ro);
        void UpdateRole(int roleId, Role ro);
        bool DeleteRole(int roleId);
        Role SearchRole(int roleId);
        IEnumerable<Role> GetRoles();
    }
}
