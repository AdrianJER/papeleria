using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papeleria
{
    public partial class MDI : Form
    {
        public Form currentChildForm;
        public int level;
        public MDI()
        {
            InitializeComponent();
        }
        public MDI(string user, int level)
        {
            InitializeComponent();
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            lblName.Text = user;
        }

        public void openForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForms.Controls.Add(childForm);
            pnlForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            openForm(new Sales());
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            openForm(new Inventory());
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
