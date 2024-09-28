using AVI;
using System;
using System.Data;
using System.Drawing;
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
            string nombreMarca = txtNombreCategoria.Text;
            int ultimo = marca.Lastid();
            ultimo++;

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
                MessageBox.Show("Por favor, ingrese un nombre válido para la marca.");
            }
        }

        private void AplicarEstiloBoton(Button button)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.Gold;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Gold;
            button.FlatAppearance.BorderSize = 2;
        }

        private void AplicarEstiloInput(TextBox textBox)
        {
            textBox.BackColor = Color.Black;
            textBox.ForeColor = Color.Gold;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void Marcas_add_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            AplicarEstiloBoton(rjButton1);
            AplicarEstiloBoton(Cerrar);
            AplicarEstiloInput(txtNombreCategoria);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
