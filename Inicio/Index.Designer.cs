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
            label1 = new Label();
            close = new Button();
            pictureBox1 = new PictureBox();
            BtnVentas = new RJControls.RJButton();
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
            BtnCategoria.FlatAppearance.BorderSize = 0;
            BtnCategoria.FlatStyle = FlatStyle.Flat;
            BtnCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCategoria.ForeColor = Color.Gold;
            BtnCategoria.ImageSize = new Size(20, 20);
            BtnCategoria.Location = new Point(223, 128);
            BtnCategoria.Name = "BtnCategoria";
            BtnCategoria.Size = new Size(102, 62);
            BtnCategoria.TabIndex = 10;
            BtnCategoria.Text = "Categorias";
            BtnCategoria.TextColor = Color.Gold;
            BtnCategoria.TextImageRelation = TextImageRelation.TextBeforeImage;
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
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClientes.ForeColor = Color.Gold;
            BtnClientes.ImageSize = new Size(20, 20);
            BtnClientes.Location = new Point(223, 231);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(102, 57);
            BtnClientes.TabIndex = 11;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextColor = Color.Gold;
            BtnClientes.TextImageRelation = TextImageRelation.TextBeforeImage;
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
            BtnProductos.FlatAppearance.BorderSize = 0;
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProductos.ForeColor = Color.Gold;
            BtnProductos.ImageSize = new Size(20, 20);
            BtnProductos.Location = new Point(454, 128);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(101, 62);
            BtnProductos.TabIndex = 12;
            BtnProductos.Text = "Productos";
            BtnProductos.TextColor = Color.Gold;
            BtnProductos.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnProductos.UseVisualStyleBackColor = false;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 1;
            label1.Text = "Menú";
            // 
            // close
            // 
            close.AutoSize = true;
            close.FlatStyle = FlatStyle.System;
            close.ForeColor = Color.Red;
            close.Location = new Point(766, 12);
            close.Name = "close";
            close.Size = new Size(27, 24);
            close.TabIndex = 2;
            close.Text = "x";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(13, 9);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 50);
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
            BtnVentas.FlatAppearance.BorderSize = 0;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVentas.ForeColor = Color.Gold;
            BtnVentas.ImageSize = new Size(20, 20);
            BtnVentas.Location = new Point(454, 231);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(101, 57);
            BtnVentas.TabIndex = 13;
            BtnVentas.Text = "Ventas";
            BtnVentas.TextColor = Color.Gold;
            BtnVentas.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnVentas.UseVisualStyleBackColor = false;
            BtnVentas.Click += BtnVentas_Click;
            // 
            // Administador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(819, 439);
            Controls.Add(BtnVentas);
            Controls.Add(BtnProductos);
            Controls.Add(BtnClientes);
            Controls.Add(BtnCategoria);
            Controls.Add(pictureBox1);
            Controls.Add(close);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Administador";
            Text = "Inicio";
            Load += Administador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button close;
        private PictureBox pictureBox1;
        private RJControls.RJButton BtnCategoria;
        private RJControls.RJButton BtnClientes;
        private RJControls.RJButton BtnProductos;
        private RJControls.RJButton BtnVentas;
    }
}
