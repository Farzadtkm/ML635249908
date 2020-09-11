using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ML635249908
{
    public partial class Report_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5849Q5PJ;Initial Catalog=ML635249908;Integrated Security=True");
        public Report_Form()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        { 
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Leases.DateTheLeaseContractBegin, Leases.FirstPaymentDate, Costumerss.First_LastName,Costumerss.PhoneNumber, Vehicles.Model, Vehicles.VehicleVIN FROM Leases INNER JOIN Vehicles ON WhichVehicleTheLeaseIsFor = VehicleVIN inner join Costumerss on First_LastName = LeaseOwner";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LeaseNameLable.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PhoneNumberLabale.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ModelLable.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            VehicleVINLable.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
    }
}
