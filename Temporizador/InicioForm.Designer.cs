namespace Temporizador
{
    partial class InicioForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.combobox_eventos = new System.Windows.Forms.ComboBox();
            this.label_eventos = new System.Windows.Forms.Label();
            this.label_nome_do_evento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_anos = new System.Windows.Forms.Label();
            this.label_meses = new System.Windows.Forms.Label();
            this.label_dias = new System.Windows.Forms.Label();
            this.label_horas = new System.Windows.Forms.Label();
            this.label_minutos = new System.Windows.Forms.Label();
            this.label_segundos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarTodosOsEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarEventoButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox_eventos
            // 
            resources.ApplyResources(this.combobox_eventos, "combobox_eventos");
            this.combobox_eventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_eventos.FormattingEnabled = true;
            this.combobox_eventos.Name = "combobox_eventos";
            this.combobox_eventos.SelectedIndexChanged += new System.EventHandler(this.Combobox_eventos_SelectedIndexChanged);
            // 
            // label_eventos
            // 
            resources.ApplyResources(this.label_eventos, "label_eventos");
            this.label_eventos.Name = "label_eventos";
            // 
            // label_nome_do_evento
            // 
            resources.ApplyResources(this.label_nome_do_evento, "label_nome_do_evento");
            this.label_nome_do_evento.Name = "label_nome_do_evento";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label_anos
            // 
            resources.ApplyResources(this.label_anos, "label_anos");
            this.label_anos.Name = "label_anos";
            // 
            // label_meses
            // 
            resources.ApplyResources(this.label_meses, "label_meses");
            this.label_meses.Name = "label_meses";
            // 
            // label_dias
            // 
            resources.ApplyResources(this.label_dias, "label_dias");
            this.label_dias.Name = "label_dias";
            // 
            // label_horas
            // 
            resources.ApplyResources(this.label_horas, "label_horas");
            this.label_horas.Name = "label_horas";
            // 
            // label_minutos
            // 
            resources.ApplyResources(this.label_minutos, "label_minutos");
            this.label_minutos.Name = "label_minutos";
            // 
            // label_segundos
            // 
            resources.ApplyResources(this.label_segundos, "label_segundos");
            this.label_segundos.Name = "label_segundos";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoEventoToolStripMenuItem,
            this.apagarTodosOsEventosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            // 
            // novoEventoToolStripMenuItem
            // 
            resources.ApplyResources(this.novoEventoToolStripMenuItem, "novoEventoToolStripMenuItem");
            this.novoEventoToolStripMenuItem.Name = "novoEventoToolStripMenuItem";
            this.novoEventoToolStripMenuItem.Click += new System.EventHandler(this.NovoEventoToolStripMenuItem_Click);
            // 
            // apagarTodosOsEventosToolStripMenuItem
            // 
            resources.ApplyResources(this.apagarTodosOsEventosToolStripMenuItem, "apagarTodosOsEventosToolStripMenuItem");
            this.apagarTodosOsEventosToolStripMenuItem.Name = "apagarTodosOsEventosToolStripMenuItem";
            this.apagarTodosOsEventosToolStripMenuItem.Click += new System.EventHandler(this.ApagarTodosOsEventosToolStripMenuItem_Click);
            // 
            // apagarEventoButton
            // 
            resources.ApplyResources(this.apagarEventoButton, "apagarEventoButton");
            this.apagarEventoButton.Name = "apagarEventoButton";
            this.apagarEventoButton.UseVisualStyleBackColor = true;
            this.apagarEventoButton.Click += new System.EventHandler(this.ApagarEventoButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // InicioForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apagarEventoButton);
            this.Controls.Add(this.label_segundos);
            this.Controls.Add(this.label_minutos);
            this.Controls.Add(this.label_horas);
            this.Controls.Add(this.label_dias);
            this.Controls.Add(this.label_meses);
            this.Controls.Add(this.label_anos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nome_do_evento);
            this.Controls.Add(this.label_eventos);
            this.Controls.Add(this.combobox_eventos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_eventos;
        private System.Windows.Forms.Label label_eventos;
        private System.Windows.Forms.Label label_nome_do_evento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_anos;
        private System.Windows.Forms.Label label_meses;
        private System.Windows.Forms.Label label_dias;
        private System.Windows.Forms.Label label_horas;
        private System.Windows.Forms.Label label_minutos;
        private System.Windows.Forms.Label label_segundos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarTodosOsEventosToolStripMenuItem;
        private System.Windows.Forms.Button apagarEventoButton;
        private System.Windows.Forms.Timer timer;
    }
}

