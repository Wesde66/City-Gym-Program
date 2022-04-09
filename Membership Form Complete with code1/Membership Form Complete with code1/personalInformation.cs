using System;

using System.Windows.Forms;


namespace Membership_Form_Complete_with_code1
{
    public partial class personalInformation : Form
    {

        public personalInformation()
        {
            InitializeComponent();
            ;

        }



        public void personalInformation_Leave(object sender, EventArgs e)
        {
            // Saves information on form to the settings.
            Properties.Settings.Default.Save();


        }

        // We restrict the text boxes to letters and numbers they provide an error message if not correct
        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsDigit(e.KeyChar))
            {
                tbFirstName.Focus();
                errorProvider1.SetError(tbFirstName, "Please use letters only");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsDigit(e.KeyChar))
            {
                tbSurname.Focus();
                errorProvider1.SetError(tbSurname, "Please use letters only");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                tbMobile.Focus();
                errorProvider1.SetError(tbMobile, "Numbers only");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbStreetAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(tbStreetAdd.Text))
            {

                tbStreetAdd.Focus();
                errorProvider1.SetError(tbStreetAdd, "Please Complete Your Address");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbSuburb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSuburb.Text))
            {

                tbSuburb.Focus();
                errorProvider1.SetError(tbSuburb, "Please Complete Your Address");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbTown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTown.Text))
            {

                tbTown.Focus();
                errorProvider1.SetError(tbTown, "Please Complete Your Address");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                tbPostCode.Focus();
                errorProvider1.SetError(tbPostCode, "Numbers only");

            }
            else
            {
                errorProvider1.Clear();
            }
        }


    }
}
