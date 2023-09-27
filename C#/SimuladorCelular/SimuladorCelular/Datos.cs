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

namespace SimuladorCelular
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            try
            {
                // Paso 1: Conectar a la base de datos
                string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Paso 2 y 3: Seleccionar y obtener los datos
                string query = "SELECT TRespuesta FROM guardia";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Paso 4: Vincular los datos al DataGridView
                dataGridView1.DataSource = dataTable;

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
