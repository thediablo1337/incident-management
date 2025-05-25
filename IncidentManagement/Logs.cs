using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncidentManagement
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void dataGridViewIncident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Logs_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=IncidentManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM activity_logs";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewIncident.DataSource = table;
            }
        }
    }
}
