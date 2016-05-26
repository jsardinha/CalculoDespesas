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
    }
}
