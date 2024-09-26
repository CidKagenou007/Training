using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
    public partial class fmGenerateRrandomCharactersScreen : Form
    {
        public fmGenerateRrandomCharactersScreen()
        {
            InitializeComponent();
            CustomWindow(Color.Red, Color.Black, Color.Red, Handle);
        }

        Random rnd = new Random();

        enum enTypeCharacter { Letter = 1, Symbol = 2, Digit = 3};

        char GetCharacter(enTypeCharacter TypeCharacter)
        {

            switch (TypeCharacter)
            {

                case enTypeCharacter.Letter:
                    {

                        switch(rnd.Next(1, 3))
                        {
                            case 1:
                                return (char)rnd.Next(97, 123);
                            case 2:
                                return (char)rnd.Next(65, 91);
                        }

                        break;
                    }

                case enTypeCharacter.Symbol:

                    switch (rnd.Next(1, 4))
                    {
                        case 1:
                            return (char)rnd.Next(33, 48);
                        case 2:
                            return (char)rnd.Next(58, 65);
                        case 3:
                            return (char)rnd.Next(123, 126);
                    }

                    break;

                case enTypeCharacter.Digit:
                    return (char)(rnd.Next(48, 58));

            }

            return ' ';
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

        void ResetOptions()
        {
            rbLetters.Checked = false;
            rbSymbols.Checked = false;
            rbNumbers.Checked = false;
            rbMix.Checked = false;

            tbNumberOfDigits.Clear();
        }

        bool IsInputCorrect()
        {
            if (tbNumberOfDigits.Text == string.Empty)
                return false;

            if (tbNumberOfDigits.Text.Any(o => char.IsDigit(o) == false))
                return false;

            return true;
        }

        string Generate()
        {
            int Lenght = Convert.ToInt32(tbNumberOfDigits.Text);
            string Result = string.Empty;

            if (rbLetters.Checked)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    Result += GetCharacter(enTypeCharacter.Letter);
                }

                return Result;
            }

            if (rbSymbols.Checked)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    Result += GetCharacter(enTypeCharacter.Symbol);
                }

                return Result;
            }

            if (rbNumbers.Checked)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    Result += GetCharacter(enTypeCharacter.Digit);
                }

                return Result;
            }

            for (int i = 0; i < Lenght; i++)
            {
                Result += GetCharacter((enTypeCharacter)rnd.Next(1 , 4));
            }

            return Result;
        }

        bool IsUserCheckedChoice()
        {
            if (rbLetters.Checked || rbMix.Checked || rbNumbers.Checked || rbSymbols.Checked)
            {
                return true;
            }

            return false;
        }

        private void Perform_Click(object sender, EventArgs e)
        {
            if (sender == btnOptions)
            {
                pnOptions.Visible = true;
                tbNumberOfDigits.Focus();
                btnGenerate.Enabled = true;
                return;
            }

            if (sender == btnGenerate)
            {
                if (!IsInputCorrect())
                {
                    MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNumberOfDigits.Clear();
                    tbNumberOfDigits.Focus();
                    return;
                }

                if (!IsUserCheckedChoice())
                {
                    rbMix.Checked = true;
                }

                string Result = Generate();
                lbResult.Text = Result;
                return;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == btnExit)
            {
                this.Close();
                return;
            }

            if (sender == btnReset)
            {
                ResetOptions();
                pnOptions.Visible = false;
                lbResult.Text = string.Empty;
                btnGenerate.Enabled = false;
            }
        }

        
    }
}
