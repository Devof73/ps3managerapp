using System.Diagnostics;

namespace webMAN_Manager.Classes.PS3
{

    [DebuggerDisplay("{Data} ({Data.Length})")]
    internal class DebuggingDataStore
    {
        public readonly object[] Data;
        public DebuggingDataStore(params object[] obj)
        {
            Data = obj;
        }
        public static DebuggingDataStore Debug(object[] obj)
        {
            return new DebuggingDataStore(obj);
        }
    }
}
