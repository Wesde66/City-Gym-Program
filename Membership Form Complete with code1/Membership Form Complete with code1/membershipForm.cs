using System;

using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{
    public partial class membershipForm : Form
    {
        
        public membershipForm()
        {
            InitializeComponent();
        }

        //This code snippet has been taken from EA Channelearn youtube video on "Load muutiple forms in the panel using c#"
        public void loadform(object Form)
        {

            if (this.mainPanelMemberFrom.Controls.Count > 0)
                this.mainPanelMemberFrom.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelMemberFrom.Controls.Add(f);
            this.mainPanelMemberFrom.Tag = f;
            f.Show();
        }

        // Below are the button click events for loading the forms in a panel on the main form.
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new personalInformation());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new membershipType());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new membershipExtras());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new paymentMethod());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new totalCost());




        }

        // this button click will reset the settings. We have done this so that when the program is closed
        // the clients details will not appear when they are opened.
        // We also exit the application from here.
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

        private void button7_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
