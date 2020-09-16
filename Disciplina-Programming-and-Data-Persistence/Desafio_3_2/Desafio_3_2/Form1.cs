using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Estudante> estudantes = new List<Estudante>();

            estudantes.Add(new Estudante("Pedro", 10, 1, 10));
            estudantes.Add(new Estudante("João", 12, 2, 9));
            estudantes.Add(new Estudante("Maria", 9, 1, 10));
            estudantes.Add(new Estudante("Carlos", 8, 1, 8));
            estudantes.Add(new Estudante("Roberto", 10, 1, 8));

            dataGridView1.DataSource = estudantes;

        }
    }
}
