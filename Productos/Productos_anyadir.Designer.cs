namespace AVI
{
    partial class Productos_agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_agregar));
            Editar_button = new RJControls.RJButton();
            label1 = new Label();
            imageElement1 = new customelements.ImageElement();
            Nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Precio = new TextBox();
            label4 = new Label();
            label6 = new Label();
            agregar = new TextBox();
            Cerrar = new RJControls.RJButton();
            Marcascombo = new ComboBox();
            Categoriascombo = new ComboBox();
            SuspendLayout();
            // 
            // Editar_button
            // 
            Editar_button.BackColor = Color.White;
            Editar_button.BackgroundColor = Color.White;
            Editar_button.BorderColor = Color.Gray;
            Editar_button.BorderRadius = 4;
            Editar_button.BorderSize = 1;
            Editar_button.Cursor = Cursors.Hand;
            Editar_button.FlatAppearance.BorderSize = 0;
            Editar_button.FlatStyle = FlatStyle.Flat;
            Editar_button.ForeColor = Color.Black;
            Editar_button.ImageSize = new Size(20, 20);
            Editar_button.Location = new Point(30, 570);
            Editar_button.Name = "Editar_button";
            Editar_button.Size = new Size(100, 40);
            Editar_button.TabIndex = 0;
            Editar_button.Text = "Guardar";
            Editar_button.TextColor = Color.Black;
            Editar_button.UseVisualStyleBackColor = false;
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
            imageElement1.ImageHeight = 160;
            imageElement1.ImageWidth = 160;
            imageElement1.Location = new Point(128, 37);
            imageElement1.Name = "imageElement1";
            imageElement1.Position = new Point(0, 0);
            imageElement1.Size = new Size(160, 160);
            imageElement1.TabIndex = 3;
            imageElement1.Text = "imageElement1";
            imageElement1.Transparency = 1F;
            imageElement1.Url = null;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ButtonHighlight;
            Nombre.Location = new Point(59, 223);
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
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
            Precio.Size = new Size(269, 23);
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
            // agregar
            // 
            agregar.Location = new Point(59, 415);
            agregar.Multiline = true;
            agregar.Name = "agregar";
            agregar.Size = new Size(269, 132);
            agregar.TabIndex = 14;
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
            // Productos_agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(404, 641);
            Controls.Add(Categoriascombo);
            Controls.Add(Marcascombo);
            Controls.Add(Cerrar);
            Controls.Add(agregar);
            Controls.Add(label6);
            Controls.Add(Precio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(imageElement1);
            Controls.Add(label1);
            Controls.Add(Editar_button);
            Name = "Productos_agregar";
            StartPosition = FormStartPosition.Manual;
            Text = "Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AVI.RJControls.RJButton Editar_button;
        private Label label1;
        private PictureBox pictureBox1;
        private customelements.ImageElement imageElement1;
        private TextBox Nombre;
        private Label label2;
        private Label label3;
        private TextBox Precio;
        private Label label4;
        private Label label6;
        private TextBox agregar;
        private RJControls.RJButton Eliminar;
       
        private RJControls.RJButton Cerrar;
        private ComboBox Marcascombo;
        private ComboBox Categoriascombo;
    }
}