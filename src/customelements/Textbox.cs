using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AVI
{
    public class Textboxelement : TextBox
    {
        private bool isPassword;
        private bool isReadOnly;

        public Textboxelement()
        {
            this.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(10);
            this.isPassword = false;
            this.isReadOnly = false;
        }

        [Category("Behavior")]
        [Description("Indicates whether the text in the control should appear as the default password character.")]
        public bool IsPassword
        {
            get { return isPassword; }
            set
            {
                isPassword = value;
                this.UseSystemPasswordChar = isPassword;
                this.Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Indicates whether the text in the control is read-only.")]
        public bool IsReadOnly
        {
            get { return isReadOnly; }
            set
            {
                isReadOnly = value;
                this.ReadOnly = isReadOnly;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear una sombra
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(new Rectangle(0, 0, this.Width, this.Height));
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(180, Color.Gray);
                    brush.SurroundColors = new Color[] { Color.Transparent };
                    brush.FocusScales = new PointF(0.8f, 0.8f);

                    e.Graphics.FillRectangle(brush, new Rectangle(0, 0, this.Width, this.Height));
                }
            }

            // Dibujar el fondo del TextBox
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(1, 1, this.Width - 2, this.Height - 2));
            }

            // Dibujar el borde del TextBox
            using (Pen pen = new Pen(Color.LightGray, 2))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}