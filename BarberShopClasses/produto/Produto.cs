using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.produto
{
    public class Produto
    {
        private int cod_prod;
        private double preco;
        private string descricao;

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public int Cod_prod
        {
            get
            {
                return cod_prod;
            }

            set
            {
                cod_prod = value;
            }
        }
    }
}
