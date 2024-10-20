using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papeleria
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT name_user,lastname_user,usr,pass,level_user FROM users WHERE usr='" + txtUser.Text +"' AND pass='" + txtPass.Text +"' AND status_user =1";
                DataTable dataTable= connection.query(query);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Se ha iniciado sesion correctamente");
                    string user = dataTable.Rows[0][0].ToString() + " " + dataTable.Rows[0][1].ToString();
                    int level = Int32.Parse(dataTable.Rows[0][4].ToString());
                    Form mdi = new MDI(user,level);
                    mdi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o son incorrectos, intentelo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error, por favor contacte al proveedor");
            }
        }
    }
}
