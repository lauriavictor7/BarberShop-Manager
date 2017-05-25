using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.conexao
{
    public class Dados
    {
        public SqlConnection sqlConn;
        private const string local = @"DESKTOP-7LOF012\SQLEXPRESS";
        private const string banco = "Teste2";
        private const string user = "lauriavictor";
        private const string pw = "senhavl2";

        string connectionSqlServer = @"Data Source =" + local + ";Initial Catalog =" + banco + ";UId=" + user + ";Password=" + pw + ";";

        public void abrirConexao()
        {
            this.sqlConn = new SqlConnection(connectionSqlServer);
            this.sqlConn.Open();
        }

        public void fecharConexao()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }
    }
}
