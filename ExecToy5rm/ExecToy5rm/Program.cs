using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecToy5rm
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc); static void Main(string[] args)
        {
            Form f = new Form();
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Bounds = Screen.PrimaryScreen.Bounds;
            f.TopMost = true;
            DirectBitmap db = new DirectBitmap(f.Width, f.Height); // need to dispose or Using
            f.BackgroundImage = db.Bitmap;
            db.SetPixel(50, 50, Color.Red);

            Application.EnableVisualStyles();
            Application.Run(f);
        }
    }
}
