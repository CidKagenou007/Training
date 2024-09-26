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

namespace Training
{
    public partial class fmMainMenue : Form
    {
        public fmMainMenue()
        {
            InitializeComponent();
            CustomWindow(Color.Red , Color.Black , Color.Red , Handle);
        }

        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        const int DWWMA_BORDER_COLOR = 34;
        const int DWMWA_TEXT_COLOR = 36;
        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == btnExit)
            {
                Application.Exit();
                return;
            }

            if (sender == btnNumberRepeated)
            {
                fmNumberRepeatedScreen Screen = new fmNumberRepeatedScreen();
                Screen.ShowDialog();

                Screen = null;

                this.Show();

                return;
            }

            if (sender == btnGenerateRrandomCharacters)
            {
                fmGenerateRrandomCharactersScreen Screen = new fmGenerateRrandomCharactersScreen();
                Screen.ShowDialog();

                Screen = null;

                this.Show();
                return;
            }
        }
    }
}
