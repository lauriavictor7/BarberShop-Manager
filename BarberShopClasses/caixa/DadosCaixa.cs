using BarberShopClasses.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.caixa
{
    public class DadosCaixa : Dados, InterfaceCaixa
    {
        public void CadastrarValor(Caixa cx)
        {
            try
            {
                this.abrirConexao();

                string sql = "INSERT INTO Caixa (Valor_Inic) VALUES(@Valor_Inic)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Valor_Inic", SqlDbType.Decimal);

                cmd.Parameters["@Valor_Inic"].Value = cx.Valor_inicial;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir ou conectar! " + ex.Message);
            }
        }
    }
}
