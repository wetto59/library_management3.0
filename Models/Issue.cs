using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public class Issue
    {
        public int ID { get; set; }

        public string Issue_ID { get; set; }

        public string Full_Name { get; set; }
        
        public string Contact { get; set; }

        public string Email { get; set; }

        public string Book_Title { get; set; }

        public string Author { get; set; }

        public string Status { get; set; }

        public DateTime Issue_Date { get; set; }

        public DateTime Return_Date { get; set; }

        public Issue()
        {
            
        }

        public Issue(int id, string issueID, string fullName, string contact, string email,
            string bookTitle, string author, string status, DateTime issueDate, DateTime returnDate)
        {
            this.ID = id;
            this.Issue_ID = issueID;
            this.Full_Name = fullName;
            this.Contact = contact;
            this.Email = email;
            this.Book_Title = bookTitle;
            this.Author = author;
            this.Status = status;
            this.Issue_Date = issueDate;
            this.Return_Date = returnDate;
        }
    }
}
