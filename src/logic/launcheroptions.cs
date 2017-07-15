using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class launcheroptions
    {
        const string _txtpath = @"config\launcheroptions.txt";
        public bool enabled { get; set; }

        public launcheroptions(bool enabled)
        {
            this.enabled = enabled;
        }

        public void WriteToFile()
        {
            File.Delete(_txtpath);
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                try
                {
                    tw.WriteLine(this.enabled.ToString());
                }
                catch (Exception)
                {
                }

            }
        }

        public static bool GetLauncherOptions()
        {
            bool res = false;
            try
            {
                using (StreamReader rd = new StreamReader(_txtpath, true))
                {
                    while (true)
                    {
                        try
                        {
                            res = Convert.ToBoolean(rd.ReadLine().Trim());
                        }
                        catch (Exception)
                        {
                            break;
                        }

                    }
                }
            }
            catch (Exception)
            {
            }
            return res;
        }
    }
}
