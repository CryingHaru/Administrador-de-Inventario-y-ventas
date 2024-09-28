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
            AplicarEstiloDataGridView(dataGridView1);
        }

        private void LoadClienteData()
        {
            DataTable ClienteDataTable = cliente.Clientelist();
            dataGridView1.DataSource = ClienteDataTable;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdCliente"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    AVI.Cliente clientes = new AVI.Cliente();
                    bool resultado = clientes.EliminarCliente(idCliente);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.");
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdCliente"].Value);
                Cliente_edit cliente_Edit = new Cliente_edit(idCliente);
                cliente_Edit.Show();
            }
        }
        private void AplicarEstiloDataGridView(DataGridView dataGridView)
        {
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Gold;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.GridColor = Color.Gold;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoadClienteData();
        }
    }
}
