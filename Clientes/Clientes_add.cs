using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVI;

namespace Administrador_de_Inventario_y_ventas.Categorias
{
    public partial class Clientes_add : Form
    {
        public Clientes_add()
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
            AVI.Categorias categorias = new AVI.Categorias();
            // Obtener el texto del TextBox para el nombre de la categoría
            string nombreCategoria = txtNombreCategoria.Text;

            DataTable valores = categorias.UltimoId();
            int ultimo = int.Parse(valores.Rows[0][0].ToString());
            ultimo++;
            // Obtener el texto del TextBox para el Id de la categoría y convertirlo a entero

            if (!string.IsNullOrEmpty(nombreCategoria))
            {
                
                bool resultado = categorias.AgregarCategoria(ultimo,nombreCategoria);

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
