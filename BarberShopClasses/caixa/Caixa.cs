using BarberShopClasses.pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.caixa
{
    public class Caixa
    {
        private int cod_caixa;
        private decimal valor_inicial;
        private decimal valor_final;
        private decimal valor_atual;
        private string data;
        private string hora;


        public decimal Valor_inicial
        {
            get
            {
                return valor_inicial;
            }

            set
            {
                valor_inicial = value;
            }
        }

        public decimal Valor_final
        {
            get
            {
                return valor_final;
            }

            set
            {
                valor_final = value;
            }
        }

        public decimal Valor_atual
        {
            get
            {
                return valor_atual;
            }

            set
            {
                valor_atual = value;
            }
        }

        public int Cod_caixa
        {
            get
            {
                return cod_caixa;
            }

            set
            {
                cod_caixa = value;
            }
        }

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
    }
}
