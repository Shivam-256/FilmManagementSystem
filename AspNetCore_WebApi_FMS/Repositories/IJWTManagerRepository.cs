using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Models;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface IJWTManagerRepository
    {
        MyJwtToken Authenticate(string username, string password);
    }
}
