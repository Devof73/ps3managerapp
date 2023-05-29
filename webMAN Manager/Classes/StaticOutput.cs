using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace webMAN_Manager.Classes
{
    internal static class StaticOutput
    {
        private static SoundPlayer _playerr = null;
        public static void Initialize()
        {
            _playerr = new SoundPlayer();
        }
        public static void Play(Stream stream)
        {
            _playerr.Stream = stream;
            _playerr.Load();
            _playerr.Play();
        }
        public static void Stop() => _playerr.Stop();
        public static void Play() => _playerr.Play();
        public static void Dispose() => _playerr.Dispose();
    }
}
