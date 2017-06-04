namespace BarberShopTelas
{
    partial class AlterarAgendamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxServico = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servico :";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(55, 58);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCPF.TabIndex = 4;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(55, 102);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 20);
            this.textBoxData.TabIndex = 5;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(55, 148);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(100, 20);
            this.textBoxHora.TabIndex = 6;
            // 
            // textBoxServico
            // 
            this.textBoxServico.Location = new System.Drawing.Point(55, 185);
            this.textBoxServico.Name = "textBoxServico";
            this.textBoxServico.Size = new System.Drawing.Size(26, 20);
            this.textBoxServico.TabIndex = 7;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(55, 235);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 8;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(161, 58);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(82, 21);
            this.buttonPesquisar.TabIndex = 9;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // AlterarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(336, 362);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.textBoxServico);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlterarAgendamento";
            this.Text = "AlterarAgendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxServico;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}