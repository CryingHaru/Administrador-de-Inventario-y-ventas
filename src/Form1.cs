using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //onclick open file image and upload to ./Image folder
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filePath = open.FileName;
                string destPath = Path.Combine(Application.StartupPath, "Image", Path.GetFileName(filePath));
                Directory.CreateDirectory(Path.GetDirectoryName(destPath));
                File.Copy(filePath, destPath, true);
                MessageBox.Show("Imagen subida con éxito a " + destPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //barcode reader
            MessageBox.Show("Iniciando escaneo de código de barras...");
            BarcodeScannerWatcher barcodeScannerWatcher = new BarcodeScannerWatcher();
            barcodeScannerWatcher.StartWatchingAsync().Wait();
            MessageBox.Show("Código de barras detectado: " + barcodeScannerWatcher.Readed);



        }
    }
}
