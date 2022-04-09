using System;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{

    public partial class totalCost : Form
    {



        // Variables brought in from membership extras form for calculations.
        public double dcc = membershipExtras.dietConsultCost;
        public double ptc = membershipExtras.personalTrainerCost;
        public double ovc = membershipExtras.onlineVideosCost;
        public double gac = membershipExtras.gymAccessCost;
        public static double TotalExtras;

        // Variables brought forward for discount calculations
        public double pd = paymentMethod.paymentDiscount;
        public double mld = membershipType.memLengthDiscountAmount;
        public double ma = membershipType.memAmount;
        public double totalDiscount;

        // Variables for working out the total cost
        public double totalCostMem;
        public double tw = membershipType.memWeekLength;

        // Variables for working out the regular payment
        public double rp;
        public double pm = paymentMethod.paymentMonthly;
        public double mml = membershipType.memMonthLenth;




        public totalCost()
        {
            InitializeComponent();
        }

        // When the form is loaded this code brings all the information from the other forms to be displayed 
        // and to make sure that all data is correct and not missing before activation.
        private void totalCost_Load(object sender, EventArgs e)
        {

            tbTCDirectDebit.Text = paymentMethod.directDebit;
            tbTCPayment.Text = paymentMethod.paymentFrequency;
            tbTCDuration.Text = membershipType.membershipLength;
            tbTCMembership.Text = membershipType.membership;
            tbTCExtras.Text = membershipExtras.gymAccess;
            tbTCExtras1.Text = membershipExtras.onlineVideos;
            tbTCExtras2.Text = membershipExtras.personalTrainer;
            tbTCExtras3.Text = membershipExtras.dietConsult;
            Extras();
            Discount();
            totalMemAmount();
            regularPayment();
            date();
            textboxInfoCheck();
            memcodeGenerate();



        }

        // Calculation for the total extras
        private void Extras()
        {
            TotalExtras = dcc + ptc + ovc + gac;
            tbTCTotalExtras.Text = String.Format("$" + TotalExtras);
        }

        // Calculation for total discount amount
        private void Discount()
        {
            double D;
            D = ma * pd;
            totalDiscount = D + mld;

            tbTCTotalDiscount.Text = String.Format("$" + totalDiscount);
        }

        // Calculation to work out the total cost of the membership
        private void totalMemAmount()
        {
            double D;
            double DD;
            D = ma + TotalExtras;
            DD = D - totalDiscount;
            totalCostMem = DD * tw;
            tbTCTotalCost.Text = String.Format("$" + totalCostMem);
        }

        // Calculation to work out the regular payment
        private void regularPayment()
        {

            if (pm == 1)
            {
                rp = totalCostMem / mml;
                rp = Math.Round(rp, 2);
                tbTCRegularPayment.Text = String.Format("$" + rp);
            }
            else
            {
                rp = totalCostMem / tw;
                rp = Math.Round(rp, 2);
                tbTCRegularPayment.Text = String.Format("$" + rp);
            }
        }

        // This code takes the current time and adds the membership length and works out the expiry date.
        private void date()
        {

            var dt = DateTime.Now.AddMonths(Convert.ToInt32(mml));


            tbExpiryDate.Text = dt.ToString();
        }



        private void dataSavedToMemberTable()
        {
            // This code stores the data into the database. Code referenced from Stackoverflow.com/questions/12142806/how-to-insert-records-in-database
            string sm = null;
            string connectionString = null;

            connectionString = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\wesde\source\repos\Membership Form Complete with code1\Membership Form Complete with code1\GymDataBase.mdf;Integrated Security = True");
            sm = ("insert into Member([FirstName],[Surname],[StreetAdd],[Suburb],[Town],[PostCode],[Mobile],[PaymentFrequency],[MembershipExpiry],[Videos], [PersonalTrainer],[GymAccess],[DietConsult], [MemberCode]) values(@FirstName, @Surname, @StreetAdd, @Suburb, @Town, @PostCode, @Mobile, @PaymentFrequency, @MembershipExpiry, @Videos,@PersonalTrainer, @GymAccess, @DietConsult, @MemberCode)");

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sm, cnn))
                    {
                        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = tbTCFirstName.Text;
                        cmd.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = tbTCSurname.Text;
                        cmd.Parameters.Add("@StreetAdd", SqlDbType.NVarChar).Value = tbTCStreetAdd.Text;
                        cmd.Parameters.Add("@Suburb", SqlDbType.NVarChar).Value = tbTCSuburb.Text;
                        cmd.Parameters.Add("@Town", SqlDbType.NVarChar).Value = tbTCTown.Text;
                        cmd.Parameters.Add("@PostCode", SqlDbType.NVarChar).Value = tbTCPostCode.Text;
                        cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = tbTCMobile.Text;
                        cmd.Parameters.Add("@PaymentFrequency", SqlDbType.NVarChar).Value = tbTCPayment.Text;
                        cmd.Parameters.Add("@MembershipExpiry", SqlDbType.NVarChar).Value = tbExpiryDate.Text;
                        cmd.Parameters.Add("@GymAccess", SqlDbType.NVarChar).Value = tbTCExtras.Text;
                        cmd.Parameters.Add("@Videos", SqlDbType.NVarChar).Value = tbTCExtras1.Text;
                        cmd.Parameters.Add("@PersonalTrainer", SqlDbType.NVarChar).Value = tbTCExtras2.Text;
                        cmd.Parameters.Add("@DietConsult", SqlDbType.NVarChar).Value = tbTCExtras3.Text;
                        cmd.Parameters.Add("@MemberCode", SqlDbType.NVarChar).Value = tbTCMembershipCode.Text;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row Inserted");

                        }
                        else
                        {
                            MessageBox.Show("None");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        // Data stored to the other table Membership Type
        private void dataSavedtoMembershipTable()
        {
            string sm = null;
            string connectionString = null;

            connectionString = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\wesde\source\repos\Membership Form Complete with code1\Membership Form Complete with code1\GymDataBase.mdf;Integrated Security = True");
            sm = ("insert into Membership([Membershiptype], [Cost], [MemberCode1]) values(@Membershiptype, @Cost, @MemberCode1)");

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sm, cnn))
                    {
                        cmd.Parameters.Add("@Membershiptype", SqlDbType.NVarChar).Value = tbTCMembership.Text;
                        cmd.Parameters.Add("@Cost", SqlDbType.NVarChar).Value = tbTCTotalCost.Text;
                        cmd.Parameters.Add("@MemberCode1", SqlDbType.NVarChar).Value = tbTCMembershipCode.Text;


                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                cnn.Close();
            }

        }
        private void memberCodeCheck()
        {
            //This code will check to see if the membership code already exists in the data base.

            string connectionString = null;
            connectionString = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\wesde\source\repos\Membership Form Complete with code1\Membership Form Complete with code1\GymDataBase.mdf;Integrated Security = True");
            string query = "select count(*) from Member where MemberCode = @MemberCode";

            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmddatabase = new SqlCommand(query, cnn);
            cmddatabase.Parameters.AddWithValue("@MemberCode", tbTCMembershipCode.Text.Trim());

            cnn.Open();
            int count = Convert.ToInt32(cmddatabase.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Member Code Exists" + tbTCMembershipCode.Text);
            }
        }

        // We check to see if the membership code exists before the membership is activated.
        private void tbTCMembershipCode_Leave(object sender, EventArgs e)
        {

            memberCodeCheck();
        }

        // The code below is a validation check. All text boxes that are required and are empty will be displayed red.
        private void textboxInfoCheck()
        {


            if (string.IsNullOrEmpty(tbTCFirstName.Text) || string.IsNullOrEmpty(tbTCSurname.Text) || string.IsNullOrEmpty(tbTCStreetAdd.Text)
                || string.IsNullOrEmpty(tbTCTown.Text) || string.IsNullOrEmpty(tbTCPostCode.Text) || string.IsNullOrEmpty(tbTCPayment.Text)
                || string.IsNullOrEmpty(tbTCDirectDebit.Text) || string.IsNullOrEmpty(tbTCMembership.Text)
                || string.IsNullOrEmpty(tbTCDuration.Text))
            {

                MessageBox.Show("Please complete the info required");

            }

        }



        // this code will auto generate the next membercode to use.
        private void memcodeGenerate()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\wesde\source\repos\Membership Form Complete with code1\Membership Form Complete with code1\GymDataBase.mdf;Integrated Security = True");
            SqlDataReader dr;

            SqlCommand comm2 = new SqlCommand("SELECT * FROM Member WHERE MemberCode = (SELECT MAX(MemberCode) from Member)");

            comm2.Connection = conn;
            conn.Open();
            dr = comm2.ExecuteReader();

            while (dr.Read())
            {
                string C;
                int CC;
                C = dr[0].ToString();
                CC = int.Parse(C) + 1;
                tbTCMembershipCode.Text = CC.ToString();


            }
            dr.Close();
            conn.Close();



        }

        // Membership activation button
        private void button5_Click(object sender, EventArgs e)
        {
            textboxCheckInfo();
            
            
        }

        // this code will check to see if all info is correct before it is saved to the data base.
        private void textboxCheckInfo()
        {
            if (string.IsNullOrEmpty(tbTCFirstName.Text) || string.IsNullOrEmpty(tbTCSurname.Text) || string.IsNullOrEmpty(tbTCStreetAdd.Text)
                 || string.IsNullOrEmpty(tbTCTown.Text) || string.IsNullOrEmpty(tbTCPostCode.Text) || string.IsNullOrEmpty(tbTCPayment.Text)
                 || string.IsNullOrEmpty(tbTCDirectDebit.Text) || string.IsNullOrEmpty(tbTCMembership.Text)
                 || string.IsNullOrEmpty(tbTCDuration.Text))
            {
                MessageBox.Show("Information is still required");
                
            }
            else
            {
                MessageBox.Show("Data has been saved");
                dataSavedtoMembershipTable();
                dataSavedToMemberTable();

                Properties.Settings.Default.Reset();
            }
        }


    }
}