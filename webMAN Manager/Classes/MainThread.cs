using System;
using System.Diagnostics;
using System.Windows.Forms;
using webMAN_Manager.Classes.PS3;

namespace PSS3.Classes
{
    public class MainThread
    {
        private delegate void ControlDelegate();
        private static ControlDelegate Do;
        public static void Invoke(Control ctrl, Action e)
        {
            try
            {
                Do = new ControlDelegate(e);
                ctrl.Invoke(Do);
            }
            catch { }
        }
        public static bool DoTry(Action doTry, Func<Exception, object> doIfCatch = null, Action doIfFinally = null)
        {
            if (doTry == null) throw new ArgumentNullException();
            else
            {
                try
                {
                    doTry();
                    return true;
                }
                catch (Exception error)
                {
                    if (doIfCatch != null)
                    {
                        doIfCatch(error);
                        return true;
                    }
                    else
                    {
                        if (Debugger.IsAttached) throw;
                        Data.Log("ERROR: Tried to operate with no conditional argument thrown and internal exception.");
                    }
                    return true;
                }
            }
        }

    }
}
