using BarberShopClasses.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShopTelas
{
    public partial class ListarCaixa : Form
    {
        public ListarCaixa()
        {
            InitializeComponent();
        }

        private void ListarCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                Service1 sv = new Service1();
                foreach (Caixa cx in sv.listarCaixa())
                {
                    ListViewItem linha = listViewCaixa.Items.Add(cx.Cod_caixa.ToString());
                    linha.SubItems.Add(cx.Valor_inicial.ToString());
                    linha.SubItems.Add(cx.Valor_atual.ToString());
                    linha.SubItems.Add(cx.Valor_final.ToString());
                    linha.SubItems.Add(cx.Data);
                    linha.SubItems.Add(cx.Hora);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
