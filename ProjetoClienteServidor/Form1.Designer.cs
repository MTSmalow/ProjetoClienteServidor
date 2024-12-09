namespace ProjetoClienteServidor
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
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(141, 98);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 13);
            this.lblPorta.TabIndex = 0;
            this.lblPorta.Text = "Porta:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(182, 95);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 20);
            this.txtPorta.TabIndex = 1;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(144, 139);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(210, 139);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(391, 197);
            this.txtMensagem.TabIndex = 3;
            this.txtMensagem.Text = "Meu Servidor";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(368, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(472, 85);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(85, 33);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.lblPorta);
            this.Name = "Form1";
            this.Text = "\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnParar;
    }
}

