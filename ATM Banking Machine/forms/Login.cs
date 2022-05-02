using ATM_Banking_Machine.Data;
using System.Data;

namespace ATM_Banking_Machine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static String accNumber;
        private void exitLbl_Click(object sender, EventArgs e) //exiting the app
        {
            Application.Exit();
        }

        private void signupBtn_Click(object sender, EventArgs e) //after clicking signup label, open newaccount page
        {
            NewAccount na = new NewAccount();
            this.Hide();
            na.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginCheck();
        }

        public void loginCheck()
        {
            using ATMDb context = new ATMDb();

                if (loginAccNumTb.Text == "")
                {
                    MessageBox.Show("Account number can't be empty!");
                }
                else if (loginPinTb.Text == "")
                {
                    MessageBox.Show("PIN can't be empty!");
                }
                else
                {
                    var rec = context.Accounts.Where(x => x.AccNum == loginAccNumTb.Text && x.PIN == Convert.ToInt32(loginPinTb.Text)).FirstOrDefault();

                    if (rec != null)
                    {
                        MessageBox.Show("Login Success!");
                    accNumber = loginAccNumTb.Text;
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong AccNum or PIN");
                    }
                }
            }
        }
        
        
        
    }
