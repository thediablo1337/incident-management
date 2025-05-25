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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersManagement usersForm = new UsersManagement();
            usersForm.Show();
            this.Hide(); // hide the login form
        }

        private void btnIncidents_Click(object sender, EventArgs e)
        {
            IncidentManagement incidentsForm = new IncidentManagement();
            incidentsForm.Show();
            this.Hide(); // hide the login form
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Logs logsForm = new Logs();
            logsForm.Show();
            this.Hide(); // hide the login form
        }
    }
}
