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
    public partial class RemoverCliente : Form
    {
        public RemoverCliente()
        {
            InitializeComponent();
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Cliente c = new localhost.Cliente();
                c.Cpf = maskedTextBox1.Text;

                Service1 sv = new Service1();
                sv.removerCliente(c);

                MessageBox.Show("Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
        }
    }
}
