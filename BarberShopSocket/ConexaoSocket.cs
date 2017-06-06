using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.ComponentModel;
using BarberShopClasses.agendamento;
using BarberShopClasses.conexao;

namespace BarberShopSocket
{
    public class ConexaoSocket
    {
        public OdbcConnection DbConnection;
        private string Conn = "BarberShop";

        public void abrirConexao()
        {
            this.DbConnection = new OdbcConnection("DNS=" + Conn);

            try
            {
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar: " + ex.Message);
            }
        }

        public void fecharConexao()
        {
            this.DbConnection.Close();
        }

        public List<Agendamento> FilaAgendamentos()
        {
            List<Agendamento> retorno = new List<Agendamento>();
            try
            {
                Dados d = new Dados();
                d.abrirConexao();
                OdbcCommand Dbcommand = DbConnection.CreateCommand();

                string sql = "SELECT C.Nome, S.Descricao, A.Data, A.Hora ";
                sql += "FROM Agendamento AS A ";
                sql += "INNER JOIN Cliente AS C ";
                sql += "ON A.CPF = C.CPF";
                sql += "INNER JOIN Servico AS S ";
                sql += "ON A.Cod_Serv = S.Cod_Serv;";

                Dbcommand.CommandText = sql;
                OdbcDataReader DbReader = Dbcommand.ExecuteReader();

                while (DbReader.Read())
                {
                    Agendamento a = new Agendamento();
                    a.Cliente.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    a.Servico.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    a.Data = DbReader.GetString(DbReader.GetOrdinal("Data"));
                    a.Hora = DbReader.GetString(DbReader.GetOrdinal("Hora"));
                }

                DbReader.Close();
                Dbcommand.Dispose();
                d.fecharConexao();
            } catch (Exception ex)
            {
               throw new Exception("Falha ao executar instrução select " + ex.Message);
            }

            return retorno;
        }

        }
    }
