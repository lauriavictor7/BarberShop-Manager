using BarberShopClasses.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopClasses.cliente;
using BarberShopClasses.servico;

namespace BarberShopClasses.agendamento
{
    public class DadosAgendamento : Dados, InterfaceAgendamento
    {
        public void AtualizarAgendamento(Agendamento a)
        {
            this.abrirConexao();
            string sql = "UPDATE Agendamento SET data = @data, hora = @hora, Cod_Serv = @servico WHERE cpf = @cpf";

            SqlCommand cmd = new SqlCommand(sql, sqlConn);

            cmd.Parameters.Add("@data", SqlDbType.DateTime);
            cmd.Parameters.Add("@hora", SqlDbType.DateTime);
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
            cmd.Parameters.Add("@servico", SqlDbType.VarChar);

            cmd.Parameters["@data"].Value = a.Data;
            cmd.Parameters["@hora"].Value = a.Hora;
            cmd.Parameters["@cpf"].Value = a.Cliente.Cpf;
            cmd.Parameters["@servico"].Value = a.Servico.Cod_serv;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            this.fecharConexao();
        }

        public void CadastrarAgendamento(Agendamento a)
        {
            try
            {
                
                this.abrirConexao();

                string sql = "INSERT INTO Agendamento (cpf, data, hora, cod_serv) values (@cpf, @data, @hora, @cod_serv)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters.Add("@hora", SqlDbType.DateTime);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@cod_serv", SqlDbType.VarChar);

                cmd.Parameters["@data"].Value = a.Data;
                cmd.Parameters["@hora"].Value = a.Hora;
                cmd.Parameters["@cpf"].Value = a.Cliente.Cpf;
                cmd.Parameters["@cod_serv"].Value = a.Servico.Cod_serv;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }catch(Exception ex)
            {
               throw new Exception("Error" + ex.Message);
            }

        }

        public List<Agendamento> ListarAgendamento()
        {
            try
            {
                List<Agendamento> retorno = new List<Agendamento>();
                this.abrirConexao();
                string sql = "select cod_ag, cpf, data, hora, cod_serv from agendamento;";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Agendamento a = new Agendamento();
                    a.Cliente = new Cliente();
                    a.Servico = new Servico();
                    a.Cod_ag = DbReader.GetInt32(DbReader.GetOrdinal("cod_ag"));
                    a.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    a.Data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    a.Hora = DbReader.GetDateTime(DbReader.GetOrdinal("hora"));
                    a.Servico.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("cod_serv"));
                    
                    retorno.Add(a);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
                return retorno;
            }catch(Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }

        }

        public void RemoverAgendamento(Agendamento a)
        {
           try
            {
                this.abrirConexao();
                string sql = "DELETE FROM Agendamento Where cpf = @cpf";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = a.Cliente.Cpf;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.fecharConexao();
            }catch(Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }

        
    }
}
