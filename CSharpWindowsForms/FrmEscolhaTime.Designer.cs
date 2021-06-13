
namespace CSharpWindowsForms
{
    partial class FrmEscolhaTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTimes = new System.Windows.Forms.GroupBox();
            this.radPalmeiras = new System.Windows.Forms.RadioButton();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.radInternacional = new System.Windows.Forms.RadioButton();
            this.radGremio = new System.Windows.Forms.RadioButton();
            this.radBahia = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(582, 38);
            this.txtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // grpTimes
            // 
            this.grpTimes.Controls.Add(this.radPalmeiras);
            this.grpTimes.Controls.Add(this.picTime);
            this.grpTimes.Controls.Add(this.radInternacional);
            this.grpTimes.Controls.Add(this.radGremio);
            this.grpTimes.Controls.Add(this.radBahia);
            this.grpTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimes.Location = new System.Drawing.Point(12, 96);
            this.grpTimes.Name = "grpTimes";
            this.grpTimes.Size = new System.Drawing.Size(582, 349);
            this.grpTimes.TabIndex = 5;
            this.grpTimes.TabStop = false;
            this.grpTimes.Text = "Você torce para qual time?";
            // 
            // radPalmeiras
            // 
            this.radPalmeiras.AutoSize = true;
            this.radPalmeiras.Location = new System.Drawing.Point(21, 172);
            this.radPalmeiras.Name = "radPalmeiras";
            this.radPalmeiras.Size = new System.Drawing.Size(152, 35);
            this.radPalmeiras.TabIndex = 3;
            this.radPalmeiras.Text = "Palmeiras";
            this.radPalmeiras.UseVisualStyleBackColor = true;
            this.radPalmeiras.CheckedChanged += new System.EventHandler(this.radTimes_CheckedChanged);
            // 
            // picTime
            // 
            this.picTime.Location = new System.Drawing.Point(273, 49);
            this.picTime.Name = "picTime";
            this.picTime.Size = new System.Drawing.Size(294, 294);
            this.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime.TabIndex = 6;
            this.picTime.TabStop = false;
            // 
            // radInternacional
            // 
            this.radInternacional.AutoSize = true;
            this.radInternacional.Location = new System.Drawing.Point(21, 131);
            this.radInternacional.Name = "radInternacional";
            this.radInternacional.Size = new System.Drawing.Size(188, 35);
            this.radInternacional.TabIndex = 2;
            this.radInternacional.Text = "Internacional";
            this.radInternacional.UseVisualStyleBackColor = true;
            this.radInternacional.CheckedChanged += new System.EventHandler(this.radTimes_CheckedChanged);
            // 
            // radGremio
            // 
            this.radGremio.AutoSize = true;
            this.radGremio.Location = new System.Drawing.Point(21, 90);
            this.radGremio.Name = "radGremio";
            this.radGremio.Size = new System.Drawing.Size(120, 35);
            this.radGremio.TabIndex = 1;
            this.radGremio.Text = "Grêmio";
            this.radGremio.UseVisualStyleBackColor = true;
            this.radGremio.CheckedChanged += new System.EventHandler(this.radTimes_CheckedChanged);
            // 
            // radBahia
            // 
            this.radBahia.AutoSize = true;
            this.radBahia.Checked = true;
            this.radBahia.Location = new System.Drawing.Point(21, 49);
            this.radBahia.Name = "radBahia";
            this.radBahia.Size = new System.Drawing.Size(101, 35);
            this.radBahia.TabIndex = 0;
            this.radBahia.TabStop = true;
            this.radBahia.Text = "Bahia";
            this.radBahia.UseVisualStyleBackColor = true;
            this.radBahia.CheckedChanged += new System.EventHandler(this.radTimes_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(414, 451);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(180, 50);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmEscolhaTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 526);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpTimes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmEscolhaTime";
            this.Text = "FrmEscolhaTime";
            this.Load += new System.EventHandler(this.FrmEscolhaTime_Load);
            this.grpTimes.ResumeLayout(false);
            this.grpTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTimes;
        private System.Windows.Forms.RadioButton radPalmeiras;
        private System.Windows.Forms.PictureBox picTime;
        private System.Windows.Forms.RadioButton radInternacional;
        private System.Windows.Forms.RadioButton radGremio;
        private System.Windows.Forms.RadioButton radBahia;
        private System.Windows.Forms.Button btnConfirmar;
    }
}