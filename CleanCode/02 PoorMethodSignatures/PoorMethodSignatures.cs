using System;
using System.Linq;

namespace CleanCode.PoorMethodSignatures
{
    public class UserManager
    {
        public void Run()
        {
            var userService = new UserService();

            var user = userService.ValidateUser("username", "password");
            var anotherUser = userService.GetUserByUserName("username");
        }
    }

    public class UserService
    {
        private UserDbContext _dbContext = new UserDbContext();

        public User GetUserByUserName(string userName) {
            return _dbContext.Users.SingleOrDefault(u => u.Username == userName);
        }

        public User ValidateUser(string userName, string password)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Username == userName && u.Password == password);
            if (user != null)
            {
                user.LastLogin = DateTime.Now;
            }
                
            return user;
        }
    }

    public class UserDbContext : DbContext
    {
        public IQueryable<User> Users { get; set; }
    }

    public class DbSet<T>
    {
    }

    public class DbContext
    {
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
