using BarberShopClasses.cliente;
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

        [OperationContract]
        string pegarTexto();

        [OperationContract]
        string retornarAAA();

        [OperationContract]
        void inserirCliente(Cliente c);

        [OperationContract]
        void removerCliente(Cliente c);

        [OperationContract]
        void atualizarCLiente(Cliente c);
        
    }

}
