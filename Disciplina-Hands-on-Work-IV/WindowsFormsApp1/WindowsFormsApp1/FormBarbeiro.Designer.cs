namespace WindowsFormsApp1
{
    partial class FormBarbeiro
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.limparButton = new System.Windows.Forms.Button();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.celularLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.coID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluirButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.dadosPessoaisLabel = new System.Windows.Forms.Label();
            this.municipioTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.ufLabel = new System.Windows.Forms.Label();
            this.municipioLabel = new System.Windows.Forms.Label();
            this.cepLabel = new System.Windows.Forms.Label();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.endercoResLabel = new System.Windows.Forms.Label();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.rgLabel = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(1201, 169);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(180, 26);
            this.idTextBox.TabIndex = 110;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(1163, 175);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 20);
            this.idLabel.TabIndex = 109;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(1251, 478);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(128, 40);
            this.limparButton.TabIndex = 108;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click_1);
            // 
            // ufTextBox
            // 
            this.ufTextBox.Location = new System.Drawing.Point(1197, 403);
            this.ufTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(182, 26);
            this.ufTextBox.TabIndex = 107;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.Location = new System.Drawing.Point(1201, 217);
            this.sexoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(180, 26);
            this.sexoTextBox.TabIndex = 106;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(371, 217);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(446, 26);
            this.dataTextBox.TabIndex = 105;
            // 
            // celularTextBox
            // 
            this.celularTextBox.Location = new System.Drawing.Point(907, 264);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(474, 26);
            this.celularTextBox.TabIndex = 104;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(371, 264);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(446, 26);
            this.emailTextBox.TabIndex = 103;
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.Location = new System.Drawing.Point(837, 268);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(62, 20);
            this.celularLabel.TabIndex = 102;
            this.celularLabel.Text = "Celular:";
            this.celularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(308, 268);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 20);
            this.emailLabel.TabIndex = 101;
            this.emailLabel.Text = "E-mail:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coID,
            this.coNome,
            this.coCPF,
            this.coRG,
            this.coDataNascimento,
            this.coSexo,
            this.coEmail,
            this.coCelular,
            this.coEndereco,
            this.coBairro,
            this.coMunicipio,
            this.coCEP,
            this.coUF});
            this.dataGridView.Location = new System.Drawing.Point(213, 551);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1166, 365);
            this.dataGridView.TabIndex = 100;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // coID
            // 
            this.coID.HeaderText = "ID";
            this.coID.MinimumWidth = 8;
            this.coID.Name = "coID";
            this.coID.ReadOnly = true;
            this.coID.Width = 150;
            // 
            // coNome
            // 
            this.coNome.HeaderText = "Nome";
            this.coNome.MinimumWidth = 8;
            this.coNome.Name = "coNome";
            this.coNome.Width = 150;
            // 
            // coCPF
            // 
            this.coCPF.HeaderText = "CPF";
            this.coCPF.MinimumWidth = 8;
            this.coCPF.Name = "coCPF";
            this.coCPF.Width = 150;
            // 
            // coRG
            // 
            this.coRG.HeaderText = "RG";
            this.coRG.MinimumWidth = 8;
            this.coRG.Name = "coRG";
            this.coRG.Width = 150;
            // 
            // coDataNascimento
            // 
            this.coDataNascimento.HeaderText = "Data de Nascimento";
            this.coDataNascimento.MinimumWidth = 8;
            this.coDataNascimento.Name = "coDataNascimento";
            this.coDataNascimento.Width = 150;
            // 
            // coSexo
            // 
            this.coSexo.HeaderText = "Sexo";
            this.coSexo.MinimumWidth = 8;
            this.coSexo.Name = "coSexo";
            this.coSexo.Width = 150;
            // 
            // coEmail
            // 
            this.coEmail.HeaderText = "E-mail";
            this.coEmail.MinimumWidth = 8;
            this.coEmail.Name = "coEmail";
            this.coEmail.Width = 150;
            // 
            // coCelular
            // 
            this.coCelular.HeaderText = "Celular";
            this.coCelular.MinimumWidth = 8;
            this.coCelular.Name = "coCelular";
            this.coCelular.Width = 150;
            // 
            // coEndereco
            // 
            this.coEndereco.HeaderText = "Endereço";
            this.coEndereco.MinimumWidth = 8;
            this.coEndereco.Name = "coEndereco";
            this.coEndereco.Width = 150;
            // 
            // coBairro
            // 
            this.coBairro.HeaderText = "Bairro";
            this.coBairro.MinimumWidth = 8;
            this.coBairro.Name = "coBairro";
            this.coBairro.Width = 150;
            // 
            // coMunicipio
            // 
            this.coMunicipio.HeaderText = "Município";
            this.coMunicipio.MinimumWidth = 8;
            this.coMunicipio.Name = "coMunicipio";
            this.coMunicipio.Width = 150;
            // 
            // coCEP
            // 
            this.coCEP.HeaderText = "CEP";
            this.coCEP.MinimumWidth = 8;
            this.coCEP.Name = "coCEP";
            this.coCEP.Width = 150;
            // 
            // coUF
            // 
            this.coUF.HeaderText = "UF";
            this.coUF.MinimumWidth = 8;
            this.coUF.Name = "coUF";
            this.coUF.Width = 150;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(1097, 478);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(128, 40);
            this.excluirButton.TabIndex = 99;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click_1);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(933, 478);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(130, 42);
            this.atualizarButton.TabIndex = 98;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click_1);
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(769, 478);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(130, 40);
            this.inserirButton.TabIndex = 97;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click_1);
            // 
            // dadosPessoaisLabel
            // 
            this.dadosPessoaisLabel.AutoSize = true;
            this.dadosPessoaisLabel.Location = new System.Drawing.Point(209, 128);
            this.dadosPessoaisLabel.Name = "dadosPessoaisLabel";
            this.dadosPessoaisLabel.Size = new System.Drawing.Size(157, 20);
            this.dadosPessoaisLabel.TabIndex = 96;
            this.dadosPessoaisLabel.Text = "DADOS PESSOAIS:";
            // 
            // municipioTextBox
            // 
            this.municipioTextBox.Location = new System.Drawing.Point(769, 404);
            this.municipioTextBox.Name = "municipioTextBox";
            this.municipioTextBox.Size = new System.Drawing.Size(340, 26);
            this.municipioTextBox.TabIndex = 95;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(1197, 361);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(182, 26);
            this.cepTextBox.TabIndex = 94;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(371, 404);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(292, 26);
            this.bairroTextBox.TabIndex = 93;
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Location = new System.Drawing.Point(1153, 406);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(35, 20);
            this.ufLabel.TabIndex = 92;
            this.ufLabel.Text = "UF:";
            // 
            // municipioLabel
            // 
            this.municipioLabel.AutoSize = true;
            this.municipioLabel.Location = new System.Drawing.Point(685, 408);
            this.municipioLabel.Name = "municipioLabel";
            this.municipioLabel.Size = new System.Drawing.Size(79, 20);
            this.municipioLabel.TabIndex = 91;
            this.municipioLabel.Text = "Município:";
            this.municipioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Location = new System.Drawing.Point(1142, 364);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(45, 20);
            this.cepLabel.TabIndex = 90;
            this.cepLabel.Text = "CEP:";
            this.cepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.Location = new System.Drawing.Point(309, 408);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(55, 20);
            this.bairroLabel.TabIndex = 89;
            this.bairroLabel.Text = "Bairro:";
            this.bairroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(1145, 221);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(49, 20);
            this.sexoLabel.TabIndex = 88;
            this.sexoLabel.Text = "Sexo:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(283, 364);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(82, 20);
            this.enderecoLabel.TabIndex = 87;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(371, 361);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(738, 26);
            this.enderecoTextBox.TabIndex = 86;
            // 
            // endercoResLabel
            // 
            this.endercoResLabel.AutoSize = true;
            this.endercoResLabel.Location = new System.Drawing.Point(209, 321);
            this.endercoResLabel.Name = "endercoResLabel";
            this.endercoResLabel.Size = new System.Drawing.Size(217, 20);
            this.endercoResLabel.TabIndex = 85;
            this.endercoResLabel.Text = "ENDEREÇO RESIDENCIAL:";
            this.endercoResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rgTextBox
            // 
            this.rgTextBox.Location = new System.Drawing.Point(907, 218);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(204, 26);
            this.rgTextBox.TabIndex = 84;
            // 
            // rgLabel
            // 
            this.rgLabel.AutoSize = true;
            this.rgLabel.Location = new System.Drawing.Point(863, 221);
            this.rgLabel.Name = "rgLabel";
            this.rgLabel.Size = new System.Drawing.Size(38, 20);
            this.rgLabel.TabIndex = 83;
            this.rgLabel.Text = "RG:";
            this.rgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(907, 169);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(204, 26);
            this.cpfTextBox.TabIndex = 82;
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(855, 171);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(44, 20);
            this.cpfLabel.TabIndex = 81;
            this.cpfLabel.Text = "CPF:";
            this.cpfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(371, 171);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(446, 26);
            this.nomeTextBox.TabIndex = 80;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(209, 221);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(156, 20);
            this.dataLabel.TabIndex = 79;
            this.dataLabel.Text = "Data de nascimento:";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(309, 174);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(55, 20);
            this.nomeLabel.TabIndex = 78;
            this.nomeLabel.Text = "Nome:";
            this.nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 37);
            this.label1.TabIndex = 77;
            this.label1.Text = "CADASTRO DE BARBEIRO";
            // 
            // FormBarbeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 960);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.ufTextBox);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.celularLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.dadosPessoaisLabel);
            this.Controls.Add(this.municipioTextBox);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.municipioLabel);
            this.Controls.Add(this.cepLabel);
            this.Controls.Add(this.bairroLabel);
            this.Controls.Add(this.sexoLabel);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.endercoResLabel);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(this.rgLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.label1);
            this.Name = "FormBarbeiro";
            this.Text = "Cadastro de Barbeiro";
            this.Load += new System.EventHandler(this.FormBarbeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn coID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn coRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn coEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn coBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn coUF;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Label dadosPessoaisLabel;
        private System.Windows.Forms.TextBox municipioTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.Label ufLabel;
        private System.Windows.Forms.Label municipioLabel;
        private System.Windows.Forms.Label cepLabel;
        private System.Windows.Forms.Label bairroLabel;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label endercoResLabel;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.Label rgLabel;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label label1;
    }
}