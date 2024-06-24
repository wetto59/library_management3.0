using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public DateTime DateRegistered { get; set; }

        public Client()
        {
            
        }

        public Client(int id, string fullName, string email, string contact, DateTime dateRegisted)
        {
            this.ID = id;
            this.FullName = fullName;
            this.Email = email;
            this.Contact = contact;
            this.DateRegistered = dateRegisted;
        }
    }
}
