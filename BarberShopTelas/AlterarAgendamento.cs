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
    public partial class AlterarAgendamento : Form
    {
        public AlterarAgendamento()
        {
            InitializeComponent();
        }
        private void limpaTxt()
        {
            maskedTextBoxCPF.Clear();
            textBoxData.Clear();
            textBoxHora.Clear();
            textBoxServico.Clear();
        }
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = maskedTextBoxCPF.Text;
                string data;
                string hora;
                string cod_serv;

                Service1 s = new Service1();
                Agendamento a = new Agendamento();
                a.Servico = new Servico();
                a = s.buscarAgendamento(cpf);
                data = a.Data.ToString();
                hora = a.Hora;
                cod_serv = a.Servico.Cod_serv.ToString();
                textBoxData.Text = data;
                textBoxHora.Text = a.Hora;
                textBoxServico.Text = cod_serv; 
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento a = new Agendamento();
                a.Servico = new Servico();
                a.Cliente = new Cliente();
                a.Cliente.Cpf = maskedTextBoxCPF.Text;
                a.Data = textBoxData.Text;
                a.Hora = textBoxHora.Text;
                a.Servico.Cod_serv = Convert.ToInt32(textBoxServico.Text);
                Service1 s = new Service1();
                s.atualizarAgendamento(a);

                MessageBox.Show("Sucesso !");
                limpaTxt();
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
