using BarberShopClasses.genericas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BarberShopClasses.cliente
{
    public class Cliente : Endereco
    {
        private string cpf;
        private string nome;
        private string telefone;
        private string sexo;
        private Endereco endereco;

        public string ToXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(GetType());
            StringWriter stringWriter = new StringWriter();

            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
            {
                xmlSerializer.Serialize(xmlWriter, this);
            }

            return stringWriter.ToString();
        }

        public Cliente ()
        {
            this.endereco = new Endereco();
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }
    }
}

