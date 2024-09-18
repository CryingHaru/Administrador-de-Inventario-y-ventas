using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AVI
{
    public partial class Marcas_edit : Form
    {
        private int idMarca;
        public Marcas_edit(int idmarca, string nombreMarca)
        {
            InitializeComponent();
            idMarca = idmarca;
            txtnombreMarca.Text = nombreMarca;
        }

        private void Marcas_edit_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtnombreMarca.Text;

            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                AVI.Marca marcas = new AVI.Marca();
                bool resultado = marcas.EditarCategoria(idMarca, nuevoNombre);

                if (resultado)
                {
                    MessageBox.Show("Marca editada exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al editar la Marca.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para la Marca.");
            }
        }
    }
}
