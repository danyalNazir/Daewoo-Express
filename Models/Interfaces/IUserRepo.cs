namespace Daewoo_Web_Application.Models.Interfaces
{
    public interface IUserRepo
    {
        int AddUser( User user);
        bool Check_Credentials(User user);
        List<User> GetUsers();
    }
}
