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
    public partial class Productos_editar : Form
    {
        string image = "";
        DataRow contenido;
        public Productos_editar(DataRow row)
        {
            contenido = row;
            InitializeComponent();
            Marca marca = new Marca();
            DataTable marcas = marca.MarcasList();
            Marcascombo.DataSource = marcas;
            Marcascombo.DisplayMember = "Nombre";
            Marcascombo.ValueMember = "Idmarca";
            Categorias categoria = new Categorias();
            DataTable categorias = categoria.CategoriasList();
            Categoriascombo.DataSource = categorias;
            Categoriascombo.DisplayMember = "Nombre";
            Categoriascombo.ValueMember = "Idcategoria";

            //rellenar con los valores del row
            Nombre.Text = row["Nombre"].ToString();
            Descripcion.Text = row["Detalles"].ToString();
            Precio.Text = row["Precioventa"].ToString();
            Existencias.Text = row["Existencias"].ToString();
            Marcascombo.SelectedValue = row["Marca"];
            Categoriascombo.SelectedValue = row["Categoria"];
            //check image path existence
            string imagenPath = row["Imagen"]?.ToString() ?? string.Empty;
            if (!string.IsNullOrEmpty(imagenPath) && (imagenPath.EndsWith(".png") || imagenPath.EndsWith(".jpg")))
            {
                imageElement1.Url = "Image/" + imagenPath;
                imageElement1.Refresh();
                image = imagenPath;
            }
            //check existencvias
            if (int.Parse(row["Existencias"].ToString()) == 0)
            {
                imageElement1.ShowCornerImage = true;
                imageElement1.Refresh();
                
            }


        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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
            if (Nombre.Text == "" || Descripcion.Text == "" || Precio.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }
            //guarda el producto en la base de datos
            Productos producto = new Productos();
            producto.ProductoEdit(int.Parse(contenido["IdProducto"]?.ToString() ?? "0"), Nombre.Text, Descripcion.Text, int.Parse(Marcascombo.SelectedValue.ToString()), int.Parse(Categoriascombo.SelectedValue.ToString()), decimal.Parse(Precio.Text), image);
            MessageBox.Show("Producto actualizado");

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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //eliminar el producto
                Productos producto = new Productos();
                producto.ProductoDelete(int.Parse(contenido["IdProducto"]?.ToString() ?? "0"));
                MessageBox.Show("Producto eliminado");

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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            new ProductoExistencias(int.Parse(contenido["IdProducto"]?.ToString() ?? "0")).Show();
            this.Close();

        }
    }
}
