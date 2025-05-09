namespace BookStoreApplication.EmployeeUC
{
    partial class UC_ModifyBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ModifyBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSync = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView2 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.txtIsbn = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.AnimationHoverSpeed = 0.07F;
            this.btnSync.AnimationSpeed = 0.03F;
            this.btnSync.BackColor = System.Drawing.Color.White;
            this.btnSync.BaseColor = System.Drawing.Color.White;
            this.btnSync.BorderColor = System.Drawing.Color.Black;
            this.btnSync.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSync.FocusedColor = System.Drawing.Color.Empty;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSync.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSync.Location = new System.Drawing.Point(131, 10);
            this.btnSync.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSync.Name = "btnSync";
            this.btnSync.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSync.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSync.OnHoverImage = null;
            this.btnSync.OnPressedColor = System.Drawing.Color.Black;
            this.btnSync.Size = new System.Drawing.Size(30, 31);
            this.btnSync.TabIndex = 15;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(26, 26);
            this.btnDelete.Location = new System.Drawing.Point(389, 395);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 19;
            this.btnDelete.Size = new System.Drawing.Size(107, 27);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gunaDataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView2.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView2.EnableHeadersVisualStyles = false;
            this.gunaDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.Location = new System.Drawing.Point(11, 123);
            this.gunaDataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaDataGridView2.Name = "gunaDataGridView2";
            this.gunaDataGridView2.RowHeadersVisible = false;
            this.gunaDataGridView2.RowHeadersWidth = 62;
            this.gunaDataGridView2.RowTemplate.Height = 28;
            this.gunaDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView2.Size = new System.Drawing.Size(473, 257);
            this.gunaDataGridView2.TabIndex = 13;
            this.gunaDataGridView2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView2.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView2.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView2_CellClick);
            this.gunaDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView2_CellContentClick);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(137, 186);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(160, 98);
            this.gunaDataGridView1.TabIndex = 12;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtIsbn
            // 
            this.txtIsbn.BaseColor = System.Drawing.Color.White;
            this.txtIsbn.BorderColor = System.Drawing.Color.Silver;
            this.txtIsbn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIsbn.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIsbn.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIsbn.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIsbn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.ForeColor = System.Drawing.Color.Black;
            this.txtIsbn.Location = new System.Drawing.Point(137, 79);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.PasswordChar = '\0';
            this.txtIsbn.SelectedText = "";
            this.txtIsbn.Size = new System.Drawing.Size(197, 28);
            this.txtIsbn.TabIndex = 11;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ISBN NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "View Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // UC_ModifyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gunaDataGridView2);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_ModifyBooks";
            this.Size = new System.Drawing.Size(502, 432);
            this.Load += new System.EventHandler(this.UC_ModifyBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnSync;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaTextBox txtIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
