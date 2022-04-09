using System;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{
    public partial class searchMembers : Form
    {
       // Connection string used in methods bellow
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\wesde\source\repos\Membership Form Complete with code1\Membership Form Complete with code1\GymDataBase.mdf;Integrated Security = True");
        public searchMembers()
        {
            InitializeComponent();
        }

        // This will bring up the main menu and hide the current one
        private void button4_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }

        // Loads the datagrid with info as the form is loaded
        private void searchMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataBaseDataSet.SearchMember' table. You can move, or remove it, as needed.
            this.searchMemberTableAdapter.Fill(this.gymDataBaseDataSet.SearchMember);
            loadDataGrid();

        }

        private void loadDataGrid()
        {
            
            

            // This is the connection to the data base this will fill the data grid view with all the clients.

           
            SqlCommand com;
            

            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select * from SearchMember";
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }

            finally
            {
                con.Close();
            }
        }

        // This will clear the search and populate the datagrid again
        private void button5_Click(object sender, EventArgs e)
        {
            loadDataGrid();
            textBox1.Clear();
            textBox2.Clear();   
            textBox3.Clear();
        }

        //When the text box is populated the search begins as you type
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[FirstName] LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
            
            

            con.Close();
        }

        //When the text box is populated the search begins as you type
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[Surname] LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = bs;



            con.Close();
        }

        //When the text box is populated the search begins as you type
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[Membershiptype] LIKE '%" + textBox3.Text + "%'";
            dataGridView1.DataSource = bs;



            con.Close();
        }

        // This will close the aplication. Message bax apears first to confirm
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



    }
    
}
