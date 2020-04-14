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

        globalKeyboardHook tf = new globalKeyboardHook();
        globalKeyboardHook jf = new globalKeyboardHook();
        globalKeyboardHook mf = new globalKeyboardHook();
        globalKeyboardHook bf = new globalKeyboardHook();
        globalKeyboardHook sf = new globalKeyboardHook();
        globalKeyboardHook sg = new globalKeyboardHook();
        globalKeyboardHook ng = new globalKeyboardHook();
        globalKeyboardHook ch = new globalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            tf.unhook();
            jf.unhook();
            mf.unhook();
            bf.unhook();
            sf.unhook();
            ch.unhook();
            sg.hook();
            ng.hook();

            tf.HookedKeys.Add(Keys.N);
            tf.KeyDown += new KeyEventHandler(tf_KeyDown);
            jf.HookedKeys.Add(Keys.M);
            jf.KeyDown += new KeyEventHandler(jf_KeyDown);
            mf.HookedKeys.Add(Keys.Oemcomma);
            mf.KeyDown += new KeyEventHandler(mf_KeyDown);
            bf.HookedKeys.Add(Keys.OemPeriod);
            bf.KeyDown += new KeyEventHandler(bf_KeyDown);
            sf.HookedKeys.Add(Keys.OemBackslash);
            sf.KeyDown += new KeyEventHandler(sf_KeyDown);
            ch.HookedKeys.Add(Keys.L);
            ch.KeyDown += new KeyEventHandler(ch_KeyDown);
            sg.HookedKeys.Add(Keys.D1);
            sg.HookedKeys.Add(Keys.LControlKey);
            sg.KeyDown += new KeyEventHandler(sg_KeyDown);
            ng.HookedKeys.Add(Keys.OemQuotes);
            ng.KeyDown += new KeyEventHandler(ng_KeyDown);
            
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

        void tf_KeyDown(object sender, KeyEventArgs e)
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
            e.Handled = true;
        }

        void jf_KeyDown(object sender, KeyEventArgs e)
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
            e.Handled = true;
        }

        void mf_KeyDown(object sender, KeyEventArgs e)
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
            e.Handled = true;
        }

        void bf_KeyDown(object sender, KeyEventArgs e)
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
            e.Handled = true;
        }

        void sf_KeyDown(object sender, KeyEventArgs e)
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
            e.Handled = true;
        }

        void sg_KeyDown(object sender, KeyEventArgs e)
        {
            BringMainWindowToFront("League of Legends");

            tf.hook();
            jf.hook();
            mf.hook();
            bf.hook();
            sf.hook();
            ch.hook();

            timer2.Stop();
            gameTimer = 10;
            timer2.Start();
            startGameTime.Font = new Font("Open Sans Extrabold", 9, FontStyle.Bold);
            e.Handled = true;
        }

        void ng_KeyDown(object sender, KeyEventArgs e)
        {
            BringMainWindowToFront("League of Legends");
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
            e.Handled = true;
        }

        void ch_KeyDown(object sender, KeyEventArgs e)
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
            e.Handled = true;
        }

        public void startTFTimer()
        {
            tfTimeLeft = 300;
            timer1.Start();
        }

        public void startJFTimer()
        {
            jfTimeLeft = 300;
            timer3.Start();
        }

        public void startMFTimer()
        {
            mfTimeLeft = 300;
            timer4.Start();
        }

        public void startBFTimer()
        {
            bfTimeLeft = 300;
            timer5.Start();
        }

        public void startSFTimer()
        {
            sfTimeLeft = 300;
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
                this.Location = new Point(rect.X + 1220, rect.Y + 890);
            }
        }
    }
}
