namespace ProjetoCliente
{
    partial class Form1
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
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnConnet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(134, 86);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(137, 134);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 13);
            this.lblPorta.TabIndex = 1;
            this.lblPorta.Text = "Porta:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(176, 86);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(137, 20);
            this.txtIP.TabIndex = 2;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(179, 134);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 20);
            this.txtPorta.TabIndex = 3;
            // 
            // btnConnet
            // 
            this.btnConnet.Location = new System.Drawing.Point(349, 81);
            this.btnConnet.Name = "btnConnet";
            this.btnConnet.Size = new System.Drawing.Size(75, 23);
            this.btnConnet.TabIndex = 4;
            this.btnConnet.Text = "conectar";
            this.btnConnet.UseVisualStyleBackColor = true;
            this.btnConnet.Click += new System.EventHandler(this.btnConnet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnet);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnConnet;
    }
}

