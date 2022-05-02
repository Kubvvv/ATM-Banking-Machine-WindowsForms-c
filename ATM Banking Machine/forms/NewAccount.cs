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

            if(accNumTb.Text == "" || nameTb.Text == "" || surnameTb.Text == "" || addressTb.Text == "" || pinTb.Text == "" || educationCb.Text == "" || occupationTb.Text == "")
            {
                MessageBox.Show("Something went wrong, try again");
            }else
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

        private void backLbl_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        } //back to login page
        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //exiting the app
    }
}