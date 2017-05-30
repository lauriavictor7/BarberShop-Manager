using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.servico
{
    public class NegocioServico : InterfaceServico
    {
        public void AtualizarServico(Servico s)
        {
            DadosServico ds = new DadosServico();
            ds.AtualizarServico(s);
        }

        public void CadastrarServico(Servico s)
        {
            DadosServico ds = new DadosServico();
            ds.CadastrarServico(s);
        }

        public List<Servico> ListarServico()
        {
            DadosServico ds = new DadosServico();
            return ds.ListarServico();
        }

        public void RemoverServico(Servico s)
        {
            DadosServico ds = new DadosServico();
            ds.RemoverServico(s);
        }
    }
}
