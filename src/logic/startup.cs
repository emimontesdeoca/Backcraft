﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backcraft.logic
{
    class startup
    {
        const string _txtpath = @"config\startup.txt";

        public bool enabled { get; set; }


        public startup(bool enabled)
        {
            this.enabled = enabled;

        }

        public void WriteToFile()
        {
            File.Delete(_txtpath);
            using (StreamWriter tw = new StreamWriter(_txtpath, true))
            {
                string _enable = "enable=" + this.enabled.ToString();
                try
                {
                    tw.WriteLine(_enable.ToString());
                }
                catch (Exception)
                {
                }
            }
        }

        public static bool GetStartupState()
        {
            bool res = false;
            try
            {
                using (StreamReader rd = new StreamReader(_txtpath, true))
                {
                    while (true)
                    {
                        try
                        {
                            string state = rd.ReadLine().Trim();
                            state = state.Split('=')[1];

                            res = Convert.ToBoolean(state);
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
            return res;
        }
    }
}