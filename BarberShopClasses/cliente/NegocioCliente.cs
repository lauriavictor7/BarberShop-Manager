using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.cliente
{
    public class NegocioCliente : InterfaceCliente
    {
        public void AtualizarCliente(Cliente c)
        {
            DadosCliente dc = new DadosCliente();
            dc.AtualizarCliente(c);
        }

        public void CadastrarCliente(Cliente c)
        {
            if (c.Cpf == "")
            {
                throw new Exception ("Informe o CPF");
            }

            if (c.Nome == "")
            {
                throw new Exception("Informe o NOME");
            }

            if (c.Telefone == "")
            {
                throw new Exception("Informe o TELEFONE");
            }

            DadosCliente dC = new DadosCliente();
            dC.CadastrarCliente(c);
        }

        public List<Cliente> ListarCliente()
        {
            DadosCliente dc = new DadosCliente();
            return dc.ListarCliente();
        }

        public void RemoverCLiente(Cliente c)
        {
            DadosCliente dC = new DadosCliente();
            dC.RemoverCLiente(c);
        }
    }
}
