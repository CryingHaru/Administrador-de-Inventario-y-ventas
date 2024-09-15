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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Titulo = new Label();
            rjButton1 = new RJControls.RJButton();
            Agregar = new RJControls.RJButton();
            Categorias = new RJControls.RJButton();
            Marcas = new RJControls.RJButton();
            Buscar = new RJControls.RJButton();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(154, 67);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(727, 491);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(155, 21);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(131, 29);
            Titulo.TabIndex = 1;
            Titulo.Text = "Productos";
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(12, 382);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(123, 48);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "Tests";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.White;
            Agregar.BackgroundColor = Color.White;
            Agregar.BorderColor = Color.FromArgb(64, 64, 64);
            Agregar.BorderRadius = 8;
            Agregar.BorderSize = 1;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agregar.ForeColor = Color.Black;
            Agregar.ImageSize = new Size(20, 20);
            Agregar.Location = new Point(14, 67);
            Agregar.Margin = new Padding(3, 4, 3, 4);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(123, 49);
            Agregar.TabIndex = 3;
            Agregar.Text = "Nuevo";
            Agregar.TextColor = Color.Black;
            Agregar.UseVisualStyleBackColor = false;
            // 
            // Categorias
            // 
            Categorias.BackColor = Color.White;
            Categorias.BackgroundColor = Color.White;
            Categorias.BorderColor = Color.FromArgb(64, 64, 64);
            Categorias.BorderRadius = 8;
            Categorias.BorderSize = 1;
            Categorias.FlatAppearance.BorderSize = 0;
            Categorias.FlatStyle = FlatStyle.Flat;
            Categorias.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categorias.ForeColor = Color.Black;
            Categorias.ImageSize = new Size(20, 20);
            Categorias.Location = new Point(14, 181);
            Categorias.Margin = new Padding(3, 4, 3, 4);
            Categorias.Name = "Categorias";
            Categorias.Size = new Size(123, 49);
            Categorias.TabIndex = 4;
            Categorias.Text = "Categorias";
            Categorias.TextColor = Color.Black;
            Categorias.UseVisualStyleBackColor = false;
            Categorias.Click += Categorias_Click;
            // 
            // Marcas
            // 
            Marcas.BackColor = Color.White;
            Marcas.BackgroundColor = Color.White;
            Marcas.BorderColor = Color.FromArgb(64, 64, 64);
            Marcas.BorderRadius = 8;
            Marcas.BorderSize = 1;
            Marcas.FlatAppearance.BorderSize = 0;
            Marcas.FlatStyle = FlatStyle.Flat;
            Marcas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Marcas.ForeColor = Color.Black;
            Marcas.ImageSize = new Size(20, 20);
            Marcas.Location = new Point(14, 124);
            Marcas.Margin = new Padding(3, 4, 3, 4);
            Marcas.Name = "Marcas";
            Marcas.Size = new Size(123, 49);
            Marcas.TabIndex = 5;
            Marcas.Text = "Marcas";
            Marcas.TextColor = Color.Black;
            Marcas.UseVisualStyleBackColor = false;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Buscar.AutoSize = true;
            Buscar.BackColor = Color.White;
            Buscar.BackgroundColor = Color.White;
            Buscar.BorderColor = Color.Black;
            Buscar.BorderRadius = 8;
            Buscar.BorderSize = 1;
            Buscar.FlatAppearance.BorderSize = 0;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.ForeColor = Color.Black;
            Buscar.ImageSize = new Size(20, 20);
            Buscar.Location = new Point(758, 13);
            Buscar.Margin = new Padding(3, 4, 3, 4);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(123, 49);
            Buscar.TabIndex = 6;
            Buscar.Text = "Buscar";
            Buscar.TextColor = Color.Black;
            Buscar.UseVisualStyleBackColor = false;
            // 
            // Productos_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(Buscar);
            Controls.Add(Marcas);
            Controls.Add(Categorias);
            Controls.Add(Agregar);
            Controls.Add(rjButton1);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos_list";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_list_Load;
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
    }
}