using BarberShopClasses.agendamento;
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
    public partial class ListaAgendamento : Form
    {
        public ListaAgendamento()
        {
            InitializeComponent();
        }

        private void ListaAgendamento_Load(object sender, EventArgs e)
        {
            try
            {
                Service1 sv = new Service1();
                foreach (localhost.Agendamento agendamento in sv.ListarAgendamento())
                {
                    ListViewItem linha = listViewAg.Items.Add(agendamento.Cod_ag.ToString());
                    linha.SubItems.Add(agendamento.Cliente.Cpf);
                    linha.SubItems.Add(agendamento.Cliente.Nome);
                    linha.SubItems.Add(agendamento.Servico.Descricao);
                    linha.SubItems.Add(agendamento.Data);
                    linha.SubItems.Add(agendamento.Hora.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
