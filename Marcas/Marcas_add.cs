using AVI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_de_Inventario_y_ventas.Marcas
{
    public partial class Marcas_add : Form
    {
        public Marcas_add()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            AVI.Marca marca = new AVI.Marca();
            // Obtener el texto del TextBox para el nombre de la categoría
            string nombreMarca = txtNombreCategoria.Text;

            int ultimo = marca.Lastid();
            ultimo++;
            // Obtener el texto del TextBox para el Id de la categoría y convertirlo a entero

            if (!string.IsNullOrEmpty(nombreMarca))
            {

                bool resultado = marca.AgregarMarca(ultimo, nombreMarca);

                if (resultado)
                {
                    MessageBox.Show("Marca agregada exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la marca.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Id y un nombre válidos para la .");
            }
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marcas_add_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
