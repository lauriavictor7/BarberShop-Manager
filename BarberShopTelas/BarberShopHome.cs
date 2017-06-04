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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cc = new CadastrarCliente();
            cc.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarServico cs = new CadastrarServico();
            cs.Show();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAgendamento ca = new CadastrarAgendamento();
            ca.Show();
        }

        private void listaDeAgendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAgendamento la = new ListaAgendamento();
            la.Show();
        }

        private void removerAgendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAgendamento da = new DeleteAgendamento();
            da.Show();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirPagamento iP = new InserirPagamento();
            iP.Show();
        }

        private void listaDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPagamento lP = new ListarPagamento();
            lP.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarAgendamento aA = new AlterarAgendamento();
            aA.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverCliente rc = new RemoverCliente();
            rc.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCliente lc = new ListarCliente();
            lc.Show();
        }

        private void alterarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarCliente ac = new AtualizarCliente();
            ac.Show();
        }

        private void removerServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverServico rs = new RemoverServico();
            rs.Show();
        }

        private void listaDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarServico ls = new ListarServico();
            ls.Show();
        }

        private void alterarServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarServico aS = new AtualizarServico();
            aS.Show();
        }
    }
}
