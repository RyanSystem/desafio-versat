using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versat.BLLClasses;
using versat.DALdados;

namespace versat.UIform
{
    public partial class frmOrdem_compra : Form
    {
        public frmOrdem_compra()
        {
            InitializeComponent();
        }
        ordemBLL o = new ordemBLL();
        ordemDAL odal = new ordemDAL();
        produtosDAL dil = new produtosDAL();
        cadDAL cd = new cadDAL();
        userBLL uc = new userBLL();

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string keywords = txt_pesquisar_ord.Text;
            if (keywords != null)
            {
                DataTable dt = odal.SearchProduto();
                dataGridView1.DataSource = dt;


            }
            else
            {
                DataTable dt = cd.Select();
                dataGridView1.DataSource = dt;
            }

        }
    }
}

