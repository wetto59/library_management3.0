using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        public string Email { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        public string Password { get; set; }

        [Column("date_register")]
        public DateTime DateRegister { get; set; }

        public User()
        {

        }

        public User(int id, string email, string username, string password, DateTime dateRegister) 
        {
            this.ID = id;
            this.Email = email;
            this.UserName = username;
            this.Password = password;
            this.DateRegister = dateRegister;
        }
    }
}
