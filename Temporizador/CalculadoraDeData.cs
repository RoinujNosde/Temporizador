using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temporizador
{
    public class CalculadoraDeData
    {
        private double diferencaTempo;

        public enum Conversao
        {
            AnoEmSegundos = 31536000, MesEmSegundos = 2628000,
            DiaEmSegundos = 86400, HoraEmSegundos = 3600, MinutoEmSegundos = 60
        }

        public CalculadoraDeData(DateTime data)
        {
            diferencaTempo = (data - DateTime.Now).TotalSeconds;
        }

        public int GetAnos()
        {
            var anos = (int)(diferencaTempo / (int)Conversao.AnoEmSegundos);
            diferencaTempo -= (anos * (int)Conversao.AnoEmSegundos);

            return anos;
        }

        public int GetMeses()
        {
            var meses = (int)(diferencaTempo / (int)Conversao.MesEmSegundos);
            diferencaTempo -= (meses * (int)Conversao.MesEmSegundos);

            return meses;
        }

        public int GetDias()
        {
            var dias = (int)(diferencaTempo / (int)Conversao.DiaEmSegundos);
            diferencaTempo -= (dias * (int)Conversao.DiaEmSegundos);

            return dias;
        }

        public int GetHoras()
        {
            var horas = (int)(diferencaTempo / (int)Conversao.HoraEmSegundos);
            diferencaTempo -= (horas * (int)Conversao.HoraEmSegundos);

            return horas;
        }

        public int GetMinutos()
        {
            var minutos = (int)(diferencaTempo / (int)Conversao.MinutoEmSegundos);
            diferencaTempo -= (minutos * (int)Conversao.MinutoEmSegundos);

            return minutos;
        }

        public int GetSegundos()
        {
            return (int)diferencaTempo;
        }
    }
}
