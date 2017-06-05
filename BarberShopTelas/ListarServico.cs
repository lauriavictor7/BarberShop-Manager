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
    public partial class ListarServico : Form
    {
        public ListarServico()
        {
            InitializeComponent();
        }

        private void ListarServico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Service1 sv = new Service1();
                foreach (localhost.Servico servico in sv.listarServico())
                {
                    ListViewItem item = listView1.Items.Add(servico.Cod_serv.ToString());
                    item.SubItems.Add(servico.Preco.ToString());
                    item.SubItems.Add(servico.Descricao);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar! " + ex.Message);
            }
        }
    }
}
