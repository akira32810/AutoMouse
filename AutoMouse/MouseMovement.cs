using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickAutoMouseMove
{

   
    class MouseMovement
    {

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();



        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);


        [DllImport("user32.dll")]
        //find out if POE process is loaded
        public static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);


  

        private static string CurrentWindowName = string.Empty;




        public static int LeftClick(int x, int y, bool random_sleep = true, int lowest_sleep = 100, int highes_sleep = 200, bool chest_click = false)
        {
            int sleep = 0;
            Random random = new Random();
            if (random_sleep)
            {
                sleep = random.Next(lowest_sleep, highes_sleep);
                System.Threading.Thread.Sleep(sleep);
            }

            Point tmp = Cursor.Position;

            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
            Cursor.Position = ConvertToScreenPixel(new Point(randomCoordX_Y(x), randomCoordX_Y(y)));
            if (chest_click)
            {
                System.Threading.Thread.Sleep(50);
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
            }
            //Cursor.Position = tmp;
            return sleep;
        }


        public static Point ConvertToScreenPixel(Point point)
        {
            Rectangle rect;

            GetWindowRect(CurrentActiveWindow(), out rect);

            Point ret = new Point();

            ret.X = rect.Location.X + point.X;
            ret.Y = rect.Location.Y + point.Y;

            return ret;
        }


        public static IntPtr CurrentActiveWindow()
        {
            const int nChars = 256;
            IntPtr handle = GetForegroundWindow();
            StringBuilder sb = new StringBuilder(nChars);

            if (GetWindowText(handle, sb, nChars) > 0)
            {
                CurrentWindowName = sb.ToString();

            }
            if (!string.IsNullOrEmpty(CurrentWindowName))
                return handle;

            else
                return IntPtr.Zero;

        }


        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static int randomCoordX_Y(int value)
        {
            if (value != 0)
            {
                Random random = new Random();

                return random.Next(1, value);
            }

            else return 0;
        }

    }
}
