using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastroCliente
{
    public partial class cadastroForm : Form
    {
        public cadastroForm()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "cadastroclientes";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            return conexaoBD;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO dadosclientes (idCliente,nome,cpf,rg,nasc,sexo,email,celular,endereco,bairro,municipio,cep,uf) " +
                    "VALUES('" + idTextBox.Text + "','" + nomeTextBox.Text + "', '" + cpfTextBox.Text + "', '" + rgTextBox.Text + "','" + dataTextBox.Text + "','" + sexoTextBox.Text + "','" + emailTextBox.Text + "', '" + celularTextBox.Text + "','" + enderecoTextBox.Text + "','" + bairroTextBox.Text + "','" + municipioTextBox.Text + "','" + cepTextBox.Text + "','" + ufTextBox.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                limparCampos();
                atualizarGrid();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "DELETE FROM dadosclientes WHERE idCliente = '" + idTextBox.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparCampos()
        {
            idTextBox.Clear();
            nomeTextBox.Clear();
            cpfTextBox.Clear();
            rgTextBox.Clear();
            dataTextBox.Clear();
            sexoTextBox.Clear();
            celularTextBox.Clear();
            emailTextBox.Clear();
            enderecoTextBox.Clear();
            bairroTextBox.Clear();
            municipioTextBox.Clear();
            cepTextBox.Clear();
            ufTextBox.Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                idTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coID"].FormattedValue.ToString();
                nomeTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coNome"].FormattedValue.ToString();
                cpfTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coCPF"].FormattedValue.ToString();
                rgTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coRG"].FormattedValue.ToString();
                dataTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coDataNascimento"].FormattedValue.ToString();
                sexoTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coSexo"].FormattedValue.ToString();
                emailTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coEmail"].FormattedValue.ToString();
                celularTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coCelular"].FormattedValue.ToString();              
                enderecoTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coEndereco"].FormattedValue.ToString();
                bairroTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coBairro"].FormattedValue.ToString();
                municipioTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coMunicipio"].FormattedValue.ToString();
                cepTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coCEP"].FormattedValue.ToString();
                ufTextBox.Text = dataGridView.Rows[e.RowIndex].Cells["coUF"].FormattedValue.ToString();
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE dadosclientes SET nome = '" + nomeTextBox.Text + "', cpf = '" + cpfTextBox.Text + "', rg = '" + rgTextBox.Text + "', nasc = '" + dataTextBox.Text + "', sexo = '" + sexoTextBox.Text + "', email = '" + emailTextBox.Text + "', celular = '" + celularTextBox.Text + "', endereco = '" + enderecoTextBox.Text + "', bairro = '" + bairroTextBox.Text + "', municipio = '" + municipioTextBox.Text + "', cep = '" + cepTextBox.Text + "', uf = '" + ufTextBox.Text + "' WHERE idCliente = " + idTextBox.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }

        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM dadosclientes";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(12);//idCliente
                    row.Cells[1].Value = reader.GetString(0);//nome
                    row.Cells[2].Value = reader.GetInt32(1);//cpf
                    row.Cells[3].Value = reader.GetInt32(2);//rg
                    row.Cells[4].Value = reader.GetString(3);//nasc
                    row.Cells[5].Value = reader.GetString(4);//sexo
                    row.Cells[6].Value = reader.GetString(5);//email
                    row.Cells[7].Value = reader.GetInt32(6);//celular
                    row.Cells[8].Value = reader.GetString(7);//endereco
                    row.Cells[9].Value = reader.GetString(8);//bairro
                    row.Cells[10].Value = reader.GetString(9);//municipio
                    row.Cells[11].Value = reader.GetInt32(10);//cep
                    row.Cells[12].Value = reader.GetString(11);//uf
                    dataGridView.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        //private void cadastroclientes_Load(object sender, EventArgs e)
        //{
        //    atualizarGrid();
        //}

        private void limparButton_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void cadastroForm_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
    }
}
