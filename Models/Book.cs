using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Models
{
    public class Book
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("book_title")]
        public string BookTitle { get; set; }

        public string Author { get; set; }

        public int TotalCopies { get; set; }

        public DateTime Published { get; set; }
        public string Status { get; set; }
        public DateTime DataInsert { get; set; }
        public DateTime? DateDelete { get; set; }
        public DateTime? DateUpdate { get; set; }

        public Book() 
        {

        }
        public Book (int id, string bookTitle, string author, int totalCopies,DateTime published, string status, DateTime dataInsert,DateTime dateDelete, DateTime dateUpdate) 
        {
            this.ID = id;
            this.BookTitle = bookTitle;
            this.Author = author;
            this.TotalCopies = totalCopies;

            this.Published = published;
            this.Status = status;
            this.DataInsert = dataInsert;
            this.DateDelete = dateDelete;
            this.DateUpdate = dateUpdate;
        }
    }
}
