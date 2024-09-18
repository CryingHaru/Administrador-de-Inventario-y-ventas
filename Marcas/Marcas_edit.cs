using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AVI
{
    public partial class Marcas_edit : Form
    {
        private int idMarca;
        public Marcas_edit()
        {
            InitializeComponent();
            idMarca = Idmarca;
            txtnombreMarca.Text =;
        }

        private void Marcas_edit_Load(object sender, EventArgs e)
        {

        }
    }
}
