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
        public void WriteSettings(bool enable, bool savelog, bool upload, bool saveoffline, int interval)
        {
            string path = "data/bsettings.txt";
            string _enable = "# enable=" + enable;
            string _savelog = "# savelog=" + savelog;
            string _uploaddrive = "# upload=" + upload;
            string _saveoffline = "# saveoffline=" + saveoffline;
            string _intervarl = "# interval=" + interval.ToString();

            try
            {
                File.Delete(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(_enable);
                    tw.WriteLine(_savelog);
                    tw.WriteLine(_uploaddrive);
                    tw.WriteLine(_saveoffline);
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
                    tw.WriteLine(_uploaddrive);
                    tw.WriteLine(_saveoffline);
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

            using (StreamReader tw = new StreamReader(path, false))
            {
                data[0] = tw.ReadLine().Split('=')[1];
                data[1] = tw.ReadLine().Split('=')[1];
                data[2] = tw.ReadLine().Split('=')[1];
                data[3] = tw.ReadLine().Split('=')[1];
                data[4] = tw.ReadLine().Split('=')[1];
            }

            return data;
        }
    }
}
