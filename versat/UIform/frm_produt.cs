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
    public partial class frm_produt : Form
    {
        public frm_produt()
        {
            InitializeComponent();
        }
        produtoBLL p = new produtoBLL();
        produtosDAL dal = new produtosDAL();



        private void frm_produt_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgv_pro.DataSource = dt;
            dgv_pro.Columns[0].HeaderText = "ID Produto";
            dgv_pro.Columns[1].HeaderText = "Nome";
            dgv_pro.Columns[2].HeaderText = "Descrição";
            dgv_pro.Columns[3].HeaderText = "Preço";
            dgv_pro.Columns[4].HeaderText = "Categoria";
            dgv_pro.Columns[5].HeaderText = "Quantidade";
        }

        private void btn_cad_pro_Click(object sender, EventArgs e)
        {

            p.nome_prod = txt_nome_pro.Text;
            p.descricao = txt_descricao_pro.Text;
            p.preco = decimal.Parse(txt_preco_pro.Text);
            p.categoria = int.Parse(txt_categoria_pro.Text);
            p.qntd = int.Parse(txt_qnt_pro.Text);


            bool success = dal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Produto Cadastrado com sucesso!");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar esse !");
            }
            DataTable dt = dal.Select();
            dgv_pro.DataSource = dt;

        }
        private void Limpar()
        {
            txt_id_pro.Text = "";
            txt_nome_pro.Text = "";
            txt_descricao_pro.Text = "";
            txt_categoria_pro.Text = "";
            txt_preco_pro.Text = "";
            txt_qnt_pro.Text = "";
        }

        private void btn_limpar_pro_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_update_pro_Click(object sender, EventArgs e)
        {
            p.id_prod = int.Parse(txt_id_pro.Text);
            p.nome_prod = txt_nome_pro.Text;
            p.descricao = txt_descricao_pro.Text;
            p.preco = decimal.Parse(txt_preco_pro.Text);
            p.categoria = int.Parse(txt_categoria_pro.Text);
            p.qntd = int.Parse(txt_qnt_pro.Text);

            bool success = dal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Produto Atualizado com Sucesso");
                Limpar();

                DataTable dt = dal.Select();
                dgv_pro.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Não foi possivel atualizar esse produto");
            }

        }

        private void btn_deletar_pro_Click(object sender, EventArgs e)
        {
            p.id_prod = Convert.ToInt32(txt_id_pro.Text);

            bool success = dal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Produto deletado com Sucesso");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel deletar esse produto");
            }
            DataTable dt = dal.Select();
            dgv_pro.DataSource = dt;
        }

        private void dgv_pro_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_id_pro.Text = dgv_pro.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nome_pro.Text = dgv_pro.Rows[rowIndex].Cells[1].Value.ToString();
            txt_descricao_pro.Text = dgv_pro.Rows[rowIndex].Cells[2].Value.ToString();
            txt_preco_pro.Text = dgv_pro.Rows[rowIndex].Cells[3].Value.ToString();
            txt_categoria_pro.Text = dgv_pro.Rows[rowIndex].Cells[4].Value.ToString();
            txt_qnt_pro.Text = dgv_pro.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void txt_pesquisa_pro_TextChanged(object sender, EventArgs e)
        {
            string keywords = txt_pesquisa_pro.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgv_pro.DataSource = dt;
            }
            else 
            {
                DataTable dt = dal.Select();
                dgv_pro.DataSource = dt;
            }

        }
    }
}

