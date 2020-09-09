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
    public partial class Owner : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5849Q5PJ;Initial Catalog=ML635249908;Integrated Security=True");
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
        public Owner()
        {
            InitializeComponent();
        }

        private void Lease1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lease7_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssociateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM AssociateComboBox WHERE UserType='" + OwnerComboBox.SelectedItem + "'", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ComboValue = OwnerComboBox.SelectedItem.ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["UserType"].ToString() == ComboValue)
                {
                    if (OwnerComboBox.SelectedIndex == 0)
                    {
                        DeleteButton.Enabled = true;
                        VoidButton.Enabled = false;
                        TerminateButton.Enabled = false;
                        ViewButton.Enabled = true;
                        EditButton.Enabled = true;
                        InsertButton.Enabled = true;
                    }
                    else if (OwnerComboBox.SelectedIndex == 1)
                    {
                        DeleteButton.Enabled = true;
                        VoidButton.Enabled = false;
                        TerminateButton.Enabled = false;
                        ViewButton.Enabled = true;
                        EditButton.Enabled = true;
                        InsertButton.Enabled = true;
                    }
                    else if (OwnerComboBox.SelectedIndex == 2)
                    {
                        DeleteButton.Enabled = true;
                        VoidButton.Enabled = false;
                        TerminateButton.Enabled = false;
                        ViewButton.Enabled = true;
                        EditButton.Enabled = true;
                        InsertButton.Enabled = true;
                    }
                    else if (OwnerComboBox.SelectedIndex == 3)
                    {
                        DeleteButton.Enabled = false;
                        VoidButton.Enabled = true;
                        TerminateButton.Enabled = false;
                        ViewButton.Enabled = true;
                        EditButton.Enabled = false;
                        InsertButton.Enabled = true;
                    }
                }
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (OwnerComboBox.SelectedIndex == 0)
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
           else if (OwnerComboBox.SelectedIndex == 1)
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
            else if (OwnerComboBox.SelectedIndex == 2)
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
            else if (OwnerComboBox.SelectedIndex == 3)
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


        //DELETE BUTTON , Delete data from Vehicles, Customers and Leases
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (OwnerComboBox.SelectedIndex == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [Vehicles] WHERE VehicleVIN = '" + VehicleVinTxt.Text + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                VehicleVinTxt.Text = "";
                ModelTxt.Text = "";
                cartype.Text = "";
                ColorComboBox.Text = "";
                LeaseYearComboBox.Text = "";
                KilometereOnOdometertxt.Text = "";
                IsCarNewComboBox.Text = "";
                BookValueTxt.Text = "";
                TransmissionComboBox.Text = "";
                OptionComboBox.Text = "";
                displayVehicleData();
                MessageBox.Show("The Data Deleted Successfully");
            }
            else if (OwnerComboBox.SelectedIndex == 1)
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
            else if (OwnerComboBox.SelectedIndex == 2)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [Leases] WHERE LeaseOwner = '" + LeaseOwner.Text + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                BeginDate.Text = "";
                FirstPaymentDate.Text = "";
                AmountOfMonthly.Text = "";
                NumberOfMonthly.Text = "";
                WhichVehicleIsLeaseFor.Text = "";
                LeaseOwner.Text = "";
                LeaseTerm.Text = "";
                displayLeasesData();
                MessageBox.Show("The Data Deleted Successfully");
            }
        }

        //INSERT BUTTON/ To insert data to Vehicles, Customers and Leases. 
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //For Adding data To VEHICLES
            if (OwnerComboBox.SelectedIndex == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Vehicles] (VehicleVIN, Model, CarType, Color, LeaseYear, KilometersOnOdometers, IsCarNew, BookValue, TransmissionID, Options) VALUES ('" + VehicleVinTxt.Text + "','" + ModelTxt.Text + "', '" + cartype.SelectedItem.ToString() + "','" + ColorComboBox.SelectedItem.ToString() + "', '" + LeaseYearComboBox.SelectedItem.ToString() + "','" + KilometereOnOdometertxt.Text + "','" + IsCarNewComboBox.SelectedItem.ToString() + "','" + BookValueTxt.Text + "','" + TransmissionComboBox.SelectedItem.ToString() + "','" + OptionComboBox.SelectedItem.ToString() + "')";
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
            //For Adding data To Customers
            else if (OwnerComboBox.SelectedIndex == 1)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Costumerss] (First_LastName, Addreess, Province, City, PostalCode, PhoneNumber) VALUES ('" + NameTextBox.Text + "','" + AddressTextBox.Text + "', '" + ProvinceTextBox.Text + "','" + CityTextBox.Text + "', '" + PostalCodeTextBox.Text + "','" + PhoneNumberTextBox.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                NameTextBox.Text = "";
                AddressTextBox.Text = "";
                ProvinceTextBox.Text = "";
                CityTextBox.Text = "";
                PostalCodeTextBox.Text = "";
                PhoneNumberTextBox.Text = "";
                displayCustomersData();
                MessageBox.Show("The Data Inserted Successfully");
            }

            //For adding data to LEASES
            else if (OwnerComboBox.SelectedIndex == 2)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Leases] (DateTheLeaseContractBegin, FirstPaymentDate, AmountOfMonthlyPayment, NumberOfMonthlyPayments, WhichVehicleTheLeaseIsFor, LeaseOwner, TheTermsOfTheLease) VALUES ('" + BeginDate.Text.ToString() + "','" + FirstPaymentDate.Text.ToString() + "', '" + AmountOfMonthly.Text + "','" + NumberOfMonthly.Text + "', '" + WhichVehicleIsLeaseFor.Text + "','" + LeaseOwner.Text + "','" + LeaseTerm.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                BeginDate.Text = "";
                FirstPaymentDate.Text = "";
                AmountOfMonthly.Text = "";
                NumberOfMonthly.Text = "";
                WhichVehicleIsLeaseFor.Text = "";
                LeaseOwner.Text = "";
                LeaseTerm.Text = "";
                displayLeasesData();
                MessageBox.Show("The Data Inserted Successfully");
            }
            else if(OwnerComboBox.SelectedIndex == 3)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Payments] (LeaseID, Date, Amount) VALUES ('" + LeaseIDTextBox.Text + "','" + DateTextBox.Text + "', '" + AmountTextBox.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                LeaseIDTextBox.Text = "";
                DateTextBox.Text = "";
                AmountTextBox.Text = "";
                displayPaymentsData();
                MessageBox.Show("The Data Inserted Successfully");
            }
        }

        //EDIT BUTTON, To update Vehicles, Customers and Leases Tables.
        private void EditButton_Click(object sender, EventArgs e)
        {
            if(OwnerComboBox.SelectedIndex == 0)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Vehicles set VehicleVIN='" + VehicleVinTxt.Text + "',Model='" + ModelTxt.Text + "',CarType ='" + cartype.Text + "',Color='" + ColorComboBox.Text + "',LeaseYear='" + LeaseYearComboBox.Text + "',KilometersOnOdometers='" + KilometereOnOdometertxt.Text + "', IsCarNew= '"+IsCarNewComboBox.Text+ "',BookValue='"+BookValueTxt.Text+ "',TransmissionID= '"+TransmissionComboBox.Text+ "', Options= '"+OptionComboBox.Text+ "' WHERE VehicleVIN='" + VehicleVinTxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Data Updated Successfully");
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
                }
                catch (Exception)
                {

                }
            }
            else if (OwnerComboBox.SelectedIndex == 1)
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
            //Updating the LEASE Tabel
            else if (OwnerComboBox.SelectedIndex == 2)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Leases set DateTheLeaseContractBegin='" + BeginDate.Text + "',FirstPaymentDate='" + FirstPaymentDate.Text + "',AmountOfMonthlyPayment ='" + AmountOfMonthly.Text + "',NumberOfMonthlyPayments='" + NumberOfMonthly.Text + "',WhichVehicleTheLeaseIsFor='" + WhichVehicleIsLeaseFor.Text + "',LeaseOwner='" + LeaseOwner.Text + "', TheTermsOfTheLease=  '" + LeaseTerm.Text + " 'WHERE AmountOfMonthlyPayment='" + AmountOfMonthly.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Data Updated Successfully");
                    connection.Close();
                    BeginDate.Text = "";
                    FirstPaymentDate.Text = "";
                    AmountOfMonthly.Text = "";
                    NumberOfMonthly.Text = "";
                    WhichVehicleIsLeaseFor.Text = "";
                    LeaseOwner.Text = "";
                    LeaseTerm.Text = "";
                    displayLeasesData();
                }
                catch (Exception)
                {

                }
            }
        }

        //Using view to show the datas to their text boxes.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(OwnerComboBox.SelectedIndex == 0)
            {
                VehicleVinTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ModelTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cartype.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ColorComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                LeaseYearComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                KilometereOnOdometertxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                IsCarNewComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                BookValueTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                TransmissionComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                OptionComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            else if (OwnerComboBox.SelectedIndex == 1)
            {
                NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                CityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ProvinceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                PostalCodeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                PhoneNumberTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (OwnerComboBox.SelectedIndex == 2)
            {
                BeginDate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                FirstPaymentDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountOfMonthly.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                NumberOfMonthly.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                WhichVehicleIsLeaseFor.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                LeaseOwner.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                LeaseTerm.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
