namespace AVI
{
    partial class ProductoExistencias
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
            label1 = new Label();
            Guardar = new RJControls.RJButton();
            accion = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Existencias";
            // 
            // Guardar
            // 
            Guardar.BackColor = Color.White;
            Guardar.BackgroundColor = Color.White;
            Guardar.BorderColor = Color.FromArgb(255, 195, 0);
            Guardar.BorderRadius = 2;
            Guardar.BorderSize = 1;
            Guardar.FlatAppearance.BorderSize = 0;
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.Font = new Font("Speedee", 12F, FontStyle.Bold);
            Guardar.ForeColor = Color.Black;
            Guardar.ImageSize = new Size(20, 20);
            Guardar.Location = new Point(89, 185);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(150, 40);
            Guardar.TabIndex = 1;
            Guardar.Text = "Guardar";
            Guardar.TextColor = Color.Black;
            Guardar.UseVisualStyleBackColor = false;
            Guardar.Click += Guardar_Click;
            // 
            // accion
            // 
            accion.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accion.FormattingEnabled = true;
            accion.Items.AddRange(new object[] { "Agregar", "Quitar" });
            accion.Location = new Point(89, 61);
            accion.Name = "accion";
            accion.Size = new Size(174, 29);
            accion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 3;
            label2.Text = "Acción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 4;
            label3.Text = "Cantidad:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Speedee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(89, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 28);
            textBox1.TabIndex = 5;
            // 
            // ProductoExistencias
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(336, 252);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(accion);
            Controls.Add(Guardar);
            Controls.Add(label1);
            Font = new Font("Speedee", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "ProductoExistencias";
            Text = "Existencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private AVI.RJControls.RJButton Guardar;
        private ComboBox accion;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}