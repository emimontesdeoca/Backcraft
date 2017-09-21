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

        public paths(string path)
        {
            this.path = path;
        }

        public paths() { }

        public void WriteCFg()
        {

            List<string> ListToWrite = new List<string>();

            try
            {
                using (StreamReader rd = new StreamReader(_txtfile, true))
                {
                    while (true)
                    {
                        string obj = rd.ReadLine().Trim();

                        ListToWrite.Add(obj);
                    }
                }

            }
            catch (Exception)
            {
                /// Means there isnt a path file so just add it BABE
                ListToWrite.Add(this.path);
            }
            File.Delete(_txtfile);
            WriteToCFG(ListToWrite);

        }

        public void WriteToCFG(List<string> l)
        {

            using (StreamWriter tw = new StreamWriter(_txtfile, true))
            {
                try
                {
                    foreach (string s in l.Distinct())
                    {
                        tw.WriteLine(s);
                    }
                }
                catch (Exception)
                {
                }
            }

        }

        public void DeleteFromFile(string path)
        {

            List<string> l = new List<string>();
            using (StreamReader tw = new StreamReader(_txtfile, true))
            {
                try
                {
                    while (true)
                    {
                        l.Add(tw.ReadLine().Trim());
                    }
                }
                catch (Exception)
                {
                }
            }

            try
            {
                var x = l.Single(a => a.Contains(path));
                l.Remove(x);
                File.Delete(_txtfile);
                WriteToCFG(l);
            }
            catch (Exception)
            {
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
