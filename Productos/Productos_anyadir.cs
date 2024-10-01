using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVI
{
    public partial class Productos_agregar : Form
    {
        string image = "";
        public Productos_agregar()
        {
            InitializeComponent();
            //marcas
            //get marcas from db; Idmarca, Nombre and set hidden idmarca
            Marca marca = new Marca();
            DataTable marcas = marca.MarcasList();
            //Marcascombo
            Marcascombo.DataSource = marcas;
            Marcascombo.DisplayMember = "Nombre";
            Marcascombo.ValueMember = "Idmarca";
            //categorias
            //get categorias from db; Idcategoria, Nombre and set hidden idcategoria
            Categorias categoria = new Categorias();
            DataTable categorias = categoria.CategoriasList();
            //Categoriascombo
            Categoriascombo.DataSource = categorias;
            Categoriascombo.DisplayMember = "Nombre";
            Categoriascombo.ValueMember = "Idcategoria";

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //marcas onload

        private void Marcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imageElement1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagenes|*.jpg;*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                //comprueba si el input nombre tiene texto de lo contrario usar Producto_numeroaleatorio
                if (Nombre.Text == "")
                {
                    Nombre.Text = "Producto_";
                }
                int numerito = new Random().Next(0, 1000);
                //copia el archivo a la carpeta image con el nombre en la casilla nombre y un numero aleatorio
                System.IO.File.Copy(file.FileName, "Image/" + Nombre.Text + numerito + System.IO.Path.GetExtension(file.FileName));
                image = Nombre.Text + numerito + System.IO.Path.GetExtension(file.FileName);
                imageElement1.Url = "Image/" + image;
                //actualizar
                imageElement1.Refresh();
            }
        }

        private void Editar_button_Click(object sender, EventArgs e)
        {
            //comprueba si las casillas tienen valor de lo contrario informar al usuario
            if (Nombre.Text == "" || Descripcion.Text == "" || Precio.Text == "" )
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }
            //precio solo acepta numeros
            if (!decimal.TryParse(Precio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número");
                return;
            }
            //guarda el producto en la base de datos
            Productos producto = new Productos();
            //genera codigo de barra aleatorio de 8 digitos
            //muestra el id marca

            Random random = new Random();
            string codigo = "";
            for (int i = 0; i < 8; i++)
            {
                codigo += random.Next(0, 9);
            }
            //ProductoAdd(int id, string nombre,string descripcion, int marca, int categoria, decimal precio, string imagen, string codigobarra)
            producto.ProductoAdd(Nombre.Text, Descripcion.Text, int.Parse(Marcascombo.SelectedValue.ToString()), int.Parse(Categoriascombo.SelectedValue.ToString()), decimal.Parse(Precio.Text), image, codigo);
            MessageBox.Show("Producto agregado");
            //actualizar la lista de productos// el form productos_list actualizalo
            //el formulario activo con el metodo Actualizar
            Productos_list? productos = Application.OpenForms["Productos_list"] as Productos_list;
            if (productos != null)
            {
                productos.Actualizar();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la lista de productos porque el formulario Productos_list no está abierto.");
            }
            this.Close();

        }
    }
}
