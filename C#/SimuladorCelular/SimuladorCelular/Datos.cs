using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorCelular
{
    public partial class Datos : Form
    {
        private int i = 0;
        public Datos()
        {
            InitializeComponent();
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            //Establecer la conexion con la base de datos
            string connectionString = "Server=192.168.1.107;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                //Mostrar los datos del campo TRespuesta de la tabla guardia
                string query1 = "SELECT TRespuesta FROM guardia";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection); 
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    //Agregarlos al textbox
                    i++;
                    cmbGuardia.Items.Add("Tiempo (" + i + "):" + reader1["TRespuesta"].ToString());
                }
                i = 0; 
                reader1.Close();

                string query2 = "SELECT TRespuesta FROM sala1";
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    i++;
                    cmbSala1.Items.Add("Tiempo (" + i + "):" + reader2["TRespuesta"].ToString());
                }
                i = 0;
                reader2.Close();

                string query3 = "SELECT TRespuesta FROM sala2";
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    i++;
                    cmbSala2.Items.Add("Tiempo (" + i + "):" + reader3["TRespuesta"].ToString());
                }
                i = 0;
                reader3.Close();
                
                string query4 = "SELECT TRespuesta FROM sala3";
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                MySqlDataReader reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    i++;
                    cmbSala3.Items.Add("Tiempo (" + i + "):" + reader4["TRespuesta"].ToString());
                }
                i = 0;
                reader4.Close();

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                
                string query5 = "SELECT TRespuesta FROM neguardia";
                MySqlCommand cmd5 = new MySqlCommand(query5, connection);
                MySqlDataReader reader5 = cmd5.ExecuteReader();
                while (reader5.Read())
                {
                    i++;
                    cmb1Guardia.Items.Add("Tiempo (" + i + "):" + reader5["TRespuesta"].ToString());
                }
                i = 0;
                reader5.Close();

                string query6 = "SELECT TRespuesta FROM nesala1";
                MySqlCommand cmd6 = new MySqlCommand(query6, connection);
                MySqlDataReader reader6 = cmd6.ExecuteReader();
                while (reader6.Read())
                {
                    i++;
                    cmb1Sala1.Items.Add("Tiempo (" + i + "):" + reader6["TRespuesta"].ToString());
                }
                i = 0;
                reader6.Close();

                string query7 = "SELECT TRespuesta FROM nesala2";
                MySqlCommand cmd7 = new MySqlCommand(query7, connection);
                MySqlDataReader reader7 = cmd7.ExecuteReader();
                while (reader7.Read())
                {
                    i++;
                    cmb1Sala2.Items.Add("Tiempo (" + i + "):" + reader7["TRespuesta"].ToString());
                }
                i = 0;

                reader7.Close();
                string query8 = "SELECT TRespuesta FROM nesala3";
                MySqlCommand cmd8 = new MySqlCommand(query8, connection);
                MySqlDataReader reader8 = cmd8.ExecuteReader();
                while (reader8.Read())
                {
                    i++;
                    cmb1Sala3.Items.Add("Tiempo (" + i + "):" + reader8["TRespuesta"].ToString());
                }
                i = 0;
                reader8.Close();
                //Cerrar la conexion
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 sesion = new Form1();
            this.Hide();
            sesion.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbGuardia_DropDown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Conexión con la base de datos
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                // Prepara y ejecuta la consulta para obtener el promedio
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM guardia";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Lee el valor del promedio y lo guarda en una variable
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión
                connection.Close();
            }


        }

        private void btnPSala1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM sala1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnPSala2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM sala2";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM sala3";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM neguardia";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM nesala1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM nesala2";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "SELECT AVG(TRespuesta) AS Promedio FROM nesala3";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double promedio = Convert.ToDouble(reader["Promedio"]);
                    MessageBox.Show("El tiempo de respuesta promedio es: " + promedio + " segundos", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
