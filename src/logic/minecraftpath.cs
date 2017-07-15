using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class minecraftpath
    {
        const string _txtpath = @"config\minecraftpath.txt";

        public string path { get; set; }

        public minecraftpath(string path)
        {
            this.path = path;
        }

        public void WriteToFile()
        {
            File.Delete(_txtpath);
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                try
                {
                    tw.WriteLine(this.path);
                }
                catch (Exception)
                {
                }

            }
        }

        public static string GetMinecraftPath()
        {
            string res = "";
            try
            {
                using (StreamReader rd = new StreamReader(_txtpath, true))
                {
                    while (true)
                    {
                        try
                        {
                            res = rd.ReadLine().Trim();
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
