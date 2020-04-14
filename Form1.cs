using System;
using Utilities;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LoLSummTimer
{
    public partial class Form1 : Form
    {

        int tfTimeLeft, tfLabelT;
        TimeSpan tfTime, tfLabelTimer;
        int jfTimeLeft, jfLabelT;
        TimeSpan jfTime, jfLabelTimer;
        int mfTimeLeft, mfLabelT;
        TimeSpan mfTime, mfLabelTimer;
        int bfTimeLeft, bfLabelT;
        TimeSpan bfTime, bfLabelTimer;
        int sfTimeLeft, sfLabelT;
        TimeSpan sfTime, sfLabelTimer;
        int gameTimer;
        TimeSpan gameTime;
        string copy;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int X;
            public int Y;
            public int Width;
            public int Height;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        globalKeyboardHook detect = new globalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
            detect.HookedKeys.Add(Keys.D1);
            detect.HookedKeys.Add(Keys.D2);
            detect.HookedKeys.Add(Keys.D3);
            detect.HookedKeys.Add(Keys.D4);
            detect.HookedKeys.Add(Keys.D5);
            detect.HookedKeys.Add(Keys.S);
            detect.HookedKeys.Add(Keys.N);
            detect.HookedKeys.Add(Keys.Oemtilde);
            detect.HookedKeys.Add(Keys.LControlKey);
            detect.KeyDown += new KeyEventHandler(detect_KeyDown);
        }

        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
            SetLayeredWindowAttributes(this.Handle, 0, 128, LWA.Alpha);
        }

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };

        public void BringMainWindowToFront(string processName)
        {
            Process bProcess = Process.GetProcessesByName(processName).FirstOrDefault();

            if (bProcess != null)
            {
                if (bProcess.MainWindowHandle == IntPtr.Zero)
                {
                    ShowWindow(bProcess.Handle, ShowWindowEnum.Restore);
                }

                SetForegroundWindow(bProcess.MainWindowHandle);
            }
        }

        void detect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                BringMainWindowToFront("League of Legends");

                timer2.Stop();
                gameTimer = 10;
                timer2.Start();
                startGameTime.Font = new Font("Open Sans Extrabold", 9, FontStyle.Bold);
            }
            else if (e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
            {
                BringMainWindowToFront("League of Legends");
                timer1.Stop();

                tfLabelT = 0;

                startTFTimer();
                tfStart.ForeColor = Color.White;
                tfStart.Font = new Font("Arial", 7, FontStyle.Bold);

                tfLabelT = tfTimeLeft + gameTimer;
                tfLabelTimer = TimeSpan.FromSeconds(tfLabelT);
                tfLabel.Text = tfLabelTimer.ToString(@"mm\:ss");
            }
            else if (e.KeyCode == Keys.D2 && e.Modifiers == Keys.Control)
            {
                BringMainWindowToFront("League of Legends");
                timer3.Stop();

                jfLabelT = 0;

                startJFTimer();
                jfStart.ForeColor = Color.White;
                jfStart.Font = new Font("Arial", 7, FontStyle.Bold);

                jfLabelT = jfTimeLeft + gameTimer;
                jfLabelTimer = TimeSpan.FromSeconds(jfLabelT);
                jfLabel.Text = jfLabelTimer.ToString(@"mm\:ss");
            }
            else if (e.KeyCode == Keys.D3 && e.Modifiers == Keys.Control)
            {
                BringMainWindowToFront("League of Legends");
                timer4.Stop();

                mfLabelT = 0;

                startMFTimer();
                mfStart.ForeColor = Color.White;
                mfStart.Font = new Font("Arial", 7, FontStyle.Bold);

                mfLabelT = mfTimeLeft + gameTimer;
                mfLabelTimer = TimeSpan.FromSeconds(mfLabelT);
                mfLabel.Text = mfLabelTimer.ToString(@"mm\:ss");
            }
            else if (e.KeyCode == Keys.D4 && e.Modifiers == Keys.Control)
            {
                BringMainWindowToFront("League of Legends");
                timer5.Stop();

                bfLabelT = 0;

                startBFTimer();
                bfStart.ForeColor = Color.White;
                bfStart.Font = new Font("Arial", 7, FontStyle.Bold);

                bfLabelT = bfTimeLeft + gameTimer;
                bfLabelTimer = TimeSpan.FromSeconds(bfLabelT);
                bfLabel.Text = bfLabelTimer.ToString(@"mm\:ss");
            }
            else if (e.KeyCode == Keys.D5 && e.Modifiers == Keys.Control)
            {
                BringMainWindowToFront("League of Legends");
                timer6.Stop();

                sfLabelT = 0;

                startSFTimer();
                sfStart.ForeColor = Color.White;
                sfStart.Font = new Font("Arial", 7, FontStyle.Bold);

                sfLabelT = sfTimeLeft + gameTimer;
                sfLabelTimer = TimeSpan.FromSeconds(sfLabelT);
                sfLabel.Text = sfLabelTimer.ToString(@"mm\:ss");
            }
            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else if (e.KeyCode == Keys.Oemtilde)
            {

                 BringMainWindowToFront("League of Legends");
                 copy = "";

                 if (tfLabelT > 0 && tfLabelT > gameTimer)
                 {
                      copy = copy + "Top " + tfLabelTimer.ToString(@"mm\:ss") + "  ";
                 }
                 if (jfLabelT > 0 && jfLabelT > gameTimer)
                 {
                      copy = copy + "Jung " + jfLabelTimer.ToString(@"mm\:ss") + "  ";
                 }
                 if (mfLabelT > 0 && mfLabelT > gameTimer)
                 {
                 copy = copy + "Mid " + mfLabelTimer.ToString(@"mm\:ss") + "  ";
                 }
                 if (bfLabelT > 0 && bfLabelT > gameTimer)
                 {
                      copy = copy + "Bot " + bfLabelTimer.ToString(@"mm\:ss") + "  ";
                 }
                 if (sfLabelT > 0 && sfLabelT > gameTimer)
                 {
                      copy = copy + "Supp " + sfLabelTimer.ToString(@"mm\:ss") + "  ";
                 }
                 if (copy == "")
                 {
                      copy = "gg";
                 }
                 SendKeys.Send("{ENTER}");
                 SendKeys.Send(copy);
                 SendKeys.Send("{ENTER}");
            }
        }

        public void startTFTimer()
        {
            tfTimeLeft = 295;
            timer1.Start();
        }

        public void startJFTimer()
        {
            jfTimeLeft = 295;
            timer3.Start();
        }

        public void startMFTimer()
        {
            mfTimeLeft = 295;
            timer4.Start();
        }

        public void startBFTimer()
        {
            bfTimeLeft = 295;
            timer5.Start();
        }

        public void startSFTimer()
        {
            sfTimeLeft = 295;
            timer6.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (tfTimeLeft > 0)
            {
                tfTimeLeft = tfTimeLeft - 1;
                tfTime = TimeSpan.FromSeconds(tfTimeLeft);
                tfStart.Text = tfTime.ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                tfStart.Text = "ON";

                tfStart.ForeColor = Color.Green;
                tfStart.Font = new Font("Consolas", 11, FontStyle.Bold);

                tfStart.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            gameTimer = gameTimer + 1;
            gameTime = TimeSpan.FromSeconds(gameTimer);
            startGameTime.Text = gameTime.ToString(@"mm\:ss");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (jfTimeLeft > 0)
            {
                jfTimeLeft = jfTimeLeft - 1;
                jfTime = TimeSpan.FromSeconds(jfTimeLeft);
                jfStart.Text = jfTime.ToString(@"mm\:ss");
            }
            else
            {
                timer3.Stop();
                jfStart.Text = "ON";

                jfStart.ForeColor = Color.Green;
                jfStart.Font = new Font("Consolas", 11, FontStyle.Bold);

                jfStart.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (mfTimeLeft > 0)
            {
                mfTimeLeft = mfTimeLeft - 1;
                mfTime = TimeSpan.FromSeconds(mfTimeLeft);
                mfStart.Text = mfTime.ToString(@"mm\:ss");
            }
            else
            {
                timer4.Stop();
                mfStart.Text = "ON";

                mfStart.ForeColor = Color.Green;
                mfStart.Font = new Font("Consolas", 11, FontStyle.Bold);

                mfStart.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (bfTimeLeft > 0)
            {
                bfTimeLeft = bfTimeLeft - 1;
                bfTime = TimeSpan.FromSeconds(bfTimeLeft);
                bfStart.Text = bfTime.ToString(@"mm\:ss");
            }
            else
            {
                timer5.Stop();
                bfStart.Text = "ON";

                bfStart.ForeColor = Color.Green;
                bfStart.Font = new Font("Consolas", 11, FontStyle.Bold);

                bfStart.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (sfTimeLeft > 0)
            {
                sfTimeLeft = sfTimeLeft - 1;
                sfTime = TimeSpan.FromSeconds(sfTimeLeft);
                sfStart.Text = sfTime.ToString(@"mm\:ss");
            }
            else
            {
                timer6.Stop();
                sfStart.Text = "ON";

                sfStart.ForeColor = Color.Green;
                sfStart.Font = new Font("Consolas", 11, FontStyle.Bold);

                sfStart.Enabled = true;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, "League of Legends (TM) Client");
            RECT rect;
            GetWindowRect(hWnd, out rect);
            if (rect.X == -32000)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(rect.X + 1260, rect.Y + 890);
            }
        }
    }
}
