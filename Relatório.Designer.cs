namespace Sistema_Financeiro
{
    partial class Relatório
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
            this.lbPagina = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnrelatorio = new System.Windows.Forms.Panel();
            this.mtbValorFinal = new System.Windows.Forms.MaskedTextBox();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pnrelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPagina
            // 
            this.lbPagina.AutoSize = true;
            this.lbPagina.Location = new System.Drawing.Point(854, 8);
            this.lbPagina.Name = "lbPagina";
            this.lbPagina.Size = new System.Drawing.Size(40, 13);
            this.lbPagina.TabIndex = 4;
            this.lbPagina.Text = "Página";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(357, 56);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(80, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Por Fornecedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "IFTM";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView3.Location = new System.Drawing.Point(0, 85);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(816, 489);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Forncedor";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "C. de Custo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "P. de Conta";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data Comp.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Núm.";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tp.";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Data Venc.";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Valor Pgto";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Saldo";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Data Pgto";
            this.Column10.Name = "Column10";
            // 
            // pnrelatorio
            // 
            this.pnrelatorio.Controls.Add(this.mtbValorFinal);
            this.pnrelatorio.Controls.Add(this.lbTotalPagar);
            this.pnrelatorio.Controls.Add(this.lbPagina);
            this.pnrelatorio.Controls.Add(this.lbTipo);
            this.pnrelatorio.Controls.Add(this.label9);
            this.pnrelatorio.Controls.Add(this.dataGridView3);
            this.pnrelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnrelatorio.Location = new System.Drawing.Point(0, 0);
            this.pnrelatorio.Name = "pnrelatorio";
            this.pnrelatorio.Size = new System.Drawing.Size(800, 450);
            this.pnrelatorio.TabIndex = 42;
            // 
            // mtbValorFinal
            // 
            this.mtbValorFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorFinal.Location = new System.Drawing.Point(643, 409);
            this.mtbValorFinal.Mask = "$ 000,000,000.00";
            this.mtbValorFinal.Name = "mtbValorFinal";
            this.mtbValorFinal.Size = new System.Drawing.Size(124, 23);
            this.mtbValorFinal.TabIndex = 6;
            this.mtbValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.Location = new System.Drawing.Point(258, 410);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(215, 19);
            this.lbTotalPagar.TabIndex = 5;
            this.lbTotalPagar.Text = "Total geral de contas a pagar";
            // 
            // Relatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnrelatorio);
            this.Name = "Relatório";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pnrelatorio.ResumeLayout(false);
            this.pnrelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPagina;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel pnrelatorio;
        private System.Windows.Forms.MaskedTextBox mtbValorFinal;
        private System.Windows.Forms.Label lbTotalPagar;
    }
}