﻿using System;
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
                cmd.CommandText = "INSERT INTO [Payments] (LeaseID, Date, Amount) VALUES ('" +LeaseIDTextBox.Text+ "','" + DateTextBox.Text + "', '" + AmountTextBox.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                LeaseIDTextBox.Text = "";
                DateTextBox.Text = "";
                AmountTextBox.Text = "";
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
            cmd.CommandText = "SELECT * FROM [Leases]";
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
            if(ManagerComboBox.SelectedIndex == 0)
            {
                displayCustomersData();
            }
            else if(ManagerComboBox.SelectedIndex == 1)
            {
                displayLeasesData();
            }
            else if(ManagerComboBox.SelectedIndex == 2)
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
            if (ManagerComboBox.SelectedIndex == 0) {
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
                    cmd.CommandText = "UPDATE Leases set DateTheLeaseContractBegin='" + LeaseDate.Text + "',FirstPaymentDate='" + FirstPaymentDate.Text + "',AmountOfMonthlyPayment ='" + AmountOfMonthlyPayment.Text + "',NumberOfMonthlyPayments='" + NumberOfMonthlyPayments.Text + "',WhichVehicleTheLeaseIsFor='" + WhichVehicleLeaseFor.Text + "',LeaseOwner='" + LeaseOwner.Text + "', TheTermsOfTheLease=  '"+LeaseTerms.Text+ " 'WHERE AmountOfMonthlyPayment='" + AmountOfMonthlyPayment.Text + "'";
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
                    displayLeasesData();
                }
                catch (Exception)
                {

                }
            } 
        }

        //Provine text box only get to characters for input.
        private void ProvinceTextBox_TextChanged(object sender, EventArgs e)
        {
            ProvinceTextBox.MaxLength = 2;
        }

        //Phone number text box just get Numbers to save for Data.
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
           // if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumberTextBox.Text, "[^0-9]"))
           // {
           //     MessageBox.Show("Don't put any character! Only numbers.");

          //      string s = PhoneNumberTextBox.Text;

           //     if (s.Length > 1)
          //      {
           //         s = s.Substring(0, s.Length - 1);
           //     }
            //    else
           //    {
             //       s = "";
           //     }

             //   PhoneNumberTextBox.Text = s;
          //  }
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
                        TerminateButton.Enabled = false;
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
            if(ManagerComboBox.SelectedIndex == 0)
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
            }
            else if(ManagerComboBox.SelectedIndex == 2)
            {
                LeaseIDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
