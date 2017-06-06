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
    public partial class AtualizarServico : Form
    {
        public AtualizarServico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();
                s.Cod_serv = Convert.ToInt32(textBox1.Text);
                s.Preco = Convert.ToInt32(textBox2.Text);
                s.Descricao = textBox3.Text;

                Service1 sv = new Service1();
                sv.atualizarServico(s);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Servico s = new localhost.Servico();

                int cod = Convert.ToInt32(textBox1.Text);
                Service1 sv = new Service1();
                var servico = sv.buscarServico(cod);
                textBox2.Text = Convert.ToString(servico.Preco);
                textBox3.Text = servico.Descricao;

                 
            } catch (Exception ex)
            {
                MessageBox.Show("Serviço não encontrado! " + ex.Message);
            }
        }
    }
}
