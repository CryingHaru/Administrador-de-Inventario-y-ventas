﻿namespace Administrador_de_Inventario_y_ventas.Categorias
{
    partial class Categorias_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias_add));
            Titulo = new Label();
            label1 = new Label();
            Cerrar = new AVI.RJControls.RJButton();
            rjButton1 = new AVI.RJControls.RJButton();
            txtNombreCategoria = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.Gold;
            Titulo.Location = new Point(90, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(208, 29);
            Titulo.TabIndex = 3;
            Titulo.Text = "Nueva Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(37, 72);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre Categoria:";
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
            Cerrar.ForeColor = Color.Gold;
            Cerrar.HoverColor = Color.Black;
            Cerrar.ImageSize = new Size(20, 20);
            Cerrar.Location = new Point(230, 199);
            Cerrar.Margin = new Padding(3, 4, 3, 4);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(114, 53);
            Cerrar.TabIndex = 16;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Gold;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.White;
            rjButton1.BackgroundColor = Color.White;
            rjButton1.BorderColor = Color.Gray;
            rjButton1.BorderRadius = 4;
            rjButton1.BorderSize = 1;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.Gold;
            rjButton1.HoverColor = Color.Black;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(37, 199);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(114, 53);
            rjButton1.TabIndex = 17;
            rjButton1.Text = "Aceptar";
            rjButton1.TextColor = Color.Gold;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(37, 95);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(307, 27);
            txtNombreCategoria.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // Categorias_add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 279);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreCategoria);
            Controls.Add(rjButton1);
            Controls.Add(Cerrar);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Name = "Categorias_add";
            Text = "Categorias_add";
            Load += Categorias_add_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label label1;
        private AVI.RJControls.RJButton Cerrar;
        private AVI.RJControls.RJButton rjButton1;
        private TextBox txtNombreCategoria;
        private PictureBox pictureBox1;
    }
}