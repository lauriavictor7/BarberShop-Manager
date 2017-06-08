namespace BarberShopTelas
{
    partial class ListarPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarPagamento));
            this.listViewPG = new System.Windows.Forms.ListView();
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Metodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPG
            // 
            this.listViewPG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CPF,
            this.Data,
            this.Hora,
            this.Valor,
            this.Metodo});
            this.listViewPG.Location = new System.Drawing.Point(1, 1);
            this.listViewPG.Name = "listViewPG";
            this.listViewPG.Size = new System.Drawing.Size(559, 172);
            this.listViewPG.TabIndex = 0;
            this.listViewPG.UseCompatibleStateImageBehavior = false;
            this.listViewPG.View = System.Windows.Forms.View.Details;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // Data
            // 
            this.Data.Tag = "";
            this.Data.Text = "Data";
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // Metodo
            // 
            this.Metodo.Text = "Metodo";
            // 
            // ListarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 173);
            this.Controls.Add(this.listViewPG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListarPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pagamentos";
            this.Load += new System.EventHandler(this.ListarPagamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPG;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Metodo;
    }
}