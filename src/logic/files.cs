using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    public class files
    {
        const string _txtfile = @"config/files.txt";

        public string name { get; set; }
        public string path { get; set; }
        public string MD5 { get; set; }
        public string type { get; set; }

        public files(string name, string path, string type)
        {
            this.name = name;
            this.path = path;

            this.type = type;

            if (type == "f")
            {
                string cppath = "";
                switch (name)
                {
                    case "launcher_profiles":

                        cppath = @"backups\" + name + ".json";
                        File.Copy(this.path, cppath);
                        this.MD5 = bs.md5.checkMD5(path);
                        File.Delete(cppath);

                        break;
                    case "options":

                        cppath = @"backups\" + name + ".txt";
                        File.Copy(this.path, cppath);
                        this.MD5 = bs.md5.checkMD5(path);
                        File.Delete(cppath);

                        break;
                }
            }
            else
            {
                string newname = @"backups\" + name;
                bs.compression.Copy(path, newname);
                this.MD5 = bs.md5.CreateMd5ForFolder(newname);
                Directory.Delete(newname, true);
            }


        }

        public files() { }

        public void WriteCFG()
        {
            List<string> ListToWrite = new List<string>();
            string build = this.name + "&" + this.type + "&" + this.path + "&" + this.MD5;


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

                string cmd5 = x.Split('&')[3];

                if (this.MD5 != cmd5)
                {
                    ListToWrite.Remove(x);
                    ListToWrite.Add(build);
                }

            }
            catch (Exception)
            {
                build = this.name + "&" + this.type + "&" + this.path + "&";
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

            if (l.Count > 0)
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

        }

        public void DeleteFromFile(string name, string path)
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
                var x = l.Single(a => a.Contains(name) && a.Contains(path));
                l.Remove(x);
                File.Delete(_txtfile);
                WriteToCFG(l);
            }
            catch (Exception)
            {
            }

        }

        public static List<files> GetFiles()
        {
            List<files> files = new List<logic.files>();

            //If file doese not exist, create empty file and close writer
            if (!File.Exists(_txtfile))
            {
                File.Create(_txtfile).Dispose();
            }

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
                        f.path = split[2];
                        f.MD5 = split[3];

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

        public void UpdateFile(string currentName, string newMD5)
        {

            List<string> ListToWrite = new List<string>();

            using (StreamReader rd = new StreamReader(_txtfile, true))
            {

                while (true)
                {
                    try
                    {
                        string line = rd.ReadLine();
                        string[] split = line.Split('&');

                        string name = split[0];
                        string type = split[1];
                        string path = split[2];
                        string MD5 = split[3];

                        if (name == currentName && MD5 != newMD5)
                        {
                            MD5 = newMD5;
                        }

                        string build = name + "&" + type + "&" + path + "&" + MD5;

                        ListToWrite.Add(build);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }
            File.Delete(_txtfile);
            WriteToCFG(ListToWrite);
        }

    }
}
