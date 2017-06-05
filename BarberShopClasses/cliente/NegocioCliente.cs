﻿using System;
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
        public Cliente buscarCliente(string cpf)
        {
            if(cpf.Length < 11)
            {
                throw new Exception("Informe um cpf valido");   
            }
            DadosCliente dc = new DadosCliente();
            return dc.buscarCliente(cpf);
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

            if(c.Cep.Length < 9)
            {
                throw new Exception("Informe um CEP Valido");
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
