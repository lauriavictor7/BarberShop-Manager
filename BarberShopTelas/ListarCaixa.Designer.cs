namespace BarberShopTelas
{
    partial class ListarCaixa
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
            this.listViewCaixa = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor_Inicial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor_Atual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor_Final = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewCaixa
            // 
            this.listViewCaixa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.Valor_Inicial,
            this.Valor_Atual,
            this.Valor_Final,
            this.Data,
            this.Hora});
            this.listViewCaixa.Location = new System.Drawing.Point(1, -1);
            this.listViewCaixa.Name = "listViewCaixa";
            this.listViewCaixa.Size = new System.Drawing.Size(551, 166);
            this.listViewCaixa.TabIndex = 0;
            this.listViewCaixa.UseCompatibleStateImageBehavior = false;
            this.listViewCaixa.View = System.Windows.Forms.View.Details;
            // 
            // Código
            // 
            this.Código.Text = "Código";
            // 
            // Valor_Inicial
            // 
            this.Valor_Inicial.Text = "Valor Inicial";
            // 
            // Valor_Atual
            // 
            this.Valor_Atual.Text = "Valor Atual";
            // 
            // Valor_Final
            // 
            this.Valor_Final.Text = "Valor Final";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            // 
            // ListarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(555, 165);
            this.Controls.Add(this.listViewCaixa);
            this.Name = "ListarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Caixa";
            this.Load += new System.EventHandler(this.ListarCaixa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCaixa;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Valor_Inicial;
        private System.Windows.Forms.ColumnHeader Valor_Atual;
        private System.Windows.Forms.ColumnHeader Valor_Final;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
    }
}