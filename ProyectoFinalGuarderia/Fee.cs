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
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
            cbfee.Items.Add("Cuenta total del niño");
            cbfee.Items.Add("Reporte con el especialista");
            cbfee.Items.Add("Reporte de consumo");
            cbfee.Items.Add("Reporte de Tarifa");
            cbfee.SelectedItem = "Cuenta total del niño";
        }
        
        string connectionString = "Data Source=JOSE;Initial Catalog=ProyectoFinal;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string storedProcedureName = "CuentaInfanteTarifa";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    
                    command.Parameters.AddWithValue("@NroMatricula", tmat.Text);
                    command.Parameters.AddWithValue("@mes", int.Parse(tmes.Text));
                    command.Parameters.AddWithValue("@año", int.Parse(tyear.Text));
                    
                    SqlParameter totalParameter = new SqlParameter("@MontoTotal", SqlDbType.Money);
                    totalParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(totalParameter);

                    try
                    {
                        connection.Open();

                        
                        command.ExecuteNonQuery();

                        
                        decimal total = (decimal)command.Parameters["@MontoTotal"].Value;

                        
                        total = Math.Round(total, 2);

                        
                        MessageBox.Show("El total es: " + total.ToString() + " Bs.");
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                    }
                }
            }
        }

        private void cbfee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfee.SelectedItem.ToString() == "Cuenta total del niño")
            {
                tmat.Visible = true;
                lmat.Visible = true;
                tmes.Visible = true;
                lmes.Visible = true;
                tyear.Visible = true;
                lyear.Visible = true;
                tper.Visible = false;
                lper.Visible = false;
                tmon.Visible = false;
                lmon.Visible = false;
                btar.Visible = true;
                btaresp.Visible = false;
                btarcons.Visible = false;
                breptar.Visible = false;
                grillafee.Visible = false;
            }
            else
            {
                if (cbfee.SelectedItem.ToString() == "Reporte con el especialista")
                {
                    tmat.Visible = true;
                    lmat.Visible = true;
                    tper.Visible = false;
                    lper.Visible = false;
                    tmes.Visible = true;
                    lmes.Visible = true;
                    tyear.Visible = true;
                    lyear.Visible = true;
                    tmon.Visible = true;
                    lmon.Visible = true;
                    btaresp.Visible = true;
                    btar.Visible = false;
                    btarcons.Visible = false;
                    breptar.Visible = false;
                    grillafee.Visible = false;
                }
                else
                {
                    if (cbfee.SelectedItem.ToString() == "Reporte de consumo")
                    {
                        tmat.Visible = true;
                        lmat.Visible = true;
                        tmes.Visible = true;
                        lmes.Visible = true;
                        tyear.Visible = true;
                        lyear.Visible = true;
                        tper.Visible = false;
                        lper.Visible = false;
                        tmon.Visible = false;
                        lmon.Visible = false;
                        btar.Visible= false;
                        btaresp.Visible = false;
                        btarcons.Visible = true;
                        breptar.Visible = false;
                        grillafee.Visible = true;
                    }
                    else
                    {
                        if (cbfee.SelectedItem.ToString() == "Reporte de Tarifa")
                        {
                            tmat.Visible = true;
                            lmat.Visible = true;
                            tper.Visible = true;
                            lper.Visible = true;
                            tmes.Visible = false;
                            lmes.Visible = false;
                            tyear.Visible = false;
                            lyear.Visible = false;
                            tmon.Visible = false;
                            lmon.Visible = false;
                            btar.Visible = false;
                            btaresp.Visible = false;
                            btarcons.Visible = false;
                            breptar.Visible = true;
                            grillafee.Visible = true;
                        }
                    }
                }
            }
        }

        private void breptar_Click(object sender, EventArgs e)
        {
            string storedProcedureName = "ReporteTarifaInf";
            string nroMatricula = tmat.Text;
            string periodo = tper.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    
                    command.Parameters.AddWithValue("@NroMatricula", nroMatricula);
                    command.Parameters.AddWithValue("@periodo", periodo);

                    try
                    {
                        connection.Open();

                        
                        DataTable resultTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }

                        
                        grillafee.DataSource = resultTable;
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                    }
                }
            }
        }

        private void btarcons_Click(object sender, EventArgs e)
        {
            string storedProcedureName = "ReporteConsumoInf";
            string nroMatricula = tmat.Text;
            int mes = Int32.Parse(tmes.Text);
            int año = Int32.Parse(tyear.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    
                    command.Parameters.AddWithValue("@NroMatricula", nroMatricula);
                    command.Parameters.AddWithValue("@mes", mes);
                    command.Parameters.AddWithValue("@año", año);

                    try
                    {
                        connection.Open();

                        
                        DataTable resultTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }

                        
                        grillafee.DataSource = resultTable;
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                    }
                }
            }
        }

        private void btaresp_Click(object sender, EventArgs e)
        {
            string storedProcedureName = "CuantaInfanteEspecialista";
            string nroMatricula = tmat.Text;
            int mes = Int32.Parse(tmes.Text);
            int año = Int32.Parse(tyear.Text);
            double cuenta = Math.Round(Double.Parse(tmon.Text), 2);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    
                    command.Parameters.AddWithValue("@NroMatricula", nroMatricula);
                    command.Parameters.AddWithValue("@mes", mes);
                    command.Parameters.AddWithValue("@año", año);

                    
                    SqlParameter outputParameter = new SqlParameter("@cuenta", SqlDbType.Money);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    try
                    {
                        connection.Open();

                        
                        command.ExecuteNonQuery();

                        
                        cuenta = (double)outputParameter.Value;

                        
                        MessageBox.Show("Cuenta: " + cuenta.ToString());
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                    }
                }
            }
        }
    }
}