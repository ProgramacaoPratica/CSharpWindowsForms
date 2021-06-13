using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWindowsForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFrmComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmComponentes());
        }

        private void abrirFrmEscolhaTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmEscolhaTime());
        }

        private void abrirFrmAgendaContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmAgendaContatos());
        }

        private void AbrirFormularios(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
