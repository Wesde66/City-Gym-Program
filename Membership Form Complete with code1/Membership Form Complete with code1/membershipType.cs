using System;
using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{
    public partial class membershipType : Form
    {
        public static string membership;
        public static double memAmount;
        public static string membershipLength;
        public static double memLengthDiscountAmount;
        public static double memWeekLength;
        public static double memMonthLenth;


        public membershipType()
        {
            InitializeComponent();
        }


        //This code is run when form is closed. 
        // We save the settings if the client returns they do not need to fill everything back in
        // We also run the methods below so the information is sent to the total cost form.
        private void membershipType_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            typeMemebrship();
            lengthMembership();


        }

        // The below methods are working out what gets sent to the total cost form
        public void typeMemebrship()
        {
            if (rbBasicMembership.Checked == true)
            {
                membership = "Basic membership selected";
                memAmount = 10;
            }
            else if (rbRegularMembership.Checked == true)
            {
                membership = "Regular membership selected";
                memAmount = 15;
            }
            else if (rbPremiumMembership.Checked)
            {
                membership = "Premium membership selected";
                memAmount = 20;
            }
            else
                membership = "Error nothing selected";
        }

        public void lengthMembership()
        {
            if (rb3MonthMembership.Checked == true)
            {
                membershipLength = "3 Months selected";
                memWeekLength = 13;
                memMonthLenth = 3;

            }
            else if (rb1YearMembership.Checked == true)
            {
                membershipLength = "1 year selected";
                memLengthDiscountAmount = 2;
                memWeekLength = 52;
                memMonthLenth = 12;
            }
            else if (rb2YearMembership.Checked == true)
            {
                membershipLength = "2 years selected";
                memLengthDiscountAmount = 5;
                memWeekLength = 104;
                memMonthLenth = 24;
            }
            else
                membershipLength = "Error nothing selected";

        }



    }
}
