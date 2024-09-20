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
    public partial class Clientes_list : Form
    {
        private AVI.Cliente cliente;
        public Clientes_list()
        {
            InitializeComponent();
            cliente = new AVI.Cliente();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_list_Load(object sender, EventArgs e)
        {
            LoadClienteData();
        }
        private void LoadClienteData()
        {
            DataTable ClienteDataTable = cliente.Clientelist();

            // Asigna el DataTable al DataGridView
            dataGridView1.DataSource = ClienteDataTable;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos_list productos = new Productos_list();
            productos.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadClienteData();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Cliente_add cliente_Add = new Cliente_add();
            cliente_Add.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdCliente"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Llamar al método EliminarCliente
                    AVI.Cliente clientes = new AVI.Cliente();
                    bool resultado = clientes.EliminarCliente(idCliente);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.");
                        // Recargar los datos después de la eliminación
                        LoadClienteData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
            }
        }
    }
}
