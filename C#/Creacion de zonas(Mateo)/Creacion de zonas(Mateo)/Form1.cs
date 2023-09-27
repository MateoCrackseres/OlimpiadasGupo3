using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creacion_de_zonas_Mateo_
{
    public partial class Form1 : Form
    {
        private int errores = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string INGclave;
            string[] Aclaves = new string[4];
            Aclaves[0] = "primeraclave"; Aclaves[1] = "segundaclave"; Aclaves[2] = "terceraclave"; Aclaves[3] = "cuartaclave";
            
            //Se verifica que la clave ingresada coincida con las claves predeterminadas
                INGclave = txtclave.Text;
            if (INGclave == Aclaves[0] || INGclave == Aclaves[1] || INGclave == Aclaves[2] || INGclave == Aclaves[3])
            {
                MessageBox.Show("Clave de acceso aceptada\nBienvenido", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Se abre el apartado para agregar una nueva zona
                Programa configuracion = new Programa();
                this.Hide();
                configuracion.Show();
            }
            else
            {
                label4.Visible = false;
                label3.Visible = true;
                txtclave.Clear();
                errores++;
            }
            //Se cierra el programa si los intentos permitidos son mas de 3
            if(errores == 3)
            {
                MessageBox.Show("Se ha alcanzado el limite de intentos perimtidos\nSi no recuerdas tu clave de acceso consulta en el centro de analisis de datos o al supervisor de dicha area", "Intentos maximos alcanzados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
    }
}
