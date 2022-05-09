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
