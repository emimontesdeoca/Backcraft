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
            List<files> FilesToBackup;
            try
            {
                FilesToBackup = logic.files.GetFiles();
                if (FilesToBackup.Count == 0)
                {
                    new logs.log().WriteLog(3, "There are no files in files.txt");
                }
            }
            catch (Exception)
            {
                new logs.log().WriteLog(3, "Files.txt not found");
                return;
            }

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

            try
            {
                new logs.log().WriteLog(0, "Starting backup at " + DateTime.Now);
                Backup(FilesToBackup);
            }
            catch (Exception)
            {
                new logs.log().WriteLog(3, "Error while doing backup");
            }
        }


        public static void Backup(List<files> F)
        {
            List<string> paths;
            try
            {
                paths = logic.paths.GetPaths();

                if (paths.Count == 0)
                {
                    new logs.log().WriteLog(3, "There are no paths in paths.txt");
                }
            }
            catch (Exception)
            {
                new logs.log().WriteLog(3, "Paths.txt not found");
                return;
            }

            foreach (logic.files f in F)
            {
                /// Get file info
                string name = f.name;
                string path = f.path;
                string CurrentMd5 = f.MD5;
                string type = f.type;

                /// Check again for MD5
                string NewMd5 = "newMD5";

                string newname = "";
                /// Start copy
                switch (type)
                {
                    /// if File
                    case "f":
                        /// Changes in the files, copy stuff to folder
                        if (name.Contains("launcher_profiles"))
                        {
                            newname = @"backups\" + name + ".json";
                        }
                        else if (name.Contains("options"))
                        {
                            newname = @"backups\" + name + ".txt";
                        }

                        try
                        {
                            File.Copy(path, newname);
                            new logs.log().WriteLog(0, "File copy from " + path);
                        }
                        catch (Exception)
                        {
                            new logs.log().WriteLog(2, "File copy from " + newname);
                        }

                        try
                        {
                            NewMd5 = bs.md5.checkMD5(newname);
                            new logs.log().WriteLog(0, "Check MD5 for " + newname);
                        }
                        catch (Exception)
                        {
                            new logs.log().WriteLog(2, "Check MD5 for " + newname);
                        }

                        if (NewMd5 != CurrentMd5)
                        {
                            try
                            {
                                new logic.files().UpdateFile(name, NewMd5);
                                new logs.log().WriteLog(0, "Change MD5 for " + newname);
                            }
                            catch (Exception)
                            {
                                new logs.log().WriteLog(2, "Change MD5 for " + newname);
                            }
                        }
                        else
                        {
                            new logs.log().WriteLog(0, "File without changes");
                            try
                            {
                                File.Delete(newname);
                                new logs.log().WriteLog(0, "Delete file " + newname);
                            }
                            catch (Exception)
                            {
                                new logs.log().WriteLog(2, "Delete file  " + newname);
                            }
                        }
                        break;

                    ///If Directory
                    case "d":
                        /// Changes in the files, copy stuff to folder
                        newname = @"backups\" + name;
                        try
                        {
                            bs.compression.Copy(path, newname);
                            new logs.log().WriteLog(0, "Folder copy from " + path);
                        }
                        catch (Exception)
                        {
                            new logs.log().WriteLog(2, "Folder copy from " + newname);
                        }

                        try
                        {
                            NewMd5 = bs.md5.CreateMd5ForFolder(newname);
                            new logs.log().WriteLog(0, "Check MD5 for " + newname);
                        }
                        catch (Exception)
                        {
                            new logs.log().WriteLog(2, "Check MD5 for " + newname);
                        }

                        if (NewMd5 != CurrentMd5)
                        {
                            try
                            {
                                new logic.files().UpdateFile(name, NewMd5);
                                new logs.log().WriteLog(0, "Change MD5 for " + newname);
                            }
                            catch (Exception)
                            {
                                new logs.log().WriteLog(2, "Change MD5 for " + newname);
                            }
                        }
                        else
                        {
                            new logs.log().WriteLog(0, "Folder without changes");
                            try
                            {
                                Directory.Delete(newname, true);
                                new logs.log().WriteLog(0, "Delete file " + newname);
                            }
                            catch (Exception a)
                            {
                                string e = a.ToString();
                                new logs.log().WriteLog(2, "Delete file  " + newname);
                            }
                        }
                        break;
                }
            }

            if (!IsDirectoryEmpty(@"backups"))
            {

                /// Build folderpath string
                string folderpath = "Backcraft_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString();
                folderpath = folderpath.Replace('/', '-').Replace(':', '-').Replace(' ', '-');

                /// Compress
                string path7zip = "";

                try
                {
                    path7zip = logic.cfg.GetTypeFromFile("7zip");
                }
                catch (Exception)
                {
                    new logs.log().WriteLog(3, "No 7zip location detected");
                    return;
                }

                try
                {
                    string fullname = new FileInfo("backups").FullName;

                    /// Compress it with 7Zip
                    try
                    {
                        bs.compression.CreateZipFile(path7zip, folderpath, fullname);
                        new logs.log().WriteLog(0, "Compressing " + fullname);

                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Compressing " + fullname);

                    }
                    /// Delete folder 
                    try
                    {
                        Directory.Delete("backups", true);
                        new logs.log().WriteLog(0, "Delete backups folder ");
                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Delete backups folder ");
                    }
                    /// Create it again
                    try
                    {
                        Directory.CreateDirectory("backups");
                        new logs.log().WriteLog(0, "Create backups folder ");
                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Create backups folder ");
                    }
                    /// Copy the zip to all the destinations
                    try
                    {
                        new logs.log().WriteLog(0, "Folder paths");

                        foreach (string s in paths)
                        {
                            string destpath = s + "\\" + folderpath + ".7z";
                            try
                            {
                                File.Copy(folderpath + ".7z", destpath);
                                new logs.log().WriteLog(0, "Copy 7zip to " + destpath);
                            }
                            catch (Exception)
                            {
                                new logs.log().WriteLog(3, "Copy 7zip to " + destpath);
                            }

                        }
                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Folder paths");
                    }
                    /// Delete zip
                    try
                    {
                        File.Delete(folderpath + ".7z");
                        new logs.log().WriteLog(0, "Delete " + folderpath + ".7zip");
                    }
                    catch (Exception)
                    {
                        new logs.log().WriteLog(2, "Delete " + folderpath + ".7zip");
                    }
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
