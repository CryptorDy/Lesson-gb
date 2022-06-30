using Microsoft.AspNetCore.Identity;

namespace Lesson_1_GB.Models
{
    public class Users : IdentityUser
    {
        public string Role { get; set; }
    }
}
