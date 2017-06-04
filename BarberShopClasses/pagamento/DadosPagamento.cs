using BarberShopClasses.cliente;
using BarberShopClasses.conexao;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.pagamento
{
    public class DadosPagamento : Dados
    {
        public Servico buscarValor(string cpf)
        {
            Servico s = new Servico();
            try
            {

                this.abrirConexao();
                string sql = "select Servico.Cod_Serv,Servico.Descricao, Servico.Preco from Agendamento inner join Servico on Agendamento.Cod_Serv = Servico.Cod_Serv where Agendamento.CPF = @cpf";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = cpf;
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    s.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("cod_serv"));
                    s.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    s.Preco = Convert.ToDouble(DbReader.GetValue(DbReader.GetOrdinal("preco")));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            this.fecharConexao();
            return s;
        }
        public void CadastrarPagamento(Pagamento p)
        {
            try
            {

                this.abrirConexao();

                string sql = "INSERT INTO Pagamento (cpf, valor, data, hora, metodo) values (@cpf ,@valor, @data, @hora, @metodo)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters.Add("@hora", SqlDbType.VarChar);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters.Add("@metodo", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = p.Cliente.Cpf;
                cmd.Parameters["@data"].Value = p.Data;
                cmd.Parameters["@hora"].Value = p.Hora;
                cmd.Parameters["@valor"].Value = p.Valor;
                cmd.Parameters["@metodo"].Value = p.Metodo;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }
        public List<Pagamento> ListarPagamento()
        {
            try
            {
                List<Pagamento> retorno = new List<Pagamento>();
                DateTime data;
                this.abrirConexao();
                string sql = "select cod_pag, valor, data, hora, cpf, metodo from pagamento";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Pagamento p = new Pagamento();
                    p.Cliente = new Cliente();
                    p.Cod_pag = DbReader.GetInt32(DbReader.GetOrdinal("cod_pag"));
                    p.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("valor"));
                    data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    p.Data = data.ToShortDateString();
                    p.Hora = DbReader.GetString(DbReader.GetOrdinal("hora"));
                    p.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    p.Metodo = DbReader.GetString(DbReader.GetOrdinal("metodo"));
                    
                    retorno.Add(p);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
                return retorno;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
    }
}
