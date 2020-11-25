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

namespace WindowsFormsApp1
{
    public partial class FormBarbeiro : Form
    {
        public FormBarbeiro()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "barbearia";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            return conexaoBD;
        }

        private void inserirButton_Click_1(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO dadosbarbeiro (idBarbeiro,nome,cpf,rg,nasc,sexo,email,celular,endereco,bairro,municipio,cep,uf) " +
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

        private void excluirButton_Click_1(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "DELETE FROM dadosbarbeiro WHERE idBarbeiro = '" + idTextBox.Text + "'";
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

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void atualizarButton_Click_1(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE dadosbarbeiro SET nome = '" + nomeTextBox.Text + "', cpf = '" + cpfTextBox.Text + "', rg = '" + rgTextBox.Text + "', nasc = '" + dataTextBox.Text + "', sexo = '" + sexoTextBox.Text + "', email = '" + emailTextBox.Text + "', celular = '" + celularTextBox.Text + "', endereco = '" + enderecoTextBox.Text + "', bairro = '" + bairroTextBox.Text + "', municipio = '" + municipioTextBox.Text + "', cep = '" + cepTextBox.Text + "', uf = '" + ufTextBox.Text + "' WHERE idBarbeiro = " + idTextBox.Text + "";
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
                comandoMySql.CommandText = "SELECT * FROM dadosbarbeiro";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//idBarbeiro
                    row.Cells[1].Value = reader.GetString(2);//nome
                    row.Cells[2].Value = reader.GetInt32(1);//cpf
                    row.Cells[3].Value = reader.GetInt32(4);//rg
                    row.Cells[4].Value = reader.GetString(3);//nasc
                    row.Cells[5].Value = reader.GetString(5);//sexo
                    row.Cells[6].Value = reader.GetString(6);//email
                    row.Cells[7].Value = reader.GetInt32(7);//celular
                    row.Cells[8].Value = reader.GetString(8);//endereco
                    row.Cells[9].Value = reader.GetString(10);//bairro
                    row.Cells[10].Value = reader.GetString(11);//municipio
                    row.Cells[11].Value = reader.GetInt32(9);//cep
                    row.Cells[12].Value = reader.GetString(12);//uf
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

        private void limparButton_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void FormBarbeiro_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }


    }
}
