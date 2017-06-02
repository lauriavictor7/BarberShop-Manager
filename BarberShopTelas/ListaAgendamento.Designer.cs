namespace BarberShopTelas
{
    partial class ListaAgendamento
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
            this.dataGridViewAgendamento = new System.Windows.Forms.DataGridView();
            this.buttonAgendamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAgendamento
            // 
            this.dataGridViewAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendamento.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewAgendamento.Name = "dataGridViewAgendamento";
            this.dataGridViewAgendamento.Size = new System.Drawing.Size(381, 150);
            this.dataGridViewAgendamento.TabIndex = 0;
            // 
            // buttonAgendamento
            // 
            this.buttonAgendamento.Location = new System.Drawing.Point(164, 187);
            this.buttonAgendamento.Name = "buttonAgendamento";
            this.buttonAgendamento.Size = new System.Drawing.Size(75, 23);
            this.buttonAgendamento.TabIndex = 1;
            this.buttonAgendamento.Text = "Atualizar";
            this.buttonAgendamento.UseVisualStyleBackColor = true;
            this.buttonAgendamento.Click += new System.EventHandler(this.buttonAgendamento_Click);
            // 
            // ListaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.Controls.Add(this.buttonAgendamento);
            this.Controls.Add(this.dataGridViewAgendamento);
            this.Name = "ListaAgendamento";
            this.Text = "ListaAgendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgendamento;
        private System.Windows.Forms.Button buttonAgendamento;
    }
}