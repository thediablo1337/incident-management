namespace IncidentManagement
{
    partial class CreateEditUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtCreatedAt = new TextBox();
            txtRole = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtModifiedFields = new TextBox();
            label7 = new Label();
            txtUpdatedAt = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblMode = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Created At";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 85);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 52);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "FullName";
            // 
            // txtId
            // 
            txtId.Location = new Point(157, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.Location = new Point(157, 177);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.ReadOnly = true;
            txtCreatedAt.Size = new Size(125, 27);
            txtCreatedAt.TabIndex = 7;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(157, 144);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(157, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(157, 45);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 11;
            // 
            // txtModifiedFields
            // 
            txtModifiedFields.Location = new Point(157, 243);
            txtModifiedFields.Name = "txtModifiedFields";
            txtModifiedFields.ReadOnly = true;
            txtModifiedFields.Size = new Size(125, 27);
            txtModifiedFields.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 250);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 12;
            label7.Text = "Modified Fields";
            // 
            // txtUpdatedAt
            // 
            txtUpdatedAt.Location = new Point(157, 210);
            txtUpdatedAt.Name = "txtUpdatedAt";
            txtUpdatedAt.ReadOnly = true;
            txtUpdatedAt.Size = new Size(125, 27);
            txtUpdatedAt.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 217);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 14;
            label8.Text = "Last Modified At";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(188, 312);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Location = new Point(575, 57);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(0, 20);
            lblMode.TabIndex = 18;
            // 
            // CreateEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMode);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUpdatedAt);
            Controls.Add(label8);
            Controls.Add(txtModifiedFields);
            Controls.Add(label7);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtRole);
            Controls.Add(txtCreatedAt);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateEditUser";
            Text = "CreateEditUser";
            Load += CreateEditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtCreatedAt;
        private TextBox txtRole;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox txtModifiedFields;
        private Label label7;
        private TextBox txtUpdatedAt;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private Label lblMode;
    }
}