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
using AVI.customelements;
namespace AVI
{
    public partial class Ventas_nueva : Form
    {
        private WebcamBarcodeReader _barcodeReader;
        private Productos Productos; // Declarar la variable productos
        private DataTable Contenido = new Productos().ProductosList();
        //lista de precios
        DataTable cantidades = new DataTable();
        void styles()
        {
            dataGridView1.AccessibilityObject.Value = "Nombre del producto";
            dataGridView1.Columns.Add("IdProducto", "IdProducto");
            //hide idproducto
            dataGridView1.Columns["IdProducto"].Visible = false;
            dataGridView1.Columns.Add("Nombre", "Nombre del producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio unitario");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.DefaultCellStyle.Font = new Font("Speede", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Speede", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);

        }
        public Ventas_nueva()
        {
            cantidades.Columns.Add("IdProducto", typeof(int));
            cantidades.Columns.Add("Existencias", typeof(int));
            InitializeComponent();
            Productos = new Productos();
            Generatedisplay(Productos.ProductosList());
            styles();
            //barcode reader
            _barcodeReader = new WebcamBarcodeReader(UpdateBarcodeResult);
            _barcodeReader.Start();

            Cliente cliente = new Cliente();
            DataTable clientes = cliente.Clientelist();
            //display nombre y apellido
            clientelement.DataSource = clientes;
            clientelement.DisplayMember = "Nombre";
            clientelement.ValueMember = "IdCliente";



        }


        private void UpdateBarcodeResult(string result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateBarcodeResult), result);
                return;
            }

            //revisa si en contenido hay un codigo de barra que sea el mismo
            DataRow[] rows = Contenido.Select("Codigobarra = '" + result + "'");
            if (rows.Length > 0)
            {
                // Preguntar la cantidad
                string input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántos productos desea agregar?", "Agregar producto", "1");
                if (int.TryParse(input, out int cantidad) && cantidad > 0)
                {
                    // Agregar al DataGridView
                    decimal precioUnitario = Convert.ToDecimal(rows[0]["Precioventa"]);
                    //comprobar si hay existencias
                    if (cantidad > Convert.ToInt32(cantidades.Select("IdProducto = " + rows[0]["IdProducto"].ToString())[0]["Existencias"]))
                    {
                        MessageBox.Show("No hay suficientes existencias para este producto.", "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //actualizar existencias
                    cantidades.Select("IdProducto = " + rows[0]["IdProducto"].ToString())[0]["Existencias"] = Convert.ToInt32(cantidades.Select("IdProducto = " + rows[0]["IdProducto"].ToString())[0]["Existencias"]) - cantidad;
                    //actualizar datagrid

                    decimal total = cantidad * precioUnitario;
                    dataGridView1.Rows.Add(rows[0]["IdProducto"].ToString(), rows[0]["Nombre"].ToString(), cantidad, precioUnitario.ToString(), total.ToString());
                    dataGridView1_CellValueChanged();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Generatedisplay(DataTable content)
        {
            //contenido = idproducto y codigobarra

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in content.Rows)
            {
                cantidades.Rows.Add(row["IdProducto"], row["Existencias"]);
                RJButton button = new RJControls.RJButton();
                button.BackColor = Color.Black;
                button.FlatStyle = FlatStyle.Flat;
                //border black
                button.BorderSize = 1;
                button.BorderColor = Color.FromArgb(255, 196, 0);
                button.BorderRadius = 3;
                button.TextColor = Color.White;
                button.Font = new Font("Roboto", 10);

                button.Cursor = Cursors.Hand;
                button.TabStop = true;


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
                    // Preguntar la cantidad
                    string input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántos productos desea agregar?", "Agregar producto", "1");
                    if (int.TryParse(input, out int cantidad) && cantidad > 0)
                    {
                        // Agregar al DataGridView
                        decimal precioUnitario = Convert.ToDecimal(row["Precioventa"]);
                        //comprobar si hay existencias
                        if (cantidad > Convert.ToInt32(cantidades.Select("IdProducto = " + row["IdProducto"].ToString())[0]["Existencias"]))
                        {
                            MessageBox.Show("No hay suficientes existencias para este producto.", "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        //actualizar existencias
                        cantidades.Select("IdProducto = " + row["IdProducto"].ToString())[0]["Existencias"] = Convert.ToInt32(cantidades.Select("IdProducto = " + row["IdProducto"].ToString())[0]["Existencias"]) - cantidad;
                        //actualizar datagrid

                        decimal total = cantidad * precioUnitario;
                        dataGridView1.Rows.Add(row["IdProducto"].ToString(), row["Nombre"].ToString(), cantidad, precioUnitario.ToString(), total.ToString());
                        dataGridView1_CellValueChanged();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                });

                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //agrega a la base de datos los productos y la venta completa
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se han agregado productos a la venta.", "Venta vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }




        private void dataGridView1_CellValueChanged()
        {
            Totaldelostotales.Text = "0";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    Totaldelostotales.Text = (Convert.ToDecimal(Totaldelostotales.Text) + Convert.ToDecimal(row.Cells["Total"].Value)).ToString();
                }
            }
        }

        private void clientenew_Click(object sender, EventArgs e)
        {
            //new cliente
            new Cliente_add().ShowDialog();
            //actualizar combobox
            clientelement.DataSource = new Cliente().Clientelist();
            clientelement.Refresh();


        }

        private void Totaldelostotales_Click(object sender, EventArgs e)
        {

        }
    }
}
