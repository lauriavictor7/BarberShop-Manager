using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopClasses.conexao;
using System.Data.SqlClient;
using System.Data;


namespace BarberShopClasses.produto
{
    public class DadosProduto : Dados, InterfaceProduto
    {
        public void AtualizarProduto(Produto p)
        {
            try
            {
                this.abrirConexao();

                string sql = "UPDATE produto SET preco = @preco, descricao = @descricao WHERE cod = @cod";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod", SqlDbType.Int);
                cmd.Parameters.Add("@preco", SqlDbType.Int);
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);

                cmd.Parameters["@cod"].Value = p.Cod_prod;
                cmd.Parameters["@preco"].Value = p.Preco;
                cmd.Parameters["@descricao"].Value = p.Descricao;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception ("Erro ao atualizar! " +ex.Message);
            }
        }

        public void CadastrarProduto(Produto p)
        {
            try
            {
                this.abrirConexao();

                string sql = "INSERT INTO produto (cod, preco, descricao) VALUES(@cod, @preco, @descricao)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod", SqlDbType.Int);
                cmd.Parameters.Add("@preco", SqlDbType.Int);
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);

                cmd.Parameters["@cod"].Value = p.Cod_prod;
                cmd.Parameters["@preco"].Value = p.Preco;
                cmd.Parameters["@descricao"].Value = p.Descricao;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir ou conectar! " + ex.Message);
            }
        }

        public List<Produto> ListarProduto()
        {
            try
            {
                List<Produto> retorno = new List<Produto>();

                this.abrirConexao();
                string sql = "SELECT cod, preco, descricao FROM produto";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                 SqlDataReader DbReader = cmd.ExecuteReader();

                 while (DbReader.Read())
                 {
                     Produto p = new Produto();
                     p.Cod_prod = DbReader.GetInt32(DbReader.GetOrdinal("cod"));
                     p.Preco = DbReader.GetInt32(DbReader.GetOrdinal("preco"));
                     p.Descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                     retorno.Add(p);
                 }

                 DbReader.Close();
                 cmd.Dispose();
                 this.fecharConexao();
                 return retorno; 
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar! " + ex.Message);
            }
        }

        public void RemoverProduto(Produto p)
        {
            try
            {
                this.abrirConexao();

                string sql = "DELETE FROM produto WHERE cod = @cod";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod", SqlDbType.Int);

                cmd.Parameters["@cod"].Value = p.Cod_prod;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception ("Erro ao remover! " + ex.Message);
            }
        }
    }
}