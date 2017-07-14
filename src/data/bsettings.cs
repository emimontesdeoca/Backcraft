using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.data
{
    class bsettings
    {
        public void WriteSettings(bool enable, bool savelog, string path7zip, string pathbackps, int interval)
        {
            string path = @"data\bsettings.txt";
            string _enable = "# enable=" + enable;
            string _savelog = "# savelog=" + savelog;
            string _7zip = "# 7zippath=" + path7zip;
            string _backups = "# backupspath=" + pathbackps;
            string _intervarl = "# interval=" + interval.ToString();

            try
            {
                File.Delete(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(_enable);
                    tw.WriteLine(_savelog);
                    tw.WriteLine(_7zip);
                    tw.WriteLine(_backups);
                    tw.WriteLine(_intervarl);
                }
            }
            catch (Exception)
            {
                File.Create(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(_enable);
                    tw.WriteLine(_savelog);
                    tw.WriteLine(_7zip);
                    tw.WriteLine(_backups);
                    tw.WriteLine(_intervarl);
                }
            }
        }

        public void WriteLog(string time, string text, int type)
        {
            string path = "data/log.txt";

            switch (type)
            {
                case 0:
                    try
                    {
                        using (StreamWriter tw = new StreamWriter(path, true))
                        {
                            tw.WriteLine("###############################################################################################");
                        }
                    }
                    catch (Exception)
                    {
                        File.Create(path);
                        using (StreamWriter tw = new StreamWriter(path, true))
                        {
                            tw.WriteLine("###############################################################################################");
                        }
                    }
                    break;
                case 1:
                    try
                    {
                        using (StreamWriter tw = new StreamWriter(path, true))
                        {
                            tw.WriteLine(time + " - " + text);
                        }
                    }
                    catch (Exception)
                    {
                        File.Create(path);
                        using (StreamWriter tw = new StreamWriter(path, true))
                        {
                            tw.WriteLine(time + " - " + text);
                        }
                    }
                    break;
            }


        }

        public string[] GetBackcraftSettingsData()
        {
            string[] data = new string[5];
            string path = "data/bsettings.txt";

            try
            {
                using (StreamReader tw = new StreamReader(path, false))
                {
                    data[0] = tw.ReadLine().Split('=')[1];
                    data[1] = tw.ReadLine().Split('=')[1];
                    data[2] = tw.ReadLine().Split('=')[1];
                    data[3] = tw.ReadLine().Split('=')[1];
                    data[4] = tw.ReadLine().Split('=')[1];
                }

            }
            catch (Exception)
            {
            }


            return data;
        }
    }
}
