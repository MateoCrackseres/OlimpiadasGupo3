using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorCelular
{
    public partial class Form1 : Form
    {
        private int error = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contra = "clavedeacceso";
            string usuario = "admin";
            //Verificar si el ususario y la clave coinciden
            if(txtUsuario.Text.Length < 1 || txtPassword.Text.Length < 1 ) 
            {
                MessageBox.Show("Rellena ambos campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtUsuario.Text.Trim() == usuario && txtPassword.Text == contra)
                {
                    MessageBox.Show("Datos validados correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Datos nuevoform = new Datos();
                    this.Hide();
                    nuevoform.Show();
                }
                else
                {
                    error++;
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    if(error == 3)
                    {
                        MessageBox.Show("Se han exedido los intentos maximos premitidos\nSi no recuerdas tu contraseña consulta con tu superior","Limite", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
