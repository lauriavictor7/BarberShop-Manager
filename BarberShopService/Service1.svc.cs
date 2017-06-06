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
using BarberShopClasses.servico;
using BarberShopClasses.agendamento;
using BarberShopClasses.pagamento;
using BarberShopClasses.caixa;

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
        public Cliente buscarCliente(string cpf)
        {
            NegocioCliente nc = new NegocioCliente();
            return nc.buscarCliente(cpf);
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

        public Servico buscarServico(int cod)
        {
            NegocioServico ns = new NegocioServico();
            return ns.PesquisarServico(cod);
        }
        #endregion

        #region Métodos Referentes a Agendamento
        public void CadastrarAgendamento(Agendamento a)
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            nA.CadastrarAgendamento(a);

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
        public Agendamento buscarAgendamento(string cpf)
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            return nA.buscarAgendamento(cpf);
            
        }
        public void atualizarAgendamento(Agendamento a)
        {
            NegocioAgendamento nA = new NegocioAgendamento();
            nA.atualizarAgendamento(a);
        }

        #endregion

        #region Métodos Referentes a Pagamentos
        public Servico buscarValor(string cpf)
        {
            NegocioPagamento nP = new NegocioPagamento();
            return nP.buscarValor(cpf);
        }

        public void CadastrarPagamento(Pagamento p)
        {
            NegocioPagamento nP = new NegocioPagamento();
            nP.CadastrarPagamento(p);
        }
        
        public List<Pagamento> ListarPagamento()
        {
            NegocioPagamento nP = new NegocioPagamento();
            return nP.ListarPagamento();
        }
        #endregion

        #region Métodos referentes a Caixa
        public void iniciarCaixa(Caixa cx)
        {
            NegocioCaixa nc = new NegocioCaixa();
            nc.CadastrarValor(cx);
        }
        #endregion
    }
}