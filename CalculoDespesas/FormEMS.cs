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
    public partial class FormEMS : Form
    {
        public FormEMS()
        {
            InitializeComponent();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
