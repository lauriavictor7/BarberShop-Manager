using BarberShopClasses.agendamento;
using BarberShopClasses.conexao;
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
    public partial class BarberShopHome : Form
    {
        public BarberShopHome()
        {
            InitializeComponent();
        }

        private void testeWCF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localhost.Service1 sv = new localhost.Service1();
            string mensagem = sv.pegarTexto();
            MessageBox.Show(mensagem);

        }

        private void testeWCF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localhost.Service1 sv = new localhost.Service1();
            string mensagem = sv.retornarAAA();
            MessageBox.Show(mensagem);
        }

        private void testandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Dados conn = new Dados();
                conn.abrirConexao();
                MessageBox.Show("Funfou!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cc = new CadastrarCliente();
            cc.Show();
        }

        private void testeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
