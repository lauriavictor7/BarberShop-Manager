using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.cliente
{
    public class Cliente
    {
        private string cpf;
        private string nome;
        private string telefone;
        private string bairro;
        private string endereco;
        private string sexo;

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }
    }
}
