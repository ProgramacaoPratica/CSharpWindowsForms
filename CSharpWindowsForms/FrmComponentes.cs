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
    public partial class FrmComponentes : Form
    {
        public FrmComponentes()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Trim().Equals(string.Empty))
            {
                lstNomes.Items.Add(txtNome.Text.Trim());
                txtNome.Text = string.Empty;
                txtNome.Focus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstNomes.SelectedItems.Count > 0)
            {
                lstNomes.Items.RemoveAt(lstNomes.SelectedIndices[0]);
            }
        }
    }
}
