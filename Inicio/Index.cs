using Administrador_de_Inventario_y_ventas.Categorias;
using Administrador_de_Inventario_y_ventas.Clientes;

namespace AVI
{
    public partial class Administador : Form
    {
        public Administador()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Administador_Load(object sender, EventArgs e)
        {
        }

        private void close_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            Categorias_list categorias = new Categorias_list();
            categorias.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Clientes_list clientes_List = new Clientes_list();
            clientes_List.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Productos_list productos_List = new Productos_list();
            productos_List.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            new Ventas_list().Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
