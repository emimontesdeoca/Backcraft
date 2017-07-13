using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.data
{
    class msettings
    {
        public void WriteSettings(string folderlocation, bool resourcepack, bool launcheroptions, bool screenshots, bool options, bool saves)
        {
            string path = "data/msettings.txt";
            string _flocation = "# folder_location=" + folderlocation;
            string _rpack = "# resourcepack=" + resourcepack;
            string _loptions = "# launcheroptions=" + launcheroptions;
            string _sshots = "# screenshots=" + screenshots;
            string _options = "# options=" + options;
            string _saves = "# saves=" + saves;

            try
            {
                File.Delete(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(_flocation);
                    tw.WriteLine(_rpack);
                    tw.WriteLine(_loptions);
                    tw.WriteLine(_sshots);
                    tw.WriteLine(_options);
                    tw.WriteLine(_saves);
                }
            }
            catch (Exception)
            {
                File.Create(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(_flocation);
                    tw.WriteLine(_rpack);
                    tw.WriteLine(_loptions);
                    tw.WriteLine(_sshots);
                    tw.WriteLine(_options);
                    tw.WriteLine(_saves);
                }
            }
        }

        public string[] GetMinecraftSettingsData()
        {
            string[] data = new string[6];
            string path = "data/msettings.txt";

            using (StreamReader tw = new StreamReader(path, false))
            {
                data[0] = tw.ReadLine().Split('=')[1];
                data[1] = tw.ReadLine().Split('=')[1];
                data[2] = tw.ReadLine().Split('=')[1];
                data[3] = tw.ReadLine().Split('=')[1];
                data[4] = tw.ReadLine().Split('=')[1];
                data[5] = tw.ReadLine().Split('=')[1];
            }

            return data;
        }
    }
}
