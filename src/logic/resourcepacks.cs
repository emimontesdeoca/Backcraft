using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class resourcepacks
    {
        const string _txtpath = @"config\resourcepacks.txt";
        public string name { get; set; }
        public string path { get; set; }
        public string md5 { get; set; }

        public static List<string> allresourcepacks;
        public resourcepacks(string name, string path)
        {
            this.name = name;
            this.path = path;
            this.md5 = bs.md5.CreateMd5ForFolder(this.path);
        }

        public resourcepacks() { }

        public void WriteResourcePackDirectories(bool checkbox)
        {
            string _name = "name=" + this.name;
            string _path = "path=" + this.path;
            string _md5 = "md5=" + this.md5;
            string fullstring = "#&" + _name + "&" + _path + "&" + _md5;


            try
            {
                if (!File.Exists(_txtpath))
                {
                    var f = File.Create(_txtpath);
                    f.Close();
                }

                using (StreamReader rd = new StreamReader(_txtpath, true))
                {
                    if (allresourcepacks == null)
                    {
                        allresourcepacks = new List<string>();
                        while (true)
                        {
                            try
                            {
                                string newline = rd.ReadLine().Trim();
                                allresourcepacks.Add(newline);
                            }
                            catch (Exception)
                            {
                                break;
                            }
                        }
                    }
                    if (allresourcepacks.Contains(fullstring))
                    {
                        if (!checkbox)
                        {
                            try
                            {
                                var x = allresourcepacks.Single(a => a == fullstring);
                                allresourcepacks.Remove(x);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    else if (!allresourcepacks.Contains(fullstring) && checkbox)
                    {
                        allresourcepacks.Add(fullstring);
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        public static void FinallyWriteFile()
        {
            new resourcepacks().WriteToFile(allresourcepacks);
        }

        public void WriteToFile(List<string> strings)
        {
            File.Delete(_txtpath);
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                try
                {
                    foreach (string s in strings)
                    {
                        tw.WriteLine(s);
                    }
                }
                catch (Exception)
                {
                }

            }
        }

        public List<resourcepacks> GetResourcePackFrom()
        {
            List<resourcepacks> resourcepacks = new List<logic.resourcepacks>();

            try
            {
                using (StreamReader rd = new StreamReader(_txtpath, true))
                {

                    while (true)
                    {
                        try
                        {
                            string newline = rd.ReadLine().Trim();

                            string name = newline.Split('&')[1];
                            string path = newline.Split('&')[2];
                            resourcepacks.Add(new logic.resourcepacks(name.Split('=')[1], path.Split('=')[1]));
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

            return resourcepacks;

        }
    }
}
