using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lıste
{
    public partial class çarşamba : Form
    {
        private string corba = "";
        private string yemek = "";
        private string tatli = "";
        private int kalori = 0;
        public çarşamba()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                corba = radioButton1.Text;
                kalori += 112;
            }
            else if (radioButton2.Checked == true)
            {
                corba = radioButton2.Text;
                kalori += 95;
            }

            if (radioButton3.Checked == true)
            {
                yemek = radioButton3.Text;
                kalori += 73;
            }
            else if (radioButton4.Checked == true)
            {
                yemek = radioButton4.Text;
                kalori += 185;
            }

            if (radioButton5.Checked == true)
            {
                tatli = radioButton5.Text;
                kalori += 266;
            }
            else if (radioButton6.Checked == true)
            {
                tatli = radioButton6.Text;
                kalori += 424;
            }

            // Kalori değerini etikete yazdır
            label1.Text = kalori.ToString();
        }

    }
}
