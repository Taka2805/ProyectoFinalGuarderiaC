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
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }
        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";

        private void bing_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Ingredientes";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                   
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillaing.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bplat_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                   
                    connection.Open();

                    
                    string query = "SELECT * FROM Platos";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillaplato.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void breging_Click(object sender, EventArgs e)
        {
           
            string idingrediente = tiding.Text;
            string ingrediente = ting.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Ingredientes VALUES (@valor1, @valor2)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idingrediente);
                    command.Parameters.AddWithValue("@valor2", ingrediente);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bregplat_Click(object sender, EventArgs e)
        {
           
            string idplato = tidplat.Text;
            string plato = tplat.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Platos VALUES (@valor1, @valor2)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idplato);
                    command.Parameters.AddWithValue("@valor2", plato);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bmen_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Menus";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillamen.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bregmen_Click(object sender, EventArgs e)
        {
            
            string numeromen = tnummen.Text;
            string desc = tmen.Text;
            double precio = Double.Parse(tpre.Text);

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Menus VALUES (@valor1, @valor2, @valor3)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", numeromen);
                    command.Parameters.AddWithValue("@valor2", desc);
                    command.Parameters.AddWithValue("@valor3", precio);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void brec_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "Select Recetas.*, Ingredientes.NombreIngr, Platos.NombrePl from Recetas join Ingredientes on Recetas.IdIngrediente = Ingredientes.IdIngrediente join Platos on Recetas.IdPlato = Platos.IdPlato";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillarec.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bregrec_Click(object sender, EventArgs e)
        {
            
            string iding = tiding2.Text;
            string idplato = tidplat2.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Recetas VALUES (@valor1, @valor2)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", iding);
                    command.Parameters.AddWithValue("@valor2", idplato);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "select ContMenu.*, Menus.Descripcion, Platos.NombrePl from ContMenu join Menus on ContMenu.NroMenu = Menus.NroMenu join Platos on ContMenu.IdPlato = Platos.IdPlato";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillacont.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string idmen = tnmen.Text;
            string idplato = tidplat3.Text;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO ContMenu VALUES (@valor1, @valor2)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idmen);
                    command.Parameters.AddWithValue("@valor2", idplato);

                    
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

                    
                    string query = "Select * from ConsumoInfanteView";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillacons.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
        }

        private void bregcons_Click(object sender, EventArgs e)
        {
            
            DateTime fechacons = tfcon.Value;
            string idmatricula = tmat.Text;
            string nummenu = tnmen2.Text;
            int cantidad = Int32.Parse(tcan.Text);

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Consumos VALUES (@valor1, @valor2, @valor3, @valor4)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idmatricula);
                    command.Parameters.AddWithValue("@valor2", nummenu);
                    command.Parameters.AddWithValue("@valor3", fechacons);
                    command.Parameters.AddWithValue("@valor4", cantidad);

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
