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

        public Account()
        {
            InitializeComponent();

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

            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE [Username] = @Username AND [Password] = @Password", myConnection);

            myCommand.Parameters.AddWithValue("@Username", LoginUsername);
            myCommand.Parameters.AddWithValue("@Password", LoginPassword);

            //myCommand.ExecuteNonQuery();
           
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
                //staffCommand.Parameters.AddWithValue("@Staff", staff);
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


            Customer customer = new Customer();
            customer.AddUser(Username, Password, Fname, Sname, Address, PhoneNum, Email);
            MessageBox.Show("Account Created");          

            label11.Text = LoginUsername;
            LoginPanel.Visible = true;
            RegisterPanel.Visible = false;

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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
