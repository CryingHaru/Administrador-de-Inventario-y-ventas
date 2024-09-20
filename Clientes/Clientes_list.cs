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
            // Obtén el DataTable de las categorías
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
    }
}
