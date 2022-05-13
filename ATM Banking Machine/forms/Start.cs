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
using System.Windows.Forms;

namespace ATM_Banking_Machine
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int starting = 0;
        
        private void Start_Load(object sender, EventArgs e) //starting the timer
        {
            timer1.Start();
            using ATMDb context = new ATMDb();
            context.Database.EnsureCreated();
            createFirstUser();
        }

        private void createFirstUser() //creates first user if no exist
        {
            using ATMDb context = new ATMDb();
            var isCreated = context.Accounts.SingleOrDefault(x => x.AccNum == "1"); // checking if there is an account with the same accnumber
            if(isCreated == null)
            {
                Account acc = new Account()
                {
                    AccNum = "1",
                    Name = "Jan",
                    Surname = "Kowalski",
                    DateOfBirth = "11.7.1957",
                    Phone = "987123456",
                    Address = "Warszawa",
                    PIN = 1234,
                    Education = "Post-Graduate",
                    Occupation = "Programmer",
                    Balance = 10000,
                };
                context.Add(acc);
                context.SaveChanges();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //progress bar loading
        {
            starting += 4;
            progressBarStart.Value = starting;
            percentageLbl.Text = "" + starting;
            if(progressBarStart.Value == 100)
            {
                progressBarStart.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }
    }
}
