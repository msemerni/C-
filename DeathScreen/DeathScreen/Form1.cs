using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace DeathScreen
{
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();
        Form2 fr3 = new Form2();

        public Form1()
        {
            InitializeComponent();
            SystemSounds.Hand.Play();

            Screen[] sc;
            sc = Screen.AllScreens;
            fr2.Left = sc[0].Bounds.Width;
            fr2.Top = sc[0].Bounds.Height;
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = sc[0].Bounds.Location;
            Point p = new Point(sc[0].Bounds.Location.X, sc[0].Bounds.Location.Y);
            fr2.Location = p;
            fr2.WindowState = FormWindowState.Maximized;
            fr2.Show();

            //Screen[] sc2;
            //sc2 = Screen.AllScreens;
            fr3.Left = sc[1].Bounds.Width;
            fr3.Top = sc[1].Bounds.Height;
            fr3.StartPosition = FormStartPosition.Manual;
            fr3.Location = sc[1].Bounds.Location;
            Point p2 = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            fr3.Location = p2;
            fr3.WindowState = FormWindowState.Maximized;
            fr3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
    }
}








//namespace MultiScreen
//{
//    public class ScreenInformation
//    {
//        [StructLayout(LayoutKind.Sequential)]
//        public struct ScreenRect
//        {
//            public int left;
//            public int top;
//            public int right;
//            public int bottom;
//        }

//        [DllImport("user32")]
//        private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lpRect, MonitorEnumProc callback, int dwData);

//        private delegate bool MonitorEnumProc(IntPtr hDesktop, IntPtr hdc, ref ScreenRect pRect, int dwData);

//        public class WpfScreen
//        {
//            public WpfScreen(ScreenRect prect)
//            {
//                metrics = prect;
//            }

//            public ScreenRect metrics;
//        }

//        static LinkedList<WpfScreen> allScreens = new LinkedList<WpfScreen>();

//        public static LinkedList<WpfScreen> GetAllScreens()
//        {
//            ScreenInformation.GetMonitorCount();
//            return allScreens;
//        }
//        public static int GetMonitorCount()
//        {
//            allScreens.Clear();
//            int monCount = 0;
//            MonitorEnumProc callback = (IntPtr hDesktop, IntPtr hdc, ref ScreenRect prect, int d) =>
//            {
//                Console.WriteLine("Left {0}", prect.left);
//                Console.WriteLine("Right {0}", prect.right);
//                Console.WriteLine("Top {0}", prect.top);
//                Console.WriteLine("Bottom {0}", prect.bottom);
//                allScreens.AddLast(new WpfScreen(prect));
//                return ++monCount > 0;
//            };

//            if (EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, callback, 0))
//                Console.WriteLine("You have {0} monitors", monCount);
//            else
//                Console.WriteLine("An error occured while enumerating monitors");

//            return monCount;
//        }
//    }
//}



//namespace MultiScreen
//{
//    /// <summary>
//    /// Interaction logic for App.xaml
//    /// </summary>
//    public partial class App : Application
//    {
//        protected override void OnStartup(StartupEventArgs e)
//        {
//            base.OnStartup(e);
//            LinkedList<ScreenInformation.WpfScreen> screens = ScreenInformation.GetAllScreens();
//            foreach (var screen in screens)
//            {
//                var window = new MainWindow();

//                Console.WriteLine("Metrics {0} {1}", screen.metrics.top, screen.metrics.left);

//                window.Top = screen.metrics.top;
//                window.Left = screen.metrics.left;
//                window.Show();
//            }
//        }

//    }
//}




//foreach (var screen in Screen.AllScreens)
//{
//    var window = new MyWindow();
//var workingArea = screen.WorkingArea;
//window.Top = workingArea.Top;
//    window.Left = workingArea.Left;
//    window.Show();
//}



//private void button1_Click(object sender, EventArgs e)
//        {
//            // Разворачивание 2-й формы на первом мониторе
//            Screen[] sc;
//sc = Screen.AllScreens;
//            Form1 fr2 = new Form1();
//fr2.FormBorderStyle = FormBorderStyle.Sizable;
//            fr2.Left = sc[0].Bounds.Width;
//            fr2.Top = sc[0].Bounds.Height;
//            fr2.StartPosition = FormStartPosition.Manual;
//            fr2.Location = sc[0].Bounds.Location;
//            Point p = new Point(sc[0].Bounds.Location.X, sc[0].Bounds.Location.Y);
//fr2.Location = p;
//            fr2.WindowState = FormWindowState.Maximized;
//            fr2.Show();
//        }
 
//        private void button2_Click(object sender, EventArgs e)
//{
//    // Разворачивание 2-й формы на втором мониторе
//    Screen[] sc;
//    sc = Screen.AllScreens;
//    Form1 fr2 = new Form1();
//    fr2.FormBorderStyle = FormBorderStyle.Sizable;
//    fr2.Left = sc[1].Bounds.Width;
//    fr2.Top = sc[1].Bounds.Height;
//    fr2.StartPosition = FormStartPosition.Manual;
//    fr2.Location = sc[1].Bounds.Location;
//    Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
//    fr2.Location = p;
//    fr2.WindowState = FormWindowState.Maximized;
//    fr2.Show();
//}