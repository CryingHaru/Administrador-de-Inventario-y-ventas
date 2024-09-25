namespace AVI
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            lblResult = new Label();
            rjButton1 = new RJControls.RJButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 36);
            button1.Name = "button1";
            button1.Size = new Size(86, 72);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(140, 36);
            button2.Name = "button2";
            button2.Size = new Size(123, 72);
            button2.TabIndex = 1;
            button2.Text = "Prueba detectorde codigos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(268, 66);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(35, 13);
            lblResult.TabIndex = 2;
            lblResult.Text = "label1";
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
            rjButton1.Location = new Point(425, 39);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 3;
            rjButton1.Text = "Ventas";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(rjButton1);
            Controls.Add(lblResult);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblResult;
        private RJControls.RJButton rjButton1;
    }
}