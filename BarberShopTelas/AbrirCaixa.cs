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

        private void limpaTxt()
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Caixa cx = new localhost.Caixa();
                cx.Valor_inicial = Convert.ToDecimal(textBox2.Text);
                cx.Data = maskedTextBox1.Text;
                cx.Hora = maskedTextBox2.Text;
                              
                Service1 sv = new Service1();
                sv.iniciarCaixa(cx);

                MessageBox.Show("Sucesso!");
                limpaTxt();
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
            maskedTextBox1.Text = date;
            maskedTextBox2.Text = hora;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
          
        }
    }
}
