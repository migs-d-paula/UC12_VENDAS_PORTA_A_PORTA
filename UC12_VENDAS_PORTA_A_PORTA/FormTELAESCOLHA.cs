using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_VENDAS_PORTA_A_PORTA
{
    public partial class FormTELAESCOLHA : Form
    {
        public FormTELAESCOLHA()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void buttonCADASTROCLIENTE_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void cadastroDeClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTROPRODUTOS = new FormCADASTROPRODUTOS();
            telaCADASTROPRODUTOS.MdiParent = this;
            telaCADASTROPRODUTOS.WindowState = FormWindowState.Maximized;
            telaCADASTROPRODUTOS.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaVENDAS = new FormVENDER();
            telaVENDAS.MdiParent = this;
            telaVENDAS.WindowState = FormWindowState.Maximized;
            telaVENDAS.Show();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaHISTORICO = new FormHISTORICO();
            telaHISTORICO.MdiParent = this;
            telaHISTORICO.WindowState = FormWindowState.Maximized;
            telaHISTORICO.Show();
        }
    }
}
