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
            Idmarca.Text = idmarca.ToString();

            // Aplicar estilos a los controles
            this.BackColor = Color.Black; // Fondo negro del formulario
            AplicarEstiloBoton(rjButton1);
            AplicarEstiloBoton(Cerrar);
            AplicarEstiloInput(txtnombreMarca);
            AplicarEstiloInput(Idmarca);
        }

        // Método para aplicar estilo a los botones
        private void AplicarEstiloBoton(Button button)
        {
            button.BackColor = Color.Black; // Fondo negro
            button.ForeColor = Color.Gold;  // Texto dorado
            button.FlatStyle = FlatStyle.Flat;  // Botón plano
            button.FlatAppearance.BorderColor = Color.Gold;  // Borde dorado
            button.FlatAppearance.BorderSize = 2; // Grosor del borde
        }

        // Método para aplicar estilo a los TextBox (inputs)
        private void AplicarEstiloInput(TextBox textBox)
        {
            textBox.BackColor = Color.Black;  // Fondo negro
            textBox.ForeColor = Color.Gold;   // Texto dorado
            textBox.BorderStyle = BorderStyle.FixedSingle;  // Borde simple
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
                bool resultado = marcas.EditarMarca(idMarca, nuevoNombre);

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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Idmarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
