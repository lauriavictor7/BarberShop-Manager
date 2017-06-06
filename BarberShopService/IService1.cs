using BarberShopClasses.agendamento;
using BarberShopClasses.caixa;
using BarberShopClasses.cliente;
using BarberShopClasses.pagamento;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BarberShopService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IService1
    {

        #region Métodos referentes a Cliente.
        [OperationContract]
        void inserirCliente(Cliente c);

        [OperationContract]
        void removerCliente(Cliente c);

        [OperationContract]
        void atualizarCLiente(Cliente c);

        [OperationContract]
        List<Cliente> listarCliente();

        [OperationContract]
        Cliente buscarCliente(string cpf);
        #endregion

        #region Métodos referentes a Serviço.
        [OperationContract]
        void inserirServico(Servico s);

        [OperationContract]
        void removerServico(Servico s);

        [OperationContract]
        void atualizarServico(Servico s);

        [OperationContract]
        List<Servico> listarServico();

        [OperationContract]
        Servico buscarServico(int cod);
        #endregion

        #region Métodos Referentes a Agendamento
        [OperationContract]
        void CadastrarAgendamento(Agendamento a);
        [OperationContract]
        void RemoverAgendamento(Agendamento a);
        [OperationContract]
        List<Agendamento> ListarAgendamento();
        [OperationContract]
        void atualizarAgendamento(Agendamento a);
        [OperationContract]
        Agendamento buscarAgendamento(string cpf);
        #endregion

        #region Métodos Referentes a Pagamento
        [OperationContract]
        Servico buscarValor(string cpf);
        [OperationContract]
        void CadastrarPagamento(Pagamento p);
        [OperationContract]
        List<Pagamento> ListarPagamento();
        #endregion

        #region Métodos Referentes a Caixa
        [OperationContract]
        void iniciarCaixa(Caixa cx);
        #endregion
    }

}
