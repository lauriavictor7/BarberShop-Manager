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
                string sql = "select Servico.Cod_Serv,Servico.Descricao, Servico.Preco from Agendamento inner join Servico on Agendamento.Cod_Serv = Servico.Cod_Serv where Agendamento.CPF = @CPF";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar);
                cmd.Parameters["@CPF"].Value = cpf;
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    s.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("Cod_Serv"));
                    s.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    s.Preco = Convert.ToDouble(DbReader.GetValue(DbReader.GetOrdinal("Preco")));
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

                string sql = "INSERT INTO Pagamento (cpf, valor, data, hora, metodo) values (@cpf, @valor, @data, @hora, @metodo)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal);
                cmd.Parameters.Add("@data", SqlDbType.VarChar);
                cmd.Parameters.Add("@hora", SqlDbType.VarChar);
                cmd.Parameters.Add("@metodo", SqlDbType.VarChar);
                
                cmd.Parameters["@cpf"].Value = p.Cliente.Cpf;
                cmd.Parameters["@valor"].Value = p.Valor;
                cmd.Parameters["@data"].Value = p.Data;
                cmd.Parameters["@hora"].Value = p.Hora;
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

                this.abrirConexao();
                string sql = "select Cod_Pag, CPF, Valor, Data, Hora, Metodo from Pagamento";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Pagamento p = new Pagamento();
                    p.Cliente = new Cliente();
                    p.Cod_pag = DbReader.GetInt32(DbReader.GetOrdinal("Cod_Pag"));
                    p.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    p.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    p.Data = DbReader.GetString(DbReader.GetOrdinal("Data"));
                    p.Hora = DbReader.GetString(DbReader.GetOrdinal("Hora"));
                    p.Metodo = DbReader.GetString(DbReader.GetOrdinal("Metodo"));
                    
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
