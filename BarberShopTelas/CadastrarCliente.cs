
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
            try
            {
                localhost.Cliente c = new localhost.Cliente();
               // c.Endereco = new Endereco();

                c.Cpf = textBox1.Text;
                c.Nome = textBox2.Text;
                c.Telefone = textBox3.Text;
                
                

                
                Service1 sv = new Service1();
                sv.inserirCliente(c);

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
                localhost.Cliente c = new localhost.Cliente();
                c.Cpf = textBox1.Text;

                Service1 sv = new Service1();
                sv.removerCliente(c);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          try
            {
                localhost.Cliente c = new localhost.Cliente();
                c.Cpf = textBox1.Text;
                c.Nome = textBox2.Text;
                c.Telefone = textBox3.Text;

                Service1 sv = new Service1();
                sv.atualizarCLiente(c);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Instância não necessária. Clientes são listados mesmo sem ela.
                localhost.Cliente c = new localhost.Cliente();

                Service1 sv = new Service1();
                dataGridView1.DataSource = sv.listarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
