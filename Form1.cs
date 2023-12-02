using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace bloodDashBoard
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-EL259RHK;Initial Catalog=blood;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    RunQueries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Always close the connection in a finally block to ensure it's closed even if an exception occurs
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void RunQueries()
        {
            // Query 1: Total Number of Requests
            string query1 = "select count(ReqID) from [Requests] where ReqDate between @fromDate and @toDate";
            int numRequests = ExecuteScalarQuery<int>(query1, new SqlParameter("@fromDate", System.Data.SqlDbType.DateTime) { Value = DateTime.Parse("2023-05-05") }, new SqlParameter("@toDate", System.Data.SqlDbType.DateTime) { Value = DateTime.Parse("2024-01-01") });
            lblNumReq.Text = numRequests.ToString();

            // Query 2: Top 5 Blood Types in Stock
            DisplayTopBloodTypesChart();

            // Query 3: Total Number of Donors
            lblNumDonors.Text = ExecuteScalarQuery<int>("select count(DonorId) from Donors").ToString();

            // Query 4: Total Number of Patients
            lblNumPatients.Text = ExecuteScalarQuery<int>("select count(PatientId) from Patients").ToString();

            // Query 5: Total Number of Stock
            lblTotalProducts.Text = ExecuteScalarQuery<int>("select count(StockId) from Stock").ToString();

            // Query 6: Blood Types with Stock <= 6
            // (Note: The results of this query are not being used in the current code)

            // Query 7: Count of each blood type in Stock
            DisplayBloodTypeCounts();
            // Display the donor age distribution
            DisplayDonorAgeDistributionChart();
            DisplayLowStockBloodTypes();
            DisplayGenderDistributionChart();
        }

        private void DisplayTopBloodTypesChart()
        {
            string query = "SELECT TOP 5 BType, COUNT(*) AS TotalCount FROM Stock GROUP BY BType ORDER BY TotalCount DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = DateTime.Parse("2023-05-05");
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = DateTime.Parse("2024-01-01");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    chart2.Series.Clear();
                    Series series = new Series("Blood Types");
                    series.ChartType = SeriesChartType.Doughnut;

                    while (reader.Read())
                    {
                        string bloodType = reader["BType"].ToString();
                        int totalCount = Convert.ToInt32(reader["TotalCount"]);

                        DataPoint dataPoint = new DataPoint();
                        dataPoint.SetValueXY(bloodType, totalCount);
                        dataPoint.LegendText = bloodType;
                        dataPoint.Label = totalCount.ToString();

                        series.Points.Add(dataPoint);
                    }

                    chart2.Series.Add(series);
                }
            }
        }

        private void DisplayBloodTypeCounts()
        {
            string query = "SELECT BType, COUNT(StockId) AS TotalCount FROM Stock GROUP BY BType";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int labelIndex = 1;
                    while (reader.Read() && labelIndex <= 7) // Assuming you have 7 labels
                    {
                        string bloodType = reader["BType"].ToString();
                        int totalCount = Convert.ToInt32(reader["TotalCount"]);

                        Label currentLabel = Controls.Find($"labelBloodTypeCount{labelIndex}", true).FirstOrDefault() as Label;

                        if (currentLabel != null)
                        {
                            currentLabel.Text = $"{bloodType} : {totalCount}";
                        }

                        labelIndex++;
                    }
                }
            }
        }

        private void DisplayDonorAgeDistributionChart()
        {
            try
            {
                // Query: Retrieve donor ages
                string query = "SELECT Age FROM Donors";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing data in the chart
                        chart1.Series.Clear();

                        // Create a new series for the chart
                        Series series = new Series("Donor Age Distribution");
                        series.ChartType = SeriesChartType.Column;

                        // Set the bin width for the histogram
                        double binWidth = 5;

                        while (reader.Read())
                        {
                            // Read donor ages from the database
                            int donorAge = Convert.ToInt32(reader["Age"]);

                            // Calculate the bin for the current donor age
                            int bin = (int)(donorAge / binWidth) * (int)binWidth;

                            // Find the data point in the series corresponding to the bin
                            DataPoint dataPoint = null;

                            foreach (DataPoint existingDataPoint in series.Points)
                            {
                                if (existingDataPoint.XValue == bin)
                                {
                                    dataPoint = existingDataPoint;
                                    break;
                                }
                            }

                            // If the data point exists, increment its Y value; otherwise, create a new data point
                            if (dataPoint != null)
                            {
                                dataPoint.YValues[0]++;
                            }
                            else
                            {
                                series.Points.AddXY(bin, 1);
                            }
                        }

                        // Add the series to the chart
                        chart1.Series.Add(series);

                        // Customize the appearance of the chart
                        chart1.ChartAreas[0].AxisX.Title = "Donor Age";
                        chart1.ChartAreas[0].AxisY.Title = "Number of Donors";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayLowStockBloodTypes()
        {
            try
            {
                // Query: Blood Types with Stock <= 6
                string query = "SELECT BType, COUNT(StockID) AS TotalCount FROM Stock GROUP BY BType HAVING COUNT(StockID) <= 6";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Create a DataTable to hold the result
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        
                        // Check if DataGridView columns need to be created
                        if (dgvUnderStock.Columns.Count == 0)
                        {
                            // Auto-generate columns based on the DataTable
                            dgvUnderStock.AutoGenerateColumns = true;
                            dgvUnderStock.DataSource = dataTable;
                        }
                        else
                        {
                            // Set the existing columns to match the DataTable schema
                            dgvUnderStock.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayGenderDistributionChart()
        {
            try
            {
                // Query: Count of genders from donors
                string query = "SELECT Gender, COUNT(*) AS TotalCount FROM Donors GROUP BY Gender";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing data in the chart
                        chart3.Series.Clear();

                        // Create a new series for the chart
                        Series series = new Series("Gender Distribution");
                        series.ChartType = SeriesChartType.Bar;

                        while (reader.Read())
                        {
                            // Read gender and count from the database
                            int gender = Convert.ToInt32(reader["Gender"]);
                            int totalCount = Convert.ToInt32(reader["TotalCount"]);

                            // Map gender values to meaningful labels
                            string genderLabel = (gender == 1) ? "Male" : "Female";

                            // Add data points to the series
                            DataPoint dataPoint = new DataPoint();
                            dataPoint.SetValueXY(genderLabel, totalCount);

                            // Set legend and label for the data point
                            dataPoint.LegendText = genderLabel;
                            dataPoint.Label = totalCount.ToString();

                            series.Points.Add(dataPoint);
                        }

                        // Add the series to the chart
                        chart3.Series.Add(series);

                        // Customize the appearance of the chart
                        chart3.ChartAreas[0].AxisX.Title = "Gender";
                        chart3.ChartAreas[0].AxisY.Title = "Number of Donors";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private T ExecuteScalarQuery<T>(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddRange(parameters);
                object result = command.ExecuteScalar();
                return result == DBNull.Value ? default(T) : (T)result;
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUnderStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

