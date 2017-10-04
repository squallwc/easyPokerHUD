using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace easyPokerHUD
{
    class LicenseCheck
    {
        static string userSettingsFolderPath = @Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\easyPokerHUD\UserSettings\";

        //Checks whether a license is valid or not and returns true or false
        public static Boolean isLicenseValid(string licenseKey)
        {
            string responseFromServer = checkLicenseKeyWithAPI(licenseKey);
            if (responseFromServer != null && responseFromServer.Contains("true") && responseFromServer.Contains("inactive"))
            {
                return true;
            }
            return false;
        }

        //Gets details about a license key from the EDD-License-Keys-API of easypokerhud.com
        private static string checkLicenseKeyWithAPI(string licenseKey)
        {
            try
            {
                // Create a request using a URL that can receive a post.
                WebRequest request = WebRequest.Create("https://easyPokerHUD.com/edd-sl");

                // Set the Method property of the request to POST.
                request.Method = "POST";

                // Create POST data and convert it to a byte array. Do not include the URL if you do URL verification in the EDD SL settings
                string postData = "edd_action=check_license&license=" + licenseKey + "&item_name=easyPokerHUD";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                // Get the response.
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                // Read the content. This is the response from the Software Licensing API
                string responseFromServer = reader.ReadToEnd();

                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            } catch
            {
                MessageBox.Show("Could not connect to the server and validate your license. Please connect to the internet and try again.");
                return null;
            }
        }

        //Returns a previously stored license key
        public static string getStoredLicenseKey()
        {
            try
            {
                string licenseKey = File.ReadAllText(userSettingsFolderPath + "licenseKey.txt");
                return licenseKey;
            }
            catch
            {
                return null;
            }
        }

        //Stores a license key in the userSettings
        public static void storeLicenseKey(String licenseKey)
        {
            Directory.CreateDirectory(userSettingsFolderPath);
            File.WriteAllText(userSettingsFolderPath + "licenseKey.txt", licenseKey);
        }
    }
}
