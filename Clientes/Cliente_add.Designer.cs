namespace Administrador_de_Inventario_y_ventas.Clientes
{
    partial class Cliente_add
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
            txtApellidoCliente = new TextBox();
            rjButton1 = new AVI.RJControls.RJButton();
            Cerrar = new AVI.RJControls.RJButton();
            label1 = new Label();
            Titulo = new Label();
            txtNombreCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDUICliente = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(42, 156);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(307, 27);
            txtApellidoCliente.TabIndex = 30;
            txtApellidoCliente.TextChanged += txtNombreCategoria_TextChanged;
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
            rjButton1.Location = new Point(42, 408);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(114, 53);
            rjButton1.TabIndex = 29;
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
            Cerrar.Location = new Point(227, 408);
            Cerrar.Margin = new Padding(3, 4, 3, 4);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(114, 53);
            Cerrar.TabIndex = 28;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 133);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 27;
            label1.Text = "Apellido:";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(341, 30);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(0, 29);
            Titulo.TabIndex = 26;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(42, 90);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(307, 27);
            txtNombreCliente.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 67);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 32;
            label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 196);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 33;
            label3.Text = "Telelfono:";
            label3.Click += label3_Click;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(42, 219);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(307, 27);
            txtTelefonoCliente.TabIndex = 34;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(42, 279);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(307, 27);
            txtDireccionCliente.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 256);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 36;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 316);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 37;
            label5.Text = "DUI:";
            // 
            // txtDUICliente
            // 
            txtDUICliente.Location = new Point(42, 339);
            txtDUICliente.Name = "txtDUICliente";
            txtDUICliente.Size = new Size(307, 27);
            txtDUICliente.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 238);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(100, 30);
            label7.Name = "label7";
            label7.Size = new Size(178, 29);
            label7.TabIndex = 40;
            label7.Text = "Nuevo Cliente";
            // 
            // Cliente_add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 485);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDUICliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(rjButton1);
            Controls.Add(Cerrar);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Name = "Cliente_add";
            Text = "Cliente_add";
            Load += Cliente_add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellidoCliente;
        private AVI.RJControls.RJButton rjButton1;
        private AVI.RJControls.RJButton Cerrar;
        private Label label1;
        private Label Titulo;
        private TextBox txtNombreCliente;
        private Label label2;
        private Label label3;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private Label label4;
        private Label label5;
        private TextBox txtDUICliente;
        private Label label6;
        private Label label7;
    }
}