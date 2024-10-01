namespace Administrador_de_Inventario_y_ventas.Categorias
{
    public partial class Categorias_add : Form
    {
        public Categorias_add()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            AVI.Categorias categorias = new AVI.Categorias();
            string nombreCategoria = txtNombreCategoria.Text;

            if (!string.IsNullOrEmpty(nombreCategoria))
            {
                bool resultado = categorias.AgregarCategoria(nombreCategoria);

                if (resultado)
                {
                    MessageBox.Show("Categoría agregada exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoría.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Id y un nombre válidos para la categoría.");
            }
        }

        private void Categorias_add_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            AplicarEstiloBoton(rjButton1);
            AplicarEstiloBoton(Cerrar);
            AplicarEstiloInput(txtNombreCategoria);
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
    }
}