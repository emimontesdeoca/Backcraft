using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class options
    {
        const string _txtpath = @"config\options.txt";
        public string name { get; set; }
        public string path { get; set; }
        public string md5 { get; set; }
        public bool enabled { get; set; }


        public options(string name, string path, bool enabled)
        {
            this.name = name;
            this.path = path;
            this.enabled = enabled;
            this.md5 = bs.md5.CreateMd5ForFolder(this.path);
        }

        public void WriteToFile()
        {
            File.Delete(_txtpath);
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                string _enable = "enable=" + this.enabled.ToString();
                string _name = "name=" + this.name;
                string _path = "path=" + this.path;
                string _md5 = "md5=" + this.md5;
                string fullstring = "#&" + _enable + "&" + _name + "&" + _path + "&" + _md5;

                try
                {
                    tw.WriteLine(fullstring.ToString());
                }
                catch (Exception)
                {
                }

            }
        }

        public static bool GetOptionsState()
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
                            string state = rd.ReadLine().Trim();
                            state = state.Remove(0, 1);
                            state = state.Split('&')[0];
                            state = state.Split('=')[1];

                            res = Convert.ToBoolean(state);
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
        public static string GetOptionsMD5()
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
                            string md5 = rd.ReadLine().Trim();
                            md5 = md5.Remove(0, 1);
                            md5 = md5.Split('&')[3];
                            md5 = md5.Split('=')[1];

                            res = md5;
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
