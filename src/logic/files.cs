using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class files
    {
        const string _txtfile = @"config/files.txt";



        public string name { get; set; }
        public string path { get; set; }
        public string MD5 { get; set; }
        public string type { get; set; }
        public bool enabled { get; set; }

        public files(string name, string path, string type, bool enabled)
        {
            this.name = name;
            this.path = path;

            this.type = type;
            this.enabled = enabled;

            if (type == "f")
            {
                MD5 = bs.md5.checkMD5(path);

            }
            else
            {
                MD5 = bs.md5.CreateMd5ForFolder(path);
            }

        }

        public files() { }

        public void WriteCFG()
        {
            List<string> ListToWrite = new List<string>();
            string build = this.name + "&" + this.type + "&" + this.enabled + "&" + this.path + "&" + this.MD5;
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
                var x = ListToWrite.Single(a => a.Contains(this.name) && a.Contains(this.path));

                string cmd5 = x.Split('&')[4];
                string fileenabled = x.Split('&')[2];

                if (this.enabled == false)
                {
                    ListToWrite.Remove(x);
                }
                else if (this.MD5 != cmd5)
                {
                    ListToWrite.Remove(x);
                    ListToWrite.Add(build);
                }


            }
            catch (Exception)
            {
                if (!ListToWrite.Contains(build))
                {
                    ListToWrite.Add(build);
                }
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
        public static List<files> GetFiles()
        {
            List<files> files = new List<logic.files>();

            using (StreamReader rd = new StreamReader(_txtfile, true))
            {

                while (true)
                {
                    try
                    {
                        string line = rd.ReadLine();
                        string[] split = line.Split('&');

                        files f = new files();
                        f.name = split[0];
                        f.type = split[1];
                        f.enabled = Convert.ToBoolean(split[2]);
                        f.path = split[3];
                        f.MD5 = split[4];

                        files.Add(f);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            return files;

        }

    }
}
