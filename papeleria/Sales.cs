using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace papeleria
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void txtItemSearch_Enter(object sender, EventArgs e)
        {
            string query = "SELECT name_item FROM inventory WHERE name_item LIKE '%" + txtItemSearch.Text + "' AND status_item = 1";

        }
    }
}
