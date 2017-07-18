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

        public files(string name, string path, string mD5, string type, bool enables)
        {
            this.name = name;
            this.path = path;
            MD5 = mD5;
            this.type = type;
            this.enabled = enables;
        }

        public files() { }

        public void WriteCFG()
        {
            List<string> ListToWrite = new List<string>();
            string build = this.name + "&" + this.enabled + "&" + this.path + "&" + this.MD5;
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
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
