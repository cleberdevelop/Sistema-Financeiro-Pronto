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
    public partial class RelatorioContasaPagar : Form
    {
        public RelatorioContasaPagar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            Relatório outroform = new Relatório();
            outroform.ShowDialog();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            dateTimePicker3.ResetText();
            dateTimePicker4.ResetText();
            dateTimePicker5.ResetText();
            dateTimePicker6.ResetText();
            rbAnalitico.Checked = false;
            rbSintetico.Checked = false;
            rbPagos.Checked = false;
            rbTodos.Checked = false;
            rbEmAberto.Checked = false;
            rb12.Checked = false;
            rb7.Checked = false;
            rb8.Checked = false;
            rb9.Checked = false;
            rb10.Checked = false;
            rb11.Checked = false;
            rb12.Checked = false;
            rb13.Checked = false;
            rb14.Checked = false;
            rb15.Checked = false;
            rb16.Checked = false;
            rb17.Checked = false;
        }
    }
}
