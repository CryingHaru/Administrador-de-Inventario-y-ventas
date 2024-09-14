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
        public Productos_Detalles(DataRow row)
        {
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
       

        
    }
}
