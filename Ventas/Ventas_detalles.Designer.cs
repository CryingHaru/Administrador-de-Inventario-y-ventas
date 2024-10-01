namespace AVI
{
    partial class Ventas_Detalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_Detalles));
            flowLayoutPanel1 = new FlowLayoutPanel();
            Titulo = new Label();
            rjButton1 = new RJControls.RJButton();
            Agregar = new RJControls.RJButton();
            pictureBox1 = new PictureBox();
            LBnombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            total = new Label();
            Nombrecliente = new Label();
            Fechaventa = new Label();
            VentaID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = Color.WhiteSmoke;
            flowLayoutPanel1.Location = new Point(37, 206);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 226);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Black;
            Titulo.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(146, 26);
            Titulo.Margin = new Padding(2, 0, 2, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(85, 25);
            Titulo.TabIndex = 1;
            Titulo.Text = "Ventas";
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rjButton1.BackColor = Color.Black;
            rjButton1.BackgroundColor = Color.Black;
            rjButton1.BorderColor = SystemColors.Window;
            rjButton1.BorderRadius = 2;
            rjButton1.BorderSize = 1;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.HoverColor = Color.FromArgb(255, 196, 0);
            rjButton1.Image = (Image)resources.GetObject("rjButton1.Image");
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(582, 439);
            rjButton1.Margin = new Padding(2);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(131, 42);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "Atras";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Agregar
            // 
            Agregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Agregar.BackColor = Color.Black;
            Agregar.BackgroundColor = Color.Black;
            Agregar.BorderColor = Color.FromArgb(255, 195, 0);
            Agregar.BorderRadius = 2;
            Agregar.BorderSize = 1;
            Agregar.Cursor = Cursors.Hand;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agregar.ForeColor = Color.White;
            Agregar.HoverColor = Color.FromArgb(255, 196, 0);
            Agregar.Image = (Image)resources.GetObject("Agregar.Image");
            Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            Agregar.ImageSize = new Size(20, 20);
            Agregar.Location = new Point(582, 392);
            Agregar.Margin = new Padding(2, 3, 2, 3);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(131, 42);
            Agregar.TabIndex = 3;
            Agregar.Text = "Anular";
            Agregar.TextColor = Color.White;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 42);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LBnombre
            // 
            LBnombre.AutoSize = true;
            LBnombre.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBnombre.ForeColor = Color.White;
            LBnombre.Location = new Point(37, 76);
            LBnombre.Name = "LBnombre";
            LBnombre.Size = new Size(155, 21);
            LBnombre.TabIndex = 10;
            LBnombre.Text = "Nombre del Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Speedee", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 178);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 11;
            label1.Text = "Productos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 147);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 12;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(464, 76);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 13;
            label3.Text = "Venta N°:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(416, 451);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 14;
            label4.Text = "Total:";
            // 
            // total
            // 
            total.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            total.AutoSize = true;
            total.Font = new Font("Speedee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.White;
            total.Location = new Point(474, 451);
            total.Name = "total";
            total.Size = new Size(19, 21);
            total.TabIndex = 15;
            total.Text = "0";
            // 
            // Nombrecliente
            // 
            Nombrecliente.AutoSize = true;
            Nombrecliente.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombrecliente.ForeColor = Color.White;
            Nombrecliente.Location = new Point(37, 97);
            Nombrecliente.Name = "Nombrecliente";
            Nombrecliente.Size = new Size(68, 21);
            Nombrecliente.TabIndex = 16;
            Nombrecliente.Text = "Nombre";
            // 
            // Fechaventa
            // 
            Fechaventa.AutoSize = true;
            Fechaventa.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fechaventa.ForeColor = Color.White;
            Fechaventa.Location = new Point(103, 147);
            Fechaventa.Name = "Fechaventa";
            Fechaventa.Size = new Size(54, 21);
            Fechaventa.TabIndex = 17;
            Fechaventa.Text = "Fecha";
            // 
            // VentaID
            // 
            VentaID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VentaID.AutoSize = true;
            VentaID.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VentaID.ForeColor = Color.White;
            VentaID.Location = new Point(547, 76);
            VentaID.Name = "VentaID";
            VentaID.Size = new Size(28, 21);
            VentaID.TabIndex = 18;
            VentaID.Text = "00";
            // 
            // Ventas_Detalles
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(724, 493);
            Controls.Add(VentaID);
            Controls.Add(Fechaventa);
            Controls.Add(Nombrecliente);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LBnombre);
            Controls.Add(pictureBox1);
            Controls.Add(Agregar);
            Controls.Add(rjButton1);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ventas_Detalles";
            Text = "Detalles";
            WindowState = FormWindowState.Maximized;
            Load += Productos_list_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Titulo;
        private RJControls.RJButton rjButton1;
        private RJControls.RJButton Agregar;
        private PictureBox pictureBox1;
        private Label LBnombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label total;
        private Label Nombrecliente;
        private Label Fechaventa;
        private Label VentaID;
    }
}