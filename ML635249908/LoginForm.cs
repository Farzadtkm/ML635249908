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
    public partial class LoginForm : Form
    {
        

        SqlConnection Connection = new SqlConnection("Data Source=LAPTOP-5849Q5PJ;Initial Catalog=ML635249908;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE UserName='"+UserNameTextBox.Text+"' AND Password ='"+PasswordTextBox.Text+"'", Connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ComboValue = UserTypeComboBox.SelectedItem.ToString();

            // test commit

            if (dt.Rows.Count > 0)
            {
                for(int i=0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i]["UserType"].ToString() == ComboValue)
                    {
                        MessageBox.Show("You are login as " + dt.Rows[i][2]);
                        if(UserTypeComboBox.SelectedIndex == 0)
                        {
                            Manager manager = new Manager();
                            manager.Show();
                            this.Hide();
                        }
                        else if(UserTypeComboBox.SelectedIndex == 1){
                            Associate associate = new Associate();
                            associate.Show();
                            this.Hide();
                        }
                        else if(UserTypeComboBox.SelectedIndex == 2)
                        {
                            Owner owner = new Owner();
                            owner.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
