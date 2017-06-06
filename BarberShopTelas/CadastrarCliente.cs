
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
    using WSCorreios;

    public partial class CadastrarCliente : Form
    {
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

                if (comboBoxSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("Escolha uma opção por favor");
                }
                if(comboBoxSexo.SelectedIndex == 0)
                {
                    
                    c.Sexo = "M";
                    

                }if(comboBoxSexo.SelectedIndex == 1)
                {
                 
                    c.Sexo = "F";
                    
                }

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
    }
}
