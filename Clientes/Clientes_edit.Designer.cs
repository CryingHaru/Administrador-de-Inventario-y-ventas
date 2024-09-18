namespace Administrador_de_Inventario_y_ventas.Categorias
{
    partial class Clientes_edit
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
            txtIdCategoria = new TextBox();
            label2 = new Label();
            txtNombreCategoria = new TextBox();
            label1 = new Label();
            Titulo = new Label();
            rjButton1 = new AVI.RJControls.RJButton();
            Cerrar = new AVI.RJControls.RJButton();
            SuspendLayout();
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(27, 79);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.ReadOnly = true;
            txtIdCategoria.Size = new Size(307, 27);
            txtIdCategoria.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 56);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 24;
            label2.Text = "Id Categoria:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(27, 155);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(307, 27);
            txtNombreCategoria.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 132);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre Categoria:";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(80, 18);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(203, 29);
            Titulo.TabIndex = 21;
            Titulo.Text = "Editar Categoria";
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
            rjButton1.ForeColor = Color.Black;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(27, 216);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(114, 53);
            rjButton1.TabIndex = 27;
            rjButton1.Text = "Aceptar";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
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
            Cerrar.Location = new Point(220, 216);
            Cerrar.Margin = new Padding(3, 4, 3, 4);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(114, 53);
            Cerrar.TabIndex = 26;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // Categorias_edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 298);
            Controls.Add(rjButton1);
            Controls.Add(Cerrar);
            Controls.Add(txtIdCategoria);
            Controls.Add(label2);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Name = "Categorias_edit";
            Text = "Categorias_edit";
            Load += Categorias_edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCategoria;
        private Label label2;
        private TextBox txtNombreCategoria;
        private Label label1;
        private Label Titulo;
        private AVI.RJControls.RJButton rjButton1;
        private AVI.RJControls.RJButton Cerrar;
    }
}