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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
