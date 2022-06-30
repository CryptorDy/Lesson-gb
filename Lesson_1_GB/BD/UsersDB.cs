using Lesson_1_GB.Models;

namespace Lesson_1_GB.BD
{
    public class UsersDB
    {
        private List<Users> _users;
        public UsersDB()
        {
            var user1 = new Users { Id = "1", UserName = "Mark", Role = "Admin"};
            var user2 = new Users { Id = "2", UserName = "Jack", Role = "User"};

            _users = new List<Users> { user1, user2 };
        }
        public List<Users> AllUsers()
        {
            return _users;
        }  
    }
}
