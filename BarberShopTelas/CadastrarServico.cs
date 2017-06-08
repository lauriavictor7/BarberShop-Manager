using BarberShopTelas.localhost;
using BarberShopClasses.servico;
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
    public partial class CadastrarServico : Form
    {
        public CadastrarServico()
        {
            InitializeComponent();
        }

        private void limpaTxt()
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();
                s.Preco = Convert.ToInt32(textBox2.Text);
                s.Descricao = textBox3.Text;

                Service1 sv = new Service1();
                sv.inserirServico(s);

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

