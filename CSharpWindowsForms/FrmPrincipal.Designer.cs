
namespace CSharpWindowsForms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirFrmComponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFrmEscolhaTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFrmAgendaContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFrmComponentesToolStripMenuItem,
            this.abrirFrmEscolhaTimeToolStripMenuItem,
            this.abrirFrmAgendaContatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirFrmComponentesToolStripMenuItem
            // 
            this.abrirFrmComponentesToolStripMenuItem.Name = "abrirFrmComponentesToolStripMenuItem";
            this.abrirFrmComponentesToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.abrirFrmComponentesToolStripMenuItem.Text = "Abrir FrmComponentes";
            this.abrirFrmComponentesToolStripMenuItem.Click += new System.EventHandler(this.abrirFrmComponentesToolStripMenuItem_Click);
            // 
            // abrirFrmEscolhaTimeToolStripMenuItem
            // 
            this.abrirFrmEscolhaTimeToolStripMenuItem.Name = "abrirFrmEscolhaTimeToolStripMenuItem";
            this.abrirFrmEscolhaTimeToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.abrirFrmEscolhaTimeToolStripMenuItem.Text = "Abrir FrmEscolhaTime";
            this.abrirFrmEscolhaTimeToolStripMenuItem.Click += new System.EventHandler(this.abrirFrmEscolhaTimeToolStripMenuItem_Click);
            // 
            // abrirFrmAgendaContatosToolStripMenuItem
            // 
            this.abrirFrmAgendaContatosToolStripMenuItem.Name = "abrirFrmAgendaContatosToolStripMenuItem";
            this.abrirFrmAgendaContatosToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.abrirFrmAgendaContatosToolStripMenuItem.Text = "Abrir FrmAgendaContatos";
            this.abrirFrmAgendaContatosToolStripMenuItem.Click += new System.EventHandler(this.abrirFrmAgendaContatosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 552);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirFrmComponentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFrmEscolhaTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFrmAgendaContatosToolStripMenuItem;
    }
}

