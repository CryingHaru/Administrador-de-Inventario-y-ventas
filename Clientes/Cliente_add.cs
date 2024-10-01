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

namespace Administrador_de_Inventario_y_ventas.Clientes
{
    public partial class Cliente_add : Form
    {
        public Cliente_add()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            AplicarEstiloBoton(rjButton1);
            AplicarEstiloBoton(Cerrar);
            AplicarEstiloInput(txtNombreCliente);
            AplicarEstiloInput(txtApellidoCliente);
            AplicarEstiloInput(txtTelefonoCliente);
            AplicarEstiloInput(txtDUICliente);
            AplicarEstiloInput(txtDireccionCliente);
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

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Cliente_add_Load(object sender, EventArgs e)
        {
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            AVI.Cliente clientes = new AVI.Cliente();
            string nombreCliente = txtNombreCliente.Text;
            string apellidoCliente = txtApellidoCliente.Text;
            string telefonoCliente = txtTelefonoCliente.Text;
            string direccionCliente = txtDireccionCliente.Text;
            string duiCliente = txtDUICliente.Text;

            if (!string.IsNullOrEmpty(nombreCliente) &&
                !string.IsNullOrEmpty(apellidoCliente) &&
                !string.IsNullOrEmpty(telefonoCliente) &&
                !string.IsNullOrEmpty(direccionCliente) &&
                !string.IsNullOrEmpty(duiCliente))

            {
                bool resultado = clientes.AgregarCliente(nombreCliente, apellidoCliente, telefonoCliente, direccionCliente, duiCliente);

                if (resultado)
                {
                    MessageBox.Show("Cliente agregado exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el cliente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los datos válidos para el cliente.");
            }
        }
    }
}
