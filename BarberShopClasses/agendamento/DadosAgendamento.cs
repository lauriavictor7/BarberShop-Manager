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
    public class DadosAgendamento : Dados
    {

        public void CadastrarAgendamento(Agendamento a)
        {
            try
            {

                this.abrirConexao();

                string sql = "INSERT INTO Agendamento (cpf, data, hora, cod_serv) values (@cpf, @data, @hora, @cod_serv)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters.Add("@hora", SqlDbType.Time);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@cod_serv", SqlDbType.VarChar);

                cmd.Parameters["@data"].Value = a.Data;
                cmd.Parameters["@hora"].Value = a.Hora;
                cmd.Parameters["@cpf"].Value = a.Cliente.Cpf;
                cmd.Parameters["@cod_serv"].Value = a.Servico.Cod_serv;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
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
                string sql = "select a.cod_ag, c.cpf, c.nome, a.data, a.hora, s.descricao from Agendamento as a   ";
                sql += " inner join Cliente as c on a.CPF = c.CPF ";
                sql += " inner join Servico as s on a.Cod_serv = s.Cod_serv;;";
                DateTime data;
                

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Agendamento a = new Agendamento();
                    a.Cliente = new Cliente();
                    a.Servico = new Servico();
                    a.Cod_ag = DbReader.GetInt32(DbReader.GetOrdinal("cod_ag"));
                    a.Cliente.Cpf = DbReader.GetString(DbReader.GetOrdinal("CPF"));
                    data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    a.Data = data.ToShortDateString();
                    a.Hora = DbReader.GetString(DbReader.GetOrdinal("hora"));
                    a.Servico.Descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    a.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    retorno.Add(a);
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
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }

        public void AtualizarAgendamento(Agendamento a)
        {
            try
            {
                
                this.abrirConexao();

                string sql = "UPDATE Agendamento SET cod_serv = @cod_serv, data = @data, hora = @hora WHERE cpf = @cpf";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod_serv", SqlDbType.Int);
                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters.Add("@hora", SqlDbType.VarChar);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);

                cmd.Parameters["@cod_serv"].Value = a.Servico.Cod_serv;
                cmd.Parameters["@data"].Value = a.Data;
                cmd.Parameters["@hora"].Value = a.Hora;
                cmd.Parameters["@cpf"].Value = a.Cliente.Cpf;
              
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar! " + ex.Message);
            }
        }
        public Agendamento buscarAgendamento(string cpf)
        {
            Agendamento a = new Agendamento();
            a.Cliente = new Cliente();
            a.Servico = new Servico();
            
            try
            {
                this.abrirConexao();
                string sql = "select cod_serv, data, hora from agendamento where cpf = @cpf";
                DateTime data;
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = cpf;

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    
                    a.Servico.Cod_serv = DbReader.GetInt32(DbReader.GetOrdinal("cod_serv"));
                    data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    a.Data = data.ToShortDateString();
                    a.Hora = DbReader.GetString(DbReader.GetOrdinal("hora"));
                }
            }catch(Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            this.fecharConexao();
            return a;
        }


    }
}
