using BarberShopClasses.cliente;
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
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                Service1 s = new Service1();
                foreach (localhost.Cliente cliente in s.listarCliente())
                {

                    ListViewItem linha = listViewCliente.Items.Add(cliente.Cpf);
                    linha.SubItems.Add(cliente.Nome);
                    linha.SubItems.Add(cliente.Telefone);
                    linha.SubItems.Add(cliente.Sexo);
                    linha.SubItems.Add(cliente.Cep);
                    linha.SubItems.Add(cliente.Rua);
                    linha.SubItems.Add(cliente.Numero.ToString());
                    linha.SubItems.Add(cliente.Bairro);
                    linha.SubItems.Add(cliente.Cidade);
                    linha.SubItems.Add(cliente.Uf);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void listViewCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
