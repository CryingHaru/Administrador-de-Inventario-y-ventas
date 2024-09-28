using AVI;
using System;
using System.Data;
using System.Drawing;
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

            this.BackColor = Color.Black;
            AplicarEstiloBoton(Agregar);
            AplicarEstiloBoton(rjButton1);
            AplicarEstiloBoton(rjButton2);
            AplicarEstiloBoton(rjButton3);
            AplicarEstiloDataGridView(dataGridView1);
        }

        private void Categorias_list_Load(object sender, EventArgs e)
        {
            LoadCategoriasData();
        }

        private void LoadCategoriasData()
        {
            DataTable categoriasDataTable = categorias.CategoriasList();
            dataGridView1.DataSource = categoriasDataTable;
        }

        private void AplicarEstiloBoton(Button button)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.Gold;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Gold;
            button.FlatAppearance.BorderSize = 2;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Categorias_add categoriasAdd = new Categorias_add();
            categoriasAdd.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Idcategoria"].Value);
                string nombreCategoria = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();

                Categorias_edit categoriasEdit = new Categorias_edit(idCategoria, nombreCategoria);
                categoriasEdit.ShowDialog();

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
                int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Idcategoria"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AVI.Categorias categorias = new AVI.Categorias();
                    bool resultado = categorias.EliminarCategoria(idCategoria);

                    if (resultado)
                    {
                        MessageBox.Show("Categoría eliminada exitosamente.");
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
