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
using BarberShopClasses.produto;
using BarberShopClasses.servico;
using BarberShopClasses.agendamento;
using BarberShopClasses.pagamento;

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

        #region Métodos referentes a Produto.
        public void inserirProduto(Produto p)
        {
            NegocioProduto np = new NegocioProduto();
            np.CadastrarProduto(p);
        }

        public void removerProduto(Produto p)
        {
            NegocioProduto np = new NegocioProduto();
            np.RemoverProduto(p);
        }

        public void atualizarProduto(Produto p)
        {
            NegocioProduto np = new NegocioProduto();
            np.AtualizarProduto(p);
        }

        public List<Produto> listarProduto()
        {
            NegocioProduto np = new NegocioProduto();
            return np.ListarProduto();
        }
        #endregion

        #region Métodos referentes a Serviço.
        public void inserirServico(Servico s)
        {
            NegocioServico ns = new NegocioServico();
            ns.CadastrarServico(s);
        }

        public void removerServico(Servico s)
        {
            NegocioServico ns = new NegocioServico();
            ns.RemoverServico(s);
        }

        public void atualizarServico(Servico s)
        {
            NegocioServico ns = new NegocioServico();
            ns.AtualizarServico(s);
        }

        public List<Servico> listarServico()
        {
            NegocioServico ns = new NegocioServico();
            return ns.ListarServico();
        }
        #endregion

        #region Métodos Referentes a Agendamento
        public void CadastrarAgendamento(Agendamento a)
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            nA.CadastrarAgendamento(a);

        }

        public void AtualizarAgendamento(Agendamento a)
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            nA.AtualizarAgendamento(a);
        }

        public void RemoverAgendamento(Agendamento a)
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            nA.RemoverAgendamento(a);
        }

        public List<Agendamento> ListarAgendamento()
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            return nA.ListarAgendamento();
        }


        #endregion

        #region Métodos Referentes a Pagamentos
        public Servico buscarValor(string cpf)
        {
            DadosPagamento dP = new DadosPagamento();
            return dP.buscarValor(cpf);
        }
        #endregion

    }
}