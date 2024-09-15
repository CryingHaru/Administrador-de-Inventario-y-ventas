using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using ZXing;
using ZXing.Windows.Compatibility;

namespace AVI
{
    public class WebcamBarcodeReader
    {
        private VideoCapture _capture;
        private bool _isRunning;
        private Action<string> _onBarcodeScanned;

        public WebcamBarcodeReader(Action<string> onBarcodeScanned)
        {
            _onBarcodeScanned = onBarcodeScanned;

            for (int i = 0; i < 10; i++)
            {
                _capture = new VideoCapture(i);
                if (_capture.IsOpened())
                {
                    break;
                }
            }

            if (!_capture.IsOpened())
            {
                throw new Exception("No se pudo abrir ninguna cámara.");
            }
        }

        public void Start()
        {
            _isRunning = true;
            Thread captureThread = new Thread(CaptureLoop);
            captureThread.IsBackground = true;
            captureThread.Start();
        }

        public void Stop()
        {
            _isRunning = false;
        }

        private void CaptureLoop()
        {
            _onBarcodeScanned?.Invoke("Leyendo...");
            while (_isRunning)
            {
                using (Mat frame = new Mat())
                {
                    _capture.Read(frame);

                    if (!frame.Empty())
                    {
                        ProcessFrame(frame);
                    }
                }
                Thread.Sleep(100); // Pausar por 100 milisegundos
            }
        }

        private void ProcessFrame(Mat frame)
        {
            try
            {
                Bitmap bitmap = BitmapConverter.ToBitmap(frame);

                // Verifica si la versión de ZXing.Net es compatible
                var barcodeReader = new BarcodeReader(); // Instancia del lector de ZXing.Net
                var result = barcodeReader.Decode(bitmap);

                if (result != null)
                {
                    _onBarcodeScanned?.Invoke($"Código de barras encontrado: {result.Text}");
                    //detener por 5 segundos
                    Thread.Sleep(5000);


                }
                else
                {
                    _onBarcodeScanned?.Invoke("No se encontró código de barras.");
                }
            }
            catch (Exception ex)
            {
                _onBarcodeScanned?.Invoke($"Error al procesar el frame: {ex.Message}");
            }
        }
    }
}
