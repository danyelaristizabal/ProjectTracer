using System;
using System.Runtime.InteropServices;


namespace ProjectTracer.Forms
{
    public static class NativeWinApi
    {
        public static readonly int GWL_EXSTYLE = -20;
        public static readonly int WS_EX_COMPOSITED = 0x02000000;

        [DllImport("user32")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
    }
}
