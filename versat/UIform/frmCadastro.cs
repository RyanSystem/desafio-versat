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

namespace versat
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        cadDAL dal = new cadDAL();
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            u.nome = txt_nome_cad.Text;
            u.endereco = txt_end_cad.Text;
            u.contato = txt_cont_cli.Text;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("Usuario Cadastrado com sucesso!");
                Limpar();

            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar esse usuario!");
            }
            DataTable dt = dal.Select();
            dgvCad.DataSource = dt;

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCad.DataSource = dt;
            dgvCad.Columns[0].HeaderText = "ID Usuario";
            dgvCad.Columns[1].HeaderText = "Nome";
            dgvCad.Columns[2].HeaderText = "Endereço";
            dgvCad.Columns[3].HeaderText = "Contato";

        }
        private void Limpar()
        {
            txt_id_cad.Text = "";
            txt_nome_cad.Text = "";
            txt_end_cad.Text = "";
            txt_cont_cli.Text = "";
        }

        private void dgvCad_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_id_cad.Text = dgvCad.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nome_cad.Text = dgvCad.Rows[rowIndex].Cells[1].Value.ToString();
            txt_end_cad.Text = dgvCad.Rows[rowIndex].Cells[2].Value.ToString();
            txt_cont_cli.Text = dgvCad.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txt_id_cad.Text);
            u.nome = txt_nome_cad.Text;
            u.endereco = txt_end_cad.Text;
            u.contato = txt_cont_cli.Text;

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("Usuario Atualizado com Sucesso");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel atualizar esse usuario");
            }
            DataTable dt = dal.Select();
            dgvCad.DataSource = dt;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txt_id_cad.Text);

            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("Usuario deletado com Sucesso");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel deletar esse usuario");
            }
            DataTable dt = dal.Select();
            dgvCad.DataSource = dt;
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txt_pesquisar.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvCad.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCad.DataSource = dt;
            }

        }

        private void dgvCad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
