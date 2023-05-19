using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryApellidoControlesBasicos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoconcatenar = "";

            if (chkmayo.Checked == true)
                lblEscribirTexto.Text = "mayo";
                lblEscribirTexto.Text= textoconcatenar;

            if (chkpicante.Checked == true)
                lblEscribirTexto.Text = "picante";
          lblEscribirTexto.Text = textoconcatenar;
            if (chkKet.Checked == true)
                lblEscribirTexto.Text = "ket";
            lblEscribirTexto.Text = textoconcatenar;

            cboAdicional.Items.Add(textoconcatenar);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void cboAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEscribirTexto.Text = cboAdicional.Text;
            lblEscribirTexto.Text = cboAdicional.SelectedItem.ToString();
        }

        private void optRed_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }
    }
}
