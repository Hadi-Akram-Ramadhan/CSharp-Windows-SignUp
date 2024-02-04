using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VpApp2
{
    public partial class SignUp : Form
    {

        public static string FName;
        public static string LName;
        public static string Email;
        public static Boolean sms;
        public static Boolean report;
        public static Boolean TReport;

        Home home = new Home();

        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FName = txbFirstName.Text;
            LName = txbLastName.Text;
            Email = txbEmail.Text;

            home.Show();
           
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMS.Checked == true)
            {
                sms = true;
                lblSMS.Text = "Anda memilih pilihan ini";
            }
            else
            {
                sms = false;
                lblSMS.Text = "...";
            }
        }

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReport.Checked == true)
            {
                report = true;
            }
            else
            {
                report = false;
            }
        }

        private void chkTR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTR.Checked == true)
            {
                TReport = true;
                lblTR.Text = "Anda memilih pilihan ini";
            }
            else
            {
                TReport = false;
                lblTR.Text = "...";
            }
        }
    }
}
