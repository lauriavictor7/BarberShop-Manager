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

                string sql = "INSERT INTO Caixa (Valor_Inic, data, hora) VALUES(@Valor_Inic, @data, @hora)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Valor_Inic", SqlDbType.Decimal);
                cmd.Parameters.Add("@data", SqlDbType.VarChar);
                cmd.Parameters.Add("@hora", SqlDbType.VarChar);

                cmd.Parameters["@Valor_Inic"].Value = cx.Valor_inicial;
                cmd.Parameters["@data"].Value = cx.Data;
                cmd.Parameters["@hora"].Value = cx.Hora;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir ou conectar! " + ex.Message);
            }
        }
        public Caixa pesquisarCaixa(int cod)
        {
            Caixa cx = new Caixa();
            try
            {
                this.abrirConexao();

                string sql = "select cod_caixa, valor_inic, valor_atu, valor_fin, hora, data from caixa where cod_caixa = @cod_caixa";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cod_caixa", SqlDbType.Int);
                cmd.Parameters["@cod_caixa"].Value = cod;

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    cx.Cod_caixa = DbReader.GetInt32(DbReader.GetOrdinal("cod_caixa"));
                    cx.Valor_inicial = DbReader.GetDecimal(DbReader.GetOrdinal("valor_inic"));
                    cx.Valor_atual = DbReader.GetDecimal(DbReader.GetOrdinal("valor_atu"));
                    cx.Valor_final = DbReader.GetDecimal(DbReader.GetOrdinal("valor_fin"));
                    cx.Hora = DbReader.GetString(DbReader.GetOrdinal("hora"));
                    cx.Data = DbReader.GetString(DbReader.GetOrdinal("data"));
                }
                this.fecharConexao();
            }catch(Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            return cx;

        }
        public void atualizarValorAtual(Caixa cx)
        {
            try
            {
                decimal valoratu = cx.Valor_atual;
                decimal valorfin = cx.Valor_final;
                this.abrirConexao();

                string sql = "UPDATE caixa SET valor_atu = @valor_atu, valor_fin = @valor_fin WHERE cod_caixa = @cod_caixa";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.Add("@valor_atu", SqlDbType.Decimal);
                cmd.Parameters.Add("@valor_fin", SqlDbType.Decimal);
                cmd.Parameters.Add("@cod_caixa", SqlDbType.Int);

                cmd.Parameters["@valor_atu"].Value = valoratu;
                cmd.Parameters["@valor_fin"].Value = valorfin;
                cmd.Parameters["@cod_caixa"].Value = cx.Cod_caixa;

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
