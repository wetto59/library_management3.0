using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public  class BorrowedBookViewModel
    {
         public int ID { get; set; }
         public string ClientName { get; set; }
         public string BookTitle { get; set; }
         public DateTime RegistrationDate { get; set; }
         public DateTime? ReturnDate { get; set; }
    }
}
