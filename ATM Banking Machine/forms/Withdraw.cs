using ATM_Banking_Machine.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Transaction = ATM_Banking_Machine.Models.Transaction;

namespace ATM_Banking_Machine
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        string acc = Login.accNumber;
        int balance, newBalance;
        private void getBalance() //getting actuall balance from database and putting it into lbl
        {
            using ATMDb context = new ATMDb();
            balance = context.Accounts.Where(x => x.AccNum == acc).FirstOrDefault().Balance;
            availableBalanceLbl.Text = $"Balance: {balance.ToString()} €";
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        } //loading getBalance method

        private void withdrawBtn_Click(object sender, EventArgs e) //if withdraw amount is bigger than 0, and is not null, update actuall balance, and add transaction to database
        {
            if(withdrawAmountTb.Text == "" || Convert.ToInt32(withdrawAmountTb.Text) <= 0)
            {
                MessageBox.Show("Wrong amount, try again");
            }
            else if(Convert.ToInt32(withdrawAmountTb.Text) > balance)
            {
                MessageBox.Show("You dont have enought money!");
            }
            else
            {
                newBalance = balance - Convert.ToInt32(withdrawAmountTb.Text);
                using ATMDb context = new ATMDb();
                var res = context.Accounts.SingleOrDefault(x => x.AccNum == acc);
                if (res != null)
                {
                    res.Balance = newBalance;
                    context.SaveChanges();
                    MessageBox.Show("Success withdraw");
                    addTransaction();
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
            }
            
        }

        private void addTransaction() //adding a record to Transaction database
        {
            using ATMDb context = new ATMDb();
            string trType = "Withdraw";
            int accId = context.Accounts.Where(x => x.AccNum == acc).FirstOrDefault().Id;
            try
            {
                Transaction trans = new Transaction()
                {
                    AccountId = accId,
                    AccNum = acc,
                    Type = trType,
                    Amount = Convert.ToInt32(withdrawAmountTb.Text),
                    TransactionDate = DateTime.Today.Date.ToString(),
                };
                context.Add(trans);
                context.SaveChanges();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        } //back to home label

        private void exitLbl_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }
    }
}
