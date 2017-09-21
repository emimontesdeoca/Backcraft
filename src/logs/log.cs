using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logs
{
    public class log
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public log() { }

        /// <summary>
        /// Log function
        /// </summary>
        /// <param name="level">0 - INFO | 1 - WARNING | 2 - ERROR | 3 - FATAL | 4 - STARTUP | 5 - EXIT</param>
        /// <param name="message">Text to show</param>
        public void WriteLog(int level, string message)
        {

            string txt = DateTime.UtcNow.ToString("dd-MM-yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture);

            switch (level)
            {
                case 0:
                    txt += " - [INFO] - ";
                    break;
                case 1:
                    txt += " - [WARNING] - ";
                    break;
                case 2:
                    txt += " - [ERROR] - ";
                    break;
                case 3:
                    txt += " - [FATAL] - ";
                    break;
                case 4:
                    txt += " - [BACKCRAFT STARTING] ";
                    break;
                case 5:
                    txt += " - [BACKCRAFT EXITING] ";
                    break;
                case 6:
                    txt += " - [STARTING NEW BACKUP] ";
                    break;
                case 7:
                    txt += " - [FINISHED BACKUP] ";
                    break;
            }

            txt += message;
            if (level == 4 || level == 5 || level == 6 || level == 7)
            {
                System.IO.File.AppendAllText("logs.txt", txt + Environment.NewLine);
            }
            else
            {
                System.IO.File.AppendAllText("logs.txt", txt + "." + Environment.NewLine);
            }
        }

    }
}
