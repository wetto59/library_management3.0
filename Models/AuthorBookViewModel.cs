using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public class AuthorBookViewModel
    {
        public string BookTitle { get; set; }
        public int AvailableCopies { get; set; }
        public string Author { get; set; }
    }
}
