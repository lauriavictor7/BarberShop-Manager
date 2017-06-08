using BarberShopClasses.pagamento;
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
    public partial class ListarPagamento : Form
    {
        public ListarPagamento()
        {
            InitializeComponent();
        }


        private void ListarPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                Service1 s = new Service1();
                foreach (localhost.Pagamento pagamento in s.ListarPagamento())
                {
                    
                    ListViewItem linh1 = listViewPG.Items.Add(pagamento.Cpf);
                    linh1.SubItems.Add(pagamento.Data);
                    linh1.SubItems.Add(pagamento.Hora);
                    linh1.SubItems.Add(pagamento.Valor.ToString());
                    linh1.SubItems.Add(pagamento.Metodo);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
