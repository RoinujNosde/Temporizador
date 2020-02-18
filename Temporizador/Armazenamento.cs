using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.ComponentModel;
using System;

namespace Temporizador
{
    class Armazenamento
    {
        private static BindingList<Evento> eventos;

        public Armazenamento()
        {
            if (eventos == null)
            {
                eventos = new BindingList<Evento>();
                CarregarEventos();
            }
        }

        public void CarregarEventos()
        {
            if (!File.Exists("eventos.json"))
            {
                using (File.Create("eventos.json")) { }
            }

            try
            {
                using (FileStream arquivo = File.OpenRead("eventos.json"))
                {
                    ValueTask<BindingList<Evento>> valueTask = JsonSerializer.DeserializeAsync<BindingList<Evento>>(arquivo);
                    BindingList<Evento> e = valueTask.GetAwaiter().GetResult();
                    if (e != null)
                    {
                        for (int i = 0; i < e.Count; i++)
                        {
                            eventos.Add(e.ElementAt(i));
                        }
                    }
                }
            }
            catch (System.Text.Json.JsonException) { }

            
        }

        public void ApagarEventos()
        {
            eventos.Clear();
            File.Delete("eventos.json");
        }

        public BindingList<Evento> GetEventos()
        {
            return eventos;
        }

        public static void SalvarEventos()
        {
            using (FileStream arquivo = File.OpenWrite("eventos.json"))
            {
                Task task = JsonSerializer.SerializeAsync<BindingList<Evento>>(arquivo, eventos);
                task.GetAwaiter().GetResult();
            }
        }

        public void Adicionar(Evento evento)
        {
            eventos.Add(evento);
            SalvarEventos();
        }

        public void Deletar(Evento evento)
        {
            eventos.Remove(evento);
            SalvarEventos();
        }
    }
}
