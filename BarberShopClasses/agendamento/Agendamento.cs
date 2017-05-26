using BarberShopClasses.cliente;
using BarberShopClasses.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopClasses.agendamento
{
    public class Agendamento
    {
        private DateTime data;
        private DateTime hora;
        private Cliente cliente;
        private Servico servico;

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public Servico Servico
        {
            get
            {
                return servico;
            }

            set
            {
                servico = value;
            }
        }
    }
}
