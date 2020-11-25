using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void clienteButton_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barbeiroButton_Click(object sender, EventArgs e)
        {
            FormBarbeiro frm = new FormBarbeiro();
            frm.Show();
        }

        private void reservarButton_Click(object sender, EventArgs e)
        {
            FormAgenda frm = new FormAgenda();
            frm.Show();
        }
    }
}
