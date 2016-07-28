using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace LendoGravandoArquivoIni
{
    class INIFile
    {

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string applicationName, string keyName,
        string strValue, string fileName);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string applicationName, string keyName,
        string defaultValue, StringBuilder returnString, int nSize, string fileName);


        public static void WriteValue(string sectionName, string keyName, string keyValue, string fileName)
        {
            WritePrivateProfileString(sectionName, keyName, keyValue, fileName);
        }

        public static string ReadValue(string sectionName, string keyName, string fileName)
        {
            StringBuilder szStr = new StringBuilder(255);
            GetPrivateProfileString(sectionName, keyName, "", szStr, 255, fileName);
            return szStr.ToString().Trim();
        }
    }
}
