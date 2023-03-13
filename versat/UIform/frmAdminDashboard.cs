using versat.UIform;

namespace versat
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produt pro = new frm_produt();
            pro.Show();
        }

        private void ordemDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdem_compra ord = new frmOrdem_compra();    
            ord.Show();
        }
    }
}