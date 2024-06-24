using Library_manangement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Data
{
    public class LibraryDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<BooksRegistration> BooksRegistrations { get; set; }

        public DbSet<BorrowedBookViewModel> BorrowedBookViewModels { get; set; }


        public int GetAvailableBooksCount()
        {
            return Books.Sum(b => b.TotalCopies - BooksRegistrations.Count(br => br.BookID == b.ID && br.ReturnDate == null));
        }

       
        public int GetRegisteredClientsCount()
        {
            return Clients.Count();
        }

        
        public List<AuthorBookViewModel> GetBooksByAuthor(string keyword)
        {
            var booksByAuthor = from book in Books
                                where book.Author.Contains(keyword)
                                select new AuthorBookViewModel
                                {
                                    Author = book.Author,
                                    BookTitle = book.BookTitle,
                                    AvailableCopies = book.TotalCopies - BooksRegistrations.Count(br => br.BookID == book.ID && br.ReturnDate == null)
                                };

            return booksByAuthor.ToList();
        }

        public List<AuthorBookViewModel> GetBooksByTitleKeyword(string keyword)
        {
            var booksByTitle = from book in Books
                               where book.BookTitle.Contains(keyword)
                               select new AuthorBookViewModel
                               {
                                   Author = book.Author,
                                   BookTitle = book.BookTitle,
                                   AvailableCopies = book.TotalCopies - BooksRegistrations.Count(br => br.BookID == book.ID && br.ReturnDate == null)
                               };

            return booksByTitle.ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=library_management";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
            optionsBuilder.UseMySql(connectionString,serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.BookTitle).HasColumnName("BookTitle"); // Adjust if needed
                entity.Property(e => e.Author).HasColumnName("Author");
                entity.Property(e => e.Published).HasColumnName("Published");
                entity.Property(e => e.Status).HasColumnName("Status");
                entity.Property(e => e.DataInsert).HasColumnName("DataInsert");
                entity.Property(e => e.DateDelete).HasColumnName("DateDelete");  // Nullable field
                entity.Property(e => e.DateUpdate).HasColumnName("DateUpdate");  // Nullable field
            });
        }
    }
}
