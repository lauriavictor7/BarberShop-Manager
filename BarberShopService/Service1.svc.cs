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
        #region Métodos referentes a Cliente.
        public void atualizarCLiente(Cliente c)
        {
            NegocioCliente nc = new NegocioCliente();
            nc.AtualizarCliente(c);
        }

        public void inserirCliente(Cliente c)
        {
            NegocioCliente nc = new NegocioCliente();
            nc.CadastrarCliente(c);
        }

        public void removerCliente(Cliente c)
        {
            NegocioCliente nc = new NegocioCliente();
            nc.RemoverCLiente(c);
        }

        public List<Cliente> listarCliente()
        {
            NegocioCliente nc = new NegocioCliente();
            return nc.ListarCliente();
        }
        #endregion
    }
}