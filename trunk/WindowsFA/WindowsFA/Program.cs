using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFA
{
    static class Program
    {
        public static Configuration cApp;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new WFA());
            try
            {
                cApp = Configuration.Deserialize("config.xml");
                if (cApp.StartupFormIndex == 0)
                {
                    Application.Run(new FormTVMMortgage());
                }
                if (cApp.StartupFormIndex == 1)
                {
                    Application.Run(new FormCFLO());
                }
                if (cApp.StartupFormIndex == 2)
                {
                    Application.Run(new FormPE());
                }
                //
                //if (cApp.InetConnectionIndex == 1)
                //{
                //    proxyURL = (cApp.ProxyURL);
                //}
                //else
                //{
                //    proxyURL = string.Empty;
                //}
            }
            catch (System.IO.FileNotFoundException)
            {
                cApp = new Configuration();
                Application.Run(new FormTVMMortgage());
            }

        }

    }
}