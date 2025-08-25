namespace View
{
    partial class Person
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            dgvPerson = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.Location = new Point(702, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 49);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 255, 128);
            btnEdit.Location = new Point(702, 169);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 49);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 128);
            btnDelete.Location = new Point(702, 251);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGray;
            btnRefresh.Location = new Point(702, 331);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 49);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(128, 255, 128);
            btnBack.Location = new Point(702, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 49);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 88);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "FirstName :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(81, 111);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(221, 27);
            txtFirstName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "LastName :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(319, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(221, 27);
            txtLastName.TabIndex = 8;
            // 
            // dgvPerson
            // 
            dgvPerson.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(81, 169);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.Size = new Size(459, 288);
            dgvPerson.TabIndex = 9;
            dgvPerson.CellClick += dgvPerson_CellClick;
            dgvPerson.CellContentClick += dgvPerson_CellContentClick;
            // 
            // Person
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 719);
            Controls.Add(dgvPerson);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Person";
            Text = "Person";
            Load += Person_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnBack;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private DataGridView dgvPerson;
    }
}