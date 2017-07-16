using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class interval
    {
        const string _txtpath = @"config\interval.txt";

        public int time { get; set; }


        public interval(int time)
        {
            this.time = time;

        }

        public void WriteToFile()
        {
            File.Delete(_txtpath);
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                string _enable = "interval=" + this.time.ToString();
                try
                {
                    tw.WriteLine(_enable.ToString());
                }
                catch (Exception)
                {
                }
            }
        }

        public static int GetIntervalTime()
        {
            int res = 5;
            try
            {
                using (StreamReader rd = new StreamReader(_txtpath, true))
                {
                    while (true)
                    {
                        try
                        {
                            string time = rd.ReadLine().Trim();
                            time = time.Split('=')[1];

                            res = Convert.ToInt32(time);
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
