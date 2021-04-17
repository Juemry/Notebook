using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp4;
using WindowsFormsApp7;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void radioButtonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Creo el formulario que deseo mostrar
            frmRadioButton ofrmRadioButton = new frmRadioButton();
            //Digo que es Hijo del MDI
            ofrmRadioButton.MdiParent = this;
            //Muestro el form
            ofrmRadioButton.Show();
        }

        private void checkBoxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Creo el formulario que deseo mostrar
            frmCheckBox ofrmCheckBox = new frmCheckBox();
            //Digo que es Hijo del MDI
            ofrmCheckBox.MdiParent = this;
            //Muestro el form
            ofrmCheckBox.Show();
        }

        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creo el formulario que deseo mostrar
            frmGroupBox ofrmGroupBox = new frmGroupBox();
            //Digo que es Hijo del MDI
            ofrmGroupBox.MdiParent = this;
            //Muestro el form
            ofrmGroupBox.Show();
        }
    }
}
