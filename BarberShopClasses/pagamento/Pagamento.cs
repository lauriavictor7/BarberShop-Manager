using BarberShopClasses.cliente;
using BarberShopClasses.notaFiscal;
using BarberShopClasses.produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.pagamento
{
    public class Pagamento
    {
        private int cod_pag;
        private decimal valor;
        private string metodo;
        private string data;
        private string hora;
        private Cliente cliente;


        public string Data
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

        public string Hora
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

        public int Cod_pag
        {
            get
            {
                return cod_pag;
            }

            set
            {
                cod_pag = value;
            }
        }

        public string Metodo
        {
            get
            {
                return metodo;
            }

            set
            {
                metodo = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
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
    }
}
