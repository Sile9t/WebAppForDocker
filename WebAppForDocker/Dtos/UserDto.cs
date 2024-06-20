using WebAppForDocker.Models;

namespace WebAppForDocker.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRoleDto Role { get; set; }
    }
}
