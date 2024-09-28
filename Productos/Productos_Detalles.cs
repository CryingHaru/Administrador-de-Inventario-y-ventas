using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

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

            if (int.Parse(row["Existencias"].ToString()) < 1)
            {
                imageElement1.ShowCornerImage = true;
                imageElement1.Refresh();
            }

            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 100,
                    Width = 300
                }
            };
            codigobarraimagen.Image = writer.Write(row["Codigobarra"].ToString());
            codigobarraimagen.SizeMode = PictureBoxSizeMode.StretchImage;
            codigobarraimagen.Refresh();
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
