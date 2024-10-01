using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace AVI
{
    public partial class Movimientos : Form
    {

        public Movimientos()
        {
           InitializeComponent();
           Productos movimientos = new Productos();
           DataTable content = movimientos.Movimientos();
        
            Mov.Columns.Add("Fecha", "Fecha");
            Mov.Columns.Add("Nombre", "Nombre");
            Mov.Columns.Add("Tipo", "Tipo");
            Mov.Columns.Add("Cantidad", "Cantidad");
      
            styles();

            foreach (DataRow row in content.Rows)
            {//if row  row[2] is equal to 0 in tipo set "salida" else "entrada"
                string tipo = row[1].ToString() == "0" ? "Salida" : "Entrada";
                Mov.Rows.Add(row[0], row[2], tipo, row[3]);

            }
        }

        void styles()
        {
            Mov.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mov.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mov.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mov.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mov.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
