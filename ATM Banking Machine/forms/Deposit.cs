using ATM_Banking_Machine.Data;
using ATM_Banking_Machine.Models;
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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        string acc = Login.accNumber; //accountNumber

        private void backLbl_Click(object sender, EventArgs e) //back to home menu
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void exitLbl_Click(object sender, EventArgs e)//exiting the app
        {
            Application.Exit();
        }

        private void depositBtn_Click(object sender, EventArgs e) //adding deposit amount to overall balance in database account, and creating transaction
        {
            if(depositAmountTb.Text == "" || Convert.ToInt32(depositAmountTb.Text) <= 0)
            {
                MessageBox.Show("Enter the amount to deposit!");
            }
            else
            {
                newBalance = oldBalance + Convert.ToInt32(depositAmountTb.Text); //updating the balance
                try
                {
                    using ATMDb context = new ATMDb();
                    var res = context.Accounts.SingleOrDefault(x => x.AccNum == acc);
                    if(res != null)
                    {
                        res.Balance = newBalance;
                        context.SaveChanges();
                        MessageBox.Show("Success deposit");
                        addTransaction();
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int oldBalance, newBalance;

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }//loading the getBalance method

        private void getBalance() //getting actuall balance from database
        {
            using ATMDb context = new ATMDb();
            oldBalance = context.Accounts.Where(x => x.AccNum == acc).FirstOrDefault().Balance;
        }

        private void addTransaction() //adding a record to Transaction database
        {
            using ATMDb context = new ATMDb();
            string trType = "Deposit";
            int accId = context.Accounts.Where(x => x.AccNum == acc).FirstOrDefault().Id;
            try
            {
                Transaction trans = new Transaction()
                {
                    AccountId = accId,
                    AccNum = acc,
                    Type = trType,
                    Amount = Convert.ToInt32(depositAmountTb.Text),
                    TransactionDate = DateTime.Today.Date.ToString(),
                };
                context.Add(trans);
                context.SaveChanges();

            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
