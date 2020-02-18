using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Temporizador
{
    class Evento
    {
        private readonly ResourceManager resource = new ResourceManager("Temporizador.Properties.Resources", typeof(Evento).Assembly);
        private string nome;
        private DateTime data;

        public Evento() { }

        public Evento(string nome, DateTime data)
        {
            if (String.IsNullOrWhiteSpace(nome)) {
                throw new ArgumentException(resource.GetString("evento_nome_exception", CultureInfo.CurrentCulture));
            }
            this.nome = nome;
            if (!IsDataValida(data))
            {
                throw new ArgumentException(resource.GetString("evento_data_exception", CultureInfo.CurrentCulture));
            }
            this.data = data;
        }

        public static Boolean IsDataValida(DateTime data)
        {
            if (data == null)
                return false;
            if (DateTime.Now.CompareTo(data) > 0)
            {
                return false;
            }
            return true;
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
            }
        }

        public DateTime Data
        {
            get => data;
            set
            {
                if (IsDataValida(value))
                {
                    data = value;
                }
            }
        }
    }
}
