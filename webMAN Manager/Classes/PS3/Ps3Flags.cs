using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webMAN_Manager.Classes.PS3
{
    internal class Ps3Flags
    {
        [DefaultValue(true)]
        public static bool EnableWebMAN { get; set; }
        [DefaultValue(false)]
        public static bool DisableSfoDownload { get; set; }
        [DefaultValue(false)]
        public static bool DisableFriendDownload { get; set; }
        [DefaultValue(true)]
        public static bool DoNotParsedSaveData { get; set; }
        [DefaultValue(false)]
        public static bool DisableLog { get; set; }
    }
}
