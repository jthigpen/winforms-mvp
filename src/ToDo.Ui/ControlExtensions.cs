using System;
using System.Windows.Forms;

namespace ToDo.Ui
{
    public static class ControlExtensions
    {
        public static void ThreadSafeInvoke(this Control control, Action methodcall)
        {
            if (control.InvokeRequired)
                control.Invoke(methodcall);
            else
                methodcall();
        }
    }
}