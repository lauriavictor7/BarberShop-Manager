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
    public partial class Balanco : Form
    {
        public Balanco()
        {
            InitializeComponent();
        }

        private void Balanco_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1 sv = new Service1();
            Caixa cx = new Caixa();
            int cod = Convert.ToInt32(textBoxCod.Text);
            cx = sv.pesquisarCaixa(cod);

            label4.Text = "R$" + cx.Valor_inicial.ToString();
            label5.Text = "R$" + cx.Valor_atual.ToString();
            label6.Text = "R$" + cx.Valor_final.ToString();
        }
    }
}
