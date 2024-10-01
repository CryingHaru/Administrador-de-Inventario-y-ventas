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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_add));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.BackColor = SystemColors.WindowText;
            txtApellidoCliente.ForeColor = SystemColors.Window;
            txtApellidoCliente.Location = new Point(32, 101);
            txtApellidoCliente.Margin = new Padding(2, 2, 2, 2);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(231, 20);
            txtApellidoCliente.TabIndex = 30;
            txtApellidoCliente.TextChanged += txtNombreCategoria_TextChanged;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Black;
            rjButton1.BackgroundColor = Color.Black;
            rjButton1.BorderColor = Color.FromArgb(255, 195, 0);
            rjButton1.BorderRadius = 2;
            rjButton1.BorderSize = 1;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.HoverColor = Color.Black;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(32, 265);
            rjButton1.Margin = new Padding(2, 3, 2, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(86, 34);
            rjButton1.TabIndex = 29;
            rjButton1.Text = "Aceptar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.Black;
            Cerrar.BackgroundColor = Color.Black;
            Cerrar.BorderColor = Color.FromArgb(255, 195, 0);
            Cerrar.BorderRadius = 2;
            Cerrar.BorderSize = 1;
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.FlatAppearance.BorderSize = 0;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.ForeColor = Color.White;
            Cerrar.HoverColor = Color.Black;
            Cerrar.ImageSize = new Size(20, 20);
            Cerrar.Location = new Point(170, 265);
            Cerrar.Margin = new Padding(2, 3, 2, 3);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(86, 34);
            Cerrar.TabIndex = 28;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.White;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 195, 0);
            label1.Location = new Point(32, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 13);
            label1.TabIndex = 27;
            label1.Text = "Apellido:";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(256, 19);
            Titulo.Margin = new Padding(2, 0, 2, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(0, 24);
            Titulo.TabIndex = 26;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = SystemColors.MenuText;
            txtNombreCliente.ForeColor = SystemColors.Window;
            txtNombreCliente.Location = new Point(32, 59);
            txtNombreCliente.Margin = new Padding(2, 2, 2, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(231, 20);
            txtNombreCliente.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 195, 0);
            label2.Location = new Point(32, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 13);
            label2.TabIndex = 32;
            label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 195, 0);
            label3.Location = new Point(32, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 13);
            label3.TabIndex = 33;
            label3.Text = "Telefono:";
            label3.Click += label3_Click;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.BackColor = SystemColors.WindowText;
            txtTelefonoCliente.ForeColor = SystemColors.Window;
            txtTelefonoCliente.Location = new Point(32, 142);
            txtTelefonoCliente.Margin = new Padding(2, 2, 2, 2);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(231, 20);
            txtTelefonoCliente.TabIndex = 34;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = SystemColors.WindowText;
            txtDireccionCliente.ForeColor = SystemColors.Window;
            txtDireccionCliente.Location = new Point(32, 181);
            txtDireccionCliente.Margin = new Padding(2, 2, 2, 2);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(231, 20);
            txtDireccionCliente.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 195, 0);
            label4.Location = new Point(32, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 13);
            label4.TabIndex = 36;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 195, 0);
            label5.Location = new Point(32, 205);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 13);
            label5.TabIndex = 37;
            label5.Text = "DUI:";
            // 
            // txtDUICliente
            // 
            txtDUICliente.BackColor = SystemColors.WindowText;
            txtDUICliente.ForeColor = SystemColors.Window;
            txtDUICliente.Location = new Point(32, 220);
            txtDUICliente.Margin = new Padding(2, 2, 2, 2);
            txtDUICliente.Name = "txtDUICliente";
            txtDUICliente.Size = new Size(231, 20);
            txtDUICliente.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 154);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 13);
            label6.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(82, 8);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 24);
            label7.TabIndex = 40;
            label7.Text = "Nuevo Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // Cliente_add
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(278, 315);
            Controls.Add(pictureBox1);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "Cliente_add";
            Text = "Cliente_add";
            Load += Cliente_add_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}