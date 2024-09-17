namespace Administrador_de_Inventario_y_ventas.Marcas
{
    partial class Marcas_list
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
            dataGridView1 = new DataGridView();
            rjButton3 = new AVI.RJControls.RJButton();
            rjButton2 = new AVI.RJControls.RJButton();
            rjButton1 = new AVI.RJControls.RJButton();
            Agregar = new AVI.RJControls.RJButton();
            Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(163, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(267, 371);
            dataGridView1.TabIndex = 1;
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
            rjButton3.Location = new Point(12, 267);
            rjButton3.Margin = new Padding(3, 4, 3, 4);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(123, 49);
            rjButton3.TabIndex = 11;
            rjButton3.Text = "Cerrar";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
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
            rjButton2.Location = new Point(12, 169);
            rjButton2.Margin = new Padding(3, 4, 3, 4);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(123, 49);
            rjButton2.TabIndex = 10;
            rjButton2.Text = "Borrar";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
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
            rjButton1.Location = new Point(12, 112);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(123, 49);
            rjButton1.TabIndex = 9;
            rjButton1.Text = "Editar";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
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
            Agregar.Location = new Point(12, 55);
            Agregar.Margin = new Padding(3, 4, 3, 4);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(123, 49);
            Agregar.TabIndex = 8;
            Agregar.Text = "Nuevo";
            Agregar.TextColor = Color.Black;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(163, 7);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(97, 29);
            Titulo.TabIndex = 12;
            Titulo.Text = "Marcas";
            // 
            // Marcas_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(Titulo);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(Agregar);
            Controls.Add(dataGridView1);
            Name = "Marcas_list";
            Text = "Marcas_list";
            Load += Marcas_list_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private AVI.RJControls.RJButton rjButton3;
        private AVI.RJControls.RJButton rjButton2;
        private AVI.RJControls.RJButton rjButton1;
        private AVI.RJControls.RJButton Agregar;
        private Label Titulo;
    }
}