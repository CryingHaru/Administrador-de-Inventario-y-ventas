using Administrador_de_Inventario_y_ventas.Categorias;
using AVI;
using System;
using System.Data;
using System.Drawing;
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
            DataTable MarcaDataTable = Marca.MarcasList();
            dataGridView1.DataSource = MarcaDataTable;
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Desactivar estilos visuales de encabezados
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersVisible = false;

            // Configurar colores y estilos
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
           
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
        }



        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Marcas_add marcaAdd = new Marcas_add();
            marcaAdd.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            EditarMarca();
        }

        private void EditarMarca()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int idmarca = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Idmarca"].Value);
                    string nombreMarca = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();

                    Marcas_edit marcasEdit = new Marcas_edit(idmarca, nombreMarca);
                    marcasEdit.ShowDialog();
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
            EliminarMarca();
        }

        private void EliminarMarca()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idMarca = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdMarca"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta Marca?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AVI.Marca marcas = new AVI.Marca();
                    bool resultado = marcas.EliminarMarca(idMarca);

                    if (resultado)
                    {
                        MessageBox.Show("Marca eliminada exitosamente.");
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
    }
}
