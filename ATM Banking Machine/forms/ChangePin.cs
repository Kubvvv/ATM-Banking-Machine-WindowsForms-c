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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void exitLbl_Click(object sender, EventArgs e) //exit app
        {
            Application.Exit();
        }

        string acc = Login.accNumber;

        private void pinChangeBtn_Click(object sender, EventArgs e)
        {
            using ATMDb context = new ATMDb();
            var oldPin = context.Accounts.Where(x => x.AccNum == acc && x.PIN == Convert.ToInt32(oldPinTb.Text)).FirstOrDefault();
            if (oldPinTb.Text == "" || newPinTb.Text == "" || confirmNewPinTb.Text == "")
            {
                MessageBox.Show("You're missing something!");
            }
            else if(newPinTb.Text != confirmNewPinTb.Text)
            {
                MessageBox.Show("New pin and pin confirmation must be the same");
            }
            else if(oldPin == null)
            {
                MessageBox.Show("Wrong old pin!");
            }
            else if(oldPinTb.Text == newPinTb.Text)
            {
                MessageBox.Show("New pin must be different from the old pin!");
            }
            else
            {
                var res = context.Accounts.SingleOrDefault(x => x.AccNum == acc);
                if (res != null)
                {
                    res.PIN = Convert.ToInt32(newPinTb.Text);
                    context.SaveChanges();
                    MessageBox.Show("PIN Changed !");
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
            }
        } //method changing the pin if everything is correct

        private void backPB_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }//back to menu picture
    }
}
