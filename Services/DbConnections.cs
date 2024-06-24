using Library_manangement.Data;
using Library_manangement.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_manangement.Services
{

    public class DbConnections
    {

        public static void RegisterBook(int cid, int bid)
        {
            using (var dbContext = new LibraryDbContext())
            {
                var book = dbContext.Books.FirstOrDefault(b => b.ID == bid);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                if (book.TotalCopies < 1)
                {
                    MessageBox.Show("No copies available.");
                    return;
                }

                var client = dbContext.Clients.FirstOrDefault(c => c.ID == cid);
                if (client == null)
                {
                    MessageBox.Show("Client not found.");
                    return;
                }

                var registration = new BooksRegistration
                {
                    BookID = bid,
                    ClientID = cid,
                    RegistrationDate = DateTime.Now
                };

                dbContext.BooksRegistrations.Add(registration);
                book.TotalCopies -= 1;

                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Book registered successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        public static List<Issue> GetIssuedBooks()
        {
            using (var db = new LibraryDbContext())
            {
                return db.Issues.ToList();
            }
        }

        public static void DeleteBookData(Book deletedBook)
        {
            using (var db = new LibraryDbContext())
            {
                var book = db.Books.FirstOrDefault(x => x.ID == deletedBook.ID);
                try
                {
                    if (book != null)
                    {
                        db.Books.Remove(book);
                        db.SaveChanges();
                        MessageBox.Show("The book has been deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found!");

                    }
                }
                catch (Exception ex)
                {
                    var detailedMessage = $"An error occurred: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                    }
                    MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public static void UpdateBookData(Book updatedBook)
        {
            try
            {
                using (var dbContext = new LibraryDbContext())
                {
                    var book = dbContext.Books.FirstOrDefault(x => x.ID == updatedBook.ID);
                    if (book != null)
                    {
                        book.BookTitle = updatedBook.BookTitle;
                        book.Author = updatedBook.Author;
                        book.Published = updatedBook.Published;
                        book.Status = updatedBook.Status;
                        book.DateUpdate = updatedBook.DateUpdate;
                        book.TotalCopies = updatedBook.TotalCopies;

                        dbContext.SaveChanges();
                        MessageBox.Show("The book has been updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Book> GetBooks()
        {
            using (var dbContext = new LibraryDbContext())
            {
                return dbContext.Books.ToList();
            }
        }

        public static void AddUserInDB(User newUser)
        {
            using (var dbContext = new LibraryDbContext())
            {

                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                CashedData.usersInfo.Add(newUser);
                MessageBox.Show("Registration successful!");
            }
        }

        public static void AddBookData(Book newBook)
        {
            try
            {
                using (var dbContext = new LibraryDbContext())
                {

                    dbContext.Books.Add(newBook);
                    dbContext.SaveChanges();
                    CashedData.bookInfo.Add(newBook);
                    MessageBox.Show("The book added successful!");

                    //var selectData = dbContext.Books.Where(b => b.DateDelete == null).ToList();

                }
            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void AddIssuedBookData(Issue newBook) 
        {
            try
            {
                using (var dbContext = new LibraryDbContext())
                {

                    dbContext.Issues.Add(newBook);
                    dbContext.SaveChanges();
                    CashedData.IssuedBook.Add(newBook);
                    MessageBox.Show("The book added successful!");
                }
            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateIssuedBookData(Issue updatedIssuedBook) 
        {
            try
            {
                using (var db = new LibraryDbContext())
                {
                    var book = db.Issues.FirstOrDefault(x => x.ID == updatedIssuedBook.ID);

                    if (book != null) 
                    {
                        book.ID = updatedIssuedBook.ID;
                        book.Issue_ID = updatedIssuedBook.Issue_ID;
                        book.Full_Name = updatedIssuedBook.Full_Name;
                        book.Email = updatedIssuedBook.Email;
                        book.Contact = updatedIssuedBook.Contact;
                        book.Book_Title = updatedIssuedBook.Book_Title;
                        book.Author = updatedIssuedBook.Author;
                        book.Issue_Date = updatedIssuedBook.Issue_Date;
                        book.Return_Date = updatedIssuedBook.Return_Date;
                        book.Status = updatedIssuedBook.Status;

                        db.SaveChanges();
                        MessageBox.Show("The issued book has been updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                var detailedMessage = $"An error occurred: {ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(detailedMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
