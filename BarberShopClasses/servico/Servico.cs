using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.servico
{
    public class Servico
    {
        private int cod_serv;
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

        public int Cod_serv
        {
            get
            {
                return cod_serv;
            }

            set
            {
                cod_serv = value;
            }
        }
    }
}
