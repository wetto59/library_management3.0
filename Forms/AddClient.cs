using Library_manangement.Models;
using Library_manangement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_manangement
{
    public partial class AddClient : Form
    {
        private int clientID = 0;
        private Client selectedClient;
        public AddClient()
        {
            InitializeComponent();
            DisplayClients();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Btn_AddClientAdd_Click(object sender, EventArgs e)
        {
            if (Txt_AddClientContact.Text == ""
                || Txt_AddClientEmail.Text == ""
                || Txt_AddClientFullName.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newClient = new Client
            {
                ID = clientID,
                FullName = Txt_AddClientFullName.Text,
                Email = Txt_AddClientEmail.Text,
                Contact = Txt_AddClientContact.Text,
                DateRegistered = DateTime.Now

            };

            AddClientsService.AddClientInDb(newClient);
            ClearFields();
            DisplayClients();
        }

        public void ClearFields()
        {
            Txt_AddClientContact.Text = "";
            Txt_AddClientEmail.Text = "";
            Txt_AddClientFullName.Text = "";
        }

        public void DisplayClients()
        {
            List<Client> clients = AddClientsService.GetClients();
            dataGridView1.DataSource = clients;
        }

        private void Btn_AddClientClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Btn_AddClientUpdate_Click(object sender, EventArgs e)
        {
            if (Txt_AddClientContact.Text == ""
               || Txt_AddClientEmail.Text == ""
               || Txt_AddClientFullName.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clientID == 0)
            {
                MessageBox.Show("Please select a book to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatedClient = new Client
            {
                ID = clientID,
                Email = Txt_AddClientEmail.Text,
                FullName = Txt_AddClientFullName.Text,
                Contact = Txt_AddClientContact.Text,
            };

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to UPDATE CLIENT ID: " + clientID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AddClientsService.AddClientInDb(updatedClient);
                ClearFields();
                DisplayClients();
                clientID = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                clientID = (int)row.Cells[0].Value;
                Txt_AddClientFullName.Text = row.Cells[1].Value.ToString();
                Txt_AddClientEmail.Text = row.Cells[2].Value.ToString();
                Txt_AddClientContact.Text = row.Cells[3].Value.ToString();
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedRowIndex >= 0)
                {
                    selectedClient = dataGridView1.SelectedRows[0].DataBoundItem as Client;

                    if (selectedClient != null)
                    {
                        clientID = selectedClient.ID;
                        Txt_AddClientFullName.Text = selectedClient.FullName;
                        Txt_AddClientEmail.Text = selectedClient.Email;
                        Txt_AddClientContact.Text = selectedClient.Contact;
                    }
                }
            }
        }

        private void Btn_AddClientDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            clientID = (int)selectedRow.Cells["ID"].Value;

            var deletedClient = new Client
            {
                ID = clientID
            };


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE Book ID: " + clientID + " ?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AddClientsService.DeleteClientsFromDb(deletedClient);
                DisplayClients(); // Refresh the DataGridView
                ClearFields(); // Clear the input fields
                clientID = 0;
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //if (e.RowIndex != -1)
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //clientID = (int) row.Cells[0].Value;
        //Txt_AddClientFullName.Text = row.Cells[1].Value.ToString();
        //        Txt_AddClientEmail.Text = row.Cells[2].Value.ToString();
        //        Txt_AddClientContact.Text = row.Cells[3].Value.ToString();
        //    }
}
}
