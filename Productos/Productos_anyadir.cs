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
    }
}
