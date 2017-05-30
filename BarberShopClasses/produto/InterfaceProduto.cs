using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.produto
{
    public interface InterfaceProduto
    {
        void CadastrarProduto(Produto p);
        void AtualizarProduto(Produto p);
        void RemoverProduto(Produto p);
        List<Produto> ListarProduto();
    }
}
