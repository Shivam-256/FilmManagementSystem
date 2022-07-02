using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public class UserRepository : IUser
    {
        private FMSDbContext _db;
        public UserRepository(FMSDbContext context)
        {
            this._db = context;
        }
        public User AddUser(User use)
        {
            _db.Users.Add(use);
            _db.SaveChanges();
            return use;
        }

        public bool DeleteUser(int userId)
        {
            var use = _db.Users.FirstOrDefault(u => u.UserId == userId);
            if (use != null)
            {
                _db.Remove(use);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<User> GetUsers()
        {
            var useList = _db.Users;
            return useList;
        }

        public User SearchUser(int userId)
        {
            var use = _db.Users.FirstOrDefault(u => u.UserId == userId);
            if (use != null)
                return use;
            else
                return null;
        }

        public void UpdateUser(int userId, User use)
        {
            var newUse = _db.Users.FirstOrDefault(u => u.UserId == userId);
            if (newUse != null)
            {
                newUse.UserId = use.UserId;
                newUse.UserName = use.UserName;
                newUse.Password = use.Password;
                newUse.FirstName = use.FirstName;
                newUse.LastName = use.LastName;
                newUse.RoleId = use.RoleId;
                _db.SaveChanges();
            }
        }
    }
}

