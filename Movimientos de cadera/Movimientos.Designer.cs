namespace AVI
{
    partial class Movimientos
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
            Cerrar = new RJControls.RJButton();
            Mov = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Mov).BeginInit();
            SuspendLayout();
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
            Cerrar.HoverColor = Color.FromArgb(255, 196, 0);
            Cerrar.ImageSize = new Size(20, 20);
            Cerrar.Location = new Point(555, 587);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(86, 35);
            Cerrar.TabIndex = 15;
            Cerrar.Text = "Cerrar";
            Cerrar.TextColor = Color.Black;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // Mov
            // 
            Mov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Mov.Location = new Point(21, 36);
            Mov.Name = "Mov";
            Mov.Size = new Size(620, 538);
            Mov.TabIndex = 16;
            // 
            // Movimientos
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(667, 634);
            Controls.Add(Mov);
            Controls.Add(Cerrar);
            Name = "Movimientos";
            StartPosition = FormStartPosition.Manual;
            Text = "Movimientos";
            ((System.ComponentModel.ISupportInitialize)Mov).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private RJControls.RJButton Eliminar;
       
        private RJControls.RJButton Cerrar;
        private DataGridView Mov;
    }
}