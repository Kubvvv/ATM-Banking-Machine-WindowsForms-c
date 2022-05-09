using ATM_Banking_Machine.Data;
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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            accNumberLbl.Text = Home.accNumber;
            getBalance();
        }
        private void getBalance() //getting actuall balance from database and putting it into lbl
        {
            using ATMDb context = new ATMDb();
            balanceEuroLbl.Text = (context.Accounts.Where(x => x.AccNum == Home.accNumber).FirstOrDefault().Balance).ToString()+ "€";
        }

        private void exitLbl_Click(object sender, EventArgs e)//exit app lbl
        {
            Application.Exit();
        }

        private void backPB_Click(object sender, EventArgs e)//back to home page
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
