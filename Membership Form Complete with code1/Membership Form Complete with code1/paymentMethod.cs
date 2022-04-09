using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{
    public partial class paymentMethod : Form
    {
        public static string directDebit;
        public static string paymentFrequency;
        public static double paymentDiscount;
        public static double paymentMonthly;



        public paymentMethod()
        {
            InitializeComponent();
        }


        private void paymentMethod_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            payment();
            discountPayment();

        }



        private void payment()
        {
            if (rbWeeklyPayment.Checked == true)
            {
                paymentFrequency = "Weekly Payments";
                paymentMonthly = 0;

            }
            else if (rbMonthlyPayment.Checked == true)
            {
                paymentFrequency = "Monthly payments";
                paymentMonthly = 1;


            }
            else
                paymentFrequency = "Error nothing selected";
        }

        private void discountPayment()
        {
            if (rbDirectDebitYes.Checked)
            {
                paymentDiscount = 0.1;
                directDebit = "Debit Selected";
            }

            else
            {
                paymentDiscount = 0;
                directDebit = "Debit not selected";
            }
        }

    }
}
