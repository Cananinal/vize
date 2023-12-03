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
    public partial class pazartesi : Form
    {
        private string corba = "";
        private string yemek = "";
        private string tatli = "";
        private int kalori = 0;

        public pazartesi()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Gerekirse burada başka işlemler yapabilirsiniz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                corba = radioButton1.Text;
                kalori += 95;
            }
            else if (radioButton2.Checked == true)
            {
                corba = radioButton2.Text;
                kalori += 67;
            }

            if (radioButton3.Checked == true)
            {
                yemek = radioButton3.Text;
                kalori += 322;
            }
            else if (radioButton4.Checked == true)
            {
                yemek = radioButton4.Text;
                kalori += 465;
            }

            if (radioButton5.Checked == true)
            {
                tatli = radioButton5.Text;
                kalori += 184;
            }
            else if (radioButton6.Checked == true)
            {
                tatli = radioButton6.Text;
                kalori += 443;
            }

            // Kalori değerini etikete yazdır
            label1.Text = kalori.ToString();
        }
    }
}

