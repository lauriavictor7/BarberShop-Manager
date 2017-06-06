
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberShopClasses.agendamento;
using BarberShopTelas.localhost;


namespace BarberShopTelas
{
    public partial class CadastrarAgendamento : Form
    {
        public CadastrarAgendamento()
        {
            InitializeComponent();
        }

        private void CadastrarAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarAg_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Agendamento a = new localhost.Agendamento();
                a.Cliente = new Cliente();
                a.Servico = new Servico();
                
                a.Cliente.Cpf = maskedTextBox1.Text;
                a.Servico.Cod_serv = Convert.ToInt16(textBoxServiAg.Text);
                a.Data = maskedTextBoxDataAg.Text;
                a.Hora = maskedTextBoxHoraAg.Text;
   
                Service1 sv = new Service1();
                sv.CadastrarAgendamento(a);

                MessageBox.Show("Sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            
            

        }
    }
}
