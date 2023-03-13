using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versat.BLLClasses;

namespace versat.DALdados
{
    class produtosDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region metodo de selecionar
        public DataTable Select()
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
        #region cadastrar novo produto
        public bool Insert(produtoBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_produt(nome_prod,descricao,preco,categoria,qntd) VALUES (@nome_prod,@descricao,@preco,@categoria,@qntd)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome_prod", p.nome_prod);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@preco", p.preco);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@qntd", p.qntd);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }

        #endregion
        #region Atualizar produto
        public bool Update(produtoBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE tbl_produt SET nome_prod=@nome_prod,descricao=@descricao,preco=@preco,categoria=@categoria,qntd=@qntd WHERE id_prod=@id_prod";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_prod", p.id_prod);
                cmd.Parameters.AddWithValue("@nome_prod", p.nome_prod);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@preco", p.preco);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@qntd", p.qntd);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Deletar produto
        public bool Delete(produtoBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM tbl_produt WHERE id_prod=@id_prod";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_prod", u.id_prod);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region metodo para pesquisar produto
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_produt WHERE id_prod LIKE '%" + keywords + "%' OR nome_prod LIKE '%" + keywords + "%' ";
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
    }
}
