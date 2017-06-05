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

                string sql = "UPDATE Servico SET Preco = @Preco, Descricao = @Descricao WHERE Cod_Serv = @Cod_Serv";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Cod_Serv", SqlDbType.Int);
                cmd.Parameters.Add("@Preco", SqlDbType.Int);
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);

                cmd.Parameters["@Cod_Serv"].Value = s.Cod_serv;
                cmd.Parameters["@Preco"].Value = s.Preco;
                cmd.Parameters["@Descricao"].Value = s.Descricao;

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

                string sql = "INSERT INTO Servico (Cod_Serv, Preco, Descricao) VALUES(@Cod_Serv, @Preco, @Descricao)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Cod_Serv", SqlDbType.Int);
                cmd.Parameters.Add("@Preco", SqlDbType.Decimal);
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);

                cmd.Parameters["@Cod_Serv"].Value = s.Cod_serv;
                cmd.Parameters["@Preco"].Value = s.Preco;
                cmd.Parameters["@Descricao"].Value = s.Descricao;

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
                string sql = "SELECT Cod_Serv, Preco, Descricao FROM Servico";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    Servico s = new Servico();
                    s.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("Cod_Serv"));
                    s.Preco = Convert.ToDouble(DbReader.GetDecimal(DbReader.GetOrdinal("Preco")));
                    s.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
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

                string sql = "DELETE FROM Servico WHERE Cod_Serv = @Cod_Serv";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Cod_Serv", SqlDbType.Int);

                cmd.Parameters["@Cod_Serv"].Value = s.Cod_serv;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover! " + ex.Message);
            }
        }

        public Servico PesquisarServico(int cod)
        {
            Servico s = new Servico();

            try
            {
                this.abrirConexao();
                string sql = "select Cod_Serv, Preco, Descricao from Servico where Cod_Serv = @Cod_Serv";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@Cod_Serv", SqlDbType.VarChar);

                cmd.Parameters["@Cod_Serv"].Value = cod;

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    s.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("Cod_Serv"));
                    s.Preco = Convert.ToDouble(DbReader.GetDecimal(DbReader.GetOrdinal("Preco")));
                    s.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar! " + ex.Message);
            }
            this.fecharConexao();
            return s;
        }
    }
}
