namespace AVI
{
    partial class Productos_editar
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_editar));
            Guardar_button = new RJControls.RJButton();
            label1 = new Label();
            imageElement1 = new customelements.ImageElement();
            Nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Precio = new TextBox();
            label4 = new Label();
            label6 = new Label();
            Descripcion = new TextBox();
            Cerrar = new RJControls.RJButton();
            Marcascombo = new ComboBox();
            Categoriascombo = new ComboBox();
            Existencias = new TextBox();
            label5 = new Label();
            Editarexistencias = new RJControls.RJButton();
            rjButton2 = new RJControls.RJButton();
            SuspendLayout();
            // 
            // Guardar_button
            // 
            Guardar_button.BackColor = Color.White;
            Guardar_button.BackgroundColor = Color.White;
            Guardar_button.BorderColor = Color.Gray;
            Guardar_button.BorderRadius = 4;
            Guardar_button.BorderSize = 1;
            Guardar_button.Cursor = Cursors.Hand;
            Guardar_button.FlatAppearance.BorderSize = 0;
            Guardar_button.FlatStyle = FlatStyle.Flat;
            Guardar_button.ForeColor = Color.Black;
            Guardar_button.ImageSize = new Size(20, 20);
            Guardar_button.Location = new Point(30, 570);
            Guardar_button.Name = "Guardar_button";
            Guardar_button.Size = new Size(100, 40);
            Guardar_button.TabIndex = 0;
            Guardar_button.Text = "Guardar";
            Guardar_button.TextColor = Color.Black;
            Guardar_button.UseVisualStyleBackColor = false;
            Guardar_button.Click += Editar_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 205);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // imageElement1
            // 
            imageElement1.BackgroundImage = (Image)resources.GetObject("imageElement1.BackgroundImage");
            imageElement1.BackgroundImageLayout = ImageLayout.Stretch;
            imageElement1.Cursor = Cursors.Hand;
            imageElement1.ImageHeight = 160;
            imageElement1.ImageWidth = 160;
            imageElement1.Location = new Point(128, 37);
            imageElement1.Name = "imageElement1";
            imageElement1.Position = new Point(0, 0);
            imageElement1.ShowCornerImage = false;
            imageElement1.Size = new Size(160, 160);
            imageElement1.TabIndex = 3;
            imageElement1.Text = "imageElement1";
            imageElement1.Transparency = 1F;
            imageElement1.Url = null;
            imageElement1.Click += imageElement1_Click;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ButtonHighlight;
            Nombre.Location = new Point(59, 223);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(269, 23);
            Nombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 252);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 300);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Categoria:";
            // 
            // Precio
            // 
            Precio.Location = new Point(59, 366);
            Precio.Name = "Precio";
            Precio.Size = new Size(122, 23);
            Precio.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 348);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 397);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 13;
            label6.Text = "Descripción:";
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(59, 415);
            Descripcion.Multiline = true;
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(269, 132);
            Descripcion.TabIndex = 14;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.White;
            Cerrar.BackgroundColor = Color.White;
            Cerrar.BorderColor = Color.Gray;
            Cerrar.BorderRadius = 4;
            Cerrar.BorderSize = 1;
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.FlatAppearance.BorderSize = 0;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.ForeColor = Color.Black;
            Cerrar.ImageSize = new Size(20, 20);
            Cerrar.Location = new Point(250, 570);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(100, 40);
            Cerrar.TabIndex = 15;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // Marcascombo
            // 
            Marcascombo.FormattingEnabled = true;
            Marcascombo.Location = new Point(59, 274);
            Marcascombo.Name = "Marcascombo";
            Marcascombo.Size = new Size(269, 23);
            Marcascombo.TabIndex = 16;
            Marcascombo.SelectedIndexChanged += Marcas_SelectedIndexChanged;
            // 
            // Categoriascombo
            // 
            Categoriascombo.FormattingEnabled = true;
            Categoriascombo.Location = new Point(59, 318);
            Categoriascombo.Name = "Categoriascombo";
            Categoriascombo.Size = new Size(269, 23);
            Categoriascombo.TabIndex = 17;
            // 
            // Existencias
            // 
            Existencias.Location = new Point(194, 368);
            Existencias.Name = "Existencias";
            Existencias.ReadOnly = true;
            Existencias.Size = new Size(67, 23);
            Existencias.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 348);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 18;
            label5.Text = "Existencias:";
            // 
            // Editarexistencias
            // 
            Editarexistencias.BackColor = Color.MediumSlateBlue;
            Editarexistencias.BackgroundColor = Color.MediumSlateBlue;
            Editarexistencias.BorderColor = Color.PaleVioletRed;
            Editarexistencias.BorderRadius = 2;
            Editarexistencias.BorderSize = 0;
            Editarexistencias.FlatAppearance.BorderSize = 0;
            Editarexistencias.FlatStyle = FlatStyle.Flat;
            Editarexistencias.ForeColor = Color.White;
            Editarexistencias.ImageSize = new Size(20, 20);
            Editarexistencias.Location = new Point(267, 366);
            Editarexistencias.Name = "Editarexistencias";
            Editarexistencias.Size = new Size(61, 25);
            Editarexistencias.TabIndex = 20;
            Editarexistencias.Text = "Editar";
            Editarexistencias.TextColor = Color.White;
            Editarexistencias.UseVisualStyleBackColor = false;
            Editarexistencias.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.White;
            rjButton2.BackgroundColor = Color.White;
            rjButton2.BorderColor = Color.Gray;
            rjButton2.BorderRadius = 4;
            rjButton2.BorderSize = 1;
            rjButton2.Cursor = Cursors.Hand;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.Black;
            rjButton2.Image = (Image)resources.GetObject("rjButton2.Image");
            rjButton2.ImageSize = new Size(20, 20);
            rjButton2.Location = new Point(12, 12);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(40, 40);
            rjButton2.TabIndex = 21;
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // Productos_editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(404, 641);
            Controls.Add(rjButton2);
            Controls.Add(Editarexistencias);
            Controls.Add(Existencias);
            Controls.Add(label5);
            Controls.Add(Categoriascombo);
            Controls.Add(Marcascombo);
            Controls.Add(Cerrar);
            Controls.Add(Descripcion);
            Controls.Add(label6);
            Controls.Add(Precio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(imageElement1);
            Controls.Add(label1);
            Controls.Add(Guardar_button);
            Name = "Productos_editar";
            StartPosition = FormStartPosition.Manual;
            Text = "Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AVI.RJControls.RJButton Guardar_button;
        private Label label1;
        private PictureBox pictureBox1;
        private customelements.ImageElement imageElement1;
        private TextBox Nombre;
        private Label label2;
        private Label label3;
        private TextBox Precio;
        private Label label4;
        private Label label6;
        private TextBox Descripcion;
        private RJControls.RJButton Eliminar;
       
        private RJControls.RJButton Cerrar;
        private ComboBox Marcascombo;
        private ComboBox Categoriascombo;
        private TextBox Existencias;
        private Label label5;
        private RJControls.RJButton Editarexistencias;
        private RJControls.RJButton rjButton2;
    }
}