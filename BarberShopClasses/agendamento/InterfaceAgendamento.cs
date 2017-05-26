using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.agendamento
{
    public interface InterfaceAgendamento
    {
        void CadastrarAgendamento(Agendamento a);
        void AtualizarAgendamento(Agendamento a);
        void RemoverAgendamento(Agendamento a);
        List<Agendamento> ListarAgendamento();
    }
}
