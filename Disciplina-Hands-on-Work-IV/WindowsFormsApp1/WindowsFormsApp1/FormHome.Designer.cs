namespace WindowsFormsApp1
{
    partial class FormHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.reservarButton = new System.Windows.Forms.Button();
            this.barbeiroButton = new System.Windows.Forms.Button();
            this.clienteButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "GESTÃO DE HORÁRIOS";
            // 
            // reservarButton
            // 
            this.reservarButton.Location = new System.Drawing.Point(304, 329);
            this.reservarButton.Name = "reservarButton";
            this.reservarButton.Size = new System.Drawing.Size(171, 61);
            this.reservarButton.TabIndex = 37;
            this.reservarButton.Text = "Reservar horário";
            this.reservarButton.UseVisualStyleBackColor = true;
            this.reservarButton.Click += new System.EventHandler(this.reservarButton_Click);
            // 
            // barbeiroButton
            // 
            this.barbeiroButton.Location = new System.Drawing.Point(304, 243);
            this.barbeiroButton.Name = "barbeiroButton";
            this.barbeiroButton.Size = new System.Drawing.Size(171, 61);
            this.barbeiroButton.TabIndex = 36;
            this.barbeiroButton.Text = "Cadastrar Barbeiro";
            this.barbeiroButton.UseVisualStyleBackColor = true;
            this.barbeiroButton.Click += new System.EventHandler(this.barbeiroButton_Click);
            // 
            // clienteButton
            // 
            this.clienteButton.Location = new System.Drawing.Point(304, 154);
            this.clienteButton.Name = "clienteButton";
            this.clienteButton.Size = new System.Drawing.Size(171, 61);
            this.clienteButton.TabIndex = 35;
            this.clienteButton.Text = "Cadastrar Cliente";
            this.clienteButton.UseVisualStyleBackColor = true;
            this.clienteButton.Click += new System.EventHandler(this.clienteButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(304, 414);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(171, 61);
            this.sairButton.TabIndex = 39;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservarButton);
            this.Controls.Add(this.barbeiroButton);
            this.Controls.Add(this.clienteButton);
            this.Name = "FormHome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reservarButton;
        private System.Windows.Forms.Button barbeiroButton;
        private System.Windows.Forms.Button clienteButton;
        private System.Windows.Forms.Button sairButton;
    }
}

