using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace LoginServer.Models
{
    public partial class LoginDemoDbContext: DbContext
    {

        public User GetUserByEmail(string email)
        {
            return this.Users.Where(user => user.Email == email).FirstOrDefault(); 
        }

        public User Login(string email, string pass)
        {
            return this.Users.Where(user => user.Email == email && user.Password == pass).FirstOrDefault();
        }

    }
}
