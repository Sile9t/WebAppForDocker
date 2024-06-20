using WebAppForDocker.Dtos;
using WebAppForDocker.Models;

namespace WebAppForDocker.Abstraction
{
    public interface IUserRepository
    {
        int AddUser(UserDto user);
        RoleId CheckUser(LoginDto login);
    }
}
