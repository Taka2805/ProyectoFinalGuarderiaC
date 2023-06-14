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

namespace ProyectoFinal
{
    public partial class Form4 : Form
    {
        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
            cbmon.Items.Add("BOB");
            cbmon.Items.Add("USD");
            cbmon.Items.Add("EUR");
            cbmon.Items.Add("MXN");
            cbmon.SelectedItem = "BOB";

            cbtipoc.Items.Add("Cuenta Corriente");
            cbtipoc.Items.Add("Caja de Ahorros");
            cbtipoc.SelectedItem = "Caja de Ahorros";
        }

        private void brevprof_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM PersonasAut";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillapersaut.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idpers = tcipersaut.Text;
            string nombre = tnom.Text;
            string direccion = tdir.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO PersonasAut VALUES (@valor1, @valor2, @valor3)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idpers);
                    command.Parameters.AddWithValue("@valor2", nombre);
                    command.Parameters.AddWithValue("@valor3", direccion);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bregtelf_Click(object sender, EventArgs e)
        {
            string idtelf = tid.Text;
            string idpers = tci.Text;
            string ntelf = telf.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Telefono VALUES (@valor1, @valor2, @valor3)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idtelf);
                    command.Parameters.AddWithValue("@valor2", idpers);
                    command.Parameters.AddWithValue("@valor3", ntelf);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btelf_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Telefono";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillatelf.DataSource = dataTable;
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

                    
                    string query = "SELECT * FROM Bancos";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillabanco.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numc = tnumc.Text;
            string idpers = tci2.Text;
            string moneda = cbmon.SelectedItem.ToString();
            string tipocuenta = cbtipoc.SelectedItem.ToString();
            string banco = tban.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO CuentaBcos VALUES (@valor1, @valor2, @valor3, @valor4, @valor5)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", numc);
                    command.Parameters.AddWithValue("@valor2", idpers);
                    command.Parameters.AddWithValue("@valor3", moneda);
                    command.Parameters.AddWithValue("@valor4", tipocuenta);
                    command.Parameters.AddWithValue("@valor5", idpers);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tcipersaut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
