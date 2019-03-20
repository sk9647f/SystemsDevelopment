using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    public partial class Account : Form
    {
        string LoginUsername;
        string LoginPassword;
        string Username;
        string Password;
        string Fname;
        string Sname;
        string Address;
        string PhoneNum;
        string Email;
        bool staff;
        public string connString;


        public Account()
        {
            InitializeComponent();


            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
            AccountPanel.Visible = false;
            StaffAccountPanel.Visible = false;





        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginUsername = textBox13.Text;
            LoginPassword = textBox14.Text;






            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE [Username] = @Username AND [Password] = @Password", myConnection);

            myCommand.Parameters.AddWithValue("@Username", LoginUsername);
            myCommand.Parameters.AddWithValue("@Password", LoginPassword);



            OleDbDataReader re = myCommand.ExecuteReader();


            if (re.Read() == true)
            {
                MessageBox.Show("Account found");
                LoginPanel.Visible = false;
                RegisterPanel.Visible = false;
                StaffAccountPanel.Visible = false;
                AccountPanel.Visible = true;

                re.Close();

                OleDbCommand staffCommand = new OleDbCommand("SELECT Staff FROM [User] WHERE Username = @Username", myConnection);

                staffCommand.Parameters.AddWithValue("@Username", LoginUsername);

                OleDbDataReader res = staffCommand.ExecuteReader();
                while (res.Read())
                {
                    staff = Convert.ToBoolean(res["Staff"]);
                    if (staff)
                    {
                        StaffAccountPanel.Visible = true;
                        AccountPanel.Visible = false;
                    }




                }


                label11.Text = LoginUsername;
                textBox13.Text = "";
                textBox14.Text = "";


            }
            else
            {
                MessageBox.Show("Account not found");
            }



            myConnection.Close();

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;
            StaffAccountPanel.Visible = false;
            AccountPanel.Visible = false;
            displayInfoPanel.Visible = false;

            buttonSaveDetails.Visible = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            Password = textBox2.Text;
            Fname = textBox3.Text;
            Sname = textBox4.Text;
            Address = textBox5.Text;
            PhoneNum = textBox6.Text;
            Email = textBox7.Text;






            OleDbConnection myConnection = new OleDbConnection(connString);
            using (myConnection)
            {
                myConnection.Open();
                OleDbCommand checkcmd = new OleDbCommand("SELECT * FROM [User] WHERE Username = @Username", myConnection);
                using (myConnection)
                {

                    checkcmd.Parameters.AddWithValue("@Username", Username);

                    Int32 count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("This username already exists");
                        LoginPanel.Visible = true;
                        RegisterPanel.Visible = false;
                    }
                    else if
                        (Username == "")
                    {
                        MessageBox.Show("Please enter a valid Username");

                    }
                    else if (Password == "")
                    {
                        MessageBox.Show("Please enter a valid Password");

                    }
                    else if (Fname == "")
                    {
                        MessageBox.Show("Please enter a valid Forname");
                    }
                    else if (Sname == "")
                    {
                        MessageBox.Show("Please enter a valid Surname");
                    }
                    else if (Address == "")
                    {
                        MessageBox.Show("Please enter a valid Address");
                    }
                    else if (PhoneNum == "")
                    {
                        MessageBox.Show("Please enter a valid Phone Number");
                    }
                    else if (Email == "" || !Email.Contains("@"))
                    {
                        MessageBox.Show("Please enter a valid Email Address");
                    }

                    else
                    {
                        Customer customer = new Customer();
                        customer.AddUser(Username, Password, Fname, Sname, Address, PhoneNum, Email);


                        MessageBox.Show("Account Created");
                        label11.Text = LoginUsername;
                        LoginPanel.Visible = true;
                        RegisterPanel.Visible = false;
                    }
                }



            }


        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
            AccountPanel.Visible = false;
            StaffAccountPanel.Visible = false;
            LoginUsername = " ";

        }

        private void StaffLogoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;
            AccountPanel.Visible = false;
            StaffAccountPanel.Visible = false;
        }

        private void AddPlayButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete your account??",
                                    "Confirm Delete!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Customer customer = new Customer();
                customer.DeleteUser(LoginUsername);


                LoginUsername = " ";


                LoginPanel.Visible = true;
                AccountPanel.Visible = false;
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void EditPersonalInfoButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            displayInfoPanel.Visible = true;
            buttonSaveDetails.Visible = false;
            submitButton.Visible = false;

            displayInfo.Text = " ";

            Customer customer = new Customer();
            customer.DisplayProfile(LoginUsername);
            displayInfo.Text = customer.details;


        }

        private void editDetailsButton_Click(object sender, EventArgs e)
        {
            displayInfoPanel.Visible = false;
            AccountPanel.Visible = false;
            buttonSaveDetails.Visible = true;
            editDetailsButton.Visible = false;

            Customer customer = new Customer();
            customer.EditPersonalDetails(LoginUsername);

            textBox1.Text = customer.userName;
            textBox2.Text = customer.password;
            textBox3.Text = customer.forName;
            textBox4.Text = customer.surName;
            textBox5.Text = customer.address;
            textBox6.Text = customer.phoneNumber;
            textBox7.Text = customer.email;
            

        }

        private void buttonSaveDetails_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            Password = textBox2.Text;
            Fname = textBox3.Text;
            Sname = textBox4.Text;
            Address = textBox5.Text;
            PhoneNum = textBox6.Text;
            Email = textBox7.Text;

            Customer customer = new Customer();
            customer.UpdateDetails(Username, Password, Fname, Sname, Address, PhoneNum, Email, LoginUsername);
            label11.Text = LoginUsername;

            MessageBox.Show("Details saved");

            RegisterPanel.Visible = false;
            AccountPanel.Visible = true;
            
        }
    }
}
