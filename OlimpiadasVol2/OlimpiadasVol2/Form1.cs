using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            timer1.Enabled = true;
            

            if (sliderButton1.Checked == false) 
            {
                if (customComboBox1.SelectedIndex == 0 ) 
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/GuardiaEmergencia.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
                if (customComboBox1.SelectedIndex == 1)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/Sala1Emergencia.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
                if (customComboBox1.SelectedIndex == 2)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/Sala2Emergencia.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
                if (customComboBox1.SelectedIndex == 3)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/Sala3Emergencia.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
            }
            else 
            {
                if (customComboBox1.SelectedIndex == 0)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/NEGuardia.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
                if (customComboBox1.SelectedIndex == 1)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/NESala1.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
                if (customComboBox1.SelectedIndex == 2)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/NESala2.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
                if (customComboBox1.SelectedIndex == 3)
                {
                    SoundPlayer Alerta = new SoundPlayer();
                    Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/NESala3.wav";
                    Alerta.PlayLooping();

                    btnAlarma.Enabled = false;
                    btnAlarma.Visible = false;
                    btnAlarmaStop.Enabled = true;
                    btnAlarmaStop.Visible = true;
                }
            }

     
        }

        private void sliderButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (sliderButton1.Checked) 
            {
                panel1.BackColor = Color.FromArgb(49, 70, 80);
                txtTitulo.ForeColor = Color.White;
                txtTitulo.Text = "Medical No Emegercy - Green Code";
                this.BackColor = Color.FromArgb(49, 55, 62);

                btnAlarma.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\BotonVerde.png");

                btnAlarmaStop.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\BotonVerde.png");

                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\Icono_verde.png");

                pictureBox2.Image = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\doctorVerde.png");

                customComboBox1.BorderColor = Color.Green;
                customComboBox1.IconColor = Color.Green;
            }
            else 
            {
                this.BackColor = Color.FromArgb(32, 47, 66);
                txtTitulo.ForeColor = Color.White;
                txtTitulo.Text = "Medical Emegercy - Blue Code";
                panel1.BackColor = Color.FromArgb(23, 35, 49);

                btnAlarma.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\BotonAzul.png");

                btnAlarmaStop.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\BotonRojo.png");

                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\Icono_azul.png");

                pictureBox2.Image = Image.FromFile(@"C:\Users\Usuario\Desktop\Olimpiadas 2023 - grupo 3\OlimpiadasGupo3\Documentacion\doctorAzul.png");

                customComboBox1.BorderColor = Color.Blue;
                customComboBox1.IconColor = Color.Blue;
            }
        }

        private void btnAlarmaStop_Click(object sender, EventArgs e)
        {
            SoundPlayer Alerta = new SoundPlayer();
            Alerta.SoundLocation = "C:/Users/Usuario/Desktop/Olimpiadas 2023 - grupo 3/OlimpiadasGupo3/Documentacion/GuardiaEmergencia.wav";
            Alerta.Stop();

            btnAlarma.Enabled = true;
            btnAlarma.Visible = true;
            btnAlarmaStop.Enabled = false;
            btnAlarmaStop.Visible = false;
        }
    }
}
