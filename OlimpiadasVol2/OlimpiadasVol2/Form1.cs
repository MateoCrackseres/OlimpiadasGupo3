using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlimpiadasVol2
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

        private void sliderButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (sliderButton1.Checked) 
            {
                this.BackColor = Color.FromArgb(154, 5, 38);
                txtTitulo.Text = "Medical Emegercy";
                panel1.BackColor = Color.FromArgb(106, 4, 26);

                btnAlarma.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\BotonRojo.png");

                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\Icono_rojo.png");

                pictureBox2.Image = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\doctorRojo.png");

                customComboBox2.BorderColor = Color.Red;
                customComboBox2.IconColor = Color.Red;
            }
            else 
            {
                this.BackColor = Color.FromArgb(32, 47, 66);
                txtTitulo.Text = "Medical No Emegercy";
                panel1.BackColor = Color.FromArgb(23, 35, 49);

                btnAlarma.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\BotonAzul.png");

                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\Icono_azul.png");

                pictureBox2.Image = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\doctorAzul.png");

                customComboBox2.BorderColor = Color.Blue;
                customComboBox2.IconColor = Color.Blue;
            }
        }
    }
}
