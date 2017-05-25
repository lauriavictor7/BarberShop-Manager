using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopClasses.cliente;
using BarberShopClasses.caixa;
using BarberShopClasses.notaFiscal;
using BarberShopClasses.pagamento;
using BarberShopClasses.produto;
using BarberShopClasses.servico;
using BarberShopClasses.agendamento;

namespace BarberShopClasses.fachada
{
    public class Fachada : InterfaceCliente, InterfaceCaixa, InterfaceNotaFiscal, InterfacePagamento, InterfaceProduto, InterfaceServico, InterfaceAgendamento
    {
        public void AtualizarCliente(Cliente c)
        {
            NegocioCliente nC = new NegocioCliente();
            nC.AtualizarCliente(c);
        }

        public void CadastrarCliente(Cliente c)
        {
            NegocioCliente nC = new NegocioCliente();
            nC.CadastrarCliente(c);
        }

        public List<Cliente> ListarCliente()
        {
            NegocioCliente nC = new NegocioCliente();
            return nC.ListarCliente();
        }

        public void RemoverCLiente(Cliente c)
        {
            NegocioCliente nC = new NegocioCliente();
            nC.RemoverCLiente(c);
        }
    }
}
