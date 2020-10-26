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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroFornecedor outroform = new CadastroFornecedor();
            outroform.ShowDialog();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CadastroFornecedor outroform = new CadastroFornecedor();
            outroform.ShowDialog();
        }

        private void btnLLocalizar_Click(object sender, EventArgs e)
        {
            CadastroFornecedor outroform = new CadastroFornecedor();
            outroform.ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            
        }
    }
}
