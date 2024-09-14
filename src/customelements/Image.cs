using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Imaging;


namespace AVI.customelements
{
    public class ImageElement : Control
    {
        private string url;
        private float transparency;
        private int imageWidth;
        private int imageHeight;
        private Point position;

        [Category("Custom Properties")]
        public string Url
        {
            get { return url; }
            set { url = value; Invalidate(); }
        }

        [Category("Custom Properties")]
        public float Transparency
        {
            get { return transparency; }
            set { transparency = value; Invalidate(); }
        }

        [Category("Custom Properties")]
        public int ImageWidth
        {
            get { return imageWidth; }
            set { imageWidth = value; Invalidate(); }
        }

        [Category("Custom Properties")]
        public int ImageHeight
        {
            get { return imageHeight; }
            set { imageHeight = value; Invalidate(); }
        }

        [Category("Custom Properties")]
        public Point Position
        {
            get { return position; }
            set { position = value; Invalidate(); }
        }

        public ImageElement()
        {
            transparency = 1.0f; // Opacidad completa por defecto
            imageWidth = 100; // Ancho por defecto
            imageHeight = 100; // Altura por defecto
            position = new Point(0, 0); // Posición por defecto
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    using (var image = new Bitmap(url))
                    {
                        var colorMatrix = new ColorMatrix
                        {
                            Matrix33 = transparency
                        };

                        var imageAttributes = new ImageAttributes();
                        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        e.Graphics.DrawImage(
                            image,
                            new Rectangle(position.X, position.Y, imageWidth, imageHeight),
                            0, 0, image.Width, image.Height,
                            GraphicsUnit.Pixel,
                            imageAttributes
                        );
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, por ejemplo, si la URL no es válida
                    e.Graphics.DrawString("Error loading image", this.Font, Brushes.Red, new PointF(0, 0));
                }
            }
        }
    }
}
