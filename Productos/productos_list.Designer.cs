namespace AVI
{
    partial class Productos_list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_list));
            flowLayoutPanel1 = new FlowLayoutPanel();
            Titulo = new Label();
            rjButton1 = new RJControls.RJButton();
            Agregar = new RJControls.RJButton();
            Categorias = new RJControls.RJButton();
            Marcas = new RJControls.RJButton();
            Buscar = new RJControls.RJButton();
            pictureBox1 = new PictureBox();
            textboxelement1 = new Textboxelement();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(146, 57);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(467, 312);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Speedee", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(146, 26);
            Titulo.Margin = new Padding(2, 0, 2, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(112, 28);
            Titulo.TabIndex = 1;
            Titulo.Text = "Productos";
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rjButton1.BackColor = Color.Black;
            rjButton1.BackgroundColor = Color.Black;
            rjButton1.BorderColor = SystemColors.Window;
            rjButton1.BorderRadius = 2;
            rjButton1.BorderSize = 1;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Image = (Image)resources.GetObject("rjButton1.Image");
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(11, 328);
            rjButton1.Margin = new Padding(2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(131, 42);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "Atras";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.White;
            Agregar.BackgroundColor = Color.White;
            Agregar.BorderColor = Color.FromArgb(255, 195, 0);
            Agregar.BorderRadius = 2;
            Agregar.BorderSize = 1;
            Agregar.Cursor = Cursors.Hand;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agregar.ForeColor = Color.Black;
            Agregar.Image = (Image)resources.GetObject("Agregar.Image");
            Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            Agregar.ImageSize = new Size(20, 20);
            Agregar.Location = new Point(11, 84);
            Agregar.Margin = new Padding(2, 3, 2, 3);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(131, 42);
            Agregar.TabIndex = 3;
            Agregar.Text = "Nuevo";
            Agregar.TextColor = Color.Black;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // Categorias
            // 
            Categorias.BackColor = Color.White;
            Categorias.BackgroundColor = Color.White;
            Categorias.BorderColor = Color.FromArgb(255, 195, 0);
            Categorias.BorderRadius = 2;
            Categorias.BorderSize = 1;
            Categorias.Cursor = Cursors.Hand;
            Categorias.FlatAppearance.BorderSize = 0;
            Categorias.FlatStyle = FlatStyle.Flat;
            Categorias.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categorias.ForeColor = Color.Black;
            Categorias.Image = (Image)resources.GetObject("Categorias.Image");
            Categorias.ImageAlign = ContentAlignment.MiddleLeft;
            Categorias.ImageSize = new Size(20, 20);
            Categorias.Location = new Point(11, 132);
            Categorias.Margin = new Padding(2, 3, 2, 3);
            Categorias.Name = "Categorias";
            Categorias.Size = new Size(131, 42);
            Categorias.TabIndex = 4;
            Categorias.Text = "Categorias";
            Categorias.TextAlign = ContentAlignment.MiddleRight;
            Categorias.TextColor = Color.Black;
            Categorias.UseVisualStyleBackColor = false;
            Categorias.Click += Categorias_Click;
            // 
            // Marcas
            // 
            Marcas.BackColor = Color.White;
            Marcas.BackgroundColor = Color.White;
            Marcas.BorderColor = Color.FromArgb(255, 195, 0);
            Marcas.BorderRadius = 2;
            Marcas.BorderSize = 1;
            Marcas.Cursor = Cursors.Hand;
            Marcas.FlatAppearance.BorderSize = 0;
            Marcas.FlatStyle = FlatStyle.Flat;
            Marcas.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Marcas.ForeColor = Color.Black;
            Marcas.Image = (Image)resources.GetObject("Marcas.Image");
            Marcas.ImageAlign = ContentAlignment.MiddleLeft;
            Marcas.ImageSize = new Size(20, 20);
            Marcas.Location = new Point(11, 180);
            Marcas.Margin = new Padding(2, 3, 2, 3);
            Marcas.Name = "Marcas";
            Marcas.Size = new Size(131, 42);
            Marcas.TabIndex = 5;
            Marcas.Text = "Marcas";
            Marcas.TextColor = Color.Black;
            Marcas.UseVisualStyleBackColor = false;
            Marcas.Click += Marcas_Click;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Buscar.AutoSize = true;
            Buscar.BackColor = Color.White;
            Buscar.BackgroundColor = Color.White;
            Buscar.BorderColor = Color.FromArgb(255, 195, 0);
            Buscar.BorderRadius = 2;
            Buscar.BorderSize = 2;
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderSize = 0;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.ForeColor = Color.Black;
            Buscar.ImageSize = new Size(20, 20);
            Buscar.Location = new Point(533, 14);
            Buscar.Margin = new Padding(2, 3, 2, 3);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(80, 26);
            Buscar.TabIndex = 6;
            Buscar.Text = "Buscar";
            Buscar.TextColor = Color.Black;
            Buscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 42);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textboxelement1
            // 
            textboxelement1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textboxelement1.BorderColor = Color.Black;
            textboxelement1.BorderRadius = 1;
            textboxelement1.BorderSize = 2;
            textboxelement1.BorderStyle = BorderStyle.None;
            textboxelement1.Cursor = Cursors.IBeam;
            textboxelement1.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxelement1.IsPassword = false;
            textboxelement1.IsReadOnly = false;
            textboxelement1.Location = new Point(385, 17);
            textboxelement1.Name = "textboxelement1";
            textboxelement1.PlaceholderText = "Escribe aqui...";
            textboxelement1.Size = new Size(143, 21);
            textboxelement1.TabIndex = 9;
            textboxelement1.TextChanged += textboxelement1_TextChanged;
            // 
            // Productos_list
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(637, 381);
            Controls.Add(textboxelement1);
            Controls.Add(pictureBox1);
            Controls.Add(Buscar);
            Controls.Add(Marcas);
            Controls.Add(Categorias);
            Controls.Add(Agregar);
            Controls.Add(rjButton1);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Productos_list";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_list_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Titulo;
        private RJControls.RJButton rjButton1;
        private RJControls.RJButton Agregar;
        private RJControls.RJButton Categorias;
        private RJControls.RJButton Marcas;
        private RJControls.RJButton Buscar;
        private PictureBox pictureBox1;
        private Textboxelement textboxelement1;
    }
}