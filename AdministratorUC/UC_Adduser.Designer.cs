namespace BookStoreApplication.AdministratorUC
{
    partial class UC_Adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Adduser));
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userRole = new Guna.UI.WinForms.GunaComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.resetBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtuserRole
            // 
            this.txtuserRole.AutoSize = true;
            this.txtuserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserRole.Location = new System.Drawing.Point(37, 109);
            this.txtuserRole.Name = "txtuserRole";
            this.txtuserRole.Size = new System.Drawing.Size(121, 29);
            this.txtuserRole.TabIndex = 1;
            this.txtuserRole.Text = "User Role";
            this.txtuserRole.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB(Date Of Birth)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Username";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // userRole
            // 
            this.userRole.BackColor = System.Drawing.Color.Transparent;
            this.userRole.BaseColor = System.Drawing.Color.White;
            this.userRole.BorderColor = System.Drawing.Color.Silver;
            this.userRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userRole.FocusedColor = System.Drawing.Color.Empty;
            this.userRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userRole.ForeColor = System.Drawing.Color.Black;
            this.userRole.FormattingEnabled = true;
            this.userRole.Items.AddRange(new object[] {
            "Admin User",
            "Employee User",
            "Normal User"});
            this.userRole.Location = new System.Drawing.Point(41, 164);
            this.userRole.Name = "userRole";
            this.userRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.userRole.Size = new System.Drawing.Size(270, 35);
            this.userRole.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(41, 274);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 30);
            this.txtName.TabIndex = 9;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMobileNumber.Location = new System.Drawing.Point(42, 463);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(270, 30);
            this.txtMobileNumber.TabIndex = 10;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.txtEmailAddress.Location = new System.Drawing.Point(360, 184);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(270, 30);
            this.txtEmailAddress.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(360, 286);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(270, 30);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(360, 385);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(270, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtDob
            // 
            this.txtDob.CalendarForeColor = System.Drawing.Color.Black;
            this.txtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.Location = new System.Drawing.Point(41, 367);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(270, 30);
            this.txtDob.TabIndex = 14;
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
            this.btnAdd.Location = new System.Drawing.Point(364, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.White;
            this.btnAdd.Radius = 19;
            this.btnAdd.Size = new System.Drawing.Size(160, 42);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.resetBtn.Location = new System.Drawing.Point(553, 454);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.OnHoverBaseColor = System.Drawing.Color.Black;
            this.resetBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resetBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.resetBtn.OnHoverImage = null;
            this.resetBtn.OnPressedColor = System.Drawing.Color.White;
            this.resetBtn.Radius = 19;
            this.resetBtn.Size = new System.Drawing.Size(160, 42);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetBtn.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(636, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(366, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "*Check User Role Once before Adding";
            // 
            // UC_Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuserRole);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UC_Adduser";
            this.Size = new System.Drawing.Size(753, 665);
            this.Load += new System.EventHandler(this.UC_Adduser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtuserRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox userRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker txtDob;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton resetBtn;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
