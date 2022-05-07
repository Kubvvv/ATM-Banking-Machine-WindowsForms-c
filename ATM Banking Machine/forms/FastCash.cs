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
using Transaction = ATM_Banking_Machine.Models.Transaction;

namespace ATM_Banking_Machine
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        string acc = Login.accNumber;
        int balance, newBalance;

        private void FastCash_Load(object sender, EventArgs e) //loading getBalance method
        {
            getBalance();
        }
        private void getBalance() //getting actuall balance from database and putting it into lbl
        {
            using ATMDb context = new ATMDb();
            balance = context.Accounts.Where(x => x.AccNum == acc).FirstOrDefault().Balance;
            availableBalanceLbl.Text = $"Balance: {balance.ToString()} €";
        }
        

        private void backLbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        } //back to menu

        private void exitLbl_Click(object sender, EventArgs e) //exit app
        {
            Application.Exit();
        }

        private void fastCash10_Click(object sender, EventArgs e) //fastCash 10Euro
        {
            changeBalance(10);
        }

        private void fastCash20_Click(object sender, EventArgs e)
        {
            changeBalance(20);
        }//fastCash 20Euro

        private void fastCash50_Click(object sender, EventArgs e)
        {
            changeBalance(50);
        }//fastCash 50Euro
        private void fastCash100_Click(object sender, EventArgs e)
        {
            changeBalance(100);
        }//fastCash 100Euro

        private void fastCash200_Click(object sender, EventArgs e)
        {
            changeBalance(200);
        }//fastCash 200Euro

        private void fastCash500_Click(object sender, EventArgs e)
        {
            changeBalance(500);
        }//fastCash 500Euro



        private void changeBalance(int x)
        {
            if (balance < x)
            {
                MessageBox.Show("You dont have enough money");
            }
            else
            {
                newBalance = balance - x;
                try
                {
                    using ATMDb context = new ATMDb();
                    var res = context.Accounts.SingleOrDefault(x => x.AccNum == acc);
                    if (res != null)
                    {
                        res.Balance = newBalance;
                        context.SaveChanges();
                        MessageBox.Show("Success withdraw");
                        addTransaction(x);
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        } //method that is changing the balance by the x amount, and creating new transaction in database

        private void addTransaction(int x) //adding a record to Transaction database
        {
            using ATMDb context = new ATMDb();
            string trType = "FastCash";
            int accId = context.Accounts.Where(x => x.AccNum == acc).FirstOrDefault().Id;
            try
            {
                Transaction trans = new Transaction()
                {
                    AccountId = accId,
                    AccNum = acc,
                    Type = trType,
                    Amount = x,
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
    }
}
