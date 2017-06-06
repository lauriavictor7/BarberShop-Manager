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
    }
}
