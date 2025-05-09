namespace BookStoreApplication.EmployeeUC
{
    partial class UC_AddBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.resetBtn = new Guna.UI.WinForms.GunaButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(29, 94);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(181, 23);
            this.txtTitle.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Author Name";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(29, 152);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(181, 23);
            this.txtAuthor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ISBN No";
            this.label4.TextChanged += new System.EventHandler(this.label4_TextChanged);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(29, 213);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(181, 23);
            this.txtIsbn.TabIndex = 14;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(304, 94);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(181, 23);
            this.txtGenre.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(304, 167);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 23);
            this.txtPrice.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(26, 26);
            this.btnAdd.Location = new System.Drawing.Point(230, 261);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.White;
            this.btnAdd.Radius = 19;
            this.btnAdd.Size = new System.Drawing.Size(107, 27);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.AnimationHoverSpeed = 0.07F;
            this.resetBtn.AnimationSpeed = 0.03F;
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.resetBtn.BorderColor = System.Drawing.Color.Black;
            this.resetBtn.BorderSize = 1;
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resetBtn.FocusedColor = System.Drawing.Color.Empty;
            this.resetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.ImageSize = new System.Drawing.Size(26, 26);
            this.resetBtn.Location = new System.Drawing.Point(377, 261);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.OnHoverBaseColor = System.Drawing.Color.Black;
            this.resetBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resetBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.resetBtn.OnHoverImage = null;
            this.resetBtn.OnPressedColor = System.Drawing.Color.White;
            this.resetBtn.Radius = 19;
            this.resetBtn.Size = new System.Drawing.Size(107, 27);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(243, 316);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "*Check ISBN No Once before Adding";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(220, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(44, 241);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(99, 106);
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(149, 261);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(61, 45);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "ADD PICTURE";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // UC_AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_AddBooks";
            this.Size = new System.Drawing.Size(502, 432);
            this.Load += new System.EventHandler(this.UC_AddBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton resetBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
