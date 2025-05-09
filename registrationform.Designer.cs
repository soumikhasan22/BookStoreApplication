namespace BookStoreApplication
{
    partial class registrationform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regusername = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regpassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.Label();
            this.regconpassword = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_backtologin = new System.Windows.Forms.Button();
            this.regmobile = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.Label();
            this.regemail = new System.Windows.Forms.TextBox();
            this.txtbirthday = new System.Windows.Forms.Label();
            this.regdob = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(387, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(401, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // regname
            // 
            this.regname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regname.ForeColor = System.Drawing.Color.Black;
            this.regname.Location = new System.Drawing.Point(530, 126);
            this.regname.Multiline = true;
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(286, 23);
            this.regname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(366, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "UserName";
            // 
            // regusername
            // 
            this.regusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regusername.ForeColor = System.Drawing.Color.Black;
            this.regusername.Location = new System.Drawing.Point(530, 162);
            this.regusername.Multiline = true;
            this.regusername.Name = "regusername";
            this.regusername.Size = new System.Drawing.Size(286, 23);
            this.regusername.TabIndex = 3;
            // 
            // txtmobile
            // 
            this.txtmobile.AutoSize = true;
            this.txtmobile.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtmobile.Location = new System.Drawing.Point(390, 268);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(66, 23);
            this.txtmobile.TabIndex = 1;
            this.txtmobile.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(374, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password";
            // 
            // regpassword
            // 
            this.regpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regpassword.ForeColor = System.Drawing.Color.Black;
            this.regpassword.Location = new System.Drawing.Point(530, 197);
            this.regpassword.Multiline = true;
            this.regpassword.Name = "regpassword";
            this.regpassword.PasswordChar = '*';
            this.regpassword.Size = new System.Drawing.Size(286, 23);
            this.regpassword.TabIndex = 4;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.AutoSize = true;
            this.txtConfirmPass.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtConfirmPass.Location = new System.Drawing.Point(303, 231);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(155, 23);
            this.txtConfirmPass.TabIndex = 1;
            this.txtConfirmPass.Text = "Confirm Password";
            // 
            // regconpassword
            // 
            this.regconpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regconpassword.ForeColor = System.Drawing.Color.Black;
            this.regconpassword.Location = new System.Drawing.Point(530, 231);
            this.regconpassword.Multiline = true;
            this.regconpassword.Name = "regconpassword";
            this.regconpassword.PasswordChar = '*';
            this.regconpassword.Size = new System.Drawing.Size(286, 24);
            this.regconpassword.TabIndex = 5;
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button_register.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.ForeColor = System.Drawing.Color.White;
            this.button_register.Location = new System.Drawing.Point(530, 398);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(279, 52);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "REGISTER";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_backtologin
            // 
            this.button_backtologin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button_backtologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backtologin.ForeColor = System.Drawing.Color.White;
            this.button_backtologin.Location = new System.Drawing.Point(530, 463);
            this.button_backtologin.Name = "button_backtologin";
            this.button_backtologin.Size = new System.Drawing.Size(279, 44);
            this.button_backtologin.TabIndex = 6;
            this.button_backtologin.Text = "Back To Login";
            this.button_backtologin.UseVisualStyleBackColor = false;
            this.button_backtologin.Click += new System.EventHandler(this.button2_Click);
            // 
            // regmobile
            // 
            this.regmobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regmobile.ForeColor = System.Drawing.Color.Black;
            this.regmobile.Location = new System.Drawing.Point(530, 267);
            this.regmobile.Multiline = true;
            this.regmobile.Name = "regmobile";
            this.regmobile.Size = new System.Drawing.Size(286, 24);
            this.regmobile.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtemail.Location = new System.Drawing.Point(401, 302);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(54, 23);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "Email";
            // 
            // regemail
            // 
            this.regemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regemail.ForeColor = System.Drawing.Color.Black;
            this.regemail.Location = new System.Drawing.Point(530, 301);
            this.regemail.Multiline = true;
            this.regemail.Name = "regemail";
            this.regemail.Size = new System.Drawing.Size(286, 24);
            this.regemail.TabIndex = 7;
            // 
            // txtbirthday
            // 
            this.txtbirthday.AutoSize = true;
            this.txtbirthday.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbirthday.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtbirthday.Location = new System.Drawing.Point(337, 344);
            this.txtbirthday.Name = "txtbirthday";
            this.txtbirthday.Size = new System.Drawing.Size(118, 23);
            this.txtbirthday.TabIndex = 8;
            this.txtbirthday.Text = "Date Of Birth";
            // 
            // regdob
            // 
            this.regdob.CustomFormat = "dd-MM-yyyy";
            this.regdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.regdob.Location = new System.Drawing.Point(530, 344);
            this.regdob.Name = "regdob";
            this.regdob.Size = new System.Drawing.Size(200, 22);
            this.regdob.TabIndex = 9;
            // 
            // registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 558);
            this.Controls.Add(this.regdob);
            this.Controls.Add(this.txtbirthday);
            this.Controls.Add(this.regemail);
            this.Controls.Add(this.regmobile);
            this.Controls.Add(this.button_backtologin);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.regconpassword);
            this.Controls.Add(this.regpassword);
            this.Controls.Add(this.regusername);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrationform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "registrationform";
            this.Load += new System.EventHandler(this.registrationform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regusername;
        private System.Windows.Forms.Label txtmobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regpassword;
        private System.Windows.Forms.Label txtConfirmPass;
        private System.Windows.Forms.TextBox regconpassword;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_backtologin;
        private System.Windows.Forms.TextBox regmobile;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.TextBox regemail;
        private System.Windows.Forms.Label txtbirthday;
        private System.Windows.Forms.DateTimePicker regdob;
    }
}