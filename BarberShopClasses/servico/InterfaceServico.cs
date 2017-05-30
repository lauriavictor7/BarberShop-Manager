using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.servico
{
    public interface InterfaceServico
    {
        void CadastrarServico(Servico s);
        void AtualizarServico(Servico s);
        void RemoverServico(Servico s);
        List<Servico> ListarServico();
    }
}
