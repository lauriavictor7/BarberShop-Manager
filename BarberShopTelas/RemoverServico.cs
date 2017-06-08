using BarberShopTelas.localhost;
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
    public partial class RemoverServico : Form
    {
        public RemoverServico()
        {
            InitializeComponent();
        }

        private void limpaTxt()
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();
                s.Cod_serv = Convert.ToInt32(textBox1.Text);

                Service1 sv = new Service1();
                sv.removerServico(s);

                MessageBox.Show("Sucesso!");
                limpaTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }
    }
}
