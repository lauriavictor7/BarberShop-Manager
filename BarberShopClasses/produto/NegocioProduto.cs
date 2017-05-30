using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.produto
{
    public class NegocioProduto : InterfaceProduto
    {
        public void AtualizarProduto(Produto p)
        {
            DadosProduto dp = new DadosProduto();
            dp.AtualizarProduto(p);
        }

        public void CadastrarProduto(Produto p)
        {
            DadosProduto dp = new DadosProduto();
            dp.CadastrarProduto(p);
        }

        public List<Produto> ListarProduto()
        {
            DadosProduto dp = new DadosProduto();
            return dp.ListarProduto();
        }

        public void RemoverProduto(Produto p)
        {
            DadosProduto dp = new DadosProduto();
            dp.RemoverProduto(p);
        }
    }
}
