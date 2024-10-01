using Administrador_de_Inventario_y_ventas.Categorias;
using Administrador_de_Inventario_y_ventas.Marcas;
using Administrador_de_Inventario_y_ventas.Clientes;
using AVI.RJControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace AVI
{
    public partial class Productos_list : Form
    {
        private Productos Productos;

        public Productos_list()
        {
            InitializeComponent();
            Productos = new Productos();
            Generatedisplay(Productos.ProductosList());
        }

        private void Generatedisplay(DataTable content)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in content.Rows)
            {
                RJButton button = new RJControls.RJButton
                {
                    BackColor = Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    BorderSize = 1,
                    BorderColor = Color.FromArgb(255, 196, 0),
                    BorderRadius = 3,
                    TextColor = Color.White,
                    Font = new Font("Roboto", 10),
                    Cursor = Cursors.Hand,
                    ImageAlign = ContentAlignment.TopCenter,
                    TextAlign = ContentAlignment.BottomCenter,
                    Text = row["Nombre"].ToString(),
                    Size = new Size(130, 180)
                };

                string imagenPath = row["Imagen"]?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(imagenPath) && (imagenPath.EndsWith(".png") || imagenPath.EndsWith(".jpg")) && File.Exists("Image/" + imagenPath))
                {
                    button.SetImage(Image.FromFile("Image/" + imagenPath));
                }

                button.ImageSize = new Size(100, 100);
                button.Click += (sender, e) => new Productos_Detalles(row).Show();
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Categorias_Click(object sender, EventArgs e)
        {
            Categorias_list categorias = new Categorias_list();
            categorias.Show();
        }

        private void Marcas_Click(object sender, EventArgs e)
        {
            Marcas_list marcas = new Marcas_list();
            marcas.Show();
        }

        private void Cliente_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Clientes_list cliente = new Clientes_list();
            cliente.Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            new Productos_agregar().Show();
        }

        private void textboxelement1_TextChanged(object sender, EventArgs e)
        {
        }

        public void Actualizar()
        {
            Productos = new Productos();
            Generatedisplay(Productos.ProductosList());

            string[] files = Directory.GetFiles("Image");
            DataTable images = Productos.listimages();
            List<string> imagenes = new List<string>();

            foreach (DataRow row in images.Rows)
            {
                imagenes.Add(row["Imagen"].ToString());
            }

            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                if (!imagenes.Contains(filename))
                {
                    if (imagenes.Count == 0) break;
                    File.Delete(file);
                }
            }
        }
    }
}
