namespace Temporizador
{
    partial class NovoEventoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoEventoForm));
            this.dataDoEventoTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeDoEventoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDoEventoTimePicker
            // 
            this.dataDoEventoTimePicker.Checked = false;
            resources.ApplyResources(this.dataDoEventoTimePicker, "dataDoEventoTimePicker");
            this.dataDoEventoTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDoEventoTimePicker.Name = "dataDoEventoTimePicker";
            this.dataDoEventoTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dataDoEventoTimePicker_Validating);
            // 
            // nomeDoEventoTextBox
            // 
            resources.ApplyResources(this.nomeDoEventoTextBox, "nomeDoEventoTextBox");
            this.nomeDoEventoTextBox.Name = "nomeDoEventoTextBox";
            this.nomeDoEventoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NomeDoEventoTextBox_Validating);
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
            // adicionarButton
            // 
            resources.ApplyResources(this.adicionarButton, "adicionarButton");
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NovoEventoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeDoEventoTextBox);
            this.Controls.Add(this.dataDoEventoTimePicker);
            this.Name = "NovoEventoForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataDoEventoTimePicker;
        private System.Windows.Forms.TextBox nomeDoEventoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}