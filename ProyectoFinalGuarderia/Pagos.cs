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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string idProfesional = tidesp.Text;
            int mes = int.Parse(tmes.Text);
            int año = int.Parse(taño.Text);
            decimal sueldo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PagoEspecialista", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdProfesional", idProfesional);
                command.Parameters.AddWithValue("@mes", mes);
                command.Parameters.AddWithValue("@año", año);

                SqlParameter sueldoParameter = new SqlParameter("@sueldo", SqlDbType.Money);
                sueldoParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(sueldoParameter);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    if (sueldoParameter.Value != DBNull.Value)
                    {
                        sueldo = Math.Round((decimal)sueldoParameter.Value, 2);
                    }

                    MessageBox.Show("El sueldo es: " + sueldo.ToString() + " Bs.");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idProfesional = tidesp.Text;
            int mes = int.Parse(tmes.Text);
            int año = int.Parse(taño.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ReporteSueldo", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdProfesional", idProfesional);
                command.Parameters.AddWithValue("@mes", mes);
                command.Parameters.AddWithValue("@año", año);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    
                    DataTable reporteTable = new DataTable();
                    reporteTable.Load(reader);
                    grillaSueldo.DataSource = reporteTable;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tidesp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
