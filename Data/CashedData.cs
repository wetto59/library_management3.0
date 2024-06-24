using Library_manangement.Models;
using Library_manangement.Data;

namespace Library_manangement.Data
{
    public class CashedData
    {
        public static List<User> usersInfo = new List<User>();
        public static User CurrentUser = new User();

        public static List <Book> bookInfo = new List<Book>(); 
        public static Book CurrentBook = new Book();

        public static List<Issue> IssuedBook = new List<Issue>();

        public static List<Client> Clients = new List<Client>();
    }
}
