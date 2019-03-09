using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADCT_CFG.Controller
{
    public class ATEFileController
    {
        private static string[] SetupPath=new string[4];
        private static string[] CFGPath = new string[4];
        private static string IniPath;

        public string[] SetupPath1 { get => SetupPath; set => SetupPath = value; }
        public string[] CFGPath1 { get => CFGPath; set => CFGPath = value; }
        public string IniPath1 { get => IniPath; set => IniPath = value; }
    }
}
