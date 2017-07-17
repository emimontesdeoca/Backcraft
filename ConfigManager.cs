using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace backcraft.configManager
{
    public class ConfigManager
    {
        /*
            There will be issues if you intend to handle strings containing two adjacent 
            quotes (""), because lists of strings will be like this in config:
       
            # listOfBackupPaths = {""D:\Backup"",""C:\Program Files\Backcraft\MCBackups\""}
      
            If that's a problem, you can change _strDelim below. 
            (as long as it doesn't include numbers, either)
        */

        private const string _strDelim = "\"\"";
        string _path;

        // So that temp files don't conflict
        static uint _idGlobal = 0;
        uint _id;

        public string Path
        {
            get { return _path; }
        }

        public uint Id
        {
            get { return _id; }
        }

        public ConfigManager(string path)
        {
            this._path = path;
            this._id = _idGlobal;
            _idGlobal++;

            if (!File.Exists(this.Path))
                File.Create(this.Path).Close();
        }

        public bool ConfigExists(string cfgName)
        {
            var sr = new StreamReader(this.Path);
            string currLine;

            while (!sr.EndOfStream)
            {
                currLine = sr.ReadLine();

                if (currLine.Split('=')[0].Replace("#", "").Trim() == cfgName)
                {
                    sr.Close();
                    return true;
                }
            }

            sr.Close();
            return false;
        }

        public void SetConfig<T>(string cfgName, T newValue)
        {
            DeleteConfig(cfgName);
            AddConfig<T>(cfgName, newValue);
        }

        public void DeleteConfig(string cfgName)
        {
            string tempPath =
            System.IO.Path.GetDirectoryName(Path) + "\\temp" + this.Id + ".txt";

            var sr = new StreamReader(Path);
            var sw = new StreamWriter(tempPath, false);
            string currLine;

            while (!sr.EndOfStream)
            {
                currLine = sr.ReadLine();
                if (!(currLine.Split('=')[0].Replace("#", "").Trim() == cfgName))
                {
                    sw.WriteLine(currLine);
                }
            }

            sw.Close();
            sr.Close();

            File.Delete(Path);
            File.Move(tempPath, Path); // Rename   
        }

        private void AddConfigRaw(string strName, string rawValue)
        {
            if (this.ConfigExists(strName))
            {
                if (RawValueOf(strName) == rawValue)
                    return;
                else
                {
                    // Will update config if it already exists
                    this.DeleteConfig(strName);
                    this.AddConfigRaw(strName, rawValue);
                }
            }

            var sw = new StreamWriter(this.Path, true);
            sw.WriteLine("# " + strName + "=" + rawValue);
            sw.Close();
        }

        public Type TypeOfValueOf(string cfgName)
        {
            cfgName = RawValueOf(cfgName);

            if (cfgName.Length == 0)
                return null;

            if (char.IsNumber(cfgName[0]))
            {
                return typeof(int);
            }

            if (char.IsLetter(cfgName[0]))
            {
                return typeof(bool);
            }

            if (cfgName.StartsWith(_strDelim))
            {
                return typeof(string);
            }

            if (cfgName[0] == '{' && char.IsNumber(cfgName[1]))
            {
                return typeof(List<int>);
            }

            if (cfgName[0] == '{' && char.IsLetter(cfgName[1]))
            {
                return typeof(List<bool>);

            }
            if (cfgName.StartsWith("{" + _strDelim))
            {
                return typeof(List<string>);
            }

            return typeof(void);
        }

        public string RawValueOf(string configName)
        {
            var sr = new StreamReader(Path);

            string currLine;
            while (!sr.EndOfStream)
            {
                currLine = sr.ReadLine();

                if (currLine.Split('=')[0].Replace("#", "").Trim() == configName)
                {
                    sr.Close();
                    return currLine.Substring(currLine.IndexOf("=") + 1);
                }
            }
            sr.Close();
            return "";
        }

        public T ValueOf<T>(string configName)
        {
            string rawValue = RawValueOf(configName);
            Type configType = TypeOfValueOf(configName);

            if (configType == typeof(string))
            {
                // It works, but might not be a good solution
                return (T)(object)(rawValue.Replace(_strDelim, ""));
            }
            else if (configType == typeof(int))
            {
                return (T)(object)(int.Parse(rawValue));
            }
            else if (configType == typeof(bool))
            {
                return (T)(object)(bool.Parse(rawValue));
            }
            else if (configType == typeof(List<int>))
            {
                rawValue = rawValue.Replace("{", "")
                                   .Replace("}", "");
                var ret = new List<int>();

                foreach (string s in rawValue.Split(','))
                {
                    ret.Add(int.Parse(s));
                }

                return (T)(object)(ret);
            }
            else if (configType == typeof(List<bool>))
            {
                rawValue = rawValue.Replace("{", "")
                                   .Replace("}", "");
                var ret = new List<bool>();

                foreach (string s in rawValue.Split(','))
                {
                    ret.Add(bool.Parse(s));
                }

                return (T)(object)(ret);
            }
            else if (configType == typeof(List<string>))
            {
                rawValue = rawValue.Replace("{", "")
                                   .Replace("}", "");
                var ret = new List<string>();

                foreach (string s in rawValue.Split(new [] {_strDelim}, StringSplitOptions.None))
                {
                    ret.Add(s);
                }

                return (T)(object)(ret);
            }

            throw new ArgumentException("Type of '" + configName + "' cannot be processed. Its value is '" + rawValue + "', which has type '" + configType.Name + "'");
        }

        public void AddConfig<T>(string configName, T cfgValue)
        {
            string strValue = "";

            // Can very easily be remade to handle float and List<float> if necessary
            if (typeof(T) == typeof(string))
            {
                strValue = _strDelim + cfgValue.ToString() + _strDelim;
            }
            else if (typeof(T) == typeof(int) ||
                     typeof(T) == typeof(bool))
            {
                strValue = cfgValue.ToString();
            }
            else if (typeof(T) == typeof(List<string>))
            {
                strValue = "{";

                foreach (string s in (cfgValue as List<String>))
                {
                    strValue += _strDelim + s + _strDelim + ",";
                }

                strValue += "}";
                strValue = strValue.Replace(",}", "}");
            }
            else if (typeof(T) == typeof(List<bool>))
            {
                strValue = "{";

                foreach (object listItem in (List<bool>)(object)cfgValue)
                {
                    strValue += listItem + ",";
                }

                strValue += "}";
                strValue = strValue.Replace(",}", "}");
            }
            else if (typeof(T)==typeof(void))
            {
                strValue = cfgValue.ToString();
            }
            else
            {
                throw new NotImplementedException();
            }

            AddConfigRaw(configName, strValue);
        }

        public static void sample()
        {
            var cfg = new configManager.ConfigManager("C:\\cfg.txt");

            var BackupWorlds = new List<bool>(new[] { true, true, false, false });
            var BackupDirList = new List<string>(new[] { "E:\\Backups\\", "D:\\Backcraft" });

            // Syntax: cfg.AddConfig<type>(config name, config value)
            // The <type> part is optional, it'll work fine without it
            cfg.AddConfig<int>("IntervalMin", 5);
            cfg.AddConfig<string>("AppName", "Backcraft");
            cfg.AddConfig<bool>("OnStartup", false);
            cfg.AddConfig<List<bool>>("MapsToBackup", BackupWorlds);
            cfg.AddConfig<List<string>>("DirsToBackupTo", BackupDirList);
            cfg.AddConfig<string>("UselessConfig", "");

            bool b = cfg.ConfigExists("UselessConfig");
            cfg.DeleteConfig("UselessConfig");
            bool c = cfg.ConfigExists("UselessConfig");

            if (b == false || c == true) MessageBox.Show("That's impossible!");

            // The <type> part is NOT optional when using ValueOf!
            bool x = cfg.ValueOf<bool>("OnStartup");
            int interval = cfg.ValueOf<int>("IntervalMin");

            MessageBox.Show("IntervalMin has type " + cfg.TypeOfValueOf("IntervalMin").Name + Environment.NewLine +
                            "Retrieved info: OnStartup = " + x.ToString() + "  and IntervalMin = " + interval.ToString());

            System.Diagnostics.Process.Start(cfg.Path);
        }
    }
}
