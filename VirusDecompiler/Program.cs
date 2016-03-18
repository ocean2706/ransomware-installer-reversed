using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace VirusDecompiler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ViralCodes.ExtractAllToFiles();
            var insideDat = File.ReadAllText("HuuGhrjVBt_decode.txt");
            File.WriteAllBytes("encodedresource_HuuGhrjVBt.txt", Convert.FromBase64String(insideDat));
           
        }
    }
}
