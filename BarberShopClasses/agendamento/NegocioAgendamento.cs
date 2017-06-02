using BarberShopClasses.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.agendamento
{
    public class NegocioAgendamento : InterfaceAgendamento
    {

        public void CadastrarAgendamento(Agendamento a)
        {
            string datastr = DateTime.Now.ToShortDateString();
            DateTime data = Convert.ToDateTime(datastr);
            if (a.Data.CompareTo(data) < 0)
            {
                throw new Exception("Data Atrasada ");
            }
            if (a.Hora.ToString().Equals("  :  :  ") == true)
            {
                throw new Exception("Por favor preencha o campo de Hora");
            }
            if (a.Data.ToString().Equals("  /  /  ") == true)
            {
                throw new Exception("Por favor preencha o campo de hora");
            }
            if (a.Servico == null)
            {
                throw new Exception("Informe um codigo de serviço valido");
            }
            if (a.Servico.Cod_serv < 0)
            {
                throw new Exception("Informe um codigo de serviço valido");
            }
            if (a.Cliente == null)
            {
                throw new Exception("Por favor preencha o cpf");
            }
            
            DadosAgendamento dA = new DadosAgendamento();
            dA.CadastrarAgendamento(a);

        }

        public List<Agendamento> ListarAgendamento()
        {
            DadosAgendamento dA = new DadosAgendamento();
            return dA.ListarAgendamento();
        }

        public void RemoverAgendamento(Agendamento a)
        {
            if (a.Cliente.Cpf == "   .   .   -  ")
            {
                throw new Exception("Por favor preencha o cpf");
            }
            DadosAgendamento dA = new DadosAgendamento();
            dA.RemoverAgendamento(a);
        }
    }
}
