using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public class RoleRepository : IRole
    {
        private FMSDbContext _db;
        public RoleRepository(FMSDbContext context)
        {
            this._db = context;
        }

        public Role AddRole(Role ro)
        {
            _db.Roles.Add(ro);
            _db.SaveChanges();
            return ro;
        }

        public bool DeleteRole(int roleId)
        {
            var ro = _db.Roles.FirstOrDefault(r => r.RoleId == roleId);
            if (ro != null)
            {
                _db.Roles.Remove(ro);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Role> GetRoles()
        {            
             var roList = _db.Roles;
             return roList;           
        }
        public Role SearchRole(int roleId)
        {
            var ro = _db.Roles.FirstOrDefault(r => r.RoleId == roleId);
            if (ro != null)
                return ro;
            else
                return null;
        }

        public void UpdateRole(int roleId, Role ro)
        {
            var newRo = _db.Roles.FirstOrDefault(r => r.RoleId == roleId);
            if (newRo != null)
            {
                newRo.RoleId = ro.RoleId;
                newRo.RoleName = ro.RoleName;
                _db.SaveChanges();
            }
        }
    }
}