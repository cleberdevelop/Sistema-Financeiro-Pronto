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
    public partial class ContasaPagar : Form
    {
        public ContasaPagar()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastrodeContas outroform = new CadastrodeContas();
            outroform.ShowDialog();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CadastrodeContas outroform = new CadastrodeContas();
            outroform.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            cb1.ResetText();
            cb2.ResetText();
            cb3.ResetText();
            cb4.ResetText();
            date1.ResetText();
            date2.ResetText();
            date3.ResetText();
            date4.ResetText();
            date5.ResetText();
            date6.ResetText();


        }
    }
}
