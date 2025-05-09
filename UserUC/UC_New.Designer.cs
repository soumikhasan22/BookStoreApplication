namespace BookStoreApplication.UserUC
{
    partial class UC_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_New));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gButtonuserlogout = new Guna.UI.WinForms.GunaButton();
            this.totalbookcart = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameshow = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.booksearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookNameSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.gButtonuserlogout);
            this.panel1.Controls.Add(this.totalbookcart);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.usernameshow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 40);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gButtonuserlogout
            // 
            this.gButtonuserlogout.AnimationHoverSpeed = 0.07F;
            this.gButtonuserlogout.AnimationSpeed = 0.03F;
            this.gButtonuserlogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gButtonuserlogout.BorderColor = System.Drawing.Color.Black;
            this.gButtonuserlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gButtonuserlogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gButtonuserlogout.FocusedColor = System.Drawing.Color.Empty;
            this.gButtonuserlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gButtonuserlogout.ForeColor = System.Drawing.Color.White;
            this.gButtonuserlogout.Image = ((System.Drawing.Image)(resources.GetObject("gButtonuserlogout.Image")));
            this.gButtonuserlogout.ImageSize = new System.Drawing.Size(30, 30);
            this.gButtonuserlogout.Location = new System.Drawing.Point(130, 2);
            this.gButtonuserlogout.Margin = new System.Windows.Forms.Padding(2);
            this.gButtonuserlogout.Name = "gButtonuserlogout";
            this.gButtonuserlogout.OnHoverBaseColor = System.Drawing.Color.White;
            this.gButtonuserlogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gButtonuserlogout.OnHoverForeColor = System.Drawing.Color.Black;
            this.gButtonuserlogout.OnHoverImage = null;
            this.gButtonuserlogout.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.gButtonuserlogout.Size = new System.Drawing.Size(142, 37);
            this.gButtonuserlogout.TabIndex = 6;
            this.gButtonuserlogout.Text = "Log Out";
            this.gButtonuserlogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gButtonuserlogout.Click += new System.EventHandler(this.gButtonuserlogout_Click);
            // 
            // totalbookcart
            // 
            this.totalbookcart.AutoSize = true;
            this.totalbookcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbookcart.ForeColor = System.Drawing.Color.White;
            this.totalbookcart.Location = new System.Drawing.Point(821, 9);
            this.totalbookcart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalbookcart.Name = "totalbookcart";
            this.totalbookcart.Size = new System.Drawing.Size(17, 17);
            this.totalbookcart.TabIndex = 4;
            this.totalbookcart.Text = "0";
            this.totalbookcart.Click += new System.EventHandler(this.totalbookcart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(840, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // usernameshow
            // 
            this.usernameshow.AutoSize = true;
            this.usernameshow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameshow.ForeColor = System.Drawing.Color.White;
            this.usernameshow.Location = new System.Drawing.Point(28, 9);
            this.usernameshow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameshow.Name = "usernameshow";
            this.usernameshow.Size = new System.Drawing.Size(59, 22);
            this.usernameshow.TabIndex = 1;
            this.usernameshow.Text = "label2";
            this.usernameshow.Click += new System.EventHandler(this.usernameshow_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 93);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(876, 406);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // booksearch
            // 
            this.booksearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.booksearch.DefaultText = "";
            this.booksearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.booksearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.booksearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.booksearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.booksearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.booksearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.booksearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.booksearch.Location = new System.Drawing.Point(397, 47);
            this.booksearch.Name = "booksearch";
            this.booksearch.PasswordChar = '\0';
            this.booksearch.PlaceholderText = "";
            this.booksearch.SelectedText = "";
            this.booksearch.Size = new System.Drawing.Size(200, 36);
            this.booksearch.TabIndex = 6;
            // 
            // BookNameSearch
            // 
            this.BookNameSearch.AutoSize = true;
            this.BookNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameSearch.Location = new System.Drawing.Point(273, 54);
            this.BookNameSearch.Name = "BookNameSearch";
            this.BookNameSearch.Size = new System.Drawing.Size(111, 20);
            this.BookNameSearch.TabIndex = 7;
            this.BookNameSearch.Text = "Book Name :";
            // 
            // UC_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 506);
            this.Controls.Add(this.BookNameSearch);
            this.Controls.Add(this.booksearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UC_New";
            this.Load += new System.EventHandler(this.UC_New_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameshow;
        private System.Windows.Forms.Label totalbookcart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton gButtonuserlogout;
        private Guna.UI2.WinForms.Guna2TextBox booksearch;
        private System.Windows.Forms.Label BookNameSearch;
    }
}