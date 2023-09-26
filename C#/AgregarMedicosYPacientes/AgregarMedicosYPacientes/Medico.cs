using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgregarMedicosYPacientes
{
    public partial class Medico : Form
    {
        private int errores = 0;
        public Medico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clave;
            string[] acceso = new string[4];
            acceso[0] = "primeraclave"; acceso[1] = "segundaclave"; acceso[2] = "terceraclave"; acceso [3] = "cuartaclave";
            clave = txtVerificar.Text;
            if (clave == acceso[0] || clave == acceso[1] || clave == acceso[2] || clave == acceso[3])
            {
                btnAGM.Enabled = true;
                txtVerificar.Clear();
                btnAGM.BackColor = Color.Honeydew;
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

        private void btnAGM_Click(object sender, EventArgs e)
        {
            bool band = false;
            if (txtLegajo.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDNI.Text.Length == 0 || txtEdad.Text.Length == 0 || txtDia.Text.Length == 0 || txtMes.Text.Length == 0 || txtYear.Text.Length == 0 || txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Por favor rellena todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAGM.Enabled = false;
                btnAGM.BackColor = Color.LightGreen;
            }
            else
            {
                string legajo = txtLegajo.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDNI.Text;
                int edad = int.Parse(txtEdad.Text);
                string fecha;
                string telefono = txtTelefono.Text;
                int estado = 1;

                dni.Replace(".", "");

                fecha = txtDia.Text + "/" + txtMes.Text + "/" + txtYear.Text;

                string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO enfermeros (legajo, nombre, apellido, dni, edad, nacimiento, telefono, estado) VALUES (@legajo, @nombre, @apellido, @dni, @edad, @nacimiento, @telefono, @estado)";


                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@legajo", legajo);
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@apellido", apellido);
                            command.Parameters.AddWithValue("@dni", dni);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@nacimiento", fecha);
                            command.Parameters.AddWithValue("@telefono", telefono);
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
