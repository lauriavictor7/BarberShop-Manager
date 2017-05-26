using BarberShopClasses.cliente;
using BarberShopClasses.produto;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.notaFiscal
{
    public class NotaFiscal
    {
        private int cod_nf;
        private Servico servico;
        private Produto produto;
        private Cliente cliente;
        private DateTime data;
        private DateTime hora;
        private string Metodo;

        public Servico Servico
        {
            get
            {
                return servico;
            }

            set
            {
                servico = value;
            }
        }

        public Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public string Metodo1
        {
            get
            {
                return Metodo;
            }

            set
            {
                Metodo = value;
            }
        }

        public int Cod_nf
        {
            get
            {
                return cod_nf;
            }

            set
            {
                cod_nf = value;
            }
        }
    }
}
