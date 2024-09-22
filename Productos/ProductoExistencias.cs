using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVI;
using System.Windows.Forms;

namespace AVI
{
    public partial class ProductoExistencias : Form
    {
        int id;
        public ProductoExistencias(int id)
        {
            this.id = id;
            InitializeComponent();
            accion.SelectedIndex = 0;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            //only numbers
            if (int.TryParse(textBox1.Text, out int result))
            {
                producto.Existencias(id, accion.SelectedIndex == 0, result);
            }

            //actualizar editar y productos
           Productos_list prod =  (Productos_list)Application.OpenForms["Productos_list"];
            if (prod != null)
            {
                prod.Actualizar();
            }
            this.Close();
        }
    }
}
