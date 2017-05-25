using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.cliente
{
    public interface InterfaceCliente
    {
        void CadastrarCliente(Cliente c);
        void AtualizarCliente(Cliente c);
        void RemoverCLiente(Cliente c);
        List<Cliente> ListarCliente();
    }
}
