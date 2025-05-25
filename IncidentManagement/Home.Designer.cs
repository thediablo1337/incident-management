namespace IncidentManagement
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogs = new Button();
            btnIncidents = new Button();
            btnUsers = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogs
            // 
            btnLogs.Location = new Point(487, 189);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(104, 29);
            btnLogs.TabIndex = 0;
            btnLogs.Text = "Activity Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnIncidents
            // 
            btnIncidents.Location = new Point(295, 189);
            btnIncidents.Name = "btnIncidents";
            btnIncidents.Size = new Size(94, 29);
            btnIncidents.TabIndex = 1;
            btnIncidents.Text = "Incidents";
            btnIncidents.UseVisualStyleBackColor = true;
            btnIncidents.Click += btnIncidents_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(127, 189);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 29);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Location = new Point(266, 106);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "Welcome, admin.";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnUsers);
            Controls.Add(btnIncidents);
            Controls.Add(btnLogs);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogs;
        private Button btnIncidents;
        private Button btnUsers;
        private Label label1;
    }
}