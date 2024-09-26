namespace AVI
{
    partial class Ventas_nueva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_nueva));
            flowLayoutPanel1 = new FlowLayoutPanel();
            Titulo = new Label();
            rjButton1 = new RJControls.RJButton();
            Agregar = new RJControls.RJButton();
            Buscar = new RJControls.RJButton();
            pictureBox1 = new PictureBox();
            textboxelement1 = new Textboxelement();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = Color.WhiteSmoke;
            flowLayoutPanel1.Location = new Point(11, 149);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(415, 421);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(146, 26);
            Titulo.Margin = new Padding(2, 0, 2, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(118, 25);
            Titulo.TabIndex = 1;
            Titulo.Text = "Productos";
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
            rjButton1.Location = new Point(836, 443);
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
            Agregar.ForeColor = Color.WhiteSmoke;
            Agregar.HoverColor = Color.FromArgb(255, 196, 0);
            Agregar.Image = (Image)resources.GetObject("Agregar.Image");
            Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            Agregar.ImageSize = new Size(20, 20);
            Agregar.Location = new Point(836, 396);
            Agregar.Margin = new Padding(2, 3, 2, 3);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(131, 42);
            Agregar.TabIndex = 3;
            Agregar.Text = "Agregar";
            Agregar.TextColor = Color.WhiteSmoke;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Buscar.AutoSize = true;
            Buscar.BackColor = Color.Black;
            Buscar.BackgroundColor = Color.Black;
            Buscar.BorderColor = Color.FromArgb(255, 195, 0);
            Buscar.BorderRadius = 2;
            Buscar.BorderSize = 2;
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderSize = 0;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.ForeColor = Color.WhiteSmoke;
            Buscar.HoverColor = Color.FromArgb(255, 196, 0);
            Buscar.ImageSize = new Size(20, 20);
            Buscar.Location = new Point(910, 14);
            Buscar.Margin = new Padding(2, 3, 2, 3);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(80, 26);
            Buscar.TabIndex = 6;
            Buscar.Text = "Buscar";
            Buscar.TextColor = Color.WhiteSmoke;
            Buscar.UseVisualStyleBackColor = false;
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
            // textboxelement1
            // 
            textboxelement1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textboxelement1.BackColor = Color.FromArgb(65, 65, 65);
            textboxelement1.BorderColor = Color.Black;
            textboxelement1.BorderRadius = 1;
            textboxelement1.BorderSize = 2;
            textboxelement1.BorderStyle = BorderStyle.None;
            textboxelement1.Cursor = Cursors.IBeam;
            textboxelement1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxelement1.ForeColor = Color.WhiteSmoke;
            textboxelement1.IsPassword = false;
            textboxelement1.IsReadOnly = false;
            textboxelement1.Location = new Point(762, 17);
            textboxelement1.Name = "textboxelement1";
            textboxelement1.PlaceholderText = "Escribe aqui...";
            textboxelement1.Size = new Size(143, 19);
            textboxelement1.TabIndex = 9;
            textboxelement1.TextChanged += textboxelement1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(42, 13);
            label1.TabIndex = 10;
            label1.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(431, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(400, 423);
            dataGridView1.TabIndex = 11;
            // 
            // Ventas_nueva
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1014, 582);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(Agregar);
            Controls.Add(textboxelement1);
            Controls.Add(pictureBox1);
            Controls.Add(Buscar);
            Controls.Add(rjButton1);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ventas_nueva";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_list_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Titulo;
        private RJControls.RJButton rjButton1;
        private RJControls.RJButton Agregar;
        private RJControls.RJButton Buscar;
        private PictureBox pictureBox1;
        private Textboxelement textboxelement1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}