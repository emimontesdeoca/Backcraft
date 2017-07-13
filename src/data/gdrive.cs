using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.data
{
    class gdrive
    {
        /// <summary>
        /// Method that saves username and password in gdrive.txt
        /// </summary>
        /// <param name="email">User email</param>
        /// <param name="password">User password</param>
        public void WriteSettings(string email, string password)
        {
            string path = "data/gdrive.txt";
            string u = "# " + email;
            string p = "# " + password;

            try
            {
                File.Delete(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(u);
                    tw.WriteLine(p);
                }
            }
            catch (Exception)
            {

                File.Create(path);
                using (StreamWriter tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(u);
                    tw.WriteLine(p);
                }
            }
        }

        /// <summary>
        /// Method that reads gdrive.txt and returns account data
        /// </summary>
        /// <returns>0 is username, 1 is password</returns>
        public string[] GetUserData()
        {
            string[] data = new string[2];
            string path = "data/gdrive.txt";

            using (StreamReader tw = new StreamReader(path, false))
            {
                data[0] = tw.ReadLine().Remove(0, 2);
                data[1] = tw.ReadLine().Remove(0, 2);
            }

            return data;
        }
    }
}
