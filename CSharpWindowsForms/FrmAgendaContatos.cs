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
    public partial class FrmAgendaContatos : Form
    {
        public FrmAgendaContatos()
        {
            InitializeComponent();
        }

        private void FrmAgendaContatos_Load(object sender, EventArgs e)
        {
            //Exibir detalhes da lista
            lvwContatos.View = View.Details;

            //Permite selecionar uma linha inteira
            lvwContatos.FullRowSelect = true;

            //Exibir linhas da grade do listview
            lvwContatos.GridLines = true;

            //Definir uma única seleção dos itens
            lvwContatos.MultiSelect = false;

            lvwContatos.Columns.Add("Nome", 330, HorizontalAlignment.Left);
            lvwContatos.Columns.Add("E-mail", 330, HorizontalAlignment.Left);
            lvwContatos.Columns.Add("Celular", 230, HorizontalAlignment.Left);
            lvwContatos.Columns.Add("Operadora", 230, HorizontalAlignment.Left);

            txtNome.Select();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o nome!", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o e-mail!", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtCelular.MaskCompleted)
            {
                MessageBox.Show("Você deve informar o celular corretamente!", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvi = new ListViewItem(txtNome.Text.Trim());
            lvi.SubItems.Add(txtEmail.Text.Trim());
            lvi.SubItems.Add(txtCelular.Text);
            lvi.SubItems.Add(cmbOperadora.SelectedItem.ToString());

            lvwContatos.Items.Add(lvi);

            btnLimpar_Click(btnLimpar, new EventArgs());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCelular.Text = string.Empty;
            cmbOperadora.SelectedIndex = -1;

            txtNome.Select();
        }

        private void btnRemoverSelecionada_Click(object sender, EventArgs e)
        {
            if (lvwContatos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Você deve selecionar um contato na lista para remover!");
                return;
            }

            lvwContatos.Items.RemoveAt(lvwContatos.SelectedIndices[0]);
        }

        private void btnRemoverTodas_Click(object sender, EventArgs e)
        {
            lvwContatos.Items.Clear();
        }
    }
}
