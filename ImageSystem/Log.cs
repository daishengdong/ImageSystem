using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using ImageSystem.CommonStaticVar;

namespace ImageSystem
{
    class Log
    {
        public static void write(string entry)
        {
            FileStream fs = new FileStream(CommonStaticVariables.logFilePath, FileMode.Append | FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string content = "On  ";
            content += DateTime.Now.ToShortDateString();
            content += "  ";
            content += DateTime.Now.ToShortTimeString();
            content += Environment.NewLine;
            content += entry;
            content += Environment.NewLine;
            sw.Write(content);
            sw.Close();
            fs.Close();
        }
    }
}
