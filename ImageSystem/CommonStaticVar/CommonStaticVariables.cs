using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Collections;

namespace ImageSystem.CommonStaticVar
{
    public class CommonStaticVariables
    {
        // 账户记录文件地址
        public static string accountsFilePath = Environment.CurrentDirectory + @"\accounts.xml";

        // 图片配置文件地址
        public static string imagesFilePath = Environment.CurrentDirectory + @"\images.xml";

        // 日志文件地址
        public static string logFilePath = Environment.CurrentDirectory + @"\log.txt";

        // 权限
        public enum AUTHORITY { ADMINISTRATOR, OPERATOR };
    }
}