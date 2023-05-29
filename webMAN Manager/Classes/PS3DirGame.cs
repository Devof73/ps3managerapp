using CefSharp.DevTools.Overlay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace webMAN_Manager.Classes.PS3
{
    internal class PS3DirGame
    {
        public static readonly string DefaultPath = "/GAMES";
        public PS3System Origin { get; private set; }
        public string ContentTitle { get; private set; }
        public string ContentTitleId { get; private set; }
        public PS3ParamSfo Parameters { get; private set; }
        private PS3DirGame()
        {

        }
        public static PS3DirGame[] FromSystem(PS3System system)
        {
            var path = system.Client.GetIso();
            string[] cred = { system.Credentials.UserName, system.Credentials.Password };
            var containers = FTP.GetDirectories(path, cred[0], cred[1]);
            foreach (string dir in containers)
            {
                if (dir is "-") continue;
                string[] arguments =
                {
                    "/PS3_GAME",
                    "/PS3_GAME/ICON0.PNG",
                    "/PS3_GAME/SND0.AT3",
                    "/PS3_GAME/PARAM.SFO",
                };
                var subpath = path + "/" + dir;
                var sub = FTP.GetDirectories(subpath, cred[0], cred[1]);
                if (sub.Length == 0)
                    continue;
                else
                {
                    // this will look the same as arguments but not :).
                    var rootdir = sub.Where((s) => s.GetFileName() == arguments[0].Trim('/')).LastOrDefault();
                    if (rootdir != null)
                    {
                        var files = FTP.GetFiles(subpath + "/" + rootdir, cred[0], cred[1]);
                        var regionpre = dir.Split('/').Last();
                        bool matchwith(string s, int index)
                        {
                            return s.EndsWith(arguments[index].Split('/').LastOrDefault());
                        }
                        string find(int index)
                        {
                            return files.Where((a) => matchwith(a, index)).LastOrDefault();
                        }
                        // i see it and i like it.
                        var icn = find(1);
                        var snd = find(2);
                        var prm = find(3);
                        var debug = new DebuggingDataStore(icn, snd, prm);
                        Debug.WriteLineIf(debug.Data.Length > 0, $"PARAM WITH {debug.Data.Length} FILES HAS BEEN FETCHED SUCCESSFULLY.");
                        Debugger.Break();

                    }
                }
            }
            return null;
        }
    }
}
