using BarberShopClasses.produto;
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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Produto p = new localhost.Produto();
                p.Cod_prod = Convert.ToInt32(textBox1.Text);
                p.Preco = Convert.ToInt32(textBox2.Text);
                p.Descricao = textBox3.Text;

                Service1 sv = new Service1();
                sv.inserirProduto(p);

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
                localhost.Produto p = new localhost.Produto();
                p.Cod_prod = Convert.ToInt32(textBox1.Text);

                Service1 sv = new Service1();
                sv.removerProduto(p);

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
                localhost.Produto p = new localhost.Produto();
                p.Cod_prod = Convert.ToInt32(textBox1.Text);
                p.Preco = Convert.ToInt32(textBox2.Text);
                p.Descricao = textBox3.Text;

                Service1 sv = new Service1();
                sv.atualizarProduto(p);

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
                //Instância não necessária. Produtos são listados mesmo sem ela.
                localhost.Produto p = new localhost.Produto();

                Service1 sv = new Service1();
                dataGridView1.DataSource = sv.listarProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }
    }
}
