using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Robot
{

    public partial class Form1 : Form
    {

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        bool durdur = false;
        Color renk1, renk2, renk3, renk4;
        Color renk11, renk22, renk33, renk44;

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public Form1()
        {
            InitializeComponent();
            ShtDown();
            barrengi();
        }

        /// <summary>
        /// durdurma tuşu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            stoping();
        }

        private void BtnKordinat_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// klavyeden tuşlanan klavye yakalama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void BtnKordinat_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void BtnKordinat_MouseUp(object sender, MouseEventArgs e)
        {
            okumakordinat();
            renkal();
            this.Cursor = Cursors.Arrow;
        }

        private void BtnTiklama_MouseUp(object sender, MouseEventArgs e)
        {
            tiklama();
            this.Cursor = Cursors.Arrow;
        }
        /// <summary>
        /// başlat butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (durdur) { } else { durdur = false; timer1.Start(); BtnBaslat.Enabled = false; BtnIptal.Enabled = true; goster_gizle(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WriteINI("Kontol", "x1", x1.Text);
            WriteINI("Kontol", "x2", x2.Text);
            WriteINI("Kontol", "x3", x3.Text);
            WriteINI("Kontol", "x4", x4.Text);
            WriteINI("Kontol", "y1", y1.Text);
            WriteINI("Kontol", "y2", y2.Text);
            WriteINI("Kontol", "y3", y3.Text);
            WriteINI("Kontol", "y4", y4.Text);
            WriteINI("Renkler", "r1r", r1.BackColor.R.ToString());
            WriteINI("Renkler", "r1g", r1.BackColor.G.ToString());
            WriteINI("Renkler", "r1b", r1.BackColor.B.ToString());
            WriteINI("Renkler", "r2r", r2.BackColor.R.ToString());
            WriteINI("Renkler", "r2g", r2.BackColor.G.ToString());
            WriteINI("Renkler", "r2b", r2.BackColor.B.ToString());
            WriteINI("Renkler", "r3r", r3.BackColor.R.ToString());
            WriteINI("Renkler", "r3g", r3.BackColor.G.ToString());
            WriteINI("Renkler", "r3b", r3.BackColor.B.ToString());
            WriteINI("Renkler", "r4r", r4.BackColor.R.ToString());
            WriteINI("Renkler", "r4g", r4.BackColor.G.ToString());
            WriteINI("Renkler", "r4b", r4.BackColor.B.ToString());

            WriteINI("Tiklama", "tx1", tx1.Text);
            WriteINI("Tiklama", "tx2", tx2.Text);
            WriteINI("Tiklama", "tx3", tx3.Text);
            WriteINI("Tiklama", "tx4", tx4.Text);
            WriteINI("Tiklama", "ty1", ty1.Text);
            WriteINI("Tiklama", "ty2", ty2.Text);
            WriteINI("Tiklama", "ty3", ty3.Text);
            WriteINI("Tiklama", "ty4", ty4.Text);
            
            WriteINI("Hiz", "hizlanma", trackBar1.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yukle();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            stoping();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            stoping();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetThreadExecutionState(0x80000000);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GetAsyncKeyState(Keys.NumPad1) != 0) { renkal(); okumakordinat(); }
            if (GetAsyncKeyState(Keys.NumPad2) != 0) { tiklama(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BtnBaslat.Text = "";
            BtnIptal.Text = "DURDUR " + Environment.NewLine +"Sol CTRL";
            BtnTiklama.Text = "Tıklanacak Kordinat" + Environment.NewLine + "(Basılı Tutup Gereken Yerde Bırakın yada Mause Gerekli Konumda Numpad 2 Tuşlayın)";
            BtnKordinat.Text = "Kontrol Kordinatı" + Environment.NewLine + " (Basılı Tutup Gereken Yerde Bırakın yada Mause Gerekli Konumda" + Environment.NewLine + " Numpad 1 Tuşlayın)";
            groupBox1.Enabled = checkBox1.Checked;
            groupBox3.Enabled = checkBox2.Checked;
            groupBox4.Enabled = checkBox3.Checked;
            groupBox5.Enabled = checkBox4.Checked;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                BtnKordinat.Enabled = true;
                BtnTiklama.Enabled = true;
            }
            else
            {
                BtnKordinat.Enabled = false;
                BtnTiklama.Enabled = false;
            }

            SetThreadExecutionState(0x80000043);
        }
        [DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern int GetAsyncKeyState(long vKey);

        /// <summary>
        /// mouse kordinatından renk alıcağı kordinatı alır
        /// </summary>
        private void okumakordinat()
        {
            if (checkBox1.Checked)
            {
                x1.Text = GetCursorPosition().X.ToString();
                y1.Text = GetCursorPosition().Y.ToString();
            }
            if (checkBox2.Checked)
            {
                x2.Text = GetCursorPosition().X.ToString();
                y2.Text = GetCursorPosition().Y.ToString();
            }
            if (checkBox3.Checked)
            {
                x3.Text = GetCursorPosition().X.ToString();
                y3.Text = GetCursorPosition().Y.ToString();
            }
            if (checkBox4.Checked)
            {
                x4.Text = GetCursorPosition().X.ToString();
                y4.Text = GetCursorPosition().Y.ToString();
            }
        }
        /// <summary>
        /// mouse kordinatından renk alır
        /// </summary>
        private void renkal()
        {
            Point nokta = GetCursorPosition();
            if (checkBox1.Checked)
            {
                r1.BackColor = GetColorAt(nokta);
                renk11 = GetColorAt(nokta);
            }
            if (checkBox2.Checked)
            {
                r2.BackColor = GetColorAt(nokta);
                renk22 = GetColorAt(nokta);
            }
            if (checkBox3.Checked)
            {
                r3.BackColor = GetColorAt(nokta);
                renk33 = GetColorAt(nokta);
            }
            if (checkBox4.Checked)
            {
                r4.BackColor = GetColorAt(nokta);
                renk44 = GetColorAt(nokta);
            }
        }

        /// <summary>
        /// daha önceden alınmış kordinattan renk alır
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void sabitrenkal(int x, int y)
        {
            Point nokta = new Point(x, y);
            if (checkBox1.Checked)
            {
                renk1 = GetColorAt(nokta);
            }
            if (checkBox2.Checked)
            {
                renk2 = GetColorAt(nokta);
            }
            if (checkBox3.Checked)
            {
                renk3 = GetColorAt(nokta);
            }
            if (checkBox4.Checked)
            {
                renk4 = GetColorAt(nokta);
            }
        }

        private static void ShtDown()
        {
            if (GetAsyncKeyState(Keys.NumPad9) != 0) { Application.Exit(); }
        }

        private void stoping()
        {
            if (timer1.Enabled) { timer1.Stop(); durdur = false; BtnBaslat.Enabled = true; BtnIptal.Enabled = false; goster_gizle(); }

        }
        /// <summary>
        /// tıklanacak kordinat 
        /// </summary>
        private void tiklama()
        {
            if (checkBox1.Checked)
            {
                tx1.Text = GetCursorPosition().X.ToString();
                ty1.Text = GetCursorPosition().Y.ToString();
            }
            if (checkBox2.Checked)
            {
                tx2.Text = GetCursorPosition().X.ToString();
                ty2.Text = GetCursorPosition().Y.ToString();
            }
            if (checkBox3.Checked)
            {
                tx3.Text = GetCursorPosition().X.ToString();
                ty3.Text = GetCursorPosition().Y.ToString();
            }
            if (checkBox4.Checked)
            {
                tx4.Text = GetCursorPosition().X.ToString();
                ty4.Text = GetCursorPosition().Y.ToString();
            }
        }

        /// <summary>
        /// süreklilik motoru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(trackBar1.Value);
            if (GetAsyncKeyState(Keys.ControlKey) != 0) { stoping(); }
            ShtDown();
            if (durdur) { timer1.Stop(); durdur = false; }
            if (checkBox1.Checked)
            {
                sabitrenkal(Convert.ToInt32(x1.Text), Convert.ToInt32(y1.Text));
                if (!renk1.IsEmpty && renk1 == renk11)
                {
                    string konum = tx1.Text + "," + ty1.Text;
                    MouseClickIzle(konum);
                }
            }
            System.Threading.Thread.Sleep(trackBar1.Value);
            if (checkBox2.Checked)
            {
                sabitrenkal(Convert.ToInt32(x2.Text), Convert.ToInt32(y2.Text));
                if (!renk2.IsEmpty && renk2 == renk22)
                {
                    string konum = tx2.Text + "," + ty2.Text;
                    MouseClickIzle(konum);
                }
            }
            System.Threading.Thread.Sleep(trackBar1.Value);
            if (checkBox3.Checked)
            {
                sabitrenkal(Convert.ToInt32(x3.Text), Convert.ToInt32(y3.Text));
                if (!renk3.IsEmpty && renk3 == renk33)
                {
                    string konum = tx3.Text + "," + ty3.Text;
                    MouseClickIzle(konum);
                }
            }
            System.Threading.Thread.Sleep(trackBar1.Value);
            if (checkBox4.Checked)
            {
                sabitrenkal(Convert.ToInt32(x4.Text), Convert.ToInt32(y4.Text));
                if (!renk4.IsEmpty && renk4 == renk44)
                {
                    string konum = tx4.Text + "," + ty4.Text;
                    MouseClickIzle(konum);
                }
            }
        }

        /// <summary>
        /// tıklama ve bekleme sürelerini belirleyen trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(trackBar1.Value);
            label1.Text = trackBar1.Value.ToString() + "ms";
            barrengi();
        }

        private void barrengi()
        {
            Color renkli = new Color();
            renkli = Color.FromArgb(255, (2000 - trackBar1.Value) / 8, 125, 125);
            trackBar1.BackColor = renkli;
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        bool WriteINI(string SectionName, string KeyName, string StringToWrite)
        {
            bool Return;
            Return = WritePrivateProfileString(SectionName, KeyName, StringToWrite, Application.StartupPath + @"\Config.ini ");
            return Return;
        }
        [DllImport("kernel32.dll")]
        static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        private string veriOku(string anabaslik, string altbaslik)
        {
            if (File.Exists(Application.StartupPath+@"\Config.ini"))
            {
                StringBuilder sb = new StringBuilder(5000);
                GetPrivateProfileString(anabaslik, altbaslik, "", sb, sb.Capacity, Application.StartupPath + @"\Config.ini ");
                string alinan = sb.ToString();
                sb.Clear();
                return alinan;
            }
            else
            {
                return "hata";
            }
            
        }
        private void yukle()
        {            
            x1.Text = veriOku("Kontol", "x1");
            x2.Text = veriOku("Kontol", "x2");
            x3.Text = veriOku("Kontol", "x3");
            x4.Text = veriOku("Kontol", "x4");
            y1.Text = veriOku("Kontol", "y1");
            y2.Text = veriOku("Kontol", "y2");
            y3.Text = veriOku("Kontol", "y3");
            y4.Text = veriOku("Kontol", "y4");

            r1.BackColor = Color.FromArgb(Convert.ToInt32(veriOku("Renkler", "r1r")), Convert.ToInt32(veriOku("Renkler", "r1g")), Convert.ToInt32(veriOku("Renkler", "r1b")));
            renk11 = r1.BackColor;
            r2.BackColor = Color.FromArgb(Convert.ToInt32(veriOku("Renkler", "r2r")), Convert.ToInt32(veriOku("Renkler", "r2g")), Convert.ToInt32(veriOku("Renkler", "r2b")));
            renk22 = r2.BackColor;
            r3.BackColor = Color.FromArgb(Convert.ToInt32(veriOku("Renkler", "r3r")), Convert.ToInt32(veriOku("Renkler", "r3g")), Convert.ToInt32(veriOku("Renkler", "r3b")));
            renk33 = r3.BackColor;
            r4.BackColor = Color.FromArgb(Convert.ToInt32(veriOku("Renkler", "r4r")), Convert.ToInt32(veriOku("Renkler", "r4g")), Convert.ToInt32(veriOku("Renkler", "r4b")));
            renk44 = r4.BackColor;
            tx1.Text = veriOku("Tiklama", "tx1");
            tx2.Text = veriOku("Tiklama", "tx2");
            tx3.Text = veriOku("Tiklama", "tx3");
            tx4.Text = veriOku("Tiklama", "tx4");
            ty1.Text = veriOku("Tiklama", "ty1");
            ty2.Text = veriOku("Tiklama", "ty2");
            ty3.Text = veriOku("Tiklama", "ty3");
            ty4.Text = veriOku("Tiklama", "ty4");
            trackBar1.Value = Convert.ToInt32(veriOku("Hiz", "hizlanma"));
            label1.Text = trackBar1.Value.ToString();
        }

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        [DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern short GetAsyncKeyState(Keys vKey);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }


        public void goster_gizle()
        {
            bool displayy = Visible;
            if (displayy) displayy = false; else displayy = true;
            Visible = displayy;

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        public void MouseClickIzle(string konum)
        {
            string[] knm = konum.Split(',');
            Win32.POINT p = new Win32.POINT();
            p.x = Convert.ToInt32(knm[0].ToString());
            p.y = Convert.ToInt32(knm[1].ToString());

            Win32.ClientToScreen(IntPtr.Zero, ref p);
            Win32.SetCursorPos(p.x, p.y);

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.x, p.y, 0, 0);
        }
        [DllImport("kernel32.dll")]
        public static extern uint SetThreadExecutionState(uint flag);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        public class Win32
        {

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }
        }
    }
}