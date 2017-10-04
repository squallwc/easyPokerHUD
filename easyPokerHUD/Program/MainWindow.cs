using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyPokerHUD
{
    public partial class MainWindow : Form
    {
        public static volatile bool hasLicense = false;
        Timer fileWatcherStatusUpdateTimer = new Timer();

        public MainWindow()
        {
            InitializeComponent();

            //Set the version number label to the current version
            this.versionNumberLabel.Text = "v " + ApplicationUpdater.getCurrentProductVersion();

            //Get a previously stored licensekey and check if it is valid
            string licenseKey = LicenseCheck.getStoredLicenseKey();
            if (licenseKey != null)
            {
                setLicenseMessages(licenseKey);
            }

            //Activate the file watchers
            Task.Factory.StartNew(() => MainMethods.activateFileWatchers());

            //Start the timer that updates the console
            fileWatcherStatusUpdateTimer.Tick += updateHUDStatus;
            fileWatcherStatusUpdateTimer.Interval = 1500;
            fileWatcherStatusUpdateTimer.Start();

            errorMessage.Click += MainMethods.openQuickStartGuide;
        }

        //Gathers the current status of every filewatcher and displays it as a label 
        public void updateHUDStatus(Object obj, EventArgs e)
        {
            string[] statusStrings = MainMethods.getHUDStatusStrings();

            if (statusStrings[0].Equals(""))
            {
                successMessage.Text = "";
            }
            else
            {
                successMessage.Text = "HUD is up and running for " + statusStrings[0]+".";
            }

            if (statusStrings[1].Equals(""))
            {
                errorMessage.Text = "";
                errorMessage.Hide();
                fileWatcherStatusUpdateTimer.Stop();
            }
            else
            {
                errorMessage.Text = "Could not find hand histories for "+statusStrings[1]+". Click here to see how to fix this.";
            }
        }

        //Checks, if a license key is valid and sets all TextBoxes accordingly
        private void setLicenseMessages(string licenseKey)
        {
            licenseKeyStatusLabel.Text = "Checking License Key...";
            licenseKeyTextBox.Text = licenseKey;

            if (LicenseCheck.isLicenseValid(licenseKey))
            {
                licenseKeyStatusLabel.Text = "You are using the pro version!";
                hasLicense = true;
                buyButton.Visible = false;
                buyMessage.Text = "May the flop be with you!";
                checkLicenseKeyButton.Text = "Thank you";
            } else
            {
                licenseKeyStatusLabel.Text = "License Key is not valid!";
                hasLicense = false;
            }
        }

        //Makes sure, that every thread is being closed
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (hasLicense)
            {
                buyMessage.Text = "Writing players to database...";
                PokerStarsMain.updatePlayersInDatabaseFromCache();
                EightPokerMain.updatePlayersInDatabaseFromCache();
            }
            Environment.Exit(Environment.ExitCode);
            base.OnClosing(e);
        }

        //Checks a newly entered license key
        private void checkLicenseKeyButton_Click(object sender, EventArgs e)
        {
            string licenseKey = licenseKeyTextBox.Text;
            LicenseCheck.storeLicenseKey(licenseKey);
            setLicenseMessages(licenseKey);
        }

        //Opens the checkout page whenever it is clicked
        private void buyButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://easyPokerHUD.com/checkout?edd_action=add_to_cart&download_id=175");
        }
    }
}
