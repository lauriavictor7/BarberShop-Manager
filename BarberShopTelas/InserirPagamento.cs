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
            textBoxValorPg.Enabled = false;
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

        private void buttonPagamento_Click(object sender, EventArgs e)
        {
            Pagamento p = new Pagamento();
            
            
            if(maskedTextBox1.Equals(" "))
            {
                MessageBox.Show("Informe o CPF, e click no Check !");
            }
            if(textBoxValorPg.Enabled == true)
            {
                MessageBox.Show("Por favor de um check no cpf, os campos preencheram automaticamente !");
            }
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha o tipo de pagamento!");
            }
            if(comboBox1.SelectedIndex == 0)
            {
                p.Cliente = new Cliente();
                p.Metodo = "Db";
                p.Valor = Convert.ToDecimal(textBoxValorPg.Text);
                string horastr = textBoxHoraPg.Text.ToString();
                p.Hora = horastr;
                p.Data = textBoxDataPg.Text;
                p.Cliente.Cpf = maskedTextBox1.Text;
                Service1 sv = new Service1();
                sv.CadastrarPagamento(p);
            }
            if(comboBox1.SelectedIndex == 1)
            {
                p.Cliente = new Cliente();
                p.Metodo = "Cd";
                p.Valor = Convert.ToDecimal(textBoxValorPg.Text);
                string horastr = textBoxHoraPg.Text.ToString();
                p.Hora = horastr;
                p.Data = textBoxDataPg.Text;
                p.Cliente.Cpf = maskedTextBox1.Text;
                Service1 sv = new Service1();
                sv.CadastrarPagamento(p);
            }
            if(comboBox1.SelectedIndex == 2)
            {
                p.Cliente = new Cliente();
                p.Metodo = "Av";
                p.Valor = Convert.ToDecimal(textBoxValorPg.Text);
                string horastr = textBoxHoraPg.Text.ToString();
                p.Hora = horastr;
                p.Data = textBoxDataPg.Text;
                p.Cliente.Cpf = maskedTextBox1.Text;
                Service1 sv = new Service1();
                sv.CadastrarPagamento(p);
            }
            MessageBox.Show("Sucesso !");

        }
    }
}
