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

        private void buttonAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                
                Service1 sv = new Service1();
                dataGridViewAgendamento.DataSource = sv.ListarAgendamento();
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }
    }
}
