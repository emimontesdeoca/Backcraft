using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class worlds
    {
        const string _txtpath = @"config\worlds.txt";
        public string name { get; set; }
        public string path { get; set; }
        public string md5 { get; set; }

        public static List<string> allworlds;

        public worlds(string name, string path)
        {
            this.name = name;
            this.path = path;
            this.md5 = bs.md5.CreateMd5ForFolder(this.path);
        }
        public worlds() { }

        public void WriteWorldsDirectories(bool checkbox)
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
                    if (allworlds == null)
                    {
                        allworlds = new List<string>();
                        while (true)
                        {
                            try
                            {
                                string newline = rd.ReadLine().Trim();
                                allworlds.Add(newline);
                            }
                            catch (Exception)
                            {
                                break;
                            }
                        }
                    }
                    if (allworlds.Contains(fullstring))
                    {
                        if (!checkbox)
                        {
                            try
                            {
                                var x = allworlds.Single(a => a == fullstring);
                                allworlds.Remove(x);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    else if (!allworlds.Contains(fullstring) && checkbox)
                    {
                        allworlds.Add(fullstring);
                    }
                }
            }
            catch (Exception)
            {

            }

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

        public static void FinallyWriteFile()
        {
            new worlds().WriteToFile(allworlds);
        }

        public List<worlds> GetWorldsFromFile()
        {
            List<worlds> resourcepacks = new List<logic.worlds>();

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
                            resourcepacks.Add(new logic.worlds(name.Split('=')[1], path.Split('=')[1]));
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
