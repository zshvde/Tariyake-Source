using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace xainp
{
    public static class CursorTings
    {
        [DllImport("user32.dll")]
        private static extern bool GetCursorInfo(ref CursorS pci);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpWindowClass, string lpWindowCaption);

        public static bool InMenu(this Cursor cursor)
        {
            if (GetForegroundWindow() == FindWindow("LWJGL", null))
            {
                if (!Cursor.Current.IsVisible()) return true;
            }
            return false;
        }

        public static bool IsVisible(this Cursor cursor)
        {
            CursorS cursorS = default(CursorS);
            cursorS.cbSize = Marshal.SizeOf(typeof(CursorS));
            GetCursorInfo(ref cursorS);
            return cursorS.hCursor.ToInt32() > 100000;
        }

        public struct PointS
        {
            public int x;
            public int y;
        }

        public struct CursorS
        {
            public int cbSize;
            public int flags;
            public IntPtr hCursor;
            public PointS pt;
        }
    }
}
