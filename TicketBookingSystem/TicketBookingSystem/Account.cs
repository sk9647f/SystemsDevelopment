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
        public static string LoginUsername;
        string LoginPassword;
        string Username;
        string Password;
        string Fname;
        string Sname;
        string Address;
        string PhoneNum;
        string Email;
        bool staffAccount;

        string Title;
        string Genre;
        string Description;
        DateTime DateOfPlay;
        DateTime TimeOfPlay;
        int TicketsAvailable;
        int TicketQuantity;
        string TitleS;
        DateTime DateOfPlayS;
        DateTime TimeOfPlayS;

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
            PlaysPanel.Visible = false;
            deletePlayPanel.Visible = false;
            



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
                    staffAccount = Convert.ToBoolean(res["Staff"]);
                    if (staffAccount)
                    {
                        StaffAccountPanel.Visible = true;
                        AccountPanel.Visible = false;
                    }




                }


                label11.Text = LoginUsername;
                label13.Text = LoginUsername;
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
            editDetailsButton.Visible = false;

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
            StaffAccountPanel.Visible = false;
            PlaysPanel.Visible = true;
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
            LoginUsername = Username;
            label11.Text = LoginUsername;

            MessageBox.Show("Details saved");

            RegisterPanel.Visible = false;
            AccountPanel.Visible = true;
            
        }

        private void submitPlayButton_Click(object sender, EventArgs e)
        {

            Title = textBox8.Text;
            Genre = textBox9.Text;
            Description = textBox10.Text;
            DateOfPlay = dateTimePicker1.Value;
            TimeOfPlay = dateTimePicker2.Value;
            TicketsAvailable = Convert.ToInt32(textBox11.Text);
            TicketQuantity = Convert.ToInt32(textBox12.Text);



            Staff staff = new Staff();
            staff.AddPlay(Title, Genre, Description, DateOfPlay, TimeOfPlay, TicketsAvailable, TicketQuantity);

            MessageBox.Show("Play Added To System");

            PlaysPanel.Visible = false;
            StaffAccountPanel.Visible = true;
        }

        

        private void deletePlaySubmitButton_Click(object sender, EventArgs e)
        {
            Title = textBox15.Text;
            DateOfPlay = dateTimePicker3.Value;
            TimeOfPlay = dateTimePicker4.Value;


            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM Plays WHERE Title = @Title AND DateOfPlay = @DateOfPlay AND TimeOfPlay = @TimeOfPlay", myConnection);

            myCommand.Parameters.AddWithValue("@Title", Title);
            myCommand.Parameters.AddWithValue("@DateOfPlay", DateOfPlay);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", TimeOfPlay);


            OleDbDataReader re = myCommand.ExecuteReader();


            if (re.Read() == true)
            {

                var confirmResult = MessageBox.Show("Are you sure to delete this play? " + "\n" + Title + " " + DateOfPlay.ToShortDateString() + " " + TimeOfPlay.ToShortTimeString(), "Confirm Delete?",
                                               MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    Staff staff = new Staff();
                    staff.DeletePlay(Title, DateOfPlay, TimeOfPlay);

                    deletePlayPanel.Visible = false;
                    StaffAccountPanel.Visible = true;

                }
                else
                {
                    // If 'No', do something here.
                }

            }
            else
            {
                MessageBox.Show("Play not found");
            }
        }

        private void EditPlayButton_Click(object sender, EventArgs e)
        {
            StaffAccountPanel.Visible = false;
            deletePlaySubmitButton.Visible = true;
            deletePlayPanel.Visible = true;
            searchPlayEditbutton.Visible = true;

        }

        private void searchPlayEditbutton_Click(object sender, EventArgs e)
        {

            

            Title = textBox15.Text;
            DateOfPlay = dateTimePicker3.Value;
            TimeOfPlay = dateTimePicker4.Value;

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM Plays WHERE Title = @Title AND DateOfPlay = @DateOfPlay AND TimeOfPlay = @TimeOfPlay", myConnection);

            myCommand.Parameters.AddWithValue("@Title", Title);
            myCommand.Parameters.AddWithValue("@DateOfPlay", DateOfPlay);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", TimeOfPlay);


            OleDbDataReader re = myCommand.ExecuteReader();


            if (re.Read() == true)
            {

                deletePlayPanel.Visible = false;
                PlaysPanel.Visible = true;
                submitPlayButton.Visible = false;
                savePlayDetailsbutton.Visible = true;

                TitleS = textBox15.Text;
                DateOfPlayS = dateTimePicker3.Value;
                TimeOfPlayS = dateTimePicker4.Value;

                Staff staff = new Staff();
                staff.EditPlay(Title, DateOfPlay, TimeOfPlay);


                textBox8.Text = staff.titleE;
                textBox9.Text = staff.genreE;
                textBox10.Text = staff.descriptionE;
                dateTimePicker1.Value = staff.dateOfPlayE;
                dateTimePicker2.Value = staff.timeOfPlayE;
                textBox11.Text = staff.ticketsAvailableE.ToString();
                textBox12.Text = staff.ticketQuantityE.ToString();
            }
            else
            {
                MessageBox.Show("Play not found");
            }


        }

        private void savePlayDetailsbutton_Click(object sender, EventArgs e)
        {
            Title = textBox8.Text;
            Genre = textBox9.Text;
            Description = textBox10.Text;
            DateOfPlay = dateTimePicker1.Value;
            TimeOfPlay = dateTimePicker2.Value;
            TicketsAvailable = Convert.ToInt32(textBox11.Text);
            TicketQuantity = Convert.ToInt32(textBox12.Text);

            Staff staff = new Staff();
            staff.UpdatePlay(Title, Genre, Description, DateOfPlay, TimeOfPlay, TicketsAvailable, TicketQuantity, TitleS, DateOfPlayS, TimeOfPlayS);

            MessageBox.Show("Play Details saved");

            PlaysPanel.Visible = false;
            StaffAccountPanel.Visible = true;
        }

        private void RegisterBackbutton_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = false;
            AccountPanel.Visible = true;
        }

        private void deletePlayBackbutton_Click(object sender, EventArgs e)
        {
            deletePlayPanel.Visible = false;
            StaffAccountPanel.Visible = true;
        }

        private void playsBackbutton_Click(object sender, EventArgs e)
        {
            PlaysPanel.Visible = false;
            StaffAccountPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
