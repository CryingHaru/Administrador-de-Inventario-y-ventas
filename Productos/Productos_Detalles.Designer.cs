namespace AVI
{
    partial class Productos_Detalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_Detalles));
            Editar_button = new RJControls.RJButton();
            label1 = new Label();
            imageElement1 = new customelements.ImageElement();
            Nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Marca = new TextBox();
            Categoria = new TextBox();
            Precio = new TextBox();
            label4 = new Label();
            Existencias = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Detalles = new TextBox();
            Cerrar = new RJControls.RJButton();
            codigobarraimagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)codigobarraimagen).BeginInit();
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
            Editar_button.HoverColor = Color.FromArgb(255, 196, 0);
            Editar_button.ImageSize = new Size(20, 20);
            Editar_button.Location = new Point(20, 580);
            Editar_button.Name = "Editar_button";
            Editar_button.Size = new Size(86, 35);
            Editar_button.TabIndex = 0;
            Editar_button.Text = "Editar";
            Editar_button.TextColor = Color.Black;
            Editar_button.UseVisualStyleBackColor = false;
            Editar_button.Click += Editar_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 178);
            label1.Name = "label1";
            label1.Size = new Size(47, 13);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // imageElement1
            // 
            imageElement1.BackgroundImage = (Image)resources.GetObject("imageElement1.BackgroundImage");
            imageElement1.BackgroundImageLayout = ImageLayout.Stretch;
            imageElement1.ImageHeight = 160;
            imageElement1.ImageWidth = 160;
            imageElement1.Location = new Point(110, 32);
            imageElement1.Name = "imageElement1";
            imageElement1.Position = new Point(0, 0);
            imageElement1.ShowCornerImage = false;
            imageElement1.Size = new Size(137, 139);
            imageElement1.TabIndex = 3;
            imageElement1.Text = "imageElement1";
            imageElement1.Transparency = 1F;
            imageElement1.Url = null;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(51, 193);
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Size = new Size(231, 20);
            Nombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 218);
            label2.Name = "label2";
            label2.Size = new Size(40, 13);
            label2.TabIndex = 5;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 260);
            label3.Name = "label3";
            label3.Size = new Size(55, 13);
            label3.TabIndex = 6;
            label3.Text = "Categoria:";
            // 
            // Marca
            // 
            Marca.Location = new Point(51, 234);
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Size = new Size(231, 20);
            Marca.TabIndex = 7;
            // 
            // Categoria
            // 
            Categoria.Location = new Point(51, 276);
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Size = new Size(231, 20);
            Categoria.TabIndex = 8;
            // 
            // Precio
            // 
            Precio.Location = new Point(51, 317);
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Size = new Size(111, 20);
            Precio.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 302);
            label4.Name = "label4";
            label4.Size = new Size(40, 13);
            label4.TabIndex = 9;
            label4.Text = "Precio:";
            // 
            // Existencias
            // 
            Existencias.Location = new Point(166, 317);
            Existencias.Name = "Existencias";
            Existencias.ReadOnly = true;
            Existencias.Size = new Size(115, 20);
            Existencias.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 302);
            label5.Name = "label5";
            label5.Size = new Size(63, 13);
            label5.TabIndex = 11;
            label5.Text = "Existencias:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 344);
            label6.Name = "label6";
            label6.Size = new Size(48, 13);
            label6.TabIndex = 13;
            label6.Text = "Detalles:";
            // 
            // Detalles
            // 
            Detalles.Location = new Point(51, 360);
            Detalles.Multiline = true;
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Size = new Size(231, 120);
            Detalles.TabIndex = 14;
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
            Cerrar.HoverColor = Color.FromArgb(255, 196, 0);
            Cerrar.ImageSize = new Size(20, 20);
            Cerrar.Location = new Point(214, 580);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(86, 35);
            Cerrar.TabIndex = 15;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // codigobarraimagen
            // 
            codigobarraimagen.Location = new Point(20, 486);
            codigobarraimagen.Name = "codigobarraimagen";
            codigobarraimagen.Size = new Size(280, 88);
            codigobarraimagen.TabIndex = 16;
            codigobarraimagen.TabStop = false;
            // 
            // Productos_Detalles
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(346, 627);
            Controls.Add(codigobarraimagen);
            Controls.Add(Cerrar);
            Controls.Add(Detalles);
            Controls.Add(label6);
            Controls.Add(Existencias);
            Controls.Add(label5);
            Controls.Add(Precio);
            Controls.Add(label4);
            Controls.Add(Categoria);
            Controls.Add(Marca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(imageElement1);
            Controls.Add(label1);
            Controls.Add(Editar_button);
            Name = "Productos_Detalles";
            StartPosition = FormStartPosition.Manual;
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)codigobarraimagen).EndInit();
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
        private TextBox Marca;
        private TextBox Categoria;
        private TextBox Precio;
        private Label label4;
        private TextBox Existencias;
        private Label label5;
        private Label label6;
        private TextBox Detalles;
        private RJControls.RJButton Eliminar;
       
        private RJControls.RJButton Cerrar;
        private PictureBox codigobarraimagen;
    }
}