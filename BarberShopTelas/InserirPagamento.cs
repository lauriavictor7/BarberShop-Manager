using BarberShopTelas.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BarberShopTelas
{
    public partial class InserirPagamento : Form
    {

        Random randNum = new Random();
        private new string Location;
        private BarberShopClasses.pagamento.Pagamento pagamento;
        private static XmlDocument documento;

        public InserirPagamento()
        {
            InitializeComponent();
        }
       
        private void InserirPagamento_Load(object sender, EventArgs e)
        {

            //Ao carregar o Form, criar um cliente, documento XML, thread para salvar dados
            pagamento = new BarberShopClasses.pagamento.Pagamento();
            documento = new XmlDocument();
            
        }


        private void SaveXML()
        {
            BarberShopClasses.pagamento.Pagamento newPagamento = new BarberShopClasses.pagamento.Pagamento()
            {
               
               Cod_caixa = Convert.ToInt32(textBoxCodCaixa.Text),
               Cpf = maskedTextBox1.Text,
               Data = textBoxDataPg.Text,
               Hora = textBoxHoraPg.Text,
               Valor = Convert.ToDecimal(textBoxValorPg.Text),
              
            };

            #region Colocando numero randomico na Notafiscal
            int rand = randNum.Next(50);
            Location = @"C:\Users\luizd\Desktop\Estudos\Persistindo os dados no XML\SalvandoDadosEmXML\NF" + rand + ".xml";
            #endregion
            documento.LoadXml(pagamento.ToXML());
            documento.Save(Location);
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
            

            localhost.Caixa cx = new localhost.Caixa();
            int cod = Convert.ToInt16(textBoxCodCaixa.Text);
         
            Service1 s = new Service1();
            cx = s.pesquisarCaixa(cod);

            cx.Valor_atual += p.Valor;
            cx.Valor_final += p.Valor + cx.Valor_inicial;

            s.atualizarValorAtual(cx);

            MessageBox.Show("Sucesso !");
            SaveXML();

        }
    }
}
