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
using static System.Runtime.InteropServices.JavaScript.JSType;
using AVI.Properties;
using System.Resources;



namespace AVI
{
    public partial class Ventas_Detalles : Form
    {
        private Productos Productos; // Declarar la variable productos
        public int id;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_list));

        public Ventas_Detalles(int id)
        {
            InitializeComponent();
            Ventas ventas = new Ventas();
            DataTable content = ventas.Productosventas(id);
            DataTable datos = ventas.DetallesVenta(id);
            //SELECT VentaCabecera.Idventa AS ID, VentaCabecera.Fecha AS Fecha, Cliente.Nombre AS Nombre, Cliente.Apellido AS Apellido FROM dbo.VentaCabecera INNER JOIN dbo.Cliente ON VentaCabecera.Idcliente = Cliente.Idcliente WHERE VentaCabecera.Idventa
            Nombrecliente.Text = datos.Rows[0]["Nombre"].ToString() + " " + datos.Rows[0]["Apellido"].ToString();
            Fechaventa.Text = datos.Rows[0]["Fecha"].ToString();
            VentaID.Text = "ID: " + datos.Rows[0]["ID"].ToString();
            total.Text = ventas.cantotal(id).Rows[0]["Total"].ToString();

            this.id = id;
            //add to content from ventas.cantot();

            Generatedisplay(content);
        }

        private void Generatedisplay(DataTable content)
        {
            //holaaa quien lee esto ps que bien xd
            //clean all

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in content.Rows)
            {
                //get cant and total
                DataTable cantotal = new Ventas().cantotal(Convert.ToInt32(row["ID"]));
                customelements.Card card = new customelements.Card();
                card.Size = new Size(140, 175);
                card.BorderSize = 2;
                card.HeaderText = row["Nombre"].ToString();
                card.HeaderColor = Color.FromArgb(0, 0, 0);
                card.HeaderImage = (Image)resources.GetObject("card1.HeaderImage");
                //comprobar imagen formato que exista o que el campo no sea vacio
                if (row["Imagen"].ToString() != "" && (row["Imagen"].ToString().EndsWith(".png") || row["Imagen"].ToString().EndsWith(".jpg")))
                {
                    card.BodyImage = Image.FromFile("Image/" + row["Imagen"].ToString());
                    card.BodyImagePosition = new Point(40, 35);
                    card.BodyImageSize = new Size(60, 60);
                }
                card.HeaderImagePosition = new Point(160, 0);
                card.HeaderImageSize = new Size(30, 30);
                card.HeaderFont = new Font("Speedee", 12, FontStyle.Bold, GraphicsUnit.Point, 0);
                card.HeaderTextColor = Color.FromArgb(255, 255, 255);
                card.HeaderTextAlign = ContentAlignment.BottomLeft;
                card.FooterText = "Total: " + (Convert.ToDouble(row["Precio"]) * Convert.ToInt32(row["Cantidad"]));
                card.Nombre = "Cantidad: " + row["Cantidad"];
                card.Apellido = "Precio:" + row["Precio"];
                card.Cantidad = "";
                card.Total = "";
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_list_Load(object sender, EventArgs e)
        {

        }

        private void Categorias_Click(object sender, EventArgs e)
        {
            // this.Hide();

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

        private void Agregar_Click(object sender, EventArgs e)
        {
            new Ventas().Anular(this.id);
            //actualizar ventas list y cerrar
            if (Application.OpenForms.OfType<Ventas_list>().Count() == 1)
                Application.OpenForms.OfType<Ventas_list>().First().Actualizar();
            this.Close();
        }

        private void textboxelement1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Actualizar()
        {
            Ventas ventas = new Ventas();
            DataTable content = ventas.VentasList();
            Generatedisplay(content);
            //Generatedisplay();
        }
    }
}
