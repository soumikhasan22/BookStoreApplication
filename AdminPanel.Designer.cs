namespace BookStoreApplication
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnViewUser = new Guna.UI.WinForms.GunaButton();
            this.btnAdduser = new Guna.UI.WinForms.GunaButton();
            this.btnDashbord = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_ViewUser2 = new BookStoreApplication.AdministratorUC.UC_ViewUser();
            this.uC_Adduser2 = new BookStoreApplication.AdministratorUC.UC_Adduser();
            this.uC_Dashbord1 = new BookStoreApplication.AdministratorUC.UC_Dashbord();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaButton4);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAdduser);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 432);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton4.Location = new System.Drawing.Point(24, 344);
            this.gunaButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.gunaButton4.Size = new System.Drawing.Size(157, 37);
            this.gunaButton4.TabIndex = 3;
            this.gunaButton4.Text = "Log Out";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.AnimationHoverSpeed = 0.07F;
            this.btnViewUser.AnimationSpeed = 0.03F;
            this.btnViewUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.BorderColor = System.Drawing.Color.Black;
            this.btnViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(26, 295);
            this.btnViewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverImage = null;
            this.btnViewUser.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewUser.Size = new System.Drawing.Size(157, 37);
            this.btnViewUser.TabIndex = 2;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.AnimationHoverSpeed = 0.07F;
            this.btnAdduser.AnimationSpeed = 0.03F;
            this.btnAdduser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdduser.BorderColor = System.Drawing.Color.Black;
            this.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdduser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdduser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdduser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdduser.Image")));
            this.btnAdduser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdduser.Location = new System.Drawing.Point(24, 245);
            this.btnAdduser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAdduser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdduser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdduser.OnHoverImage = null;
            this.btnAdduser.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdduser.Size = new System.Drawing.Size(157, 37);
            this.btnAdduser.TabIndex = 1;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.AnimationHoverSpeed = 0.07F;
            this.btnDashbord.AnimationSpeed = 0.03F;
            this.btnDashbord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashbord.BorderColor = System.Drawing.Color.Black;
            this.btnDashbord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashbord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashbord.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashbord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashbord.Image")));
            this.btnDashbord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashbord.Location = new System.Drawing.Point(24, 204);
            this.btnDashbord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnDashbord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashbord.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashbord.OnHoverImage = null;
            this.btnDashbord.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashbord.Size = new System.Drawing.Size(157, 37);
            this.btnDashbord.TabIndex = 0;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashbord.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_ViewUser2);
            this.panel2.Controls.Add(this.uC_Adduser2);
            this.panel2.Controls.Add(this.uC_Dashbord1);
            this.panel2.Location = new System.Drawing.Point(181, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 432);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // uC_ViewUser2
            // 
            this.uC_ViewUser2.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser2.Location = new System.Drawing.Point(2, 0);
            this.uC_ViewUser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_ViewUser2.Name = "uC_ViewUser2";
            this.uC_ViewUser2.Size = new System.Drawing.Size(502, 432);
            this.uC_ViewUser2.TabIndex = 1;
            this.uC_ViewUser2.Load += new System.EventHandler(this.uC_ViewUser2_Load);
            // 
            // uC_Adduser2
            // 
            this.uC_Adduser2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Adduser2.Location = new System.Drawing.Point(0, 0);
            this.uC_Adduser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_Adduser2.Name = "uC_Adduser2";
            this.uC_Adduser2.Size = new System.Drawing.Size(502, 432);
            this.uC_Adduser2.TabIndex = 1;
            // 
            // uC_Dashbord1
            // 
            this.uC_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_Dashbord1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uC_Dashbord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Dashbord1.ForeColor = System.Drawing.Color.Black;
            this.uC_Dashbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashbord1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Dashbord1.Name = "uC_Dashbord1";
            this.uC_Dashbord1.Size = new System.Drawing.Size(502, 432);
            this.uC_Dashbord1.TabIndex = 1;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnDashbord;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton btnViewUser;
        private Guna.UI.WinForms.GunaButton btnAdduser;
        private System.Windows.Forms.Label label1;
        private AdministratorUC.UC_Adduser uC_Adduser1;
        private AdministratorUC.UC_ViewUser uC_ViewUser1;
        private AdministratorUC.UC_Adduser uC_Adduser2;
        private AdministratorUC.UC_Dashbord uC_Dashbord1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private AdministratorUC.UC_ViewUser uC_ViewUser2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}