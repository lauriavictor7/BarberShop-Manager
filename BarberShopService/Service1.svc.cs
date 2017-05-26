using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BarberShopClasses.cliente;
using BarberShopClasses.conexao;
using System.Data.SqlClient;
using System.Data;

namespace BarberShopService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        public void atualizarCLiente(Cliente c)
        {
            Dados d = new Dados();
            d.abrirConexao();

            string sql = "UPDATE cliente SET nome = @nome, telefone = @telefone WHERE cpf = @cpf";

            SqlCommand cmd = new SqlCommand(sql, d.sqlConn);

            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

            cmd.Parameters["@cpf"].Value = c.Cpf;
            cmd.Parameters["@nome"].Value = c.Nome;
            cmd.Parameters["@telefone"].Value = c.Telefone;

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            d.fecharConexao();
        }

        public void inserirCliente(Cliente c)
        {
            try
            {
                Dados d = new Dados();
                d.abrirConexao();

                string sql = "INSERT INTO cliente (cpf, nome, telefone) VALUES(@cpf, @nome, @telefone)";

                SqlCommand cmd = new SqlCommand(sql, d.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = c.Cpf;
                cmd.Parameters["@nome"].Value = c.Nome;
                cmd.Parameters["@telefone"].Value = c.Telefone;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                d.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ou inserir. " + ex.Message);
            }
        }

        public string pegarTexto()
        {
            return "Bora!";
        }

        public void removerCliente(Cliente c)
        {
            try
            {
                Dados d = new Dados();
                d.abrirConexao();

                string sql = "DELETE FROM cliente WHERE cpf = @cpf";

                SqlCommand cmd = new SqlCommand(sql, d.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = c.Cpf;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                d.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ou inserir. " + ex.Message);
            }
        }

        public string retornarAAA()
        {
            return "AAA";
        }
    }
}
