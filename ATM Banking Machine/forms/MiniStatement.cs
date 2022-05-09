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
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }

        private void backLbl_Click(object sender, EventArgs e) //back to menu
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        private void exitLbl_Click(object sender, EventArgs e) //exit to menu
        {
            Application.Exit();
        }

        string acc = Login.accNumber;

        private void miniStatementShow()
        {
            using ATMDb context = new ATMDb();
            var statement = from x in context.Transactions
                            select new
                            {
                                Id = x.Id,
                                Type = x.Type,
                                Amount = x.Amount,
                                Date = x.TransactionDate
                            };
            var tylko5 = statement.OrderByDescending(x => x.Id).Take(5);
            miniStatementDGV.DataSource = tylko5.ToList();
        }
        private void MiniStatement_Load(object sender, EventArgs e)
        {
            miniStatementShow();
        }
    }
}
