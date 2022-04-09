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
    public partial class fintnessClassBooking : Form
    {
        public fintnessClassBooking()
        {
            InitializeComponent();
        }

        private void fitnessClassBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fitnessClassBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDataBaseDataSet);

        }

        private void fintnessClassBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter.Fill(this.gymDataBaseDataSet.View);
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.FitnessClass' table. You can move, or remove it, as needed.
            this.fitnessClassTableAdapter.Fill(this.gymDataBaseDataSet.FitnessClass);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
