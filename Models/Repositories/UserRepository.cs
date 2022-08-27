using Daewoo_Web_Application.Models;
using Daewoo_Web_Application.Models.Interfaces;
//using Microsoft.Data.SqlClient;
using System.Linq;
namespace Daewoo_Web_Application.Models
{

    public class UserRepository : IUserRepo
    {

        public int AddUser(User user)
        {

            var DB = new DaewooExpressApplicationContext();                  // Making connection with DataBase Context

            var emailMatch = DB.Users.Any(u => u.Email == user.Email);       // Checking if a user is having same Email
            if (emailMatch)
                return 0;

            var numberMatch = DB.Users.Any(u => u.Number == user.Number);    // Checking if a user is having same Phone Number
            if (numberMatch)
                return -1;

            User newUser = new User { Name = user.Name, Number = user.Number, CNIC = user.CNIC, Email = user.Email, Password = user.Password, ProfilePicture=user.ProfilePicture };
            DB.Users.Add(newUser);
            int flag = DB.SaveChanges();
            if (flag >= 1)
                return 1;
            else
                return 0;
        }

        public bool Check_Credentials(User user)
        {
            var DB = new DaewooExpressApplicationContext();                  // Making connection with DataBase Context

            var query = DB.Users.Any(u => u.Email == user.Email && u.Password == user.Password);
            if (query) return true;
            else return false;
        }

        public List<User> GetUsers()
        {
            var DB = new DaewooExpressApplicationContext();                  // Making connection with DataBase Context

            var query = DB.Users.Select(user => new { user.ID, user.Name, user.Number, user.CNIC, user.Email });

            List<User>? users = new List<User>();
            if (query != null)
            {
                foreach (var u in query)
                {
                    User user = new User { ID = u.ID, Name = u.Name, Number = u.Number, CNIC = u.CNIC, Email = u.Email };
                    users.Add(user);
                }
                return users;
            }
            return users;
        }
    }
}
