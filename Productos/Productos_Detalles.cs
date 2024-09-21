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
    public partial class Productos_Detalles : Form
    {
        DataRow contenido;
        public Productos_Detalles(DataRow row)
        {
            this.contenido = row;
            InitializeComponent();
            Nombre.Text = row["Nombre"].ToString();
            string imagenPath = row["Imagen"]?.ToString() ?? string.Empty;
            //comprobar si existe la imagen
            if (!string.IsNullOrEmpty(imagenPath) && (imagenPath.EndsWith(".png") || imagenPath.EndsWith(".jpg")))
            {
                imageElement1.Url = "Image/" + imagenPath;
            }
            Productos marcacategoria = new Productos();
            DataTable info = marcacategoria.GetMarcaCategoria(Convert.ToInt32(row["IdProducto"]));
            Marca.Text = info.Rows[0]["Marca"].ToString();
            Categoria.Text = info.Rows[0]["Categoria"].ToString();
            Precio.Text = row["Precioventa"].ToString();
            Existencias.Text = row["Existencias"].ToString();
            Detalles.Text = row["Detalles"].ToString();



        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_button_Click(object sender, EventArgs e)
        {
            new Productos_editar(this.contenido).Show();
            this.Close();
        }
    }
}
