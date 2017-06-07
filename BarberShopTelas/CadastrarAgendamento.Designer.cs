namespace BarberShopTelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAgendamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxServiAg = new System.Windows.Forms.TextBox();
            this.buttonCadastrarAg = new System.Windows.Forms.Button();
            this.maskedTextBoxDataAg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraAg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servico :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora :";
            // 
            // textBoxServiAg
            // 
            this.textBoxServiAg.Location = new System.Drawing.Point(237, 56);
            this.textBoxServiAg.Name = "textBoxServiAg";
            this.textBoxServiAg.Size = new System.Drawing.Size(25, 20);
            this.textBoxServiAg.TabIndex = 7;
            // 
            // buttonCadastrarAg
            // 
            this.buttonCadastrarAg.Location = new System.Drawing.Point(217, 172);
            this.buttonCadastrarAg.Name = "buttonCadastrarAg";
            this.buttonCadastrarAg.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarAg.TabIndex = 11;
            this.buttonCadastrarAg.Text = "Agendar";
            this.buttonCadastrarAg.UseVisualStyleBackColor = true;
            this.buttonCadastrarAg.Click += new System.EventHandler(this.buttonCadastrarAg_Click);
            // 
            // maskedTextBoxDataAg
            // 
            this.maskedTextBoxDataAg.Location = new System.Drawing.Point(237, 99);
            this.maskedTextBoxDataAg.Mask = "00/00/0000";
            this.maskedTextBoxDataAg.Name = "maskedTextBoxDataAg";
            this.maskedTextBoxDataAg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataAg.TabIndex = 12;
            // 
            // maskedTextBoxHoraAg
            // 
            this.maskedTextBoxHoraAg.Location = new System.Drawing.Point(57, 98);
            this.maskedTextBoxHoraAg.Mask = "00:00";
            this.maskedTextBoxHoraAg.Name = "maskedTextBoxHoraAg";
            this.maskedTextBoxHoraAg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHoraAg.TabIndex = 13;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.Location = new System.Drawing.Point(57, 56);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBoxHoraAg);
            this.Controls.Add(this.maskedTextBoxDataAg);
            this.Controls.Add(this.buttonCadastrarAg);
            this.Controls.Add(this.textBoxServiAg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Agendamento";
            this.Load += new System.EventHandler(this.CadastrarAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxServiAg;
        private System.Windows.Forms.Button buttonCadastrarAg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataAg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraAg;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}