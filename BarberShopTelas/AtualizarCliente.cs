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
    public partial class AtualizarCliente : Form
    {
        public AtualizarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.Cpf = maskedTextBox1.Text;
                c.Nome = textBoxNome.Text;
                c.Telefone = textBoxTelefone.Text;
                c.Bairro = textBoxBairro.Text;
                c.Rua = textBoxRua.Text;
                c.Cep = textBoxCEP.Text;
                c.Numero = textBoxNumero.Text;
                c.Cidade = textBoxCidade.Text;
                c.Uf = textBoxUF.Text;

                Service1 sv = new Service1();
                sv.atualizarCLiente(c);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf;
                Service1 s = new Service1();
                cpf = maskedTextBox1.Text;
                Cliente c = new Cliente();
                c = s.buscarCliente(cpf);
                textBoxNome.Text = c.Nome;
                textBoxTelefone.Text = c.Telefone;
                textBoxBairro.Text = c.Bairro;
                textBoxCidade.Text = c.Cidade;
                textBoxNumero.Text = c.Numero.ToString();
                textBoxCEP.Text = c.Cep;
                textBoxRua.Text = c.Rua;
                textBoxUF.Text = c.Uf;
                textBoxCidade.Text = c.Cidade;            
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void AtualizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
