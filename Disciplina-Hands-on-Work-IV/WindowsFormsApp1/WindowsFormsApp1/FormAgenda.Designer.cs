namespace WindowsFormsApp1
{
    partial class FormAgenda
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.excluirButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.dataLabel = new System.Windows.Forms.Label();
            this.servicoLabel = new System.Windows.Forms.Label();
            this.barbeiroLabel = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coBarbeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.barbeiroComboBox = new System.Windows.Forms.ComboBox();
            this.servicoComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(118, 120);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(180, 26);
            this.idTextBox.TabIndex = 110;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(80, 126);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 20);
            this.idLabel.TabIndex = 109;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(650, 294);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(128, 40);
            this.limparButton.TabIndex = 108;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coID,
            this.coCliente,
            this.coBarbeiro,
            this.coServico,
            this.coDataHora});
            this.dataGridView.Location = new System.Drawing.Point(41, 382);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(817, 365);
            this.dataGridView.TabIndex = 100;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(496, 294);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(128, 40);
            this.excluirButton.TabIndex = 99;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(332, 294);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(130, 42);
            this.atualizarButton.TabIndex = 98;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(168, 294);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(130, 40);
            this.inserirButton.TabIndex = 97;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(521, 213);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(117, 20);
            this.dataLabel.TabIndex = 83;
            this.dataLabel.Text = "Data e Horário:";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // servicoLabel
            // 
            this.servicoLabel.AutoSize = true;
            this.servicoLabel.Location = new System.Drawing.Point(573, 167);
            this.servicoLabel.Name = "servicoLabel";
            this.servicoLabel.Size = new System.Drawing.Size(65, 20);
            this.servicoLabel.TabIndex = 81;
            this.servicoLabel.Text = "Serviço:";
            this.servicoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barbeiroLabel
            // 
            this.barbeiroLabel.AutoSize = true;
            this.barbeiroLabel.Location = new System.Drawing.Point(37, 214);
            this.barbeiroLabel.Name = "barbeiroLabel";
            this.barbeiroLabel.Size = new System.Drawing.Size(73, 20);
            this.barbeiroLabel.TabIndex = 79;
            this.barbeiroLabel.Text = "Barbeiro:";
            this.barbeiroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(50, 170);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(62, 20);
            this.clienteLabel.TabIndex = 78;
            this.clienteLabel.Text = "Cliente:";
            this.clienteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 37);
            this.label1.TabIndex = 77;
            this.label1.Text = "RESERVA DE HORÁRIO";
            // 
            // coID
            // 
            this.coID.HeaderText = "ID";
            this.coID.MinimumWidth = 8;
            this.coID.Name = "coID";
            this.coID.ReadOnly = true;
            this.coID.Width = 150;
            // 
            // coCliente
            // 
            this.coCliente.HeaderText = "Cliente";
            this.coCliente.MinimumWidth = 8;
            this.coCliente.Name = "coCliente";
            this.coCliente.Width = 150;
            // 
            // coBarbeiro
            // 
            this.coBarbeiro.HeaderText = "Barbeiro";
            this.coBarbeiro.MinimumWidth = 8;
            this.coBarbeiro.Name = "coBarbeiro";
            this.coBarbeiro.Width = 150;
            // 
            // coServico
            // 
            this.coServico.HeaderText = "Serviço";
            this.coServico.MinimumWidth = 8;
            this.coServico.Name = "coServico";
            this.coServico.Width = 150;
            // 
            // coDataHora
            // 
            this.coDataHora.HeaderText = "Data e Hora";
            this.coDataHora.MinimumWidth = 8;
            this.coDataHora.Name = "coDataHora";
            this.coDataHora.Width = 150;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(118, 167);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(323, 28);
            this.clienteComboBox.TabIndex = 111;
            // 
            // barbeiroComboBox
            // 
            this.barbeiroComboBox.FormattingEnabled = true;
            this.barbeiroComboBox.Location = new System.Drawing.Point(118, 213);
            this.barbeiroComboBox.Name = "barbeiroComboBox";
            this.barbeiroComboBox.Size = new System.Drawing.Size(323, 28);
            this.barbeiroComboBox.TabIndex = 112;
            // 
            // servicoComboBox
            // 
            this.servicoComboBox.FormattingEnabled = true;
            this.servicoComboBox.Location = new System.Drawing.Point(644, 162);
            this.servicoComboBox.Name = "servicoComboBox";
            this.servicoComboBox.Size = new System.Drawing.Size(214, 28);
            this.servicoComboBox.TabIndex = 113;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(644, 207);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 26);
            this.dateTimePicker.TabIndex = 114;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 817);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.servicoComboBox);
            this.Controls.Add(this.barbeiroComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.servicoLabel);
            this.Controls.Add(this.barbeiroLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.label1);
            this.Name = "FormAgenda";
            this.Text = "Reserva de Horário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label servicoLabel;
        private System.Windows.Forms.Label barbeiroLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn coBarbeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn coServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDataHora;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox barbeiroComboBox;
        private System.Windows.Forms.ComboBox servicoComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}