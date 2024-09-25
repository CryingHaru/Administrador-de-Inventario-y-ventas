using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace AVI.customelements
{
    public class Card : Button
    {
        // Fields
        // header text(id)
        private string _headerText;
        private Color _headerColor;
        private Font _headerFont;
        private Color _headerTextColor;
        private ContentAlignment _headerTextAlign;
        private Image? _headerImage; // Nueva propiedad para la imagen del encabezado
        private Size _headerImageSize; // Tamaño de la imagen del encabezado
        private Point _headerImagePosition; // Posición de la imagen del encabezado

        // body multiline
        private Color _bodyColor;
        private Font _bodyFont;
        private Color _bodyTextColor;
        private ContentAlignment _bodyTextAlign;

        // Nuevos campos para los elementos de texto adicionales
        private string _nombre;
        private string _apellido;
        private string _cantidad;
        private string _total;

        // footer
        private string _footerText;
        private Color _footerColor;
        private Font _footerFont;
        private Color _footerTextColor;
        private ContentAlignment _footerTextAlign;

        // border
        private int _borderSize;
        private Color _borderColor;
        private int _borderRadius;

        // Properties
        [Category("Header")]
        public string HeaderText
        {
            get { return _headerText; }
            set { _headerText = value; Invalidate(); }
        }

        [Category("Header")]
        public Color HeaderColor
        {
            get { return _headerColor; }
            set { _headerColor = value; Invalidate(); }
        }

        [Category("Header")]
        public Font HeaderFont
        {
            get { return _headerFont; }
            set { _headerFont = value; Invalidate(); }
        }

        [Category("Header")]
        public Color HeaderTextColor
        {
            get { return _headerTextColor; }
            set { _headerTextColor = value; Invalidate(); }
        }

        [Category("Header")]
        public ContentAlignment HeaderTextAlign
        {
            get { return _headerTextAlign; }
            set { _headerTextAlign = value; Invalidate(); }
        }

        [Category("Header")]
        public Image? HeaderImage
        {
            get { return _headerImage; }
            set { _headerImage = value; Invalidate(); }
        }

        [Category("Header")]
        public Size HeaderImageSize
        {
            get { return _headerImageSize; }
            set { _headerImageSize = value; Invalidate(); }
        }

        [Category("Header")]
        public Point HeaderImagePosition
        {
            get { return _headerImagePosition; }
            set { _headerImagePosition = value; Invalidate(); }
        }

     
        [Category("Body")]
        public Color BodyColor
        {
            get { return _bodyColor; }
            set { _bodyColor = value; Invalidate(); }
        }

        [Category("Body")]
        public Font BodyFont
        {
            get { return _bodyFont; }
            set { _bodyFont = value; Invalidate(); }
        }

        [Category("Body")]
        public Color BodyTextColor
        {
            get { return _bodyTextColor; }
            set { _bodyTextColor = value; Invalidate(); }
        }

        [Category("Body")]
        public ContentAlignment BodyTextAlign
        {
            get { return _bodyTextAlign; }
            set { _bodyTextAlign = value; Invalidate(); }
        }

        // Nuevas propiedades para los elementos de texto adicionales
        [Category("Body")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; Invalidate(); }
        }

        [Category("Body")]
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; Invalidate(); }
        }

        [Category("Body")]
        public string Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; Invalidate(); }
        }

        [Category("Body")]
        public string Total
        {
            get { return _total; }
            set { _total = value; Invalidate(); }
        }

        [Category("Footer")]
        public string FooterText
        {
            get { return _footerText; }
            set { _footerText = value; Invalidate(); }
        }

        [Category("Footer")]
        public Color FooterColor
        {
            get { return _footerColor; }
            set { _footerColor = value; Invalidate(); }
        }

        [Category("Footer")]
        public Font FooterFont
        {
            get { return _footerFont; }
            set { _footerFont = value; Invalidate(); }
        }

        [Category("Footer")]
        public Color FooterTextColor
        {
            get { return _footerTextColor; }
            set { _footerTextColor = value; Invalidate(); }
        }

        [Category("Footer")]
        public ContentAlignment FooterTextAlign
        {
            get { return _footerTextAlign; }
            set { _footerTextAlign = value; Invalidate(); }
        }

        [Category("Border")]
        public int BorderSize
        {
            get { return _borderSize; }
            set { _borderSize = value; Invalidate(); }
        }

        [Category("Border")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Border")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; Invalidate(); }
        }

        // Constructor
        public Card()
        {
            // default values
            _headerText = "Header";
            _headerColor = Color.FromArgb(255, 196, 0);
            _headerFont = new Font("Roboto", 12, FontStyle.Bold);
            _headerTextColor = Color.White;
            _headerTextAlign = ContentAlignment.MiddleCenter;
            _headerImage = null;
            _headerImageSize = new Size(30, 30);
            _headerImagePosition = new Point(5, 5);

            _bodyColor = Color.White;
            _bodyFont = new Font("Roboto", 10);
            _bodyTextColor = Color.Black;
            _bodyTextAlign = ContentAlignment.MiddleCenter;

            _nombre = "Nombre";
            _apellido = "Apellido";
            _cantidad = "Cantidad";
            _total = "Total";

            _footerText = "Footer";
            _footerColor = Color.FromArgb(255, 196, 0);
            _footerFont = new Font("Roboto", 10, FontStyle.Bold);
            _footerTextColor = Color.White;
            _footerTextAlign = ContentAlignment.MiddleCenter;

            _borderSize = 1;
            _borderColor = Color.FromArgb(255, 196, 0);
            _borderRadius = 3;

            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Roboto", 10);
            this.Cursor = Cursors.Hand;
        }

        // Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            Rectangle rectangle = this.ClientRectangle;
            Rectangle headerRectangle = new Rectangle(0, 0, rectangle.Width, 30);
            Rectangle bodyRectangle = new Rectangle(0, 30, rectangle.Width, rectangle.Height - 60);
            Rectangle footerRectangle = new Rectangle(0, rectangle.Height - 30, rectangle.Width, 30);

            // header
            using (SolidBrush brush = new SolidBrush(_headerColor))
            {
                graphics.FillRectangle(brush, headerRectangle);
            }

            if (_headerImage != null)
            {
                Rectangle imageRectangle = new Rectangle(_headerImagePosition, _headerImageSize);
                graphics.DrawImage(_headerImage, imageRectangle);
            }

            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = GetStringAlignment(_headerTextAlign);
                stringFormat.LineAlignment = GetLineAlignment(_headerTextAlign);
                using (SolidBrush brush = new SolidBrush(_headerTextColor))
                {
                    graphics.DrawString(_headerText, _headerFont, brush, headerRectangle, stringFormat);
                }
            }

            // body
            using (SolidBrush brush = new SolidBrush(_bodyColor))
            {
                graphics.FillRectangle(brush, bodyRectangle);
            }

            // Dibujar los nuevos elementos de texto en el cuerpo
            int textYPosition = 50; // Posición Y inicial para los textos adicionales
            int textSpacing = 20; // Espaciado entre los textos

            using (SolidBrush brush = new SolidBrush(_bodyTextColor))
            {
                graphics.DrawString(_nombre, _bodyFont, brush, new Point(10, textYPosition));
                textYPosition += textSpacing;
                graphics.DrawString(_apellido, _bodyFont, brush, new Point(10, textYPosition));
                textYPosition += textSpacing;
                graphics.DrawString(_cantidad, _bodyFont, brush, new Point(10, textYPosition));
                textYPosition += textSpacing;
                graphics.DrawString(_total, _bodyFont, brush, new Point(10, textYPosition));
            }

            // footer
            using (SolidBrush brush = new SolidBrush(_footerColor))
            {
                graphics.FillRectangle(brush, footerRectangle);
            }

            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = GetStringAlignment(_footerTextAlign);
                stringFormat.LineAlignment = GetLineAlignment(_footerTextAlign);
                using (SolidBrush brush = new SolidBrush(_footerTextColor))
                {
                    graphics.DrawString(_footerText, _footerFont, brush, footerRectangle, stringFormat);
                }
            }

            // Dibujar el borde solo alrededor del rectángulo completo de la tarjeta
            using (Pen pen = new Pen(_borderColor, _borderSize))
            {
                graphics.DrawRectangle(pen, rectangle);
            }
        }

        private StringAlignment GetStringAlignment(ContentAlignment alignment)
        {
            return alignment switch
            {
                ContentAlignment.TopLeft or ContentAlignment.MiddleLeft or ContentAlignment.BottomLeft => StringAlignment.Near,
                ContentAlignment.TopCenter or ContentAlignment.MiddleCenter or ContentAlignment.BottomCenter => StringAlignment.Center,
                ContentAlignment.TopRight or ContentAlignment.MiddleRight or ContentAlignment.BottomRight => StringAlignment.Far,
                _ => StringAlignment.Center,
            };
        }

        private StringAlignment GetLineAlignment(ContentAlignment alignment)
        {
            return alignment switch
            {
                ContentAlignment.TopLeft or ContentAlignment.TopCenter or ContentAlignment.TopRight => StringAlignment.Near,
                ContentAlignment.MiddleLeft or ContentAlignment.MiddleCenter or ContentAlignment.MiddleRight => StringAlignment.Center,
                ContentAlignment.BottomLeft or ContentAlignment.BottomCenter or ContentAlignment.BottomRight => StringAlignment.Far,
                _ => StringAlignment.Center,
            };
        }
    }
}
