namespace BarberShopTelas
{
    partial class InserirPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValorPg = new System.Windows.Forms.TextBox();
            this.textBoxDataPg = new System.Windows.Forms.TextBox();
            this.textBoxHoraPg = new System.Windows.Forms.TextBox();
            this.buttonPagamento = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonCheckPg = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodCaixa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Metodo :";
            // 
            // textBoxValorPg
            // 
            this.textBoxValorPg.Location = new System.Drawing.Point(107, 134);
            this.textBoxValorPg.Name = "textBoxValorPg";
            this.textBoxValorPg.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorPg.TabIndex = 4;
            // 
            // textBoxDataPg
            // 
            this.textBoxDataPg.Location = new System.Drawing.Point(107, 170);
            this.textBoxDataPg.Name = "textBoxDataPg";
            this.textBoxDataPg.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataPg.TabIndex = 5;
            // 
            // textBoxHoraPg
            // 
            this.textBoxHoraPg.Location = new System.Drawing.Point(107, 206);
            this.textBoxHoraPg.Name = "textBoxHoraPg";
            this.textBoxHoraPg.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraPg.TabIndex = 6;
            // 
            // buttonPagamento
            // 
            this.buttonPagamento.Location = new System.Drawing.Point(144, 290);
            this.buttonPagamento.Name = "buttonPagamento";
            this.buttonPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonPagamento.TabIndex = 8;
            this.buttonPagamento.Text = "Finalizar";
            this.buttonPagamento.UseVisualStyleBackColor = true;
            this.buttonPagamento.Click += new System.EventHandler(this.buttonPagamento_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(107, 70);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonCheckPg
            // 
            this.buttonCheckPg.Location = new System.Drawing.Point(211, 70);
            this.buttonCheckPg.Name = "buttonCheckPg";
            this.buttonCheckPg.Size = new System.Drawing.Size(55, 23);
            this.buttonCheckPg.TabIndex = 11;
            this.buttonCheckPg.Text = "Check";
            this.buttonCheckPg.UseVisualStyleBackColor = true;
            this.buttonCheckPg.Click += new System.EventHandler(this.buttonCheckPg_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Debito",
            "Credito",
            "A Vista"});
            this.comboBox1.Location = new System.Drawing.Point(107, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo do caixa :";
            // 
            // textBoxCodCaixa
            // 
            this.textBoxCodCaixa.Location = new System.Drawing.Point(107, 41);
            this.textBoxCodCaixa.Name = "textBoxCodCaixa";
            this.textBoxCodCaixa.Size = new System.Drawing.Size(37, 20);
            this.textBoxCodCaixa.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome :";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(107, 102);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 16;
            // 
            // InserirPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(362, 341);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCodCaixa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCheckPg);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPagamento);
            this.Controls.Add(this.textBoxHoraPg);
            this.Controls.Add(this.textBoxDataPg);
            this.Controls.Add(this.textBoxValorPg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Pagamento";
            this.Load += new System.EventHandler(this.InserirPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValorPg;
        private System.Windows.Forms.TextBox textBoxDataPg;
        private System.Windows.Forms.TextBox textBoxHoraPg;
        private System.Windows.Forms.Button buttonPagamento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonCheckPg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodCaixa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}