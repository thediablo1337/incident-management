using Microsoft.Data.SqlClient;

namespace IncidentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=IncidentManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT password, role FROM users WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string dbPassword = reader["password"]?.ToString()?.Trim() ?? string.Empty;
                    string role = reader["role"]?.ToString()?.Trim() ?? string.Empty;

                    if (password == dbPassword)
                    {
                        if (role.ToLower() == "admin")
                        {
                            Home homeForm = new Home();
                            homeForm.Show();
                            this.Hide(); // hide the login form
                        }
                        else
                        {
                            lblMessage.ForeColor = Color.Red;
                            lblMessage.Text = "Access denied. Admins only.";
                        }
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Invalid password.";
                    }
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "User not found.";
                }

                reader.Close();
            }
        }
    }
}
