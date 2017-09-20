using System;
using System.Collections.Generic;
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
        /// <param name="level">0 - INFO | 1 - WARNING | 2 - ERROR | 3 - FATAL</param>
        /// <param name="message">Text to show</param>
        public void WriteLog(int level, string message)
        {
            string txt = DateTime.Now.ToString();

            switch (level)
            {
                case 0:
                    txt += " [INFO] - ";
                    break;
                case 1:
                    txt += " [WARNING] - ";
                    break;
                case 2:
                    txt += " [ERROR] - ";
                    break;
                case 3:
                    txt += " [FATAL] - ";
                    break;
            }

            txt += message;

            System.IO.File.AppendAllText("logs.txt", txt + "." + Environment.NewLine);
        }

    }
}
