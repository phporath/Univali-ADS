namespace cadastroCliente
{
    partial class cadastroForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.rgLabel = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.endercoResLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.cepLabel = new System.Windows.Forms.Label();
            this.municipioLabel = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.municipioTextBox = new System.Windows.Forms.TextBox();
            this.dadosPessoaisLabel = new System.Windows.Forms.Label();
            this.inserirButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.emailLabel = new System.Windows.Forms.Label();
            this.celularLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.helpButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CLIENTE";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(75, 109);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            this.nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(8, 140);
            this.dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(105, 13);
            this.dataLabel.TabIndex = 2;
            this.dataLabel.Text = "Data de nascimento:";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(116, 107);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(299, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(473, 106);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(137, 20);
            this.cpfTextBox.TabIndex = 6;
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(439, 107);
            this.cpfLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(30, 13);
            this.cpfLabel.TabIndex = 5;
            this.cpfLabel.Text = "CPF:";
            this.cpfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rgTextBox
            // 
            this.rgTextBox.Location = new System.Drawing.Point(473, 138);
            this.rgTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(137, 20);
            this.rgTextBox.TabIndex = 8;
            // 
            // rgLabel
            // 
            this.rgLabel.AutoSize = true;
            this.rgLabel.Location = new System.Drawing.Point(444, 140);
            this.rgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rgLabel.Name = "rgLabel";
            this.rgLabel.Size = new System.Drawing.Size(26, 13);
            this.rgLabel.TabIndex = 7;
            this.rgLabel.Text = "RG:";
            this.rgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(116, 231);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(493, 20);
            this.enderecoTextBox.TabIndex = 10;
            // 
            // endercoResLabel
            // 
            this.endercoResLabel.AutoSize = true;
            this.endercoResLabel.Location = new System.Drawing.Point(8, 205);
            this.endercoResLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endercoResLabel.Name = "endercoResLabel";
            this.endercoResLabel.Size = new System.Drawing.Size(144, 13);
            this.endercoResLabel.TabIndex = 9;
            this.endercoResLabel.Text = "ENDEREÇO RESIDENCIAL:";
            this.endercoResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.endercoResLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1859, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Município de nascimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1869, 510);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de nascimento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2812, 773);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de nascimento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(57, 233);
            this.enderecoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(56, 13);
            this.enderecoLabel.TabIndex = 14;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1909, 510);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "RG:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2871, 773);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "RG:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(632, 140);
            this.sexoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(34, 13);
            this.sexoLabel.TabIndex = 17;
            this.sexoLabel.Text = "Sexo:";
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.Location = new System.Drawing.Point(75, 261);
            this.bairroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(37, 13);
            this.bairroLabel.TabIndex = 19;
            this.bairroLabel.Text = "Bairro:";
            this.bairroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Location = new System.Drawing.Point(630, 233);
            this.cepLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(31, 13);
            this.cepLabel.TabIndex = 20;
            this.cepLabel.Text = "CEP:";
            this.cepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // municipioLabel
            // 
            this.municipioLabel.AutoSize = true;
            this.municipioLabel.Location = new System.Drawing.Point(325, 261);
            this.municipioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.municipioLabel.Name = "municipioLabel";
            this.municipioLabel.Size = new System.Drawing.Size(57, 13);
            this.municipioLabel.TabIndex = 21;
            this.municipioLabel.Text = "Município:";
            this.municipioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Location = new System.Drawing.Point(637, 260);
            this.ufLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(24, 13);
            this.ufLabel.TabIndex = 22;
            this.ufLabel.Text = "UF:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(116, 259);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(196, 20);
            this.bairroTextBox.TabIndex = 23;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(667, 231);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(123, 20);
            this.cepTextBox.TabIndex = 24;
            // 
            // municipioTextBox
            // 
            this.municipioTextBox.Location = new System.Drawing.Point(381, 259);
            this.municipioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.municipioTextBox.Name = "municipioTextBox";
            this.municipioTextBox.Size = new System.Drawing.Size(228, 20);
            this.municipioTextBox.TabIndex = 25;
            // 
            // dadosPessoaisLabel
            // 
            this.dadosPessoaisLabel.AutoSize = true;
            this.dadosPessoaisLabel.Location = new System.Drawing.Point(8, 79);
            this.dadosPessoaisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dadosPessoaisLabel.Name = "dadosPessoaisLabel";
            this.dadosPessoaisLabel.Size = new System.Drawing.Size(104, 13);
            this.dadosPessoaisLabel.TabIndex = 27;
            this.dadosPessoaisLabel.Text = "DADOS PESSOAIS:";
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(381, 307);
            this.inserirButton.Margin = new System.Windows.Forms.Padding(2);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(87, 26);
            this.inserirButton.TabIndex = 28;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(491, 307);
            this.atualizarButton.Margin = new System.Windows.Forms.Padding(2);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(87, 27);
            this.atualizarButton.TabIndex = 29;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(600, 307);
            this.excluirButton.Margin = new System.Windows.Forms.Padding(2);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(85, 26);
            this.excluirButton.TabIndex = 30;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(11, 354);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(777, 237);
            this.dataGridView.TabIndex = 31;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(74, 170);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 32;
            this.emailLabel.Text = "E-mail:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.Location = new System.Drawing.Point(427, 170);
            this.celularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(42, 13);
            this.celularLabel.TabIndex = 33;
            this.celularLabel.Text = "Celular:";
            this.celularLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(116, 168);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(299, 20);
            this.emailTextBox.TabIndex = 34;
            // 
            // celularTextBox
            // 
            this.celularTextBox.Location = new System.Drawing.Point(473, 168);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(317, 20);
            this.celularTextBox.TabIndex = 35;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(703, 25);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(77, 20);
            this.helpButton.TabIndex = 36;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(116, 137);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(299, 20);
            this.dataTextBox.TabIndex = 37;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.Location = new System.Drawing.Point(669, 137);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(121, 20);
            this.sexoTextBox.TabIndex = 38;
            // 
            // ufTextBox
            // 
            this.ufTextBox.Location = new System.Drawing.Point(667, 258);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(123, 20);
            this.ufTextBox.TabIndex = 39;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(703, 307);
            this.limparButton.Margin = new System.Windows.Forms.Padding(2);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(85, 26);
            this.limparButton.TabIndex = 40;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(644, 110);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 41;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(669, 106);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 42;
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // coID
            // 
            this.coID.HeaderText = "ID";
            this.coID.Name = "coID";
            this.coID.ReadOnly = true;
            // 
            // coNome
            // 
            this.coNome.HeaderText = "Nome";
            this.coNome.Name = "coNome";
            // 
            // coCPF
            // 
            this.coCPF.HeaderText = "CPF";
            this.coCPF.Name = "coCPF";
            // 
            // coRG
            // 
            this.coRG.HeaderText = "RG";
            this.coRG.Name = "coRG";
            // 
            // coDataNascimento
            // 
            this.coDataNascimento.HeaderText = "Data de Nascimento";
            this.coDataNascimento.Name = "coDataNascimento";
            // 
            // coSexo
            // 
            this.coSexo.HeaderText = "Sexo";
            this.coSexo.Name = "coSexo";
            // 
            // coEmail
            // 
            this.coEmail.HeaderText = "E-mail";
            this.coEmail.Name = "coEmail";
            // 
            // coCelular
            // 
            this.coCelular.HeaderText = "Celular";
            this.coCelular.Name = "coCelular";
            // 
            // coEndereco
            // 
            this.coEndereco.HeaderText = "Endereço";
            this.coEndereco.Name = "coEndereco";
            // 
            // coBairro
            // 
            this.coBairro.HeaderText = "Bairro";
            this.coBairro.Name = "coBairro";
            // 
            // coMunicipio
            // 
            this.coMunicipio.HeaderText = "Município";
            this.coMunicipio.Name = "coMunicipio";
            // 
            // coCEP
            // 
            this.coCEP.HeaderText = "CEP";
            this.coCEP.Name = "coCEP";
            // 
            // coUF
            // 
            this.coUF.HeaderText = "UF";
            this.coUF.Name = "coUF";
            // 
            // cadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 602);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.ufTextBox);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.helpButton);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cadastroForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.cadastroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.Label rgLabel;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label endercoResLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.Label bairroLabel;
        private System.Windows.Forms.Label cepLabel;
        private System.Windows.Forms.Label municipioLabel;
        private System.Windows.Forms.Label ufLabel;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox municipioTextBox;
        private System.Windows.Forms.Label dadosPessoaisLabel;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
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
    }
}

