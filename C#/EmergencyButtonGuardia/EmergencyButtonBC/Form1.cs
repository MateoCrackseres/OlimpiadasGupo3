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
using System.Media;
using MySql.Data.MySqlClient;

namespace EmergencyButtonBC
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=dbcodigoazul;User=root;Password=;";
        private double contador=0;
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión con la base de datos establecida.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.FromArgb(180, 0, 60);
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(180, 0, 60);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.FromArgb(199, 0, 57);
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(199, 0, 57);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            contador.ToString();
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer Alerta = new SoundPlayer();
            Alerta.SoundLocation = "C:/Users/matre/OneDrive/Escritorio/Olimpiadas/OlimpiadasGupo3/Documentacion/GuardiaEmergencia.wav";
            Alerta.PlayLooping();


            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnStop.Enabled = true;
            btnStop.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SoundPlayer Alerta = new SoundPlayer();
            Alerta.SoundLocation = "C:/Users/matre/OneDrive/Escritorio/Olimpiadas/OlimpiadasGupo3/Documentacion/GuardiaEmergencia.wav";
            Alerta.Stop();
            btnStart.Enabled = true;
            btnStart.Visible = true;
            btnStop.Enabled = false;
            btnStop.Visible = false;
            string query = "INSERT INTO guardia (TRespuesta) VALUES (@TRespuesta)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión establecida.");
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TRespuesta", contador); // Reemplaza "valor1" con el valor que deseas guardar

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
                MessageBox.Show(contador.ToString());
                timer1.Stop();
                contador = 0;
            }
        }

        private void btnStop_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(180, 0, 60);
            btnStop.FlatAppearance.BorderColor = Color.FromArgb(180, 0, 60);
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(199, 0, 57);
            btnStop.FlatAppearance.BorderColor = Color.FromArgb(199, 0, 57);
        }

        
    }
}
