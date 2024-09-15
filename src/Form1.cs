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
        private WebcamBarcodeReader _barcodeReader;
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "Press 'Start' to scan barcodes";

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
            
            _barcodeReader = new WebcamBarcodeReader(UpdateBarcodeResult);
            _barcodeReader.Start();
        }

        
        private void UpdateBarcodeResult(string result)
        {
      
            if (InvokeRequired)
            {
                Invoke(new Action(() => lblResult.Text = result));
            }
            else
            {
                lblResult.Text = result;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            if (_barcodeReader != null)
            {
                _barcodeReader.Stop();
            }
        }
    }
}
