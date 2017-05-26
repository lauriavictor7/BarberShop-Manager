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
        private Pagamento pagamento;
        private double valor_inicial;
        private double valor_final;
        private double valor_atual;

        public Pagamento Pagamento
        {
            get
            {
                return pagamento;
            }

            set
            {
                pagamento = value;
            }
        }

        public double Valor_inicial
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

        public double Valor_final
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

        public double Valor_atual
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
    }
}
