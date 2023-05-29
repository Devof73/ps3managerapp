using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using webMAN_Manager.Classes.PS3;

namespace webMAN_Manager.Classes.PS3
{
    public class Ps3Games
    {
        public static readonly Ps3Games Empty = new Ps3Games(new PS3ParamSfo[1] { PS3ParamSfo.Null });
        public PS3ParamSfo[] TitlesSfo { get; private set; }
        private Ps3Games(PS3ParamSfo[] sfos)
        {
            TitlesSfo = sfos;
        }
        public static Ps3Games FromSystem(PS3System e)
        {
            List<PS3ParamSfo> sfos = new List<PS3ParamSfo>();
            string PATH = e.AccessUrl + "/dev_hdd0/game";
            string[] contain = Data.GetDirectories(PATH);
            int ii = 0;
            foreach (string item in contain)
            {
                if (item.Length > 2 & !Path.HasExtension(item))
                {
                    int perc = ii * 100 / contain.Length;
                    Data.Log("Loading game: " + item + "... " + perc + "%");
                    sfos.Add(ParseFromGamePath(e, PATH + "/" + item));

                }
                ii++;
            }
            return new Ps3Games(sfos.ToArray());
        }

        private static PS3ParamSfo ParseFromGamePath(in PS3System sys, string path)
        {
            try
            {
                string gm = Path.GetFileName(path);
                string dir = Application.StartupPath + "\\USRDAT\\";
                string usrdir = dir + sys.SystemName + "\\";
                string dpath = usrdir + "game\\" + gm;
                Console.WriteLine("dpath " + dpath);
                _ = Directory.CreateDirectory(dir); _ = Directory.CreateDirectory(usrdir);
                _ = Directory.CreateDirectory(dpath);
                if (Directory.Exists(dpath) & File.Exists(dpath + "\\PARAM.SFO"))
                {
                    PS3ParamSfo param = PS3ParamSfo.FromLocal(dpath);
                    sys.OnParamReceivedEvent(null, param);
                    return param;
                }
                else
                {
                    return ParseDirectory(sys, path, dpath);
                }
            }
            catch
            { return PS3ParamSfo.Null; }
        }
        private static PS3ParamSfo ParseDirectory(PS3System sys, string dirpath, string localpath)
        {
            string filen = dirpath + "/PARAM.SFO";
            string icon = dirpath + "/ICON0.PNG";
            string pic = dirpath + "/PIC1.PNG";

            if (Data.UrlFileExists(filen))
            {
                bool hasicon = Data.UrlFileExists(icon);
                bool haspic = Data.UrlFileExists(pic);
                byte[] data = Data.Download(filen);
                Bitmap pic_ = haspic ? Data.DownloadBitmap(pic) : null;
                Bitmap icon_ = hasicon ? Data.DownloadBitmap(icon) : null;
                PS3ParamSfo sfo = PS3ParamSfo.FromData(data, icon_, pic_);
                File.WriteAllBytes(localpath + "\\PARAM.SFO", data);
                Data.Log("Writing.. " + localpath + "\\PARAM.SFO" + " - " + data.LongLength.ToBytesRepresentationString());
                sfo.Icon0?.Save(localpath + "\\" + "ICON0.PNG");
                sfo.Pic0?.Save(localpath + "\\" + "PIC0.PNG");
                sys.OnParamReceivedEvent(null, sfo);
                return sfo;
            }
            else
            {
                return PS3ParamSfo.Null;
            }


        }

    }

}
