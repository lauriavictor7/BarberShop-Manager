
using BarberShopClasses.cliente;
using BarberShopClasses.genericas;
using BarberShopTelas.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarberShopTelas
{
    using System.IO;
    using System.Threading;
    using System.Xml;
    using WSCorreios;

    public partial class CadastrarCliente : Form
    {

        private new string Location = @"Cliente1.xml";
        private BarberShopClasses.cliente.Cliente cliente;
        private Thread TSalvarDados;
        private static XmlDocument documento;

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            localhost.Cliente c = new localhost.Cliente();
            c.Endereco1 = new localhost.Endereco();
            c.Cpf = maskedTextBoxCPF.Text;
            c.Nome = textBoxNome.Text;
            c.Telefone = textBoxTelefone.Text;
            c.Cep = maskedTextBoxCEP.Text;
            c.Rua = textBoxRua.Text;
            c.Bairro = textBoxBairro.Text;
            c.Numero = textBoxNumero.Text;
            c.Uf = textBoxUF.Text;
            c.Cidade = textBoxCidade.Text;
            c.Sexo = textBox1.Text;

            Service1 sv = new Service1();
            sv.inserirCliente(c);

            MessageBox.Show("Sucesso!");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Service Correios
            string cep = maskedTextBoxCEP.Text;
            var ws = new AtendeClienteClient();
            var resposta = ws.consultaCEP(cep);
            textBoxBairro.Text = resposta.bairro;
            textBoxBairro.Enabled = false;
            textBoxCidade.Text = resposta.cidade;
            textBoxCidade.Enabled = false;
            textBoxRua.Text = resposta.end;
            textBoxRua.Enabled = false;
            textBoxUF.Text = resposta.uf;
            textBoxUF.Enabled = false;
            #endregion
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            cliente = new BarberShopClasses.cliente.Cliente();
            documento = new XmlDocument();
            TSalvarDados = new Thread(SalvarDados);

            if (File.Exists(Location))
            {
                documento.Load(Location);

                textBoxNome.Text = documento.SelectSingleNode("/Cliente/Nome").InnerText;
                maskedTextBoxCPF.Text = documento.SelectSingleNode("/Cliente/Cpf").InnerText;
                textBoxTelefone.Text = documento.SelectSingleNode("/Cliente/Telefone").InnerText;
                maskedTextBoxCEP.Text = documento.SelectSingleNode("/Cliente/Cep").InnerText;
                textBoxRua.Text = documento.SelectSingleNode("/Cliente/Rua").InnerText;
                textBoxBairro.Text = documento.SelectSingleNode("/Cliente/Bairro").InnerText;
                textBoxCidade.Text = documento.SelectSingleNode("/Cliente/Cidade").InnerText;
                textBoxNumero.Text = documento.SelectSingleNode("/Cliente/Numero").InnerText;
                textBoxUF.Text = documento.SelectSingleNode("/Cliente/Uf").InnerText;
                textBox1.Text = documento.SelectSingleNode("/Cliente/Sexo").InnerText;
              

                Console.WriteLine();
            }

            
            TSalvarDados.Start();
            Console.WriteLine(maskedTextBoxCPF.Text);

        }

        private void SalvarDados()
        {
            while (Visible)
            {
                SaveXML();
                Thread.Sleep(1500);
            }
        }

       private void SaveXML()
        {

            BarberShopClasses.cliente.Cliente newCliente = new BarberShopClasses.cliente.Cliente()
            {


               Nome = textBoxNome.Text,
               Cpf = maskedTextBoxCPF.Text,
               Telefone = textBoxTelefone.Text,
               Cep = maskedTextBoxCEP.Text,
               Rua = textBoxRua.Text,
               Bairro = textBoxBairro.Text,
               Cidade = textBoxCidade.Text,
               Numero = textBoxNumero.Text,
               Uf = textBoxUF.Text,
               Sexo = textBox1.Text

            };


            if (!cliente.Equals(newCliente))
            {
                
                cliente = newCliente;

                documento.LoadXml(cliente.ToXML());
                documento.Save(Location);
            }
        }

        private void CadastrarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveXML();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = " ";
            maskedTextBoxCPF.Text = " ";
            textBoxTelefone.Text = " ";
            maskedTextBoxCEP.Text = " ";
            textBoxRua.Text = " ";
            textBoxBairro.Text = " ";
            textBoxCidade.Text = " ";
            textBoxNumero.Text = " ";
            textBoxUF.Text = " ";
            textBox1.Text = " ";
        }
    }
}
