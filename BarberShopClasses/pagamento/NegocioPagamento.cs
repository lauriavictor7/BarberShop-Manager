using BarberShopClasses.pagamento;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.pagamento
{
    public class NegocioPagamento : InterfacePagamento
    {
        public Servico buscarValor(string cpf)
        {
            
            DadosPagamento dp = new DadosPagamento();
            if (cpf == " ")
            {
                throw new Exception("Por favor preencha o cpf");
            }
            return dp.buscarValor(cpf);

        }

        public void CadastrarPagamento(Pagamento p)
        {
            if (p.Metodo == " ")
            {
                throw new Exception("Por favor Escolha um metodo de pagamento");
            }
            DadosPagamento dP = new DadosPagamento();
            dP.CadastrarPagamento(p);
        }
    }

}
