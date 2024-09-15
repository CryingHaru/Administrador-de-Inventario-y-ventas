using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_de_Inventario_y_ventas.Categorias
{
    public partial class Categorias_edit : Form
    {
        private int idCategoria;

        public Categorias_edit(int Idcategoria, string nombre)
        {
            InitializeComponent();
            idCategoria = Idcategoria;
            txtNombreCategoria.Text = nombre;
            txtIdCategoria.Text = Idcategoria.ToString();
        }

        private void Categorias_edit_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombreCategoria.Text;

            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                AVI.Categorias categorias = new AVI.Categorias();
                bool resultado = categorias.EditarCategoria(idCategoria, nuevoNombre);

                if (resultado)
                {
                    MessageBox.Show("Categoría editada exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al editar la categoría.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.");
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
