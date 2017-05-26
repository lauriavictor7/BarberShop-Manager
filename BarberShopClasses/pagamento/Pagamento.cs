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
        private NotaFiscal NotaF;
        private Produto produto;
        private Cliente cliente;
        private DateTime data;
        private DateTime hora;

        public NotaFiscal NotaF1
        {
            get
            {
                return NotaF;
            }

            set
            {
                NotaF = value;
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
    }
}
