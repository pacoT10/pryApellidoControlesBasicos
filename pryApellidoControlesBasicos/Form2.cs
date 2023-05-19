using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


            if (chkpicante.Checked == true)
            
               lblEscribirTexto.Text = "picante exe";
           

            if (chkmayo.Checked == true)
                lblEscribirTexto.Text = "mayonesaaa";
           
            if (chkKet.Checked == true)
                lblEscribirTexto.Text = "Kett";
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
