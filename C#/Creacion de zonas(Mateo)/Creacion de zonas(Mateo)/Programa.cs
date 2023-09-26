using MySql.Data.MySqlClient;
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
    public partial class Programa : Form
    {
        private int contador = 0;
        public Programa()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux, zona;
            aux = textBox1.Text;
            zona = aux.Replace(" ", "");
            string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";

            MySqlConnection connection = new MySqlConnection(connectionString); //Creacion de la zona designada

            try
            {
                connection.Open();
                Console.WriteLine("Conexión establecida.");

                string createTableQuery = $"CREATE TABLE IF NOT EXISTS {zona} (" +
                                          "idAlerta INT PRIMARY KEY AUTO_INCREMENT," +
                                          "TRespuesta VARCHAR(50)" +
                                          ");";

                MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
                
                connection.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1050) // El código de error 1050 indica que la tabla ya existe
                {
                    MessageBox.Show("La zona ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
            MessageBox.Show("La zona '" + zona + "' fue agregada correctamente a la base de datos", "Zona agregada con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (textBox1.Text.Length<1)
            {
                button1.Enabled = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 60) 
            {
                MessageBox.Show("Tiempo limite exedido\nPor favor vuelva a iniciar sesion", "Tiempo exedido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
