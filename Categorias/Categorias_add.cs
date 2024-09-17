using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVI;

namespace Administrador_de_Inventario_y_ventas.Categorias
{
    public partial class Categorias_add : Form
    {
        public Categorias_add()
        {
            InitializeComponent();
        }



        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox para el nombre de la categoría
            string nombreCategoria = txtNombreCategoria.Text;

            // Obtener el texto del TextBox para el Id de la categoría y convertirlo a entero
            int idCategoria;
            bool idValido = int.TryParse(txtIdCategoria.Text, out idCategoria);

            if (idValido && !string.IsNullOrEmpty(nombreCategoria))
            {
                AVI.Categorias categorias = new AVI.Categorias();
                bool resultado = categorias.AgregarCategoria(idCategoria, nombreCategoria);

                if (resultado)
                {
                    MessageBox.Show("Categoría agregada exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoría.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Id y un nombre válidos para la categoría.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Categorias_add_Load(object sender, EventArgs e)
        {

        }
    }
}
