using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgregarMedicosYPacientes
{
    public partial class Personal : Form
    {
        private int errores = 0;
        public Personal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string clave;
            string[] acceso = new string[4];
            acceso[0] = "primeraclave"; acceso[1] = "segundaclave"; acceso[2] = "terceraclave"; acceso[3] = "cuartaclave";
            clave = txtVerificar.Text;
            if (clave == acceso[0] || clave == acceso[1] || clave == acceso[2] || clave == acceso[3])
            {
                btnAGP.Enabled = true;
                txtVerificar.Clear();
                btnAGP.BackColor = Color.Honeydew;
            }
            else
            {
                txtVerificar.Clear();
                errores++;
            }
            if (errores == 3)
            {
                MessageBox.Show("Se ha alcanzado el limite de intentos perimtidos\nSi no recuerdas tu clave de acceso consulta en el centro de analisis de datos o al supervisor de dicha area", "Intentos maximos alcanzados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void btnAGP_Click(object sender, EventArgs e)
        {
            bool band = false;
            if (txtHC.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDNI.Text.Length == 0 || txtDireccion.Text.Length == 0 || txtEdad.Text.Length == 0 || txtDia.Text.Length == 0 || txtMes.Text.Length == 0 || txtYear.Text.Length == 0 || cmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor rellena todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAGP.Enabled = false;
                btnAGP.BackColor = Color.LightGreen;
            }
            else
            {
                string historiaclinica = txtHC.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDNI.Text;
                string direccion = txtDireccion.Text;
                int edad = int.Parse(txtEdad.Text);
                string fecha;
                char[] sexo = new char[3];
                int estado = 1;
                if (cmbSexo.SelectedIndex == 0)
                {
                    sexo[0] = 'M';
                }
                else if (cmbSexo.SelectedIndex == 1)
                {
                    sexo[1] = 'F';
                }
                else if (cmbSexo.SelectedIndex == 2)
                {
                    sexo[2] = 'X';
                }
                dni.Replace(".", "");

                fecha = txtDia.Text + "/" + txtMes.Text + "/" + txtYear.Text;

                string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO pacientes (histClinica, nombre, apellido, dni, edad, direccion, nacimiento, sexo, estado) VALUES (@histClinica, @nombre, @apellido, @dni, @edad, @direccion, @nacimiento, @sexo, @estado)";


                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@histClinica", historiaclinica);
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@apellido", apellido);
                            command.Parameters.AddWithValue("@dni", dni);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@direccion", direccion);
                            command.Parameters.AddWithValue("@nacimiento", fecha);
                            command.Parameters.AddWithValue("@sexo", sexo);
                            command.Parameters.AddWithValue("@estado", estado);

                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Datos agregados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    }
                }
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
