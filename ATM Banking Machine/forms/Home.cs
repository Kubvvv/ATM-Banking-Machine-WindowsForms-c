using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Banking_Machine
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  //exiting the app

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        } //back to login page

        public static String accNumber;
        private void Home_Load(object sender, EventArgs e) //changing the accNum label into logged Account Number
        {
            accNumLbl.Text = $"Account number: {Login.accNumber}";
            accNumber = Login.accNumber;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            this.Hide();
            dp.Show();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            this.Hide();
            wd.Show();
        }
    }
}
