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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";

        private void bregprod_Click(object sender, EventArgs e)
        {
            
            string idproducto = tidpro.Text;
            string producto = tprod.Text;
            double precio = Math.Round(Double.Parse(tpre.Text), 2);
            int stock = int.Parse(tstock.Text);
            int minim = int.Parse(tmin.Text);

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "INSERT INTO Productos VALUES (@valor1, @valor2, @valor3, @valor4, @valor5)";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@valor1", idproducto);
                    command.Parameters.AddWithValue("@valor2", producto);
                    command.Parameters.AddWithValue("@valor3", precio);
                    command.Parameters.AddWithValue("@valor4", stock);
                    command.Parameters.AddWithValue("@valor5", minim);;

                    
                    command.ExecuteNonQuery();

                    
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idprod = tprod2.Text;

            string query = "SELECT PrecioProd FROM Productos WHERE IdProd = @IdProd";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdProd", idprod);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal precioProducto = Convert.ToDecimal(result);
                        int cantidadComprada;
                        if (int.TryParse(tcant.Text, out cantidadComprada))
                        {
                            cantidadComprada = int.Parse(tcant.Text);
                            decimal costoTotal = precioProducto * cantidadComprada;
                            decimal costoTotalRedondeado = Math.Round(costoTotal, 2);
                            tcos.Text = costoTotalRedondeado.ToString();
                        }
                        else
                        {
                            cantidadComprada = 1;
                            decimal costoTotal = precioProducto * cantidadComprada;
                            decimal costoTotalRedondeado = Math.Round(costoTotal, 2);
                            tcos.Text = costoTotalRedondeado.ToString();
                        }
                    }
                    else
                    {
                        tcos.Text = "No se encontró el producto";
                    }
                }
                catch (Exception ex)
                {
                    
                    tcos.Text = "Error: " + ex.Message;
                }
            }
        }

        private void bprod_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Productos";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                   
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillaprod.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bcomp_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    string query = "SELECT * FROM Compras";
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                   
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    grillacom.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bregcom_Click(object sender, EventArgs e)
        {
            
            string idComp = tcompra.Text;
            string idProd = tprod2.Text;
            string nroMatricula = tmat.Text;
            DateTime fechaComp = tfcompra.Value;
            int cantComp = int.Parse(tcant.Text);
            double costoTotal = Double.Parse(tcos.Text);

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

               
                string insertQuery = "INSERT INTO Compras VALUES (@IdComp, @IdProd, @NroMatricula, @FechaComp, @CantComp, @CostoTotal)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@IdComp", idComp);
                    command.Parameters.AddWithValue("@IdProd", idProd);
                    command.Parameters.AddWithValue("@NroMatricula", nroMatricula);
                    command.Parameters.AddWithValue("@FechaComp", fechaComp);
                    command.Parameters.AddWithValue("@CantComp", cantComp);
                    command.Parameters.AddWithValue("@CostoTotal", costoTotal);

                    
                    command.ExecuteNonQuery();
                }

                
                string updateQuery = "UPDATE Productos SET Stock = Stock - @CantComp WHERE IdProd = @IdProd";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@CantComp", cantComp);
                    command.Parameters.AddWithValue("@IdProd", idProd);

                    
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Compra realizada correctamente.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int minStockAlerta = int.Parse(talert.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GenerarReporteCompra", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MinStockAlerta", minStockAlerta);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    
                    DataTable reporteTable = new DataTable();
                    reporteTable.Load(reader);
                    grillaReporte.DataSource = reporteTable;

                    reader.NextResult(); 

                    DataTable alertaTable = new DataTable();
                    alertaTable.Load(reader);
                    grillaAlerta.DataSource = alertaTable;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
