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
            // Obtener el texto de los TextBox para los campos del cliente
            string nombreCliente = txtNombreCliente.Text;
            string apellidoCliente = txtApellidoCliente.Text;
            string telefonoCliente = txtTelefonoCliente.Text;
            string duiCliente = txtDUICliente.Text;
            string direccionCliente = txtDireccionCliente.Text;

            int ultimo = clientes.Lastid();
            ultimo++;

            if (!string.IsNullOrEmpty(nombreCliente) && !string.IsNullOrEmpty(apellidoCliente) && !string.IsNullOrEmpty(telefonoCliente) && !string.IsNullOrEmpty(duiCliente) && !string.IsNullOrEmpty(direccionCliente))
            {
                bool resultado = clientes.AgregarCliente(ultimo, nombreCliente, apellidoCliente, telefonoCliente, duiCliente, direccionCliente);

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
