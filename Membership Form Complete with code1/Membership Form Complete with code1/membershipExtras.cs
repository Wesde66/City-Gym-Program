using System;

using System.Windows.Forms;

namespace Membership_Form_Complete_with_code1
{
    public partial class membershipExtras : Form
    {
        public static string gymAccess;
        public static int gymAccessCost;
        public static string onlineVideos;
        public static int onlineVideosCost;
        public static string personalTrainer;
        public static int personalTrainerCost;
        public static string dietConsult;
        public static int dietConsultCost;



        public membershipExtras()
        {
            InitializeComponent();
        }


        // These methods are run when the form is closed. We also save the setting so if the client comes back 
        // the information is not lost.
        private void membershipExtras_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            accessGym();
            videosOnline();
            trainerPersonal();
            consultDiet();



        }

        // Creates the methods that need to be loaded when the person leaves the form.
        private void accessGym()
        {
            if (cbAccess.Checked == true)
            {
                gymAccess = "24/7 Access to gym";
                gymAccessCost = 1;
            }
            else
            {
                gymAccess = "";
                gymAccessCost = 0;
            }
        }
        private void videosOnline()
        {
            if (cbVideos.Checked == true)
            {
                onlineVideos = "Online videos selected";
                onlineVideosCost = 2;
            }
            else
            {
                onlineVideos = "";
                onlineVideosCost = 0;
            }


        }
        private void trainerPersonal()
        {
            if (cbTrainer.Checked == true)
            {
                personalTrainer = "Personal trainer selected";
                personalTrainerCost = 20;
            }
            else
            {
                personalTrainer = "";
                personalTrainerCost = 0;
            }

        }
        private void consultDiet()
        {
            if (cbDiet.Checked == true)
            {
                dietConsult = "Diet consultation selected";
                dietConsultCost = 20;
            }
            else
            {
                dietConsult = "";
                dietConsultCost = 0;
            }

        }


    }
}
