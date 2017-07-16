using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class paths
    {
        const string _txtpath = @"config\path.txt";

        public string name { get; set; }
        public string path { get; set; }

        public paths(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

        public paths() { }

        public void WriteCFG()
        {
            List<string> ListToWrite = new List<string>();
            string build = name + "=" + path;

            try
            {
                using (StreamReader rd = new StreamReader(_txtpath, true))
                {
                    while (true)
                    {
                        try
                        {
                            ListToWrite.Add(rd.ReadLine().Trim());
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

            try
            {
                var x = ListToWrite.Single(a => a.Contains(build.Split('=')[0]));
                
                ListToWrite.Remove(x);

            }
            catch (Exception)
            {
                if (!ListToWrite.Contains(build))
                {
                    ListToWrite.Add(build);
                }
            }
            File.Delete(_txtpath);
            WriteCFGinFile(ListToWrite);
        }

        public void WriteCFGinFile(List<string> l)
        {
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                try
                {
                    foreach (string s in l)
                    {
                        tw.WriteLine(s.ToString());
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public static string GetPathFromFile(string name)
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
                            string check = rd.ReadLine().Trim();
                            string _name = check.Split('=')[0];
                            string _path = check.Split('=')[1];
                            if (_name == name)
                            {
                                res = _path;
                            }
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
