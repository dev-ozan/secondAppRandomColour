using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;


        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 0);

        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(redText.Text);
            int blue = Convert.ToInt32(blueText.Text);
            int green = Convert.ToInt32(greenText.Text);
            this.BackColor = Color.FromArgb(red, blue, green);

        }
    }
}
