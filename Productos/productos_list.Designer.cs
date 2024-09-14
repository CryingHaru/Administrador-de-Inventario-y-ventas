namespace AVI
{
    partial class Productos_list
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Titulo = new Label();
            rjButton1 = new RJControls.RJButton();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(135, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(636, 368);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(136, 16);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(99, 23);
            Titulo.TabIndex = 1;
            Titulo.Text = "Productos";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.ImageSize = new Size(20, 20);
            rjButton1.Location = new Point(23, 42);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(80, 35);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "File uploader(for test)";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Productos_list
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(rjButton1);
            Controls.Add(Titulo);
            Controls.Add(flowLayoutPanel1);
            Name = "Productos_list";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label Titulo;
        private RJControls.RJButton rjButton1;
    }
}