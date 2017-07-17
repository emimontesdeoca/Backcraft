using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class cfg
    {
        const string _txtcfg = @"config\cfg.txt";

        public string name { get; set; }
        public string value { get; set; }

        public cfg(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public cfg() { }

        public void WriteCFG()
        {
            List<string> ListToWrite = new List<string>();
            string build = name + "=" + value.ToString();

            try
            {
                using (StreamReader rd = new StreamReader(_txtcfg, true))
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
                ListToWrite.Add(build);
            }
            catch (Exception)
            {
                if (!ListToWrite.Contains(build))
                {
                    ListToWrite.Add(build);
                }
            }
            File.Delete(_txtcfg);
            WriteCFGinFile(ListToWrite);
        }

        public void WriteCFGinFile(List<string> l)
        {
            using (StreamWriter tw = new StreamWriter(_txtcfg, true))
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
                using (StreamReader rd = new StreamReader(_txtcfg, true))
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
                                break;
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

        public static dynamic GetTypeFromFile(string name)
        {
            var res = new {};
            try
            {
                using (StreamReader rd = new StreamReader(_txtcfg, true))
                {
                    while (true)
                    {
                        try
                        {
                            string check = rd.ReadLine().Trim();
                            string _name = check.Split('=')[0];

                            if (_name == name)
                            {
                                /// returns wathever it is
                                return check.Split('=')[1];
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
