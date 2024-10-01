namespace AVI
{
    partial class Ventas_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_list));
            flowLayoutPanel1 = new FlowLayoutPanel();
            card1 = new customelements.Card();
            card2 = new customelements.Card();
            Titulo = new Label();
            rjButton1 = new RJControls.RJButton();
            Agregar = new RJControls.RJButton();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(card1);
            flowLayoutPanel1.Controls.Add(card2);
            flowLayoutPanel1.ForeColor = Color.WhiteSmoke;
            flowLayoutPanel1.Location = new Point(37, 60);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(528, 421);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // card1
            // 
            card1.Apellido = "Juan";
            card1.BackColor = Color.White;
            card1.BodyColor = Color.White;
            card1.BodyFont = new Font("Speedee", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            card1.BodyImage = null;
            card1.BodyImagePosition = new Point(10, 50);
            card1.BodyImageSize = new Size(50, 50);
            card1.BodyTextAlign = ContentAlignment.MiddleCenter;
            card1.BodyTextColor = Color.Black;
            card1.BorderColor = Color.FromArgb(255, 196, 0);
            card1.BorderRadius = 3;
            card1.BorderSize = 0;
            card1.Cantidad = "Hola";
            card1.FlatStyle = FlatStyle.Flat;
            card1.Font = new Font("Roboto", 10F);
            card1.FooterColor = Color.White;
            card1.FooterFont = new Font("Roboto", 10F, FontStyle.Bold);
            card1.FooterText = "Footer";
            card1.FooterTextAlign = ContentAlignment.MiddleCenter;
            card1.FooterTextColor = Color.White;
            card1.ForeColor = Color.Black;
            card1.HeaderColor = Color.Black;
            card1.HeaderFont = new Font("Roboto", 12F, FontStyle.Bold);
            card1.HeaderImage = (Image)resources.GetObject("card1.HeaderImage");
            card1.HeaderImagePosition = new Point(160, 0);
            card1.HeaderImageSize = new Size(30, 30);
            card1.HeaderText = "Header";
            card1.HeaderTextAlign = ContentAlignment.MiddleCenter;
            card1.HeaderTextColor = Color.White;
            card1.Location = new Point(3, 3);
            card1.Name = "card1";
            card1.Nombre = "Hola";
            card1.Size = new Size(200, 200);
            card1.TabIndex = 0;
            card1.Text = "card1";
            card1.Total = "Juan";
            card1.UseVisualStyleBackColor = false;
            // 
            // card2
            // 
            card2.Apellido = "";
            card2.BackColor = Color.White;
            card2.BodyColor = Color.White;
            card2.BodyFont = new Font("Roboto", 10F);
            card2.BodyImage = (Image)resources.GetObject("card2.BodyImage");
            card2.BodyImagePosition = new Point(30, 35);
            card2.BodyImageSize = new Size(80, 80);
            card2.BodyTextAlign = ContentAlignment.MiddleCenter;
            card2.BodyTextColor = Color.Black;
            card2.BorderColor = Color.FromArgb(255, 196, 0);
            card2.BorderRadius = 3;
            card2.BorderSize = 1;
            card2.Cantidad = "";
            card2.FlatStyle = FlatStyle.Flat;
            card2.Font = new Font("Roboto", 10F);
            card2.FooterColor = Color.FromArgb(255, 196, 0);
            card2.FooterFont = new Font("Roboto", 10F, FontStyle.Bold);
            card2.FooterText = "Footer";
            card2.FooterTextAlign = ContentAlignment.MiddleCenter;
            card2.FooterTextColor = Color.White;
            card2.ForeColor = Color.Black;
            card2.HeaderColor = Color.FromArgb(255, 196, 0);
            card2.HeaderFont = new Font("Roboto", 12F, FontStyle.Bold);
            card2.HeaderImage = null;
            card2.HeaderImagePosition = new Point(5, 5);
            card2.HeaderImageSize = new Size(30, 30);
            card2.HeaderText = "Header";
            card2.HeaderTextAlign = ContentAlignment.MiddleCenter;
            card2.HeaderTextColor = Color.White;
            card2.Location = new Point(209, 3);
            card2.Name = "card2";
            card2.Nombre = "";
            card2.Size = new Size(140, 150);
            card2.TabIndex = 1;
            card2.Text = "card2";
            card2.Total = "";
            card2.UseVisualStyleBackColor = false;
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
            Agregar.Text = "Nueva";
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
            // Ventas_list
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(724, 493);
            Controls.Add(pictureBox1);
            Controls.Add(Agregar);
            Controls.Add(rjButton1);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ventas_list";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_list_Load;
            flowLayoutPanel1.ResumeLayout(false);
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
        private customelements.Card card1;
        private customelements.Card card2;
    }
}