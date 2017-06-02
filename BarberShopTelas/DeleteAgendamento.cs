
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberShopClasses.cliente;
using BarberShopTelas.localhost;

namespace BarberShopTelas
{
    public partial class DeleteAgendamento : Form
    {
        public DeleteAgendamento()
        {
            InitializeComponent();
        }

        private void buttonDeleteAg_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento a = new Agendamento();
                a.Cliente = new localhost.Cliente();
                a.Servico = new localhost.Servico();
                a.Cliente.Cpf = maskedTextBox1.Text;
                Service1 sv = new Service1();
                sv.RemoverAgendamento(a);
                MessageBox.Show("Agendamento Apagado com Sucesso !");
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
