namespace AVI
{
    partial class Marcas_edit
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
            rjButton1 = new RJControls.RJButton();
            Cerrar = new RJControls.RJButton();
            Idmarca = new TextBox();
            label2 = new Label();
            txtnombreMarca = new TextBox();
            label1 = new Label();
            Titulo = new Label();
            SuspendLayout();
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
            rjButton1.Location = new Point(32, 230);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(114, 53);
            rjButton1.TabIndex = 34;
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
            Cerrar.Location = new Point(225, 230);
            Cerrar.Margin = new Padding(3, 4, 3, 4);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(114, 53);
            Cerrar.TabIndex = 33;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            // 
            // Idmarca
            // 
            Idmarca.Location = new Point(32, 93);
            Idmarca.Name = "Idmarca";
            Idmarca.ReadOnly = true;
            Idmarca.Size = new Size(307, 27);
            Idmarca.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 31;
            label2.Text = "Id Marca:";
            // 
            // txtnombreMarca
            // 
            txtnombreMarca.Location = new Point(32, 169);
            txtnombreMarca.Name = "txtnombreMarca";
            txtnombreMarca.Size = new Size(307, 27);
            txtnombreMarca.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 146);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 29;
            label1.Text = "Nombre Marca:";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(102, 21);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(160, 29);
            Titulo.TabIndex = 28;
            Titulo.Text = "Editar Marca";
            // 
            // Marcas_edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 302);
            Controls.Add(rjButton1);
            Controls.Add(Cerrar);
            Controls.Add(Idmarca);
            Controls.Add(label2);
            Controls.Add(txtnombreMarca);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Name = "Marcas_edit";
            Text = "Marcas_edit";
            Load += Marcas_edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AVI.RJControls.RJButton rjButton1;
        private AVI.RJControls.RJButton Cerrar;
        private TextBox Idmarca;
        private Label label2;
        private TextBox txtnombreMarca;
        private Label label1;
        private Label Titulo;
    }
}