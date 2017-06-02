using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.pagamento
{
    public interface InterfacePagamento
    {
        void CadastrarPagamento(Pagamento p);
        Servico buscarValor(string cpf);

    }
}
