using RykonServer;
using RykonServer.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Principal;

namespace RykonServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain main = new FormMain();
            string d = AppHelper.ReturnAllTime();
             
            bool isAcceptedLicense = true;
            d = "Last Edit at " + d;  
            try
            {
                System.IO.File.WriteAllText(Application.StartupPath + "lastInfo.txt", d);
            }
            catch { }

            if (!AppHelper.IsUserAdministrator())
            {
                AppHelper.ViewHowToRunAsAdmin(true);
                return;
            }

            if (!SettingsEditor.GetDonotViewIntro())
            {
              if (new Forms.FrmIntro().ShowDialog() != DialogResult.OK)
                    isAcceptedLicense = false;

            }


            if (isAcceptedLicense)
            {
                Application.Run(main);
                 
            }
        }
         public static string GithUbURl ="https://github.com/4neso/Rykon";
    }
}
