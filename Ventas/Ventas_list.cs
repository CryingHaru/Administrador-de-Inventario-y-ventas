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
    public partial class Ventas_list : Form
    {
        private Productos Productos; // Declarar la variable productos

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_list));

        public Ventas_list()
        {
            InitializeComponent();
            Ventas ventas = new Ventas();
            DataTable content = ventas.VentasList();
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
                card.Size = new Size(200, 200);
                card.BorderSize = 2;
                card.HeaderText = "ID: " + row["ID"].ToString();
                card.HeaderColor = Color.FromArgb(0, 0, 0);
                card.HeaderImage = (Image)resources.GetObject("card1.HeaderImage");
                card.HeaderImagePosition = new Point(160, 0);
                card.HeaderImageSize = new Size(30, 30);
                card.HeaderFont = new Font("Speedee", 14, FontStyle.Bold, GraphicsUnit.Point, 0);
                card.HeaderTextColor = Color.FromArgb(255, 255, 255);
                card.HeaderTextAlign = ContentAlignment.BottomLeft;
                card.FooterText = "Fecha: " + row["Fecha"].ToString();
                card.Nombre = "Nombre: " + row["Nombre"].ToString();
                card.Apellido = "Apellido: " + row["Apellido"].ToString();
                card.Cantidad = "Cantidad: " + cantotal.Rows[0]["Cantidad"].ToString();
                card.Total = "Total: " + cantotal.Rows[0]["Total"].ToString();
                card.Click += (sender, e) =>
                {
                   
                    new Ventas_Detalles(Convert.ToInt32(row["ID"])).Show();
                };
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
           new Ventas_nueva().Show();
           
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
