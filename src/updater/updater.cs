using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.updater
{
    public class updater
    {
        public static string checkForUpdates(string currentVersion)
        {
            WebClient client = new WebClient();
            String downloadedString = client.DownloadString(@"https://github.com/emimontesdeoca/Backcraft/releases");

            string a = downloadedString.Split(new[] { @"<span class=""css-truncate-target"">" }, StringSplitOptions.None)[1]
                .Split(new[] { @"</span>" }, StringSplitOptions.None)[0];

            if (Convert.ToDouble(a) > Convert.ToDouble(currentVersion))
            {
                return a;
            }
            return currentVersion;
        }

        public static void downloadUpdate(string curv, string ver)
        {
            try
            {
                if (!System.IO.Directory.Exists("updates"))
                {
                    System.IO.Directory.CreateDirectory("updates");
                }

                if (System.IO.File.Exists(@"updates\backcraft_old_" + curv + ".exe"))
                {
                    try
                    {
                        System.IO.File.Delete(@"updates\backcraft_old_" + curv + ".exe");

                    }
                    catch (Exception e)
                    {
                        string a = e.Message;
                    }
                }

                System.IO.File.Move("backcraft.exe", "updates\\backcraft_old_" + curv + ".exe");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/emimontesdeoca/Backcraft/releases/download/"
                        + ver + "/Backcraft.exe", "backcraft.exe");
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
