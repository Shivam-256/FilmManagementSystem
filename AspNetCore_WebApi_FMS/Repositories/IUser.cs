using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface IUser
    {
        public User AddUser(User use);
        public bool DeleteUser(int userId);
       public IEnumerable<User> GetUsers();
        public User SearchUser(int userId);
        public void UpdateUser(int userId, User use);
        bool ValidateUser(User user);


    }
}
