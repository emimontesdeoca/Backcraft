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
        const string _txtstate = @"config\cfg.txt";

        public string name { get; set; }
        public bool enabled { get; set; }

        public cfg(string name, bool enabled)
        {
            this.name = name;
            this.enabled = enabled;
        }

        public cfg() { }

        public void WriteCFG()
        {
            List<string> ListToWrite = new List<string>();
            string build = name + "=" + enabled.ToString();

            try
            {
                using (StreamReader rd = new StreamReader(_txtstate, true))
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
            File.Delete(_txtstate);
            WriteCFGinFile(ListToWrite);
        }

        public void WriteCFGinFile(List<string> l)
        {
            using (StreamWriter tw = new StreamWriter(_txtstate, true))
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

        public static bool GetStateFromFile(string name)
        {
            bool res = false;
            try
            {
                using (StreamReader rd = new StreamReader(_txtstate, true))
                {
                    while (true)
                    {
                        try
                        {
                            string check = rd.ReadLine().Trim();
                            string _name = check.Split('=')[0];
                            bool state = Convert.ToBoolean(check.Split('=')[1]);
                            if (_name == name)
                            {
                                res = state;
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
