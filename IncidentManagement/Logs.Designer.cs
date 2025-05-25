namespace IncidentManagement
{
    partial class Logs
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
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            comboBox1 = new ComboBox();
            btnAdd = new Button();
            btnBack = new Button();
            dataGridViewIncident = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncident).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(274, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(149, 27);
            txtSearch.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(629, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(529, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(174, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(429, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(17, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIncident
            // 
            dataGridViewIncident.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewIncident.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIncident.Location = new Point(17, 82);
            dataGridViewIncident.Name = "dataGridViewIncident";
            dataGridViewIncident.RowHeadersWidth = 51;
            dataGridViewIncident.Size = new Size(766, 356);
            dataGridViewIncident.TabIndex = 17;
            dataGridViewIncident.CellContentClick += dataGridViewIncident_CellContentClick;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(comboBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewIncident);
            Name = "Logs";
            Text = "Logs";
            Load += Logs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncident).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private ComboBox comboBox1;
        private Button btnAdd;
        private Button btnBack;
        private DataGridView dataGridViewIncident;
    }
}