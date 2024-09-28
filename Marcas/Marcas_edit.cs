using System;
using System.Drawing;
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

            this.BackColor = Color.Black;
            AplicarEstiloBoton(rjButton1);
            AplicarEstiloBoton(Cerrar);
            AplicarEstiloInput(txtnombreMarca);
            AplicarEstiloInput(Idmarca);
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
