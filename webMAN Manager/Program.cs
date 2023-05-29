using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webMAN_Manager.Classes;
using webMAN_Manager.Classes.PS3;
using webMAN_Manager.Properties;

namespace webMAN_Manager
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            StaticOutput.Initialize();
            ExtensionsTypes.GetSymbols();

            if (!Debugger.IsAttached) Ps3Database.Initialize(WriteDatabase());
            Application.SetCompatibleTextRenderingDefault(false);
            Ps3Flags.DoNotParsedSaveData = Properties.Settings.Default.DownloadParams;
            Application.Run(new BootupForm());
        }

        static string WriteDatabase()
        {
            string path = Application.StartupPath + "\\res\\ps3.database";
            string text = Encoding.Default.GetString(Resources.ps3_database);
            Directory.CreateDirectory(path.GetDirectoryName());
            if (File.Exists(path)) return path;
            else
            {
                File.AppendAllText(path, text);
                File.SetAttributes(path, FileAttributes.Hidden);
            }
            return path;
        }
    }
}
