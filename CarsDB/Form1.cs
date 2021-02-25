using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CarsDB.Properties.Settings.CarsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCarsTable();
        }
        private void PopulateCarsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CarMark", connection))
            {
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);

                listCars.DisplayMember = "CarMarkName";
                listCars.ValueMember = "Id";
                listCars.DataSource = carTable;
            }
        }
        private void listCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarNames();
        }
        private void PopulateCarNames()
        {
            string query = "SELECT CarInGarage.CarModelName FROM CarMark INNER JOIN CarInGarage ON CarInGarage.CarMarkId = CarMark.Id WHERE CarMark.Id = @CarMarkId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CarMarkId", listCars.SelectedValue);
                DataTable carNameTable = new DataTable();
                adapter.Fill(carNameTable);

                listCarNames.DisplayMember = "CarModelName";
                listCarNames.ValueMember = "Id";
                listCarNames.DataSource = carNameTable;
            }
        }
    }
}
