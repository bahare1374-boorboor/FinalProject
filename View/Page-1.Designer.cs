namespace View
{
    partial class Page_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_1));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnProduct = new Button();
            btnPerson = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnProduct);
            groupBox1.Controls.Add(btnPerson);
            groupBox1.Location = new Point(307, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "FinalProject";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(131, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 116);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 2;
            label1.Text = "Please choose one of the options";
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.White;
            btnProduct.Location = new Point(57, 264);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(220, 99);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnPerson
            // 
            btnPerson.BackColor = Color.White;
            btnPerson.Location = new Point(57, 159);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(220, 99);
            btnPerson.TabIndex = 0;
            btnPerson.Text = "Person";
            btnPerson.UseVisualStyleBackColor = false;
            btnPerson.Click += btnPerson_Click;
            // 
            // Page_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 521);
            Controls.Add(groupBox1);
            Name = "Page_1";
            Text = "Page_1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnProduct;
        private Button btnPerson;
        private PictureBox pictureBox1;
        private Label label1;
    }
}