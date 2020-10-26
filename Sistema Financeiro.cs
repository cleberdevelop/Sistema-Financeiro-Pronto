using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class SistemaFinanceiro : Form
    {
        public SistemaFinanceiro()
        {
            InitializeComponent();
        }

        private void SairClick(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fornecedor outroform = new Fornecedor();
            outroform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContasaPagar outroform = new ContasaPagar();
            outroform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelatorioContasaPagar outroform = new RelatorioContasaPagar();
            outroform.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
