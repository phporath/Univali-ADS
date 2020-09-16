using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ConversorDeMoedas
{
    public partial class Conversor : Form
    {
        const double euro = 6.26;   // Cotação no dia 07/09/2020
        const double coroaSueca = 0.60;  // Cotação no dia 07/09/2020
        const double libra = 6.97;  // Cotação no dia 07/09/2020

        public Conversor()
        {
            InitializeComponent();
            txtbValor.Text = "";
            txtbValor.Focus();
            txtbValorConvertido.Text = formataValor(0.0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbValor.Text = "";
            txtbValor.Focus();
            txtbValorConvertido.Text = formataValor(0.0);
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double valor = (double.Parse(txtbValor.Text) * euro);
            txtbValorConvertido.Text = formataValorEuro(valor);
        }

        private void btnCoroaSueca_Click(object sender, EventArgs e)
        {
            double valor = (double.Parse(txtbValor.Text) * coroaSueca);
            txtbValorConvertido.Text = formataValorCoroaSueca(valor);
        }

        private void btnLibra_Click(object sender, EventArgs e)
        {
            double valor = (double.Parse(txtbValor.Text) * libra);
            txtbValorConvertido.Text = formataValorLibra(valor);
        }

        private string formataValor(double valor)
        {
            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
        }

        private string formataValorEuro(double valor)
        {
            return string.Format(CultureInfo.GetCultureInfo("de-DE"), "{0:C}", valor);
        }

        private string formataValorLibra(double valor)
        {
            return string.Format(CultureInfo.GetCultureInfo("en-GB"), "{0:C}", valor);
        }

        private string formataValorCoroaSueca(double valor)
        {
            return string.Format(CultureInfo.GetCultureInfo("sv-SV"), "{0:C}", valor);
        }

    }
}
