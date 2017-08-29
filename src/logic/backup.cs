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
                string NewMd5 = "newMD5";

                /// TODO
                /// Since there is a problem while Minecraft is running Bcraft have to check
                /// if copying the folder changes the md5, if it does not then copy it and comapre
                /// if it is equal, delete the copied folder and do nothing
                /// if it is not equal, do stuff
                /// this will make the backup work even if minecraft is open and working
                string newname = "";
                /// Start copy
                switch (type)
                {
                    /// if File
                    case "f":

                        /// Changes in the files, copy stuff to folder
                        if (name.Contains("launcher_profiles"))
                        {
                            newname = @"backups\\" + name + ".json";
                            File.Copy(path, newname);
                            NewMd5 = bs.md5.CreateMd5ForFolder(newname);

                            if (NewMd5 != CurrentMd5)
                            {
                                new logic.files().UpdateFile(name, NewMd5);
                            }
                            else
                            {
                                Directory.Delete(newname, true);
                            }
                        }
                        else if (name.Contains("options"))
                        {
                            newname = @"backups\\" + name + ".txt";

                            File.Copy(path, newname);
                            NewMd5 = bs.md5.CreateMd5ForFolder(newname);

                            if (NewMd5 != CurrentMd5)
                            {
                                new logic.files().UpdateFile(name, NewMd5);
                            }
                            else
                            {
                                Directory.Delete(newname, true);
                            }
                        }

                        break;
                    ///If Directory
                    case "d":


                        /// Changes in the files, copy stuff to folder

                        newname = @"backups\\" + name;
                        bs.compression.Copy(path, newname);
                        NewMd5 = bs.md5.CreateMd5ForFolder(newname);
                        if (NewMd5 != CurrentMd5)
                        {
                            new logic.files().UpdateFile(name, NewMd5);
                        }
                        else
                        {
                            Directory.Delete(newname, true);
                        }

                        break;
                }
            }

            if (!IsDirectoryEmpty(@"backups"))
            {

                /// Build folderpath string
                string folderpath = "Backcraft_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString();
                folderpath = folderpath.Replace('/', '-').Replace(':', '-');

                /// Compress
                string path7zip = logic.cfg.GetTypeFromFile("7zip");

                try
                {
                    string fileName = "backups";
                    FileInfo a = new FileInfo(fileName);
                    string fullname = a.FullName;

                    /// Compress it with 7Zip
                    //bs.compression.CreateZipFile(back_7zippath.Text, back_backupfolderpath.Text + "\\" + fileName.Split('\\')[1], fullname);
                    bs.compression.CreateZipFile(path7zip, folderpath, fullname);

                    /// Delete folder and create it again
                    Directory.Delete("backups", true);
                    Directory.CreateDirectory("backups");

                    /// Copy the zip to all the destinations
                    List<string> paths = logic.paths.GetPaths();
                    foreach (string s in paths)
                    {
                        string destpath = s + "\\" + folderpath + ".7z";

                        File.Copy(folderpath + ".7z", destpath);
                    }

                    /// Delete zip
                    File.Delete(folderpath + ".7z");
                }
                catch (Exception)
                {

                }


            }
        }

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}
