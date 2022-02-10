using DiscordRPC;
using Siticone.UI.WinForms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xainp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "mouse_event", ExactSpelling = true, SetLastError = true)]
        private static extern bool apimouse_event(int dwFlags, int dX, int dY, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        public Form1() => InitializeComponent();

        private void Form2_Load(object sender, EventArgs e)
        {
            //using (DiscordRpcClient client = new DiscordRpcClient(""))
            //{
            //    ConsoleLogger val = new ConsoleLogger
            //    {
            //        Level = LogLevel.Warning
            //    }; 

            //    client.Logger = val; client.Initialize();

            //    client.SetPresence(new RichPresence
            //    {
            //        Details = "hm",
            //        State = "autoclicking with tariyake",
            //        Timestamps = Timestamps.Now
            //    });
            //}

            // not working lol
            // + some more removed code
        }


        private void siticoneMetroTrackBar1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle clipRectangle = e.ClipRectangle;
            clipRectangle.Width = (int)(clipRectangle.Width * ((siticoneMetroTrackBar1.Value - siticoneMetroTrackBar1.Minimum) / (double)(siticoneMetroTrackBar1.Maximum - siticoneMetroTrackBar1.Minimum))) - 2;
            clipRectangle.Height -= 2;
            SiticoneMetroTrackBar siticoneMetroTrackBar = (SiticoneMetroTrackBar)sender;
            SolidBrush solidBrush = new SolidBrush(siticoneMetroTrackBar.FillColor);
            e.Graphics.FillRectangle(solidBrush, e.ClipRectangle);
            e.Graphics.FillRectangle(brush, 1, 1, clipRectangle.Width, clipRectangle.Height);
            solidBrush.Dispose();
        }

        private void siticoneMetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = siticoneMetroTrackBar1.Value.ToString() ?? "";
        }

        private void siticoneMetroTrackBar2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle clipRectangle = e.ClipRectangle;
            clipRectangle.Width = (int)(clipRectangle.Width * ((siticoneMetroTrackBar2.Value - siticoneMetroTrackBar2.Minimum) / (double)(siticoneMetroTrackBar2.Maximum - siticoneMetroTrackBar2.Minimum))) - 2;
            clipRectangle.Height -= 2;
            SiticoneMetroTrackBar siticoneMetroTrackBar = (SiticoneMetroTrackBar)sender;
            SolidBrush solidBrush = new SolidBrush(siticoneMetroTrackBar.FillColor);
            e.Graphics.FillRectangle(solidBrush, e.ClipRectangle);
            e.Graphics.FillRectangle(brush, 1, 1, clipRectangle.Width, clipRectangle.Height);
            solidBrush.Dispose();
        }

        private void siticoneMetroTrackBar3_Paint(object sender, PaintEventArgs e)
        {
            Rectangle clipRectangle = e.ClipRectangle;
            clipRectangle.Width = (int)(clipRectangle.Width * ((siticoneMetroTrackBar3.Value - siticoneMetroTrackBar3.Minimum) / (double)(siticoneMetroTrackBar3.Maximum - siticoneMetroTrackBar3.Minimum))) - 2;
            clipRectangle.Height -= 2;
            SiticoneMetroTrackBar siticoneMetroTrackBar = (SiticoneMetroTrackBar)sender;
            SolidBrush solidBrush = new SolidBrush(siticoneMetroTrackBar.FillColor);
            e.Graphics.FillRectangle(solidBrush, e.ClipRectangle);
            e.Graphics.FillRectangle(brush, 1, 1, clipRectangle.Width, clipRectangle.Height);
            solidBrush.Dispose();
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked) leftClick.Start();
            else leftClick.Stop();
        }

        private void siticoneMetroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = siticoneMetroTrackBar2.Value.ToString() ?? "";
        }

        private void rightClick_Tick(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox14.Checked)
            {
                if (GetAsyncKeyState(Keys.LShiftKey) < 0) shifting = true;
                else shifting = false;
            }
            else shifting = false;

            if (!guna2CustomCheckBox3.Checked) return;

            int num = 1000 / siticoneMetroTrackBar3.Value, minValue = num + 0, num2 = 1000 / siticoneMetroTrackBar3.Value, maxValue = num2 + 0;

            rightClick.Interval = rnd.Next(minValue, maxValue);
            Process[] processesByName = Process.GetProcessesByName("javaw");
            if (processesByName.Length != 0)
            {
                Process[] array = processesByName;
                foreach (Process process in array) hWnd = FindWindow(null, process.MainWindowTitle);
            }

            if (guna2CustomCheckBox3.Checked && !hWnd.Equals(IntPtr.Zero) && GetAsyncKeyState(Keys.RButton) < 0 && !shifting)
            {
                PostMessage(hWnd, 516u, 0, 0);
                PostMessage(hWnd, 517u, 0, 0);
            }
        }

        private void siticoneMetroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label8.Text = siticoneMetroTrackBar3.Value.ToString() ?? "";
        }

        private void leftClick_Tick(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox14.Checked)
            {
                if (GetAsyncKeyState(Keys.LShiftKey) < 0) shifting = true;
                else shifting = false;
            }
            else shifting = false;

            if (guna2CustomCheckBox8.Checked)
            {
                if (GetAsyncKeyState(Keys.RButton) < 0) rmb = true;
                else rmb = false;
            }
            else rmb = false;

            if (guna2CustomCheckBox10.Checked)
            {
                if (Cursor.Current.InMenu()) inv = true;
                else inv = false;
            }

            if (!guna2CustomCheckBox1.Checked) return;

            int num = 1000 / siticoneMetroTrackBar1.Value, minValue = num + 0, num2 = 1000 / siticoneMetroTrackBar1.Value, maxValue = num2 + 0;

            leftClick.Interval = rnd.Next(minValue, maxValue);
            Process[] processesByName = Process.GetProcessesByName("javaw");
            if (processesByName.Length != 0)
            {
                Process[] array = processesByName;
                foreach (Process process in array) hWnd = FindWindow(null, process.MainWindowTitle);
            }

            if (!guna2CustomCheckBox1.Checked || hWnd.Equals(IntPtr.Zero)) return;

            if (guna2CustomCheckBox2.Checked)
            {
                if (GetAsyncKeyState(Keys.LButton) < 0 && !shifting && !inv && !rmb)
                {
                    PostMessage(hWnd, 513u, 0, 0); PostMessage(hWnd, 514u, 0, 0);
                    if (rnd.Next(0, 100) <= siticoneMetroTrackBar2.Value)
                    {
                        PostMessage(hWnd, 516u, 0, 0); PostMessage(hWnd, 517u, 0, 0);
                    }
                }
            }
            else if (GetAsyncKeyState(Keys.LButton) < 0 && !shifting && !inv && !rmb)
            {
                PostMessage(hWnd, 513u, 0, 0); PostMessage(hWnd, 514u, 0, 0);
            }
        }

        private void guna2CustomCheckBox3_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox3.Checked) rightClick.Start();
            else rightClick.Stop();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2CustomCheckBox4_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox4.Checked)
            {
                siticoneMetroTrackBar1.Maximum = 50;
                siticoneMetroTrackBar1.Minimum = 30;
                siticoneMetroTrackBar1.Value = 30;
            }
            else
            {
                siticoneMetroTrackBar1.Value = 30;
                siticoneMetroTrackBar1.Minimum = 1;
                siticoneMetroTrackBar1.Maximum = 20;
            }
        }

        private void guna2CustomCheckBox5_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox5.Checked)
            {
                siticoneMetroTrackBar3.Maximum = 50;
                siticoneMetroTrackBar3.Minimum = 30;
                siticoneMetroTrackBar3.Value = 30;
            }
            else
            {
                siticoneMetroTrackBar3.Value = 30;
                siticoneMetroTrackBar3.Minimum = 1;
                siticoneMetroTrackBar3.Maximum = 20;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Text = "...";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button3.Text = "...";
        }

        private void bindTimer_Tick(object sender, EventArgs e)
        {
            if (guna2Button1.Text != "Press" && guna2Button1.Text != "...")
            {
                KeysConverter keysConverter = new KeysConverter();
                Keys vKey = (Keys)keysConverter.ConvertFromString(((Control)(object)guna2Button1).Text);
                if (GetAsyncKeyState(vKey) != 0)
                {
                    if (guna2CustomCheckBox1.Checked) guna2CustomCheckBox1.Checked = false;
                    else guna2CustomCheckBox1.Checked = true;
                }
            }
            if (guna2Button3.Text != "Press" || guna2Button3.Text != "...") return;

            KeysConverter keysConverter2 = new KeysConverter();
            Keys vKey2 = (Keys)keysConverter2.ConvertFromString(((Control)(object)guna2Button3).Text);
            if (GetAsyncKeyState(vKey2) != 0)
            {
                if (guna2CustomCheckBox3.Checked) guna2CustomCheckBox3.Checked = false;
                else guna2CustomCheckBox3.Checked = true;
            }
        }

        private void BindKey_Down(object sender, KeyEventArgs e)
        {
            if (guna2Button1.Text == "...")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0) guna2Button1.Text = "Press";
                else guna2Button1.Text = e.KeyData.ToString();
            }
        }

        private void BindKey1_Down(object sender, KeyEventArgs e)
        {
            if (guna2Button3.Text == "...")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0) guna2Button3.Text = "Press";
                else guna2Button3.Text = e.KeyData.ToString();
            }
        }

        private async void bgwWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            await Task.Delay(2500);
            bgwScan.RunWorkerAsync();
        }

        private async void bgwScan_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!guna2CustomCheckBox11.Checked && !guna2CustomCheckBox12.Checked && !guna2CustomCheckBox13.Checked) { await Task.Delay(1500); Environment.Exit(1); }

            await Task.Run(delegate
            {
                Des.destruct(guna2CustomCheckBox11.Checked, guna2CustomCheckBox12.Checked, guna2CustomCheckBox13.Checked);
            });
        }

        private async void bgwDestruct_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!guna2CustomCheckBox11.Checked && !guna2CustomCheckBox12.Checked && !guna2CustomCheckBox13.Checked) { await Task.Delay(1500); Environment.Exit(1); }

            await Task.Run(delegate
            {
                Des.destruct(guna2CustomCheckBox11.Checked, guna2CustomCheckBox12.Checked, guna2CustomCheckBox13.Checked);
            });
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            isDestrucing = true;
            bgwDestruct.RunWorkerAsync();
            MessageBox.Show("Destructing..");
            Environment.Exit(0);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private readonly SolidBrush brush = new SolidBrush(Color.FromArgb(183, 70, 70));

        private bool isDestrucing = false;

        private readonly Random rnd = new Random();

        private IntPtr hWnd;

        public DiscordRpcClient client;

        private bool shifting = false;

        private bool rmb;

        private bool inv;

        private readonly Destruct Des = new Destruct();
    }
}
