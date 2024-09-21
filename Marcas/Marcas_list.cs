﻿using Administrador_de_Inventario_y_ventas.Categorias;
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
    }
}
