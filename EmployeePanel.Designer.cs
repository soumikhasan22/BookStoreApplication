namespace BookStoreApplication
{
    partial class EmployeePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_ModifyBooks2 = new BookStoreApplication.EmployeeUC.UC_ModifyBooks();
            this.uC_AddBooks2 = new BookStoreApplication.EmployeeUC.UC_AddBooks();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gunaButton4);
            this.panel1.Controls.Add(this.gunaButton5);
            this.panel1.Controls.Add(this.gunaButton2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 432);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(3, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee Panel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.gunaButton4.Location = new System.Drawing.Point(26, 331);
            this.gunaButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.gunaButton4.Size = new System.Drawing.Size(157, 37);
            this.gunaButton4.TabIndex = 8;
            this.gunaButton4.Text = "Log Out";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton5.Location = new System.Drawing.Point(26, 290);
            this.gunaButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.gunaButton5.Size = new System.Drawing.Size(157, 37);
            this.gunaButton5.TabIndex = 7;
            this.gunaButton5.Text = "Modify Books";
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(26, 249);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.gunaButton2.Size = new System.Drawing.Size(157, 37);
            this.gunaButton2.TabIndex = 6;
            this.gunaButton2.Text = "Add Books";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_ModifyBooks2);
            this.panel2.Controls.Add(this.uC_AddBooks2);
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 432);
            this.panel2.TabIndex = 0;
            // 
            // uC_ModifyBooks2
            // 
            this.uC_ModifyBooks2.Location = new System.Drawing.Point(0, 0);
            this.uC_ModifyBooks2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.uC_ModifyBooks2.Name = "uC_ModifyBooks2";
            this.uC_ModifyBooks2.Size = new System.Drawing.Size(502, 432);
            this.uC_ModifyBooks2.TabIndex = 1;
            // 
            // uC_AddBooks2
            // 
            this.uC_AddBooks2.BackColor = System.Drawing.Color.White;
            this.uC_AddBooks2.Location = new System.Drawing.Point(0, 0);
            this.uC_AddBooks2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.uC_AddBooks2.Name = "uC_AddBooks2";
            this.uC_AddBooks2.Size = new System.Drawing.Size(502, 432);
            this.uC_AddBooks2.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePanel";
            this.Load += new System.EventHandler(this.EmployeePanel_Load);
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
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private System.Windows.Forms.Label label2;
        private EmployeeUC.UC_AddBooks uC_AddBooks1;
        private EmployeeUC.UC_ModifyBooks uC_ModifyBooks1;
        private EmployeeUC.UC_AddBooks uC_AddBooks2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private EmployeeUC.UC_ModifyBooks uC_ModifyBooks2;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}