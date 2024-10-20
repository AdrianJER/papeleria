using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class designDG
{
   public static DataGridView sales(DataGridView dg)
    {
        dg.Columns[0].HeaderText = "Nombre del producto";
        dg.Columns[1].HeaderText = "Marca";
        dg.Columns[2].HeaderText = "Color";
        dg.Columns[3].HeaderText = "Precio";
        dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        return dg;
    }
    public static DataGridView inventory(DataGridView dg)
    {
        dg.Columns[0].HeaderText = "ID";
        dg.Columns[1].HeaderText = "Nombre del producto";
        dg.Columns[2].HeaderText = "Marca";
        dg.Columns[3].HeaderText = "Color";
        dg.Columns[4].HeaderText = "Stock";
        dg.Columns[5].HeaderText = "Minimo";
        dg.Columns[6].HeaderText = "Precio";
        dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
        dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        return dg;
    }
}
