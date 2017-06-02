using BarberShopClasses.localhost;
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
    public partial class InserirPagamento : Form
    {
        public InserirPagamento()
        {
            InitializeComponent();
        }

        private void InserirPagamento_Load(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date;
            string hora;
            date = DateTime.Now.ToShortDateString();
            hora = DateTime.Now.ToLongTimeString();
            textBoxDataPg.Text = date;
            textBoxHoraPg.Text = hora;
            textBoxDataPg.Enabled = false;
            textBoxHoraPg.Enabled = false;
        }

        private void buttonCheckPg_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = maskedTextBox1.Text;
                string valor;
                Service1 sv = new Service1();
                Servico s = new Servico();
                s = sv.buscarValor(cpf);
                valor = Convert.ToString(s.Preco);
                textBoxValorPg.Text = valor;
                textBoxValorPg.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
