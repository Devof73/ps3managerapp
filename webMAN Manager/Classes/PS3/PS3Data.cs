using CefSharp.DevTools.CSS;
using PSS3.Classes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace webMAN_Manager.Classes.PS3
{
    internal class PS3Data
    {
        private string _url;
        /// <summary>
        /// Get the current Uniform Resource Locator of the Directory
        /// </summary>
        public string URL { get => _url; }
        public static string UserName { get; set; } = "";
        public static string Password { get; set; } = "";
        public class PS3Directory : PS3Data
        {
            private IEnumerable<string> _files;
            private IEnumerable<string> _directories;
            private int _size;
            private string _name;
            private static PS3Directory _def { get => GetDefault(); }
            /// <summary>
            /// A default object for this class.
            /// </summary>
            public static readonly PS3Directory Null = _def;
            /// <summary>
            /// Gets the safe filename of this directory.
            /// </summary>
            public string Name { get => _name; }
            /// <summary>
            /// Get the count of files in this directory.
            /// </summary>
            public int Size { get => _size; }
            /// <summary>
            /// Get the files of this directory.
            /// </summary>
            public IEnumerable<string> Files { get => _files; }
            /// <summary>
            /// Get the subdirectories of this path.
            /// </summary>
            public IEnumerable<string> Directories { get => _directories; }
            /// <summary>
            /// Base default initializator.
            /// </summary>
            private PS3Directory()
            {
            }
            private static PS3Directory GetDefault()
            {
                var def = new PS3Directory();
                def._name = null;
                def._files = def._directories = new List<string>() { null };
                def._url = "about:blank";
                def._size = -1;
                return def;
            }
            /// <summary>
            /// Obtiene la lista de archivos y directorios de la PS3. Asegúrense de tener las credenciales correctas para acceder a la PS3 antes de usarlo.
            /// </summary>
            /// <param name="client"></param>
            /// <param name="path"></param>
            /// <returns></returns>
            public static PS3Directory FromSystem(PS3System client, string path = "/dev_hdd0")
            {
                string[] files = null;
                var url = (client.AccessUrl.TrimEnd('/') + "/" + path.TrimStart('/'));
                Data.Log(url);
                string[] dirs = null;
                var downloaded =
                    MainThread.DoTry(() =>
                    {
                        Data.Log("Trying to download listing of " + path);
                        files = FTP.GetFiles(url, UserName, Password);
                        dirs = FTP.GetDirectories(url, UserName, Password);
                    }, (ss) => { return null; });
                if (downloaded)
                {
                    var name = url.Split('/').Last();
                    var target = new PS3Directory();
                    target._name = name;
                    target._directories = dirs;
                    target._files = files;
                    target._size = files.Length;
                    target._url = url;
                    return target;
                }
                else return Null;
            }
            public IEnumerable<string> GetListing()
            {
                var listing = new List<string>();
                listing.AddRange(Directories);
                listing.AddRange(Files);
                return listing;
            }
        }

    }
}
