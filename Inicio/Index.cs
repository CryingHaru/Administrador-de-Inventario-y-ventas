namespace Administrador_de_Inventario_y_ventas
{
    public partial class Administador : Form
    {
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }
        public Administador()
        {
            InitializeComponent();
        }

        private void Administador_Load(object sender, EventArgs e)
        {
            this.EnterFullScreenMode(this);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.LeaveFullScreenMode(this);
        }
       
    }
}
