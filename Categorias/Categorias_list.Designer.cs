namespace Administrador_de_Inventario_y_ventas.Categorias
{
    partial class Categorias_list
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Titulo = new Label();
            Agregar = new AVI.RJControls.RJButton();
            rjButton1 = new AVI.RJControls.RJButton();
            rjButton2 = new AVI.RJControls.RJButton();
            rjButton3 = new AVI.RJControls.RJButton();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(138, 54);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(628, 374);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(625, 371);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(138, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(140, 29);
            Titulo.TabIndex = 2;
            Titulo.Text = "Categorias";
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.White;
            Agregar.BackgroundColor = Color.White;
            Agregar.BorderColor = Color.FromArgb(64, 64, 64);
            Agregar.BorderRadius = 8;
            Agregar.BorderSize = 1;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agregar.ForeColor = Color.Black;
            Agregar.ImageSize = new Size(20, 20);
            Agregar.Location = new Point(9, 54);
            Agregar.Margin = new Padding(3, 4, 3, 4);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(123, 49);
            Agregar.TabIndex = 4;
            Agregar.Text = "Nuevo";
            Agregar.TextColor = Color.Black;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.White;
            rjButton1.BackgroundColor = Color.White;
            rjButton1.BorderColor = Color.FromArgb(64, 64, 64);
            rjButton1.BorderRadius = 8;
            rjButton1.BorderSize = 1;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.Black;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(9, 111);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(123, 49);
            rjButton1.TabIndex = 5;
            rjButton1.Text = "Editar";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.White;
            rjButton2.BackgroundColor = Color.White;
            rjButton2.BorderColor = Color.FromArgb(64, 64, 64);
            rjButton2.BorderRadius = 8;
            rjButton2.BorderSize = 1;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.Black;
            rjButton2.ImageSize = new Size(20, 20);
            rjButton2.Location = new Point(9, 168);
            rjButton2.Margin = new Padding(3, 4, 3, 4);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(123, 49);
            rjButton2.TabIndex = 6;
            rjButton2.Text = "Borrar";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.White;
            rjButton3.BackgroundColor = Color.White;
            rjButton3.BorderColor = Color.FromArgb(64, 64, 64);
            rjButton3.BorderRadius = 8;
            rjButton3.BorderSize = 1;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton3.ForeColor = Color.Black;
            rjButton3.ImageSize = new Size(20, 20);
            rjButton3.Location = new Point(9, 266);
            rjButton3.Margin = new Padding(3, 4, 3, 4);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(123, 49);
            rjButton3.TabIndex = 7;
            rjButton3.Text = "Cerrar";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // Categorias_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(Agregar);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Name = "Categorias_list";
            Text = "Categorias_list";
            Load += Categorias_list_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Titulo;
        private AVI.RJControls.RJButton Agregar;
        private DataGridView dataGridView1;
        private AVI.RJControls.RJButton rjButton1;
        private AVI.RJControls.RJButton rjButton2;
        private AVI.RJControls.RJButton rjButton3;
    }
}