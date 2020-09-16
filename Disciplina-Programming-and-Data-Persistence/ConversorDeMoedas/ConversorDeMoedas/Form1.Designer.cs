namespace ConversorDeMoedas
{
    partial class Conversor
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
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnCoroaSueca = new System.Windows.Forms.Button();
            this.valorConvertido = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLibra = new System.Windows.Forms.Button();
            this.txtbValorConvertido = new System.Windows.Forms.TextBox();
            this.gbValorReal = new System.Windows.Forms.GroupBox();
            this.gbValorConvertido = new System.Windows.Forms.GroupBox();
            this.gbValorReal.SuspendLayout();
            this.gbValorConvertido.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(10, 39);
            this.txtbValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(266, 26);
            this.txtbValor.TabIndex = 1;
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(10, 92);
            this.btnEuro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(118, 57);
            this.btnEuro.TabIndex = 2;
            this.btnEuro.Text = "Euro - €";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnCoroaSueca
            // 
            this.btnCoroaSueca.Location = new System.Drawing.Point(158, 92);
            this.btnCoroaSueca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoroaSueca.Name = "btnCoroaSueca";
            this.btnCoroaSueca.Size = new System.Drawing.Size(118, 57);
            this.btnCoroaSueca.TabIndex = 3;
            this.btnCoroaSueca.Text = "Coroa Sueca - kr";
            this.btnCoroaSueca.UseVisualStyleBackColor = true;
            this.btnCoroaSueca.Click += new System.EventHandler(this.btnCoroaSueca_Click);
            // 
            // valorConvertido
            // 
            this.valorConvertido.AutoSize = true;
            this.valorConvertido.Location = new System.Drawing.Point(154, 185);
            this.valorConvertido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorConvertido.Name = "valorConvertido";
            this.valorConvertido.Size = new System.Drawing.Size(0, 20);
            this.valorConvertido.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(306, 37);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 35);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLibra
            // 
            this.btnLibra.Location = new System.Drawing.Point(306, 92);
            this.btnLibra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLibra.Name = "btnLibra";
            this.btnLibra.Size = new System.Drawing.Size(118, 57);
            this.btnLibra.TabIndex = 9;
            this.btnLibra.Text = "Libra Esterlina - £";
            this.btnLibra.UseVisualStyleBackColor = true;
            this.btnLibra.Click += new System.EventHandler(this.btnLibra_Click);
            // 
            // txtbValorConvertido
            // 
            this.txtbValorConvertido.Location = new System.Drawing.Point(8, 66);
            this.txtbValorConvertido.Name = "txtbValorConvertido";
            this.txtbValorConvertido.Size = new System.Drawing.Size(263, 26);
            this.txtbValorConvertido.TabIndex = 11;
            this.txtbValorConvertido.Text = "0,00";
            // 
            // gbValorReal
            // 
            this.gbValorReal.Controls.Add(this.btnLibra);
            this.gbValorReal.Controls.Add(this.btnLimpar);
            this.gbValorReal.Controls.Add(this.btnCoroaSueca);
            this.gbValorReal.Controls.Add(this.btnEuro);
            this.gbValorReal.Controls.Add(this.txtbValor);
            this.gbValorReal.Location = new System.Drawing.Point(12, 13);
            this.gbValorReal.Name = "gbValorReal";
            this.gbValorReal.Size = new System.Drawing.Size(454, 169);
            this.gbValorReal.TabIndex = 12;
            this.gbValorReal.TabStop = false;
            this.gbValorReal.Text = "Inserir valor em reais (R$):";
            // 
            // gbValorConvertido
            // 
            this.gbValorConvertido.Controls.Add(this.txtbValorConvertido);
            this.gbValorConvertido.Location = new System.Drawing.Point(17, 214);
            this.gbValorConvertido.Name = "gbValorConvertido";
            this.gbValorConvertido.Size = new System.Drawing.Size(448, 122);
            this.gbValorConvertido.TabIndex = 13;
            this.gbValorConvertido.TabStop = false;
            this.gbValorConvertido.Text = "Valor convertido para a moeda escolhida:";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 384);
            this.Controls.Add(this.gbValorConvertido);
            this.Controls.Add(this.gbValorReal);
            this.Controls.Add(this.valorConvertido);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Conversor";
            this.Text = "Conversor";
            this.gbValorReal.ResumeLayout(false);
            this.gbValorReal.PerformLayout();
            this.gbValorConvertido.ResumeLayout(false);
            this.gbValorConvertido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbValor;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnCoroaSueca;
        private System.Windows.Forms.Label valorConvertido;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLibra;
        private System.Windows.Forms.TextBox txtbValorConvertido;
        private System.Windows.Forms.GroupBox gbValorReal;
        private System.Windows.Forms.GroupBox gbValorConvertido;
    }
}

