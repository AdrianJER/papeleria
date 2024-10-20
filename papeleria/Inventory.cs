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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            string query = "SELECT id_item,name_item,trademark,color,stock,minimum,inventory_price FROM inventory where status_item = 1";
            dgListItem.DataSource = connection.query(query);
            designDG.inventory(dgListItem);
        }
        
    }
}
