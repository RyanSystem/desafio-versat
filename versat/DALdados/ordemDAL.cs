using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using versat.BLLClasses;

namespace versat.DALdados
{
    internal class ordemDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region metodo de selecionar cliente
        public DataTable SelectCliente()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_cliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion

        #region metodo de selecionar produtos
        public DataTable SelectProdutos()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_produt";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion


      
        #region pesquisar produto
        public produtoBLL SearchProduto(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            produtoBLL dc = new produtoBLL();
            userBLL uc = new userBLL();
            try
            {
                String sql = "SELECT * FROM tbl_produt WHERE id_prod LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                 if( dt.Rows.Count > 0 )
                {
                    uc.nome = dt.Rows[0]["nome"].ToString();
                    uc.endereco = dt.Rows[0]["endereco"].ToString();
                    uc.contato = dt.Rows[0]["contato"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dc;
        }

        internal DataTable SearchProduto()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
