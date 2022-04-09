using System;

using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{
    public partial class mainMenu : Form
    {

        int T = 0;
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "All data will be lost if not saved first";
            string title = "Close Form";

            MessageBoxButtons button = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancelled");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            membershipForm membershipForm = new membershipForm();
            membershipForm.Show();
            this.Hide();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

            date();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           searchMembers searchMembers = new searchMembers();
            searchMembers.Show();
            this.Hide();
        }

        private void date()
        {
        
         tbDate.Text = DateTime.Now.ToString();  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fintnessClassBooking fintnessClassBooking = new fintnessClassBooking();
            fintnessClassBooking.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string fileName = @"C:\Users\wesde\source\repos\Membership Form Complete with code1\Membership Form Complete with code1\bin\Manual"; var process = new System.Diagnostics.Process();

            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName};

            process.Start();


        }
    }
}
