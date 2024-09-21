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

namespace Administrador_de_Inventario_y_ventas.Categorias
{
    public partial class Categorias_list : Form
    {
        private AVI.Categorias categorias;

        public Categorias_list()
        {
            InitializeComponent();
            categorias = new AVI.Categorias();
           
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //si se seleciona un cuadro se seleciona toda la fila
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.AreAllCellsSelected(true);

        }

        private void Categorias_list_Load(object sender, EventArgs e)
        {
            LoadCategoriasData();

        }

        private void LoadCategoriasData()
        {
            // Obtén el DataTable de las categorías
            DataTable categoriasDataTable = categorias.CategoriasList();

            // Asigna el DataTable al DataGridView
            dataGridView1.DataSource = categoriasDataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar los clics en las celdas si es necesario
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Categorias_add categoriasAdd = new Categorias_add();
            categoriasAdd.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        //Productos_list productos = new Productos_list();
        //    productos.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID de la categoría seleccionada
                int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Idcategoria"].Value);
                string nombreCategoria = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();

                // Abrir el formulario de edición con los datos seleccionados
                Categorias_edit categoriasEdit = new Categorias_edit(idCategoria, nombreCategoria);
                categoriasEdit.ShowDialog();

                // Recargar los datos después de la edición
                LoadCategoriasData();
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
                int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Idcategoria"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Llamar al método EliminarCategoria
                    AVI.Categorias categorias = new AVI.Categorias();
                    bool resultado = categorias.EliminarCategoria(idCategoria);

                    if (resultado)
                    {
                        MessageBox.Show("Categoría eliminada exitosamente.");
                        // Recargar los datos después de la eliminación
                        LoadCategoriasData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoría.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría para eliminar.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadCategoriasData();
        }
    }
}