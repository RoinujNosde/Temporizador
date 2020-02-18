using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class NovoEventoForm : Form
    {
        private readonly ResourceManager resource = new ResourceManager("Temporizador.Properties.Resources", typeof(NovoEventoForm).Assembly);
        public NovoEventoForm()
        {
            InitializeComponent();
            dataDoEventoTimePicker.MinDate = DateTime.Now;
            
            nomeDoEventoTextBox.Select();
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            dataDoEventoTimePicker_Validating(null, null);
            var erroNome = errorProvider1.GetError(nomeDoEventoTextBox);
            var erroData = errorProvider1.GetError(dataDoEventoTimePicker);
            if (String.IsNullOrEmpty(erroNome) && String.IsNullOrEmpty(erroData))
            {
                Evento evento = new Evento(nomeDoEventoTextBox.Text, dataDoEventoTimePicker.Value);
                new Armazenamento().Adicionar(evento);
                this.Close();
            }
        }

        private void NomeDoEventoTextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(nomeDoEventoTextBox, "");

            if (String.IsNullOrWhiteSpace(nomeDoEventoTextBox.Text))
                errorProvider1.SetError(nomeDoEventoTextBox, resource.GetString("novo_evento_erro_nome", CultureInfo.CurrentCulture));
            
        }

        private void dataDoEventoTimePicker_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(dataDoEventoTimePicker, "");

            if (!Evento.IsDataValida(dataDoEventoTimePicker.Value))
                errorProvider1.SetError(dataDoEventoTimePicker, resource.GetString("novo_evento_erro_data", CultureInfo.CurrentCulture));

        }
    }
}
