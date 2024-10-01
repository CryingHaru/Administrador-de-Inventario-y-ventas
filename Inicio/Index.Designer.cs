namespace AVI
{
    partial class Administador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administador));
            BtnCategoria = new RJControls.RJButton();
            BtnClientes = new RJControls.RJButton();
            BtnProductos = new RJControls.RJButton();
            pictureBox1 = new PictureBox();
            BtnVentas = new RJControls.RJButton();
            rjButton1 = new RJControls.RJButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rjButton2 = new RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnCategoria
            // 
            BtnCategoria.AccessibleRole = AccessibleRole.None;
            BtnCategoria.BackColor = Color.Black;
            BtnCategoria.BackgroundColor = Color.Black;
            BtnCategoria.BorderColor = Color.Gold;
            BtnCategoria.BorderRadius = 1;
            BtnCategoria.BorderSize = 1;
            BtnCategoria.Cursor = Cursors.Hand;
            BtnCategoria.FlatAppearance.BorderSize = 0;
            BtnCategoria.FlatStyle = FlatStyle.Flat;
            BtnCategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCategoria.ForeColor = Color.Gold;
            BtnCategoria.HoverColor = Color.FromArgb(28, 28, 28);
            BtnCategoria.Image = (Image)resources.GetObject("BtnCategoria.Image");
            BtnCategoria.ImageAlign = ContentAlignment.BottomCenter;
            BtnCategoria.ImageSize = new Size(15, 15);
            BtnCategoria.Location = new Point(551, 244);
            BtnCategoria.Margin = new Padding(2, 3, 2, 3);
            BtnCategoria.Name = "BtnCategoria";
            BtnCategoria.Size = new Size(109, 84);
            BtnCategoria.TabIndex = 10;
            BtnCategoria.Text = "Categorias";
            BtnCategoria.TextAlign = ContentAlignment.TopCenter;
            BtnCategoria.TextColor = Color.Gold;
            BtnCategoria.UseVisualStyleBackColor = false;
            BtnCategoria.Click += BtnCategorias_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.AccessibleRole = AccessibleRole.None;
            BtnClientes.BackColor = Color.Black;
            BtnClientes.BackgroundColor = Color.Black;
            BtnClientes.BorderColor = Color.Gold;
            BtnClientes.BorderRadius = 1;
            BtnClientes.BorderSize = 1;
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnClientes.ForeColor = Color.Gold;
            BtnClientes.HoverColor = Color.FromArgb(28, 28, 28);
            BtnClientes.Image = (Image)resources.GetObject("BtnClientes.Image");
            BtnClientes.ImageAlign = ContentAlignment.BottomCenter;
            BtnClientes.ImageSize = new Size(20, 20);
            BtnClientes.Location = new Point(551, 333);
            BtnClientes.Margin = new Padding(2, 3, 2, 3);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(109, 81);
            BtnClientes.TabIndex = 11;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.TopCenter;
            BtnClientes.TextColor = Color.Gold;
            BtnClientes.UseVisualStyleBackColor = false;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // BtnProductos
            // 
            BtnProductos.AccessibleRole = AccessibleRole.None;
            BtnProductos.BackColor = Color.Black;
            BtnProductos.BackgroundColor = Color.Black;
            BtnProductos.BorderColor = Color.Gold;
            BtnProductos.BorderRadius = 1;
            BtnProductos.BorderSize = 1;
            BtnProductos.Cursor = Cursors.Hand;
            BtnProductos.FlatAppearance.BorderSize = 0;
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnProductos.ForeColor = Color.Gold;
            BtnProductos.HoverColor = Color.FromArgb(28, 28, 28);
            BtnProductos.Image = (Image)resources.GetObject("BtnProductos.Image");
            BtnProductos.ImageAlign = ContentAlignment.BottomCenter;
            BtnProductos.ImageSize = new Size(20, 20);
            BtnProductos.Location = new Point(734, 244);
            BtnProductos.Margin = new Padding(2, 3, 2, 3);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(109, 84);
            BtnProductos.TabIndex = 12;
            BtnProductos.Text = "Productos";
            BtnProductos.TextAlign = ContentAlignment.TopCenter;
            BtnProductos.TextColor = Color.Gold;
            BtnProductos.UseVisualStyleBackColor = false;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(551, 131);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 107);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // BtnVentas
            // 
            BtnVentas.AccessibleRole = AccessibleRole.None;
            BtnVentas.BackColor = Color.Black;
            BtnVentas.BackgroundColor = Color.Black;
            BtnVentas.BorderColor = Color.Gold;
            BtnVentas.BorderRadius = 1;
            BtnVentas.BorderSize = 1;
            BtnVentas.Cursor = Cursors.Hand;
            BtnVentas.FlatAppearance.BorderSize = 0;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnVentas.ForeColor = Color.Gold;
            BtnVentas.HoverColor = Color.FromArgb(28, 28, 28);
            BtnVentas.Image = (Image)resources.GetObject("BtnVentas.Image");
            BtnVentas.ImageAlign = ContentAlignment.BottomCenter;
            BtnVentas.ImageSize = new Size(20, 20);
            BtnVentas.Location = new Point(734, 333);
            BtnVentas.Margin = new Padding(2, 3, 2, 3);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(109, 81);
            BtnVentas.TabIndex = 13;
            BtnVentas.Text = "Ventas";
            BtnVentas.TextAlign = ContentAlignment.TopCenter;
            BtnVentas.TextColor = Color.Gold;
            BtnVentas.UseVisualStyleBackColor = false;
            BtnVentas.Click += BtnVentas_Click;
            // 
            // rjButton1
            // 
            rjButton1.AccessibleRole = AccessibleRole.None;
            rjButton1.BackColor = Color.Black;
            rjButton1.BackgroundColor = Color.Black;
            rjButton1.BorderColor = Color.Gold;
            rjButton1.BorderRadius = 1;
            rjButton1.BorderSize = 1;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            rjButton1.ForeColor = Color.Gold;
            rjButton1.HoverColor = Color.FromArgb(28, 28, 28);
            rjButton1.Image = (Image)resources.GetObject("rjButton1.Image");
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(632, 439);
            rjButton1.Margin = new Padding(2, 3, 2, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(135, 55);
            rjButton1.TabIndex = 14;
            rjButton1.Text = "Salir";
            rjButton1.TextColor = Color.Gold;
            rjButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(322, 79);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.WrapContents = false;
            // 
            // rjButton2
            // 
            rjButton2.AccessibleRole = AccessibleRole.None;
            rjButton2.BackColor = Color.Black;
            rjButton2.BackgroundColor = Color.Black;
            rjButton2.BorderColor = Color.Gold;
            rjButton2.BorderRadius = 1;
            rjButton2.BorderSize = 1;
            rjButton2.Cursor = Cursors.Hand;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            rjButton2.ForeColor = Color.Gold;
            rjButton2.HoverColor = Color.FromArgb(28, 28, 28);
            rjButton2.Image = (Image)resources.GetObject("rjButton2.Image");
            rjButton2.ImageAlign = ContentAlignment.BottomCenter;
            rjButton2.ImageSize = new Size(20, 20);
            rjButton2.Location = new Point(420, 244);
            rjButton2.Margin = new Padding(2, 3, 2, 3);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(109, 81);
            rjButton2.TabIndex = 16;
            rjButton2.Text = "Movimientos";
            rjButton2.TextAlign = ContentAlignment.TopCenter;
            rjButton2.TextColor = Color.Gold;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // Administador
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(998, 540);
            Controls.Add(rjButton2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rjButton1);
            Controls.Add(BtnVentas);
            Controls.Add(BtnProductos);
            Controls.Add(BtnClientes);
            Controls.Add(BtnCategoria);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Administador";
            Text = "Inicio";
            Load += Administador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private RJControls.RJButton BtnCategoria;
        private RJControls.RJButton BtnClientes;
        private RJControls.RJButton BtnProductos;
        private RJControls.RJButton BtnVentas;
        private RJControls.RJButton rjButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RJControls.RJButton rjButton2;
    }
}
