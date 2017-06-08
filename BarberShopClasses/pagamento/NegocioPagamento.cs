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
            if (cpf == " ")
            {
                throw new Exception("Por favor preencha o CPF. ");
            }

            DadosPagamento dp = new DadosPagamento();
            return dp.buscarValor(cpf);

        }

        public void CadastrarPagamento(Pagamento p)
        {
            if (p.Metodo == " ")
            {
                throw new Exception("Por favor escolha um MÉTODO DE PAGAMENTO. ");
            }

            DadosPagamento dP = new DadosPagamento();
            dP.CadastrarPagamento(p);
        }
        public List<Pagamento> ListarPagamento()
        {
            DadosPagamento dP = new DadosPagamento();
            return dP.ListarPagamento();
        }
    }

}
