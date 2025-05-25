using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IncidentManagement
{
    public partial class UsersManagement : Form
    {
        public UsersManagement()
        {
            InitializeComponent();
        }

        private void UsersManagement_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=IncidentManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id,full_name,username,email,created_at,role,last_modified_at,modified_fields FROM users"; // Exclude password

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewUsers.DataSource = table;
            }
            comboBox1.Items.Clear();
            comboBox1.Items.Add("id");
            comboBox1.Items.Add("username");
            comboBox1.Items.Add("role");
            comboBox1.Items.Add("email");
            comboBox1.SelectedIndex = 0; // set default
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            // Get selected row and ID
            DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["id"].Value);

            // Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Delete from database
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=IncidentManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("User deletion failed.");
                }
            }

            // Refresh the table
            UsersManagement_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide(); // hide the login form
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEditUser addUserForm = new CreateEditUser(); // No ID = Add mode
            addUserForm.ShowDialog(); // Open the form as a modal dialog
            // Refresh the user list after adding
            UsersManagement_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["id"].Value);

                CreateEditUser editForm = new CreateEditUser(selectedUserId);
                editForm.ShowDialog();

                // Optionally refresh the DataGridView after editing
                UsersManagement_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedColumn = comboBox1.SelectedItem?.ToString() ?? string.Empty;
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=IncidentManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT id,full_name,username,email,created_at,role,last_modified_at,modified_fields FROM users WHERE {selectedColumn} LIKE @value";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@value", "%" + searchValue + "%");

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewUsers.DataSource = table;
            }
        }
    }
}
