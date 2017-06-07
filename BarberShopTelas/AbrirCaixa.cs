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
    public partial class AbrirCaixa : Form
    {
        public AbrirCaixa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Caixa cx = new localhost.Caixa();
                cx.Valor_inicial = Convert.ToDecimal(textBox2.Text);
                cx.Data = textBoxData.Text;
                cx.Hora = textBoxHora.Text;
                
                Service1 sv = new Service1();
                sv.iniciarCaixa(cx);

                MessageBox.Show("Sucesso!");
            } catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date;
            string hora;
            date = DateTime.Now.ToShortDateString();
            hora = DateTime.Now.ToLongTimeString();
            textBoxData.Text = date;
            textBoxHora.Text = hora;
            textBoxData.Enabled = false;
            textBoxHora.Enabled = false;
          
        }
    }
}
