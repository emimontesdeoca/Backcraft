using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace backcraft.logic
{
    public class backup
    {
        public static void MakeBackup(bool[] states)
        {
            List<files> FilesToBackup = logic.files.GetFiles();

            bool resourcepack = states[0];
            bool saves = states[1];
            bool launcherprofiles = states[2];
            bool options = states[3];
            bool screenshots = states[4];
            bool logs = states[5];


            foreach (files f in FilesToBackup)
            {

                if (!resourcepack)
                {
                    if (f.path.Contains("resourcepacks"))
                    {
                        FilesToBackup.Remove(f);
                    }
                }
                if (!saves)
                {
                    if (f.path.Contains("saves"))
                    {
                        FilesToBackup.Remove(f);
                    }
                }
                if (!launcherprofiles)
                {
                    if (f.path.Contains("launcher_profiles"))
                    {
                        FilesToBackup.Remove(f);
                    }
                }
                if (!options)
                {
                    if (f.path.Contains("options.txt"))
                    {
                        FilesToBackup.Remove(f);
                    }
                }
                if (!screenshots)
                {
                    if (f.path.Contains("screenshots"))
                    {
                        FilesToBackup.Remove(f);
                    }
                }
            }

            Backup(FilesToBackup);
        }


        public static void Backup(List<files> F)
        {

            foreach (logic.files f in F)
            {
                /// Get file info
                string name = f.name;
                string path = f.path;
                string CurrentMd5 = f.MD5;
                string type = f.type;

                /// Check again for MD5
                string NewMd5 = "";

                switch (type)
                {
                    case "f":
                        NewMd5 = bs.md5.checkMD5(path);

                        if (CurrentMd5 != NewMd5)
                        {
                            /// Changes in the files, copy stuff to folder
                            if (name.Contains(".json"))
                            {
                                File.Copy(path, @"backups\\" + name + ".json");
                            }
                            else if (name.Contains(".txt"))
                            {
                                File.Copy(path, @"backups\\" + name + ".txt");
                            }

                            new logic.files().UpdateFile(name, NewMd5);
                        }
                        break;

                    case "d":
                        NewMd5 = bs.md5.CreateMd5ForFolder(path);

                        if (CurrentMd5 != NewMd5)
                        {
                            /// Changes in the files, copy stuff to folder
                            bs.compression.Copy(path, @"backups\\" + name);
                            new logic.files().UpdateFile(name, NewMd5);
                        }

                        break;
                }
            }
        }

        public static void CompressFile(string path, string md5)
        {



        }
    }
}
