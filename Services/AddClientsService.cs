using Library_manangement.Data;
using Library_manangement.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Services
{
    public class AddClientsService
    {
        public static void AddClientInDb(Client newClient)
        {
			try
			{
                using (var db = new LibraryDbContext()) 
                {
                    db.Clients.Add(newClient);
                    db.SaveChanges();
                    MessageBox.Show("The client added successful!");
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

        public static List<Client> GetClients()
        {
            using (var db = new LibraryDbContext())
            {
                return db.Clients.ToList();
            }
        }

        public static void DeleteClientsFromDb(Client deletedClient) 
        {
            using (var db = new LibraryDbContext())
            {
                var client = db.Clients.FirstOrDefault(x => x.ID == deletedClient.ID);
                try
                {
                    if (client != null)
                    {
                        db.Clients.Remove(client);
                        db.SaveChanges();
                        MessageBox.Show("The client has been deleted successfully!");
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
    }
}
