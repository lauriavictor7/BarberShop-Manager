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
        private double valor;
        private string metodo;
        private DateTime data;
        private DateTime hora;

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

        public double Valor
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
    }
}
