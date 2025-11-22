namespace SistemaInventario
{
    // CAMBIA "class SistemaInventario" POR "class FormPrincipal"
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}