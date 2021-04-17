using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            if ((this.Chk1.Checked == true) & (this.Chk2.Checked == false))
            {
                Lbl1.BackColor = Color.Aquamarine;
                Lbl2.BackColor = Color.Beige;
                Lbl3.BackColor = Color.Black;
            }
            if ((Chk1.Checked == false) & (Chk2.Checked == true))
            {
                Lbl1.BackColor = Color.Green;
                Lbl2.BackColor = Color.LightPink;
                Lbl3.BackColor = Color.Linen;
            }
            if ((Chk1.Checked == true) & (Chk2.Checked == true))
            {
                Lbl1.BackColor = Color.Blue;
                Lbl2.BackColor = Color.White;
                Lbl3.BackColor = Color.Blue;
            }
        }

        private void bttnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
