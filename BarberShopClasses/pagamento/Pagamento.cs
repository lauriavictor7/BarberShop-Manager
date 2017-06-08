using BarberShopClasses.cliente;
using BarberShopClasses.notaFiscal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BarberShopClasses.pagamento
{
    public class Pagamento : Cliente
    {
        
        private int cod_caixa;
        private decimal valor;
        private string metodo;
        private string data;
        private string hora;
        private int cod_pag;

        public new string ToXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(GetType());
            StringWriter stringWriter = new StringWriter();

            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
            {
                xmlSerializer.Serialize(xmlWriter, this);
            }

            return stringWriter.ToString();
        }



        public string Data
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

        public string Hora
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
        [XmlIgnore]
        public int Cod_pag
        {
            get
            {
                return cod_pag;
            }

            set
            {
                cod_pag = value;
            }
        }

        public string Metodo
        {
            get
            {
                return metodo;
            }

            set
            {
                metodo = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        
        public int Cod_caixa
        {
            get
            {
                return cod_caixa;
            }

            set
            {
                cod_caixa = value;
            }
        }
    }
}
