namespace BarberShopTelas
{
    partial class FilaDeAgendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilaDeAgendamentos));
            this.listViewFila = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serviço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFila
            // 
            this.listViewFila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Serviço,
            this.Data,
            this.Hora});
            this.listViewFila.Location = new System.Drawing.Point(13, 12);
            this.listViewFila.Name = "listViewFila";
            this.listViewFila.Size = new System.Drawing.Size(453, 208);
            this.listViewFila.TabIndex = 0;
            this.listViewFila.UseCompatibleStateImageBehavior = false;
            this.listViewFila.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 110;
            // 
            // Serviço
            // 
            this.Serviço.Text = "Serviço";
            this.Serviço.Width = 111;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 109;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            this.Hora.Width = 119;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FilaDeAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewFila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilaDeAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila de Agendamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFila;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Serviço;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.Button button1;
    }
}