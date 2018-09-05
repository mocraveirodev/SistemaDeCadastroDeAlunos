using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Cadastro
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadaluno fcadaluno = new frmcadaluno();
            fcadaluno.Show();

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcadresp fcadresp = new frmcadresp();
            fcadresp.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsResp fConsResp = new frmConsResp();
            fConsResp.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcResp fExcResp = new frmExcResp();
            fExcResp.ShowDialog();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsRespGeral fConsRespGeral = new frmConsRespGeral();
            fConsRespGeral.ShowDialog();

        }

        private void alteraçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAltResp fAltResp = new frmAltResp();
            fAltResp.ShowDialog();
        }
    }
}
