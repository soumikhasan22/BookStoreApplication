using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Lginform lginform = new Lginform();
            lginform.Show();
            this.Hide();
        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            uC_AddBooks2.Visible = false;
            uC_ModifyBooks2.Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            uC_AddBooks2.Visible = true;
            uC_AddBooks2.BringToFront();
            uC_ModifyBooks2.Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            
            uC_ModifyBooks2.Visible = true;
            uC_ModifyBooks2.BringToFront();
            uC_AddBooks2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
