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
            if (c.Cpf == "")
            {
                throw new Exception("Informe o CPF. ");
            }

            if (c.Nome == "")
            {
                throw new Exception("Informe o NOME. " );
            }

            if (c.Telefone == "")
            {
                throw new Exception("Informe o TELEFONE. ");
            }

            if (c.Cep.Length < 9)
            {
                throw new Exception("Informe um CEP válido. ");
            }
            if(c.Bairro.Length == 0)
            {
                throw new Exception("Preencha o campo BAIRRO. ");
            }
            if(c.Cidade.Length == 0)
            {
                throw new Exception("Preencha o campo CIDADE. ");
            }
            if (c.Rua.Length == 0)
            {
                throw new Exception("Preencha o campo RUA. ");
            }
            if (c.Numero.Length == 0)
            {
                throw new Exception("Preencha o campo NÚMERO. ");
            }
            if (c.Uf.Length == 0)
            {
                throw new Exception("Preencha o campo UF. ");
            }
            DadosCliente dc = new DadosCliente();
            dc.AtualizarCliente(c);
        }
        public Cliente buscarCliente(string cpf)
        {
            if(cpf.Length < 11)
            {
                throw new Exception("Informe um CPF válido. ");   
            }
            DadosCliente dc = new DadosCliente();
            return dc.buscarCliente(cpf);
        }

        public void CadastrarCliente(Cliente c)
        {
            if (c.Cpf == "")
            {
                throw new Exception ("Informe o CPF. ");
            }

            if (c.Nome == "")
            {
                throw new Exception("Informe o NOME. ");
            }

            if (c.Telefone == "")
            {
                throw new Exception("Informe o TELEFONE. ");
            }

            if (c.Telefone.Length < 8)
            {
                throw new Exception("Informe um TELEFONE válido. ");
            }

            if (c.Cep.Length < 9)
            {
                throw new Exception("Informe um CEP válido. ");
            }
            if (c.Bairro.Length == 0)
            {
                throw new Exception("Preencha o campo BAIRRO. ");
            }
            if (c.Cidade.Length == 0)
            {
                throw new Exception("Preencha o campo CIDADE. ");
            }
            if (c.Rua.Length == 0)
            {
                throw new Exception("Preencha o campo RUA.");
            }
            if (c.Numero.Length == 0)
            {
                throw new Exception("Preencha o campo NÚMERO. ");
            }
            if (c.Uf.Length == 0)
            {
                throw new Exception("Preencha o campo UF. ");
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
            if (c.Cpf == "")
            {
                throw new Exception("Informe o CPF. ");
            }

            if (c.Cpf.Length > 14)
            {
                throw new Exception("Informe um CPF válido. ");
            }

            DadosCliente dC = new DadosCliente();
            dC.RemoverCLiente(c);
        }
    }
}
