using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmergencyButtonBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.FromArgb(19, 83, 155);
            button1.FlatAppearance.BorderColor=Color.FromArgb(19, 83, 155);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.FromArgb(20, 100, 170);
            button1.FlatAppearance.BorderColor = Color.FromArgb(20, 100, 170);
        }
    }
}
