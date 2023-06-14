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
    public partial class Form2 : Form
    {
        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "No")
            {
                tfbaj.Visible = true;
                lfbaj.Visible = true;
            }
            else
            {
                tfbaj.Visible = false;
                lfbaj.Visible = false;
            }
        }

        private void brevnin_Click(object sender, EventArgs e) 
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Infantes";
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
            
            string matricula = tmat.Text;
            string nombre = tnom.Text;
            DateTime fechanac = tfnac.Value;
            DateTime fechaalt = tfal.Value;
            string tarifa = ttarmen.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Infantes VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", matricula);
                    command.Parameters.AddWithValue("@valor2", nombre);
                    command.Parameters.AddWithValue("@valor3", fechanac);
                    command.Parameters.AddWithValue("@valor4", fechaalt);
                    if (comboBox1.SelectedItem.ToString() == "No")
                    {
                        command.Parameters.AddWithValue("@valor5", tfbaj.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@valor5", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@valor6", tarifa);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void comboalergias_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (comboalergias.SelectedItem.ToString() == "Si")
            {
                baler.Visible = true;
            }
            else
            {
                baler.Visible = false;
            }
        }

        private void baler_Click(object sender, EventArgs e) 
        {
            
            Form6 form6 = new Form6();

            
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            Fee fee = new Fee();
            fee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "Select * from MontoPagoViews";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillacargo.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) 
        {
            
            string matricula = tmat2.Text;
            string periodo = tper.Text;
            string monto = tpago.Text;
            DateTime fechapago = tfpago.Value;
            string ci = tci.Text;
            string numc = tnc.Text;
            string numtran = tntran.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO CargosMes VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6, @valor7)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", matricula);
                    command.Parameters.AddWithValue("@valor2", periodo);
                    command.Parameters.AddWithValue("@valor3", monto);
                    command.Parameters.AddWithValue("@valor4", fechapago);
                    command.Parameters.AddWithValue("@valor5", ci);
                    command.Parameters.AddWithValue("@valor6", numc);
                    command.Parameters.AddWithValue("@valor6", numtran);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"UPDATE CargosMes
                                      SET MontoPago = (SELECT MontoPago FROM MontoPagoViews WHERE MontoPagoViews.NroMatricula = CargosMes.NroMatricula)
                                      WHERE NroMatricula IN (SELECT NroMatricula FROM MontoPagoViews)";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            MessageBox.Show("Consulta ejecutada correctamente.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}