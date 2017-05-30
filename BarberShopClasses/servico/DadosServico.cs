using BarberShopClasses.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.servico
{
    public class DadosServico : Dados, InterfaceServico
    {
        public void AtualizarServico(Servico s)
        {
            try
            {
                this.abrirConexao();

                string sql = "UPDATE servico SET preco = @preco, descricao = @descricao WHERE cod = @cod";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod", SqlDbType.Int);
                cmd.Parameters.Add("@preco", SqlDbType.Int);
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);

                cmd.Parameters["@cod"].Value = s.Cod_serv;
                cmd.Parameters["@preco"].Value = s.Preco;
                cmd.Parameters["@descricao"].Value = s.Descricao;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar! " + ex.Message);
            }
        }

        public void CadastrarServico(Servico s)
        {
            try
            {
                this.abrirConexao();

                string sql = "INSERT INTO servico (cod, preco, descricao) VALUES(@cod, @preco, @descricao)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod", SqlDbType.Int);
                cmd.Parameters.Add("@preco", SqlDbType.Int);
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);

                cmd.Parameters["@cod"].Value = s.Cod_serv;
                cmd.Parameters["@preco"].Value = s.Preco;
                cmd.Parameters["@descricao"].Value = s.Descricao;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir ou conectar! " + ex.Message);
            }
        }

        public List<Servico> ListarServico()
        {
            try
            {
                List<Servico> retorno = new List<Servico>();

                this.abrirConexao();
                string sql = "SELECT cod, preco, descricao FROM produto";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    Servico s = new Servico();
                    s.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("cod"));
                    s.Preco = DbReader.GetInt32(DbReader.GetOrdinal("preco"));
                    s.Descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    retorno.Add(s);
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

        public void RemoverServico(Servico s)
        {
            try
            {
                this.abrirConexao();

                string sql = "DELETE FROM servico WHERE cod = @cod";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod", SqlDbType.Int);

                cmd.Parameters["@cod"].Value = s.Cod_serv;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover! " + ex.Message);
            }
        }
    }
}
