namespace Jisainterview.Models
{
    public class UserDAL
    {
        List<User> Users;
        public UserDAL()
        {
            Users = new List<User>()
            {
                new User() {Username="abc",Password="abc123",Email="abc@gmail.com"},
                new User() {Username="xyz",Password="xyz123",Email="xyz@gmail.com"},
            }; 
        }

        public int ValidateUser(User user)
        {
            int res = 0;
            foreach (User u in Users)
            {
                if(u.Username==user.Username && u.Password == user.Password)
                {
                    res = 1;
                    break;
                }
            }
            return res;
        }
    }
}
