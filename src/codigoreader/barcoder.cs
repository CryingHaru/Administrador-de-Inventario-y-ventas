using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using IronBarCode;
using System.Drawing;

namespace AVI
{
    public class BarcodeScannerWatcher
    {
        private VideoCapture videoCapture;
        public string Readed { get; private set; }

        public BarcodeScannerWatcher()
        {
            videoCapture = new VideoCapture(0);
            if (!videoCapture.IsOpened())
            {
                MessageBox.Show("Cámara no encontrada. Asegúrese de que la cámara esté conectada.");
                throw new Exception("Camera not found. Make sure the camera is connected.");
                
            }

            Readed = null;
        }

        public async Task StartWatchingAsync()
        {
            await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(Readed))  // Keep watching until a barcode is detected
                {
                    Mat frame = new Mat();
                    videoCapture.Read(frame);

                    if (!frame.Empty())
                    {
                        Bitmap imageBitmap = MatToBitmap(frame);

                        BarcodeReaderOptions options = new BarcodeReaderOptions
                        {
                            ExpectMultipleBarcodes = false,
                            ExpectBarcodeTypes = BarcodeEncoding.All
                        };

                        BarcodeResults results = BarcodeReader.Read(imageBitmap, options);
 
                        if (results.Values().Length > 0)
                        {
                            Readed = results.Values()[0];
                        }
                    }

                    
                    System.Threading.Thread.Sleep(1000);
                }

                videoCapture.Release();
            });
        }

        private Bitmap MatToBitmap(Mat mat)
        {
            using (var ms = mat.ToMemoryStream())
            {
                return new Bitmap(ms);
            }
        }
    }
}
