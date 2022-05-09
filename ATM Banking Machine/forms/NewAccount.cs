using ATM_Banking_Machine.Data;
using ATM_Banking_Machine.Models;

namespace ATM_Banking_Machine
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        private void creatingAccountBtn_Click(object sender, EventArgs e) //button with addNewAccount method
        {
            addNewAccount();
        }

        private void addNewAccount() //creating account
        {
            int bal = 0;
            using ATMDb context = new ATMDb();
            var isCreated = context.Accounts.SingleOrDefault(x => x.AccNum == accNumTb.Text); // checking if there is an account with the same accnumber
            var isNumeric = int.TryParse(pinTb.Text, out int n);
            if (accNumTb.Text == "" || nameTb.Text == "" || surnameTb.Text == "" || addressTb.Text == "" || pinTb.Text == "" || educationCb.Text == "" || occupationTb.Text == "")
            {
                MessageBox.Show("One of the fields is empty!");
            }
            else if(isCreated != null) //if there is an account with the same accountnumber, it drops a error
            {
                MessageBox.Show("This account number is taken, try something else");
                accNumTb.Text = "";
            }
            else if(pinTb.Text.Length < 4 || isNumeric == false) 
            {
                MessageBox.Show("Pin has to have from 4 to 6 digits, and it has to be only numbers");
            }
            else if(phoneTb.Text.Length != 9)
            {
                MessageBox.Show("Wrong phone number, we need only 9 digits.");
            }
            else
            {
                try
                {
                    Account acc = new Account()
                    {
                        AccNum = accNumTb.Text,
                        Name = nameTb.Text,
                        Surname = surnameTb.Text,
                        DateOfBirth = dateOfBirth.Value.ToShortDateString(),
                        Phone = phoneTb.Text,
                        Address = addressTb.Text,
                        PIN = Convert.ToInt32(pinTb.Text),
                        Education = educationCb.Text,
                        Occupation = occupationTb.Text,
                        Balance = bal,
                    };
                    context.Add(acc);
                    context.SaveChanges();
                    MessageBox.Show("Account created succesfully");
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }
        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //exiting the app

        private void backPB_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }//back to login page
    }
}