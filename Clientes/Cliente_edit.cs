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
    public partial class Cliente_edit : Form
    {
        private int Id;
        public Cliente_edit(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            AVI.Cliente cliente = new AVI.Cliente();
            DataTable clienteData = cliente.Clientelist();
            DataRow[] clienteRow = clienteData.Select($"Idcliente = {Id}");
            txtNombreCliente.Text = clienteRow[0]["Nombre"].ToString();
            txtApellidoCliente.Text = clienteRow[0]["Apellido"].ToString();
            txtTelefonoCliente.Text = clienteRow[0]["Telefono"].ToString();
            txtDUICliente.Text = clienteRow[0]["Dui"].ToString();
            txtDireccionCliente.Text = clienteRow[0]["Direccion"].ToString();

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

            if (!string.IsNullOrEmpty(nombreCliente) && !string.IsNullOrEmpty(apellidoCliente) && !string.IsNullOrEmpty(telefonoCliente) && !string.IsNullOrEmpty(duiCliente) && !string.IsNullOrEmpty(direccionCliente))
            {
                bool resultado = clientes.EditarCliente(this.Id, nombreCliente, apellidoCliente, telefonoCliente, duiCliente, direccionCliente);

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
