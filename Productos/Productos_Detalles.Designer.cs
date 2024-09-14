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
            Cerrar.Click += (sender, e) => this.Close();
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
            Editar_button.Text = "Editar";
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
            // Marca
            // 
            Marca.Location = new Point(59, 270);
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Size = new Size(269, 23);
            Marca.TabIndex = 7;
            // 
            // Categoria
            // 
            Categoria.Location = new Point(59, 318);
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Size = new Size(269, 23);
            Categoria.TabIndex = 8;
            // 
            // Precio
            // 
            Precio.Location = new Point(59, 366);
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Size = new Size(129, 23);
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
            // Existencias
            // 
            Existencias.Location = new Point(194, 366);
            Existencias.Name = "Existencias";
            Existencias.ReadOnly = true;
            Existencias.Size = new Size(134, 23);
            Existencias.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 348);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Existencias:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 397);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Detalles:";
            // 
            // Detalles
            // 
            Detalles.Location = new Point(59, 415);
            Detalles.Multiline = true;
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Size = new Size(269, 132);
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
            Cerrar.ImageSize = new Size(20, 20);
            Cerrar.Location = new Point(250, 570);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(100, 40);
            Cerrar.TabIndex = 15;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            // 
            // Productos_Detalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(404, 641);
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
    }
}