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
        private DataTable cantidades = new DataTable(); // Lista de precios

        public Ventas_nueva()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            cantidades.Columns.Add("IdProducto", typeof(int));
            cantidades.Columns.Add("Existencias", typeof(int));

            Productos = new Productos();
            Generatedisplay(Productos.ProductosList());
            styles();

            // Inicializar lector de código de barras
            _barcodeReader = new WebcamBarcodeReader(UpdateBarcodeResult);
            _barcodeReader.Start();

            // Inicializar lista de clientes
            Cliente cliente = new Cliente();
            DataTable clientes = cliente.Clientelist();
            clientelement.DataSource = clientes;
            clientelement.DisplayMember = "Nombre";
            clientelement.ValueMember = "IdCliente";
        }

        private void styles()
        {
            dataGridView1.AccessibilityObject.Value = "Nombre del producto";
            dataGridView1.Columns.Add("IdProducto", "IdProducto");
            dataGridView1.Columns["IdProducto"].Visible = false; // Ocultar IdProducto
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

        private void UpdateBarcodeResult(string result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateBarcodeResult), result);
                return;
            }

            // Revisa si en contenido hay un código de barra que sea el mismo
            DataRow[] rows = Contenido.Select("Codigobarra = '" + result + "'");
            if (rows.Length > 0)
            {
                // Preguntar la cantidad
                string input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántos productos desea agregar?", "Agregar producto", "1");
                if (int.TryParse(input, out int cantidad) && cantidad > 0)
                {
                    decimal precioUnitario = Convert.ToDecimal(rows[0]["Precioventa"]);
                    // Comprobar si hay existencias
                    if (cantidad > Convert.ToInt32(cantidades.Select("IdProducto = " + rows[0]["IdProducto"].ToString())[0]["Existencias"]))
                    {
                        MessageBox.Show("No hay suficientes existencias para este producto.", "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Actualizar existencias
                    cantidades.Select("IdProducto = " + rows[0]["IdProducto"].ToString())[0]["Existencias"] = Convert.ToInt32(cantidades.Select("IdProducto = " + rows[0]["IdProducto"].ToString())[0]["Existencias"]) - cantidad;
                    // Actualizar DataGridView
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
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in content.Rows)
            {
                //solo los que tenga existencias
                if (Convert.ToInt32(row["Existencias"]) == 0)
                {
                    continue;
                }
                cantidades.Rows.Add(row["IdProducto"], row["Existencias"]);
                RJButton button = new RJControls.RJButton
                {
                    BackColor = Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    BorderSize = 1,
                    BorderColor = Color.FromArgb(255, 196, 0),
                    BorderRadius = 3,
                    TextColor = Color.White,
                    Font = new Font("Roboto", 10),
                    Cursor = Cursors.Hand,
                    TabStop = true,
                    ImageSize = new Size(100, 100),
                    ImageAlign = ContentAlignment.TopCenter,
                    TextAlign = ContentAlignment.BottomCenter,
                    Text = row["Nombre"].ToString(),
                    Size = new Size(130, 180)
                };

                // Imagen desde la base de datos
                string imagenPath = row["Imagen"]?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(imagenPath) && (imagenPath.EndsWith(".png") || imagenPath.EndsWith(".jpg")) && System.IO.File.Exists("Image/" + imagenPath))
                {
                    button.SetImage(Image.FromFile("Image/" + imagenPath));
                }

                button.Click += (sender, e) =>
                {
                    // Preguntar la cantidad
                    string input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuántos productos desea agregar?", "Agregar producto", "1");
                    if (int.TryParse(input, out int cantidad) && cantidad > 0)
                    {
                        decimal precioUnitario = Convert.ToDecimal(row["Precioventa"]);
                        // Comprobar si hay existencias
                        if (cantidad > Convert.ToInt32(cantidades.Select("IdProducto = " + row["IdProducto"].ToString())[0]["Existencias"]))
                        {
                            MessageBox.Show("No hay suficientes existencias para este producto.", "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Actualizar existencias
                        cantidades.Select("IdProducto = " + row["IdProducto"].ToString())[0]["Existencias"] = Convert.ToInt32(cantidades.Select("IdProducto = " + row["IdProducto"].ToString())[0]["Existencias"]) - cantidad;
                        // Actualizar DataGridView
                        decimal total = cantidad * precioUnitario;
                        //comprobar si ya existe el producto
                    
                        if (dataGridView1.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row1 in dataGridView1.Rows)
                            {
                                if (row1.Cells["IdProducto"].Value.ToString() == row["IdProducto"].ToString())
                                {
                                    row1.Cells["Cantidad"].Value = Convert.ToInt32(row1.Cells["Cantidad"].Value) + cantidad;
                                    row1.Cells["Total"].Value = Convert.ToDecimal(row1.Cells["Total"].Value) + total;
                                    dataGridView1_CellValueChanged();
                                    return;
                                }
                            }
                        }
                        dataGridView1.Rows.Add(row["IdProducto"].ToString(), row["Nombre"].ToString(), cantidad, precioUnitario.ToString(), total.ToString());
                        dataGridView1_CellValueChanged();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            // Agrega a la base de datos los productos y la venta completa
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se han agregado productos a la venta.", "Venta vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clientelement.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear venta
            Ventas ventas = new Ventas();
            int idventa = Convert.ToInt32(ventas.NuevaVenta(Convert.ToInt32(clientelement.SelectedValue)));
            if (idventa == 0)
            {
                MessageBox.Show("No se pudo crear la venta.", "Error al crear la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar productos
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ventas.AgregarProducto(idventa, Convert.ToInt32(row.Cells["IdProducto"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value), Convert.ToDouble(row.Cells["Precio"].Value));
            }

            MessageBox.Show("Venta realizada con éxito.", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //buscar el formulario de ventas abierto y en caso de encontrarlo ejecutar la funcion actualizar

            if (Application.OpenForms.OfType<Ventas_list>().Count() == 1)
            {
                Ventas_list form = (Ventas_list)Application.OpenForms["Ventas_list"];
                form.Actualizar();
            }
            this.Close();


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
            // Nuevo cliente
            new Cliente_add().ShowDialog();
            // Actualizar combobox
            clientelement.DataSource = new Cliente().Clientelist();
            clientelement.Refresh();
        }

        private void Totaldelostotales_Click(object sender, EventArgs e) { }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
