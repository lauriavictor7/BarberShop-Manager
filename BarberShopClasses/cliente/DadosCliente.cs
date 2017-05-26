using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopClasses.conexao;
using System.Data.SqlClient;
using System.Data;


namespace BarberShopClasses.cliente
{
    public class DadosCliente : Dados, InterfaceCliente
    {
        public void AtualizarCliente(Cliente c)
        {
            this.abrirConexao();

            string sql = "UPDATE cliente SET nome = @nome, telefone = @telefone WHERE cpf = @cpf";

            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

            cmd.Parameters["@cpf"].Value = c.Cpf;
            cmd.Parameters["@nome"].Value = c.Nome;
            cmd.Parameters["@telefone"].Value = c.Telefone;

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            this.fecharConexao();
        }

        public void CadastrarCliente(Cliente c)
        {
            try
            {
                this.abrirConexao();

                string sql = "INSERT INTO cliente (cpf, nome, telefone) VALUES(@cpf, @nome, @telefone)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);

                cmd.Parameters["@cpf"].Value = c.Cpf;
                cmd.Parameters["@nome"].Value = c.Nome;
                cmd.Parameters["@telefone"].Value = c.Telefone;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ou inserir. " + ex.Message);
            }
        }

        public List<Cliente> ListarCliente()
        {
          List<Cliente> retorno = new List<Cliente>();
          
            this.abrirConexao();
            string sql = "select cpf, nome, telefone from cliente";

            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            SqlDataReader DbReader = cmd.ExecuteReader();
          
            while (DbReader.Read())
            {
                Cliente c = new Cliente();
                c.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                c.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                c.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                retorno.Add(c);
            }
           
             DbReader.Close();
             cmd.Dispose();
             this.fecharConexao();
             return retorno;
        }

        public void RemoverCLiente(Cliente c)
        {
            this.abrirConexao();

            string sql = "DELETE FROM cliente WHERE cpf = @cpf";

            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);

            cmd.Parameters["@cpf"].Value = c.Cpf;

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            this.fecharConexao();
        }


    }
}
