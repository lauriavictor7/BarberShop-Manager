﻿namespace BarberShopTelas
{
    partial class CadastrarAgendamento
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeAg = new System.Windows.Forms.TextBox();
            this.textBoxServiAg = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpfAg = new System.Windows.Forms.MaskedTextBox();
            this.buttonCadastrarAg = new System.Windows.Forms.Button();
            this.maskedTextBoxDataAg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraAg = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servico :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora :";
            // 
            // textBoxNomeAg
            // 
            this.textBoxNomeAg.Location = new System.Drawing.Point(59, 118);
            this.textBoxNomeAg.Name = "textBoxNomeAg";
            this.textBoxNomeAg.Size = new System.Drawing.Size(343, 20);
            this.textBoxNomeAg.TabIndex = 6;
            // 
            // textBoxServiAg
            // 
            this.textBoxServiAg.Location = new System.Drawing.Point(59, 165);
            this.textBoxServiAg.Name = "textBoxServiAg";
            this.textBoxServiAg.Size = new System.Drawing.Size(25, 20);
            this.textBoxServiAg.TabIndex = 7;
            // 
            // maskedTextBoxCpfAg
            // 
            this.maskedTextBoxCpfAg.Location = new System.Drawing.Point(59, 73);
            this.maskedTextBoxCpfAg.Mask = "000.000.000-00";
            this.maskedTextBoxCpfAg.Name = "maskedTextBoxCpfAg";
            this.maskedTextBoxCpfAg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCpfAg.TabIndex = 10;
            // 
            // buttonCadastrarAg
            // 
            this.buttonCadastrarAg.Location = new System.Drawing.Point(59, 295);
            this.buttonCadastrarAg.Name = "buttonCadastrarAg";
            this.buttonCadastrarAg.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarAg.TabIndex = 11;
            this.buttonCadastrarAg.Text = "Cadastrar";
            this.buttonCadastrarAg.UseVisualStyleBackColor = true;
            this.buttonCadastrarAg.Click += new System.EventHandler(this.buttonCadastrarAg_Click);
            // 
            // maskedTextBoxDataAg
            // 
            this.maskedTextBoxDataAg.Location = new System.Drawing.Point(59, 206);
            this.maskedTextBoxDataAg.Mask = "00/00/0000";
            this.maskedTextBoxDataAg.Name = "maskedTextBoxDataAg";
            this.maskedTextBoxDataAg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataAg.TabIndex = 12;
            // 
            // maskedTextBoxHoraAg
            // 
            this.maskedTextBoxHoraAg.Location = new System.Drawing.Point(59, 247);
            this.maskedTextBoxHoraAg.Mask = "00:00";
            this.maskedTextBoxHoraAg.Name = "maskedTextBoxHoraAg";
            this.maskedTextBoxHoraAg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHoraAg.TabIndex = 13;
            // 
            // CadastrarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 469);
            this.Controls.Add(this.maskedTextBoxHoraAg);
            this.Controls.Add(this.maskedTextBoxDataAg);
            this.Controls.Add(this.buttonCadastrarAg);
            this.Controls.Add(this.maskedTextBoxCpfAg);
            this.Controls.Add(this.textBoxServiAg);
            this.Controls.Add(this.textBoxNomeAg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarAgendamento";
            this.Text = "CadastrarAgendamento";
            this.Load += new System.EventHandler(this.CadastrarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNomeAg;
        private System.Windows.Forms.TextBox textBoxServiAg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpfAg;
        private System.Windows.Forms.Button buttonCadastrarAg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataAg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraAg;
    }
}