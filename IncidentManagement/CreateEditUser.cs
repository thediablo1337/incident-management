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
using Microsoft.VisualBasic.ApplicationServices;

namespace IncidentManagement
{
    public partial class CreateEditUser : Form
    {
        private int? userId = null;
        private bool isEditMode;
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=IncidentManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public CreateEditUser()
        {
            InitializeComponent();
            isEditMode = false;
        }
        public CreateEditUser(int id)
        {
            InitializeComponent();
            userId = id;
            isEditMode = true;
        }

        private void CreateEditUser_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                lblMode.Text = "Edit User";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtId.Text = reader["id"].ToString();
                        txtFullName.Text = reader["full_name"].ToString();
                        txtUsername.Text = reader["username"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtRole.Text = reader["role"].ToString();
                        txtCreatedAt.Text = reader["created_at"].ToString();
                        txtUpdatedAt.Text = reader["last_modified_at"].ToString();
                        txtModifiedFields.Text = reader["modified_fields"].ToString();
                    }
                }
            }
            else
            {
                lblMode.Text = "Add User";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (isEditMode)
                {
                    // UPDATE existing user
                    string query = @"UPDATE users SET 
                    full_name = @full_name, 
                    username = @username, 
                    email = @email, 
                    role = @role
                 WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@role", txtRole.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully.");
                }
                else
                {
                    // INSERT new user
                    string query = @"INSERT INTO users 
                                (full_name, username, email, role)
                             VALUES 
                                (@full_name, @username, @email, @role)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@role", txtRole.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                }

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
