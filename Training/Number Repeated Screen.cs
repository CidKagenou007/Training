using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
    public partial class fmNumberRepeatedScreen : Form
    {
        public fmNumberRepeatedScreen()
        {
            InitializeComponent();
            CustomWindow(Color.Red, Color.Black, Color.Red, Handle);
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

        Random rn = new Random();
        int Number;
        int Counter;

        void FillLablesWithRandomNumbers()
        {
            foreach (var Control in pnNumbers.Controls)
            {
                if (Control is Label)
                {
                    Label label = (Label)Control;

                    int RandomNumber = rn.Next(0 , 9);

                    if (RandomNumber == Number)
                        Counter++;

                    label.Text = RandomNumber.ToString();
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == btnSet)
            {
                tbAnswer.Clear();
                lbResult.Visible = false;
                pnNumbers.Visible = true;
                lbNumber.Visible = true;
                Counter = 0;
                Number = rn.Next(0, 9);
                lbNumber.Text = Number.ToString();
                FillLablesWithRandomNumbers();
                tbAnswer.Focus();
                return;

            }

            if (sender == btnCheck)
            {
                lbResult.Visible = true;

                if (tbAnswer.Text == string.Empty || Counter != Convert.ToInt32(tbAnswer.Text))
                {
                    lbResult.Text = "Wrong :-(";
                    lbResult.ForeColor = Color.Red;
                    return;
                }

                lbResult.Text = "Correct :-)";
                lbResult.ForeColor = Color.Green;
                return;
            }
        }
    }
}
