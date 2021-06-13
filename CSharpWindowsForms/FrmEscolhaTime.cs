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
    public partial class FrmEscolhaTime : Form
    {
        public FrmEscolhaTime()
        {
            InitializeComponent();
        }

        private void radTimes_CheckedChanged(object sender, EventArgs e)
        {
            if (radBahia.Checked == true)
            {
                picTime.Image = Properties.Resources.Bahia;
            }
            else if (radGremio.Checked == true)
            {
                picTime.Image = Properties.Resources.Gremio;
            }
            else if (radInternacional.Checked == true)
            {
                picTime.Image = Properties.Resources.Internacional;
            }
            else if (radPalmeiras.Checked == true)
            {
                picTime.Image = Properties.Resources.Palmeiras;
            }
        }

        private void FrmEscolhaTime_Load(object sender, EventArgs e)
        {
            radTimes_CheckedChanged(radBahia, new EventArgs());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string timeSelecionado = grpTimes
                .Controls
                .OfType<RadioButton>()
                .Single(xxxx => xxxx.Checked == true).Text.Trim();

            if (txtNome.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o nome!",
                    "O nome está faltando",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Olá eu sou {txtNome.Text.Trim()} e torço para o time {timeSelecionado}",
                    "Minha torcida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
