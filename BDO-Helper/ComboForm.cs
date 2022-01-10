using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Helper
{
    public partial class ComboForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int WS_EX_TRANSPARENT = 0x20;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        public ComboForm(string combo)
        {
            InitializeComponent();

            SetWindowLong(this.Handle, GWL_EXSTYLE,
            (IntPtr)(GetWindowLong(this.Handle, GWL_EXSTYLE) ^ WS_EX_LAYERED ^ WS_EX_TRANSPARENT));
            // set transparency to 50% (128)
            SetLayeredWindowAttributes(this.Handle, 0, 255, LWA_ALPHA);
            this.TopMost = true;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 200);

            BackColor = Color.Black;
            TransparencyKey = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;

            labelCombo.Text = combo;
        }

        private void ComboForm_Load(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
    }
}
