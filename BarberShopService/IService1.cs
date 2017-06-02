using BarberShopClasses.agendamento;
using BarberShopClasses.cliente;
using BarberShopClasses.produto;
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
        #endregion

        #region Métodos referentes a Produto.
        [OperationContract]
        void inserirProduto(Produto p);

        [OperationContract]
        void removerProduto(Produto p);

        [OperationContract]
        void atualizarProduto(Produto p);

        [OperationContract]
        List<Produto> listarProduto();
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
        #endregion

        #region Métodos Referentes a Agendamento
        [OperationContract]
        void CadastrarAgendamento(Agendamento a);
        [OperationContract]
        void AtualizarAgendamento(Agendamento a);
        [OperationContract]
        void RemoverAgendamento(Agendamento a);
        [OperationContract]
        List<Agendamento> ListarAgendamento();
        #endregion

        #region Métodos Referentes a Pagamento
        [OperationContract]
        Servico buscarValor(string cpf);
        #endregion
    }

}
