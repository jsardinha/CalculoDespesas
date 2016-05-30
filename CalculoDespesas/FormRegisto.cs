using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDespesas
{
    public partial class FormRegisto : Form
    {
        public FormRegisto()
        {
            InitializeComponent();
        }

        private void buttonRetrocede_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void limpa()
        {
            peso.Value = 0;
            valor.Value = 0;
            labelrm.Text = "";
            labelrmc.Text = "";
            labelrp.Text = "";
            labelrs.Text = "";
            labelrsc.Text = "";            
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            limpa();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Registo registo = new Registo((int)peso.Value, valor.Value);
            labelrm.Text = registo.rm();
            labelrmc.Text = registo.rmc();
            labelrp.Text = registo.rp();
            labelrs.Text = registo.rs();
            labelrsc.Text = registo.rsc();
        }


    }
}
