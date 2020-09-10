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
    public partial class Associate : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5849Q5PJ;Initial Catalog=ML635249908;Integrated Security=True");
        //Methode to display Customers Data
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
       // Methode to display Leases Data
        public void displayLeasesData()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Leases]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }
        //Methode to display Vehicle Data 
        public void displayVehicleData()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Vehicles]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }
        //Methode to display Payment Data 
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
       
        public Associate()
        {
            InitializeComponent();
        }
        //Level of access to our users and which buttons are active for them. 
        private void AssociateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM AssociateComboBox WHERE UserType='" + AssociateComboBox.SelectedItem + "'", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ComboValue = AssociateComboBox.SelectedItem.ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["UserType"].ToString() == ComboValue)
                {
                    if (AssociateComboBox.SelectedIndex == 0)
                    {
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = false;
                        TerminateButton.Enabled = false;
                        ViewButton.Enabled = false;
                        EditButton.Enabled = false;
                        InsertButton.Enabled = true;
                    }
                    else if (AssociateComboBox.SelectedIndex == 1)
                    {
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = false;
                        TerminateButton.Enabled = false;
                    }
                    else if (AssociateComboBox.SelectedIndex == 2)
                    {
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = false;
                        TerminateButton.Enabled = false;
                    }
                    else if(AssociateComboBox.SelectedIndex == 3)
                    {
                        TerminateButton.Enabled = false;
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = false;
                        EditButton.Enabled = false;
                        InsertButton.Enabled = false;
                    }
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            //For Adding data To CUSTOMERS
            if (AssociateComboBox.SelectedIndex == 1)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Costumerss] (First_LastName, Addreess, Province, City, PostalCode, PhoneNumber) VALUES ('" +AssociateNameTextBox.Text+ "','" + AssociateAddressTextBox.Text + "', '" + AssociateProvinceTextBox.Text + "','" + AssociateCityTextBox.Text + "', '" + AssociatePostalCodeTextBox.Text + "','" + AssociatePhoneNumberTextBox.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                AssociateNameTextBox.Text = "";
                AssociateAddressTextBox.Text = "";
                AssociateProvinceTextBox.Text = "";
                AssociateCityTextBox.Text = "";
                AssociatePostalCodeTextBox.Text = "";
                AssociatePhoneNumberTextBox.Text = "";
                displayCustomersData();
                MessageBox.Show("The Data Inserted Successfully");
            }
            //For Adding data To VEHICLES
           else if (AssociateComboBox.SelectedIndex == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Vehicles] (VehicleVIN, Model, CarType, Color, LeaseYear, KilometersOnOdometers, IsCarNew, BookValue, TransmissionID, Options) VALUES ('" + VehicleVinTxt.Text+ "','" + ModelTxt.Text + "', '" + cartype.SelectedItem.ToString() + "','" + ColorComboBox.SelectedItem.ToString() + "', '" +LeaseYearComboBox.SelectedItem.ToString() + "','" + KilometereOnOdometertxt.Text + "','"+IsCarNewComboBox.SelectedItem.ToString()+"','"+BookValueTxt.Text+"','"+TransmissionComboBox.SelectedItem.ToString()+"','"+OptionComboBox.SelectedItem.ToString()+"')";
                cmd.ExecuteNonQuery();
                connection.Close();
                VehicleVinTxt.Text = "";
                ModelTxt.Text = "";
                cartype.Text = "";
                ColorComboBox.SelectedItem = "";
                LeaseYearComboBox.SelectedItem = "";
                KilometereOnOdometertxt.Text = "";
                IsCarNewComboBox.SelectedItem = "";
                BookValueTxt.Text = "";
                TransmissionComboBox.SelectedItem = "";
                OptionComboBox.SelectedItem = "";
                displayVehicleData();
                MessageBox.Show("The Data Inserted Successfully");
            }
            //For adding data to LEASES
            else if (AssociateComboBox.SelectedIndex == 2)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Leases] (DateTheLeaseContractBegin, FirstPaymentDate, AmountOfMonthlyPayment, NumberOfMonthlyPayments, WhichVehicleTheLeaseIsFor, LeaseOwner, TheTermsOfTheLease, NumberOfYeasrs, MaximumKilometres, ChargeForExtraMileage) VALUES ('" + BeginDate.Text.ToString() + "','" + FirstPaymentDate.Text.ToString() + "', '" + AmountOfMonthly.Text + "','" + NumberOfMonthly.Text + "', '" + WhichVehicleIsLeaseFor.Text + "','" + LeaseOwner.Text + "','"+LeaseTerms.Text+"','"+NumberOfYears.Text+"','"+MaximumKilometere.Text+"','"+ChargeOfExtraMileage.Text+"',)";
                cmd.ExecuteNonQuery();
                connection.Close();
                BeginDate.Text = "";
                FirstPaymentDate.Text = "";
                AmountOfMonthly.Text = "";
                NumberOfMonthly.Text = "";
                WhichVehicleIsLeaseFor.Text = "";
                LeaseOwner.Text = "";
                LeaseTerms.Text = "";
                NumberOfYears.Text = "";
                MaximumKilometere.Text = "";
                ChargeOfExtraMileage.Text = "";
                displayLeasesData();
                MessageBox.Show("The Data Inserted Successfully");
            }
        }

//View Button for showing Costumers, Leases and Payments Table 
        private void ViewButton_Click(object sender, EventArgs e)
        {
            if(AssociateComboBox.SelectedIndex == 1)
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
            else if(AssociateComboBox.SelectedIndex == 2)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [Leases]";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            }
            else if(AssociateComboBox.SelectedIndex == 3)
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
        }

        private void AssociateCityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Province Just get Two Characters for Province TextBox
        private void AssociateProvinceTextBox_TextChanged(object sender, EventArgs e)
        {
            AssociateProvinceTextBox.MaxLength = 2;
            if (AssociateProvinceTextBox.TextLength > 2)
            {
                MessageBox.Show("Error, Enter 2 Character of your Province");
            }
        }

        //Phone Number textbox just get number and will delete the last character if entered incorrect.
        private void AssociatePhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(AssociatePhoneNumberTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Don't put any character! Only numbers.");

                string s = AssociatePhoneNumberTextBox.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "";
                }

                AssociatePhoneNumberTextBox.Text = s;
            }
        }

        //EDIT BUTTON for Customers and Leases  Tables. It will Update them.
        private void EditButton_Click(object sender, EventArgs e)
        {
            if(AssociateComboBox.SelectedIndex == 1)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Costumerss set First_LastName='" + AssociateNameTextBox.Text + "',Addreess='" + AssociateAddressTextBox.Text + "',City ='" + AssociateCityTextBox.Text + "',Province='" + AssociateProvinceTextBox.Text + "',PostalCode='" + AssociatePostalCodeTextBox.Text + "',PhoneNumber='" + AssociatePhoneNumberTextBox.Text + "'WHERE First_LastName='" + AssociateNameTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Data Updated Successfully");
                    connection.Close();
                    AssociateNameTextBox.Text = "";
                    AssociateAddressTextBox.Text = "";
                    AssociateCityTextBox.Text = "";
                    AssociateProvinceTextBox.Text = "";
                    AssociatePostalCodeTextBox.Text = "";
                    AssociatePhoneNumberTextBox.Text = "";
                    displayCustomersData();
                }
                catch (Exception)
                {

                }
            }
            else if(AssociateComboBox.SelectedIndex == 2)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Leases set DateTheLeaseContractBegin='" + BeginDate.Text + "',FirstPaymentDate='" + FirstPaymentDate.Text + "',AmountOfMonthlyPayment ='" + AmountOfMonthly.Text + "',NumberOfMonthlyPayments='" + NumberOfMonthly    .Text + "',WhichVehicleTheLeaseIsFor='" + WhichVehicleIsLeaseFor.Text + "',LeaseOwner='" + LeaseOwner.Text + "', TheTermsOfTheLease=  '" + LeaseTerms.Text + "', NumberOfYeasrs= '" + NumberOfYears.Text+ "',MaximumKilometres='"+MaximumKilometere.Text+ "', ChargeForExtraMileage='"+ChargeOfExtraMileage.Text+"' WHERE AmountOfMonthlyPayment='" + AmountOfMonthly.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Data Updated Successfully");
                    connection.Close();
                    BeginDate.Text = "";
                    FirstPaymentDate.Text = "";
                    AmountOfMonthly.Text = "";
                    NumberOfMonthly.Text = "";
                    WhichVehicleIsLeaseFor.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AssociateComboBox.SelectedIndex == 1)
            {
                AssociateNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                AssociateAddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AssociateCityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                AssociateProvinceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                AssociatePostalCodeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                AssociatePhoneNumberTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (AssociateComboBox.SelectedIndex == 2)
            {
                BeginDate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                FirstPaymentDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountOfMonthly.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                NumberOfMonthly.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                WhichVehicleIsLeaseFor.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                LeaseOwner.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                LeaseTerms.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                NumberOfYears.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                MaximumKilometere.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                ChargeOfExtraMileage.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            else if(AssociateComboBox.SelectedIndex == 3)
            {
                LeaseIDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ReasonTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (AssociateComboBox.SelectedIndex == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Vehicles WHERE VehicleVIN='" + SearchTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                VehicleVinTxt.Text = "";
                ModelTxt.Text = "";
                cartype.Text = "";
                ColorComboBox.SelectedItem = "";
                LeaseYearComboBox.SelectedItem = "";
                KilometereOnOdometertxt.Text = "";
                IsCarNewComboBox.SelectedItem = "";
                BookValueTxt.Text = "";
                TransmissionComboBox.SelectedItem = "";
                OptionComboBox.SelectedItem = "";
            }
            else if (AssociateComboBox.SelectedIndex == 1)
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
                AssociateNameTextBox.Text = "";
                AssociateAddressTextBox.Text = "";
                AssociateCityTextBox.Text = "";
                AssociateProvinceTextBox.Text = "";
                AssociatePostalCodeTextBox.Text = "";
                AssociatePhoneNumberTextBox.Text = "";
            }
            else if (AssociateComboBox.SelectedIndex == 2)
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
                BeginDate.Text = "";
                FirstPaymentDate.Text = "";
                AmountOfMonthly.Text = "";
                NumberOfMonthly.Text = "";
                WhichVehicleIsLeaseFor.Text = "";
                LeaseOwner.Text = "";
                LeaseTerms.Text = "";
                NumberOfYears.Text = "";
                MaximumKilometere.Text = "";
                ChargeOfExtraMileage.Text = "";
            }
        }
    }
}
