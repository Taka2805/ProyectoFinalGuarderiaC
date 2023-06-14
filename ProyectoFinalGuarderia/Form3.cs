using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class Form3 : Form
    {
        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void brevprof_Click(object sender, EventArgs e) 
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Profesionales";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillaninos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            string idprof = tidprof.Text;
            string nombre = tnomprof.Text;
            string especialidad = tesp.Text;
            string direccion = tdir.Text;


            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Profesionales VALUES (@valor1, @valor2, @valor3, @valor4)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idprof);
                    command.Parameters.AddWithValue("@valor2", nombre);
                    command.Parameters.AddWithValue("@valor3", especialidad);
                    command.Parameters.AddWithValue("@valor4", direccion);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Servicios";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillaserv.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string idser = tidser.Text;
            string idprof2 = tidprof2.Text;
            string matricula = tmat.Text;
            string especialidad2 = tesp2.Text;
            DateTime fechaini = tfin.Value;
            string costo = tcost.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Servicios VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idser);
                    command.Parameters.AddWithValue("@valor2", idprof2);
                    command.Parameters.AddWithValue("@valor3", matricula);
                    command.Parameters.AddWithValue("@valor4", especialidad2);
                    command.Parameters.AddWithValue("@valor5", fechaini);
                    command.Parameters.AddWithValue("@valor6", costo);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pagos pago = new Pagos();
            pago.Show();
        }
    }
}
