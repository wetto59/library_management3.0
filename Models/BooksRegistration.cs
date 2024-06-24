using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public class BooksRegistration
    {
        public int ID { get; set; }

        public int BookID { get; set; }
        

        public int ClientID { get; set; }
      

        public DateTime RegistrationDate { get; set; }


        public DateTime? ReturnDate { get; set; }


        public BooksRegistration()
        {
            
        }
        public BooksRegistration(int id, int bookID, int clientID, DateTime registrationDate, DateTime returnDate)
        {
            this.ID = id;
            this.BookID = bookID;

            this.ClientID = clientID;

            this.RegistrationDate = registrationDate;

            this.ReturnDate = returnDate;
           
        }
    }
}
