using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class _7zippath
    {
        const string _txtpath = @"config\7ziptpath.txt";
        
        public string path { get; set; }

        public _7zippath(string path)
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

        public static string Get7ZipPath()
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
