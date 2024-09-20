using Administrador_de_Inventario_y_ventas.Categorias;
using Administrador_de_Inventario_y_ventas.Marcas;
using Administrador_de_Inventario_y_ventas.Clientes;
using AVI.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes_list = Administrador_de_Inventario_y_ventas.Clientes.Clientes_list;

namespace AVI
{
    public partial class Productos_list : Form

    {
        private Productos Productos; // Declarar la variable productos

        public Productos_list()
        {
            InitializeComponent();
            Productos = new Productos();
            Generatedisplay(Productos.ProductosList());
        }

        private void Generatedisplay(DataTable content)
        {
            //holaaa quien lee esto ps que bien xd

            foreach (DataRow row in content.Rows)
            {

                RJButton button = new RJControls.RJButton();
                button.BackColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                //border black
                button.BorderSize = 1;
                button.BorderColor = Color.FromArgb(219, 219, 219);
                button.BorderRadius = 3;
                button.TextColor = Color.Black;
                button.Font = new Font("Roboto", 10);
                //cursor pointer
                button.Cursor = Cursors.Hand;


                //img desde la base de datos
                string imagenPath = row["Imagen"]?.ToString() ?? string.Empty;
                //comprobar si existe la imagen
                if (!string.IsNullOrEmpty(imagenPath) && (imagenPath.EndsWith(".png") || imagenPath.EndsWith(".jpg")) && System.IO.File.Exists("Image/" + imagenPath))
                {
                    button.SetImage(Image.FromFile("Image/" + imagenPath));
                }

                //image size 
                button.ImageSize = new Size(100, 100);
                button.ImageAlign = ContentAlignment.TopCenter;
                button.TextAlign = ContentAlignment.BottomCenter;
                button.Text = row["Nombre"].ToString();
                button.Size = new Size(130, 180);
                button.Click += new EventHandler((sender, e) =>
                {
                    new Productos_Detalles(row).Show();
                });

                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Productos_list_Load(object sender, EventArgs e)
        {

        }

        private void Categorias_Click(object sender, EventArgs e)
        {
            this.Hide();

            Categorias_list categorias = new Categorias_list();
            categorias.Show();
        }

        private void Marcas_Click(object sender, EventArgs e)
        {
            this.Hide();

            Marcas_list marcas = new Marcas_list();
            marcas.Show();
        }

        private void Cliente_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Clientes_list cliente = new Clientes_list();
            cliente.Show();

        }
    }
}
