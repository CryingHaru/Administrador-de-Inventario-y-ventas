using Administrador_de_Inventario_y_ventas.Categorias;
using AVI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_de_Inventario_y_ventas.Marcas
{
    public partial class Marcas_list : Form
    {
        private AVI.Marca Marca;
        public Marcas_list()
        {
            InitializeComponent();
            Marca = new AVI.Marca();
        }

        private void Marcas_list_Load(object sender, EventArgs e)
        {
            LoadMarcaData();
        }
        private void LoadMarcaData()
        {
            // Obtén el DataTable de las categorías
            DataTable MarcaDataTable = Marca.MarcasList();

            // Asigna el DataTable al DataGridView
            dataGridView1.DataSource = MarcaDataTable;

            // Establecer el color de fondo del DataGridView
            dataGridView1.BackgroundColor = Color.Black;

            // Establecer el color de las filas alternas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30); // Gris oscuro

            // Color de las celdas
            dataGridView1.DefaultCellStyle.BackColor = Color.Black; // Fondo negro para las celdas
            dataGridView1.DefaultCellStyle.ForeColor = Color.Gold;  // Texto en color oro

            // Estilo para las filas seleccionadas
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gold;  // Fondo dorado para la fila seleccionada
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto en negro para la fila seleccionada

            // Estilo del encabezado de columnas
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Fondo negro en el encabezado
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold;  // Texto dorado en el encabezado
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Fuente en negrita

            // Alinear el texto del encabezado de columnas en el centro
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar el color de las líneas de separación
            dataGridView1.GridColor = Color.Gold; // Líneas doradas entre las celdas

            // Opcional: Alinear el texto en las celdas (ajusta según tus necesidades)
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Quitar el borde 3D del encabezado de columnas (opcional, para un look más plano)
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Productos_list productos = new Productos_list();
            productos.Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Marcas_add marcaAdd = new Marcas_add();
            marcaAdd.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el ID de la categoría seleccionada
                    int idmarca = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Idmarca"].Value);
                    string nombreMarca = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();

                    // Abrir el formulario de edición con los datos seleccionados
                    Marcas_edit marcasEdit = new Marcas_edit(idmarca, nombreMarca);
                    marcasEdit.ShowDialog();

                    // Recargar los datos después de la edición
                    LoadMarcaData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría para editar.");
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID de la categoría seleccionada
                int idMarca = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdMarca"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta Marca?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Llamar al método EliminarCategoria
                    AVI.Marca marcas = new AVI.Marca();
                    bool resultado = marcas.EliminarMarca(idMarca);

                    if (resultado)
                    {
                        MessageBox.Show("Marca eliminada exitosamente.");
                        // Recargar los datos después de la eliminación
                        LoadMarcaData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la Marca.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una Marca para eliminar.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadMarcaData();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
