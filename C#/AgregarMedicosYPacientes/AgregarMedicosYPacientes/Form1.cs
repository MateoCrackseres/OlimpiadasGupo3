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

namespace AgregarMedicosYPacientes
{
    public partial class Form1 : Form
    {
        private int errores = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string INGclave;
            string[] Aclaves = new string[4];
            Aclaves[0] = "primeraclave"; Aclaves[1] = "segundaclave"; Aclaves[2] = "terceraclave"; Aclaves[3] = "cuartaclave";

            //Se verifica que la clave ingresada coincida con alguna de las predeterminadas
            INGclave = txtclave.Text;
            if (INGclave == Aclaves[0] || INGclave == Aclaves[1] || INGclave == Aclaves[2] || INGclave == Aclaves[3])
            {
                MessageBox.Show("Clave de acceso aceptada\nBienvenido", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (rdbMedicos.Checked)
                {
                    //Si el radiobutton medicos fue seleccionado se accede al apartado para agregar un nuevo medico
                    Medico medicos = new Medico();
                    this.Hide();
                    medicos.Show();
                }
                else if (rdbPacientes.Checked)
                {
                    //Si el radiobutton pacientes fue seleccionado se accede al apartado para agregar un nuevo paciente
                    Personal pacientes = new Personal();
                    this.Hide();
                    pacientes.Show();
                }
                
            }
            else
            {
                label4.Visible = false;
                label3.Visible = true;
                txtclave.Clear();
                errores++;
            }
            if (errores == 3)
            {
                //Si se superan mas de 3 intentos se cierra el programa
                MessageBox.Show("Se ha alcanzado el limite de intentos perimtidos\nSi no recuerdas tu clave de acceso consulta en el centro de analisis de datos o al supervisor de dicha area", "Intentos maximos alcanzados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            VerificarHabilitarBoton();
        }

        private void rdbMedicos_CheckedChanged(object sender, EventArgs e)
        {
            VerificarHabilitarBoton();
        }

        private void rdbPacientes_CheckedChanged(object sender, EventArgs e)
        {
            VerificarHabilitarBoton();
        }
        private void VerificarHabilitarBoton()
        {
            //Se crea una clase la cual verifica si el textbox contiene algo y alguno de los radiobutton fue seleccionado
            if ((txtclave.Text.Length !=0) && (rdbMedicos.Checked || rdbPacientes.Checked))
            {
                button1.Enabled = true;
                button1.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                button1.Enabled = false;
                button1.BackColor = Color.FromArgb(255, 128, 128);
            }

        }
    }
}
