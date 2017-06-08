using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.caixa
{
    public class NegocioCaixa : InterfaceCaixa
    {
        public void CadastrarValor(Caixa cx)
        {
            DadosCaixa dc = new DadosCaixa();
            dc.CadastrarValor(cx);
        }

        public Caixa pesquisarCaixa(int cod)
        {
            DadosCaixa dc = new DadosCaixa();
            return dc.pesquisarCaixa(cod);
        }

        public void atualizarValorAtual(Caixa cx)
        {
            DadosCaixa dc = new DadosCaixa();
            dc.atualizarValorAtual(cx);
        }

        public List<Caixa> listarCaixa()
        {
            DadosCaixa dc = new DadosCaixa();
            return dc.listarCaixa();
        }
    }
}
