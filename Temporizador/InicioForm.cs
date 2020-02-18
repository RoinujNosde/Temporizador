using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace Temporizador
{
    public partial class InicioForm : Form
    {
        private readonly Armazenamento armazenamento;
        private readonly ResourceManager resource = new ResourceManager("Temporizador.Properties.Resources", typeof(InicioForm).Assembly);
        public InicioForm()
        {
            armazenamento = new Armazenamento();
            InitializeComponent();
            combobox_eventos.DataSource = armazenamento.GetEventos();
            combobox_eventos.DisplayMember = "nome";
        }

        private void NovoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NovoEventoForm form = new NovoEventoForm())
            {
                form.ShowDialog();
            }
        }

        private void ApagarTodosOsEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            armazenamento.ApagarEventos();
        }

        private void ApagarEventoButton_Click(object sender, EventArgs e)
        {
            armazenamento.Deletar((Evento) combobox_eventos.SelectedItem);
        }

        private void Combobox_eventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTelaDoEvento();
        }

        private void AtualizarTelaDoEvento()
        {
            Evento evento = ((Evento)combobox_eventos.SelectedItem);
            if (evento != null)
            {
                label_nome_do_evento.Text = evento.Nome;
                CalculadoraDeData dc = new CalculadoraDeData(evento.Data);
                label_anos.Text = ToString(dc.GetAnos());
                label_meses.Text = ToString(dc.GetMeses());
                label_dias.Text = ToString(dc.GetDias());
                label_horas.Text = ToString(dc.GetHoras());
                label_minutos.Text = ToString(dc.GetMinutos());
                label_segundos.Text = ToString(dc.GetSegundos());
            }
            else
            {
                label_nome_do_evento.Text = resource.GetString("inicio_label_nome_do_evento", CultureInfo.CurrentCulture);
                label_anos.Text = resource.GetString("inicio_padrao_label_anos", CultureInfo.CurrentCulture);
                label_meses.Text = resource.GetString("inicio_padrao_label_meses", CultureInfo.CurrentCulture);
                label_dias.Text = resource.GetString("inicio_padrao_label_dias", CultureInfo.CurrentCulture);
                label_horas.Text = resource.GetString("inicio_padrao_label_horas", CultureInfo.CurrentCulture);
                label_minutos.Text = resource.GetString("inicio_padrao_label_minutos", CultureInfo.CurrentCulture);
                label_segundos.Text = resource.GetString("inicio_padrao_label_segundos", CultureInfo.CurrentCulture);
            }
        }

        private static string ToString(int from)
        {
            return from.ToString(CultureInfo.CurrentCulture);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AtualizarTelaDoEvento();
        }
    }
}
