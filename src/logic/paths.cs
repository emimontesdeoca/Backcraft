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
        const string _txtfile = @"config/paths.txt";

        public string path { get; set; }
        public bool enabled { get; set; }
        public paths(string path, bool enabled)
        {
            this.path = path;
            this.enabled = enabled;
        }

        public void WriteCFg()
        {

            List<string> ListToWrite = new List<string>();

            try
            {
                using (StreamReader rd = new StreamReader(_txtfile, true))
                {
                    while (true)
                    {
                        ListToWrite.Add(rd.ReadLine().Trim());
                    }
                }
            }
            catch (Exception)
            {
            }

            try
            {
                var x = ListToWrite.Single(a => a.Contains(this.path));

                if (this.enabled == false)
                {
                    ListToWrite.Remove(x);
                }

            }
            catch (Exception)
            {
                ListToWrite.Add(this.path);
            }
        }

        public void WriteToCFG(List<string> l)
        {

            using (StreamWriter tw = new StreamWriter(_txtfile, true))
            {
                try
                {
                    foreach (string s in l)
                    {
                        tw.WriteLine(s);
                    }
                }
                catch (Exception)
                {
                }
            }

        }

        public static List<string> GetPaths()
        {

            List<string> list = new List<string>();

            using (StreamReader rd = new StreamReader(_txtfile, true))
            {
                try
                {
                    while (true)
                    {
                        list.Add(rd.ReadLine().Trim());
                    }
                }
                catch (Exception)
                {
                }
            }

            return list;
        }
    }

}
