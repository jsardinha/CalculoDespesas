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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }
        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Form w in Application.OpenForms)
            {
                if (w is FormRegisto)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                FormRegisto newwindow = new FormRegisto();
                newwindow.Show();
            }
        }

        private void buttonEMS_Click(object sender, EventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Form w in Application.OpenForms)
            {
                if (w is FormEMS)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                FormEMS newwindow = new FormEMS();
                newwindow.Show();
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            {
                if (!(Application.OpenForms.Count > 1))
                {
                    Close();
                }
            }
        }

    }
}
