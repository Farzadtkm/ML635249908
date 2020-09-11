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
using System.Text.RegularExpressions;

namespace ML635249908
{

    public partial class Manager : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5849Q5PJ;Initial Catalog=ML635249908;Integrated Security=True");
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        //For Insert Key 
        private void button3_Click(object sender, EventArgs e)
        {
            //To Enter Data to Payments
            if (ManagerComboBox.SelectedIndex == 2)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Payments] (LeaseID, Date, Amount, Reason) VALUES ('" + LeaseIDTextBox.Text + "','" + DateTextBox.Text + "', '" + AmountTextBox.Text + "','" + ReasonTextBox.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                LeaseIDTextBox.Text = "";
                DateTextBox.Text = "";
                AmountTextBox.Text = "";
                ReasonTextBox.Text = "";
                displayPaymentsData();
                MessageBox.Show("The Data Inserted Successfully");
            }
        }
        //To display Data In the Manager Form from Costumers
        public void displayCustomersData()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Costumerss]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }
        public void displayLeasesData()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Leases.*, Vehicles.KilometersOnOdometers FROM Leases INNER JOIN Vehicles ON WhichVehicleTheLeaseIsFor = VehicleVIN";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        public void displayPaymentsData()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Payments]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ManagerComboBox.SelectedIndex == 0)
            {
                displayCustomersData();
            }
            else if (ManagerComboBox.SelectedIndex == 1)
            {
                displayLeasesData();
            }
            else if (ManagerComboBox.SelectedIndex == 2)
            {
                displayPaymentsData();
            }
        }

        //To delete a Data from the table 
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [Costumerss] WHERE First_LastName = '" + NameTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            ProvinceTextBox.Text = "";
            CityTextBox.Text = "";
            PostalCodeTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            displayCustomersData();
            MessageBox.Show("The Data Deleted Successfully");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ManagerComboBox.SelectedIndex == 0)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Costumerss set First_LastName='" + NameTextBox.Text + "',Addreess='" + AddressTextBox.Text + "',City ='" + CityTextBox.Text + "',Province='" + ProvinceTextBox.Text + "',PostalCode='" + PostalCodeTextBox.Text + "',PhoneNumber='" + PhoneNumberTextBox.Text + "'WHERE First_LastName='" + NameTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Data Updated Successfully");
                    connection.Close();
                    NameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    CityTextBox.Text = "";
                    ProvinceTextBox.Text = "";
                    PostalCodeTextBox.Text = "";
                    PhoneNumberTextBox.Text = "";
                    displayCustomersData();
                }
                catch (Exception)
                {

                }
            }
            else if (ManagerComboBox.SelectedIndex == 1)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Leases set DateTheLeaseContractBegin='" + LeaseDate.Text + "',FirstPaymentDate='" + FirstPaymentDate.Text + "',AmountOfMonthlyPayment ='" + AmountOfMonthlyPayment.Text + "',NumberOfMonthlyPayments='" + NumberOfMonthlyPayments.Text + "',WhichVehicleTheLeaseIsFor='" + WhichVehicleLeaseFor.Text + "',LeaseOwner='" + LeaseOwner.Text + "', TheTermsOfTheLease=  '" + LeaseTerms.Text + "',NumberOfYeasrs= '" + NumberOfYears.Text + "',MaximumKilometres='" + MaximumKilometere.Text + "', ChargeForExtraMileage='" + ChargeOfExtraMileage.Text + "' WHERE AmountOfMonthlyPayment='" + AmountOfMonthlyPayment.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Data Updated Successfully");
                    connection.Close();
                    LeaseDate.Text = "";
                    FirstPaymentDate.Text = "";
                    AmountOfMonthlyPayment.Text = "";
                    NumberOfMonthlyPayments.Text = "";
                    WhichVehicleLeaseFor.Text = "";
                    LeaseOwner.Text = "";
                    LeaseTerms.Text = "";
                    NumberOfYears.Text = "";
                    MaximumKilometere.Text = "";
                    ChargeOfExtraMileage.Text = "";
                    displayLeasesData();
                }
                catch (Exception)
                {

                }
            }
        }

        //Provine text box only get to characters for input and make the string Upper case.
        private void ProvinceTextBox_TextChanged(object sender, EventArgs e)
        {
            ProvinceTextBox.MaxLength = 2;
            string ProvinceUppercase = ProvinceTextBox.Text;
            ProvinceUppercase.ToUpper();
        }

        //Phone number text box just get Numbers to save for Data.
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(PhoneNumberTextBox.Text, "^[0-9 ()-]*$"))
            {
                String Temp = PhoneNumberTextBox.Text;
                if (Temp.Length > 1)
                {
                    Temp = Temp.Substring(0, Temp.Length - 1);
                }
                else
                {
                    Temp = "";
                }
            }
            else
            {
                MessageBox.Show("Enter ONLY Numbers Please");
            }
        }

        //Giving different level of accesses to our users from here. Some of the buttons will be disabled for them.
        private void ManagerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ManagerComboBox WHERE UserType='" + ManagerComboBox.SelectedItem + "'", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ComboValue = ManagerComboBox.SelectedItem.ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["UserType"].ToString() == ComboValue)
                {
                    if (ManagerComboBox.SelectedIndex == 0)
                    {
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = false;
                        InsertButton.Enabled = false;
                        TerminateButton.Enabled = false;
                    }
                    else if (ManagerComboBox.SelectedIndex == 1)
                    {
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = false;
                        InsertButton.Enabled = false;
                        TerminateButton.Enabled = true;
                    }
                    else if (ManagerComboBox.SelectedIndex == 2)
                    {
                        TerminateButton.Enabled = false;
                        DeleteButton.Enabled = false;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ManagerComboBox.SelectedIndex == 0)
            {
                NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                CityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ProvinceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                PostalCodeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                PhoneNumberTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (ManagerComboBox.SelectedIndex == 1)
            {
                LeaseDate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                FirstPaymentDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountOfMonthlyPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                NumberOfMonthlyPayments.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                WhichVehicleLeaseFor.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                LeaseOwner.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                LeaseTerms.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                NumberOfYears.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                MaximumKilometere.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                ChargeOfExtraMileage.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                //VehicleVinTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                KilometereOnOdometertxt.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            else if (ManagerComboBox.SelectedIndex == 2)
            {
                LeaseIDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ReasonTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Search Button to search in Customer and Lease table and find their full name by their Phone Number
        /// and all their data in Lease table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (ManagerComboBox.SelectedIndex == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT First_LastName,PhoneNumber FROM Costumerss WHERE PhoneNumber='" + SearchTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                NameTextBox.Text = "";
                AddressTextBox.Text = "";
                CityTextBox.Text = "";
                ProvinceTextBox.Text = "";
                PostalCodeTextBox.Text = "";
                PhoneNumberTextBox.Text = "";
            }
            else if (ManagerComboBox.SelectedIndex == 1)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Leases WHERE LeaseOwner='" + SearchTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                LeaseDate.Text = "";
                FirstPaymentDate.Text = "";
                AmountOfMonthlyPayment.Text = "";
                NumberOfMonthlyPayments.Text = "";
                WhichVehicleLeaseFor.Text = "";
                LeaseOwner.Text = "";
                LeaseTerms.Text = "";
                NumberOfYears.Text = "";
                MaximumKilometere.Text = "";
                ChargeOfExtraMileage.Text = "";
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(NameTextBox.Text, "^[a-zA-Z ]*$"))
            {
                String Temp = NameTextBox.Text;
                if (Temp.Length > 1)
                {
                    Temp = Temp.Substring(0, Temp.Length - 1);
                }
                else
                {
                    Temp = "";
                }
            }
            else
            {
                MessageBox.Show("Enter ONLY characters Please");
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(AddressTextBox.Text, "^[a-zA-Z0-9 ]*$"))
            {
                String Temp = AddressTextBox.Text;
                if (Temp.Length > 1)
                {
                    Temp = Temp.Substring(0, Temp.Length - 1);
                }
                else
                {
                    Temp = "";
                }
            }
            else
            {
                MessageBox.Show("Enter ONLY characters Please");
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CityTextBox.Text, "^[a-zA-Z ]*$"))
            {
                String Temp = CityTextBox.Text;
                if (Temp.Length > 1)
                {
                    Temp = Temp.Substring(0, Temp.Length - 1);
                }
                else
                {
                    Temp = "";
                }
            }
            else
            {
                MessageBox.Show("Enter ONLY characters Please");
            }
        }

        private void LeaseOwner_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Amount text box check the Payment date with Contract date to see if the user pay his payments on time or not.
        /// if the payment come after 3 days or more, the user will get a fine by 2 percent on its payment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            DateTime aDateBegin = new DateTime(LeaseDate.Value.Year, LeaseDate.Value.Month, LeaseDate.Value.Day);
            DateTime aDatePayment = new DateTime(LeaseDate.Value.Year, DateTextBox.Value.Month, DateTextBox.Value.Day);
            double difference = (aDatePayment - aDateBegin).TotalDays;

            double paymentWithTax = Int32.Parse(AmountTextBox.Text);
            paymentWithTax *= 1.15;

            double extraCharge = Int32.Parse(AmountTextBox.Text);
            extraCharge *= 1.02;
            extraCharge *= 1.15;


            if (difference < 3)
            {
                AmountTextBox.Text = paymentWithTax.ToString();
            }
            else if (difference >= 3)
            {
                AmountTextBox.Text = extraCharge.ToString();
            }
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            MaximumKilometere.Text = MaximumKilometere.Text.Replace(",", "");
            KilometereOnOdometertxt.Text = KilometereOnOdometertxt.Text.Replace(",", "");

            double maxKilometer = double.Parse(MaximumKilometere.Text);
            double kilometerOnOdometere = double.Parse(KilometereOnOdometertxt.Text);
            double perimumRate = double.Parse(ChargeOfExtraMileage.Text);
            double result;

            if (kilometerOnOdometere > maxKilometer)
            {
                result = (kilometerOnOdometere - maxKilometer ) * perimumRate;

                MessageBox.Show("Because You drove more than your Max kilometere you owe us " + result + " dollars");
            }
            else
            {
                // Update Row

                MessageBox.Show("Your Lease Terminated, Thank You!!");
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (ManagerComboBox.SelectedIndex == 1)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT VehicleVIN,KilometersOnOdometers FROM Vehicles WHERE VehicleVIN='" + VehicleVinTxt.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                VehicleVinTxt.Text = "";
                KilometereOnOdometertxt.Text = "";
            }
        }
    }
}
