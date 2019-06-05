using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{

    public partial class TheInitialWindow : Form
    {
        #region Location
        public void ChangeSize()
        {
            InputNumber.Font = new Font("Times New Roman", (int)(Height * 0.04));

            InputNumber.Height = (int)(Height * 0.5);
            InputNumber.Width = (int)(Width * 0.35);

            InputNumber.Top = (int)(Height / 1.9 - InputNumber.Height / 2);
            InputNumber.Left = (int)(Width / 1.32 - InputNumber.Width / 2);

            Next.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Next.Height = (int)(Height * 0.16);
            Next.Width = (int)(Width * 0.18);

            Next.Top = (int)(Height / 7.3 - Next.Height / 2);
            Next.Left = (int)(Width / 1.32 - Next.Width / 2);

            Level1.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Level1.Height = (int)(Height * 0.1);
            Level1.Width = (int)(Width * 0.18);

            Level1.Top = (int)(Height / 7.5 - Level1.Height / 2);
            Level1.Left = (int)(Width / 6 - Level1.Width / 2);

            Level2.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Level2.Height = (int)(Height * 0.1);
            Level2.Width = (int)(Width * 0.18);

            Level2.Top = (int)(Height / 7.5 - Level2.Height / 2);
            Level2.Left = (int)(Width / 2.4 - Level2.Width / 2);

            Think.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Think.Height = (int)(Height * 0.1);
            Think.Width = (int)(Width * 0.18);

            Think.Top = (int)(Height / 3.3 - Think.Height / 2);
            Think.Left = (int)(Width / 3.5 - Think.Width / 2);

            Error.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Error.Height = (int)(Height * 0.1);
            Error.Width = (int)(Width * 0.18);

            Error.Top = (int)(Height / 2.15 - Error.Height / 2);
            Error.Left = (int)(Width / 6.4 - Error.Width / 2);

            Choose.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Choose.Height = (int)(Height * 0.1);
            Choose.Width = (int)(Width * 0.1);

            Choose.Top = (int)(Height / 1.54 - Choose.Height / 2);
            Choose.Left = (int)(Width / 2.2 - Choose.Width / 2);

            Number.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Number.Height = (int)(Height * 0.09);
            Number.Width = (int)(Width * 0.1);

            Number.Top = (int)(Height / 1.54 - Number.Height / 2);
            Number.Left = (int)(Width / 3.3 - Number.Width / 2);

            Step.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Step.Height = (int)(Height * 0.09);
            Step.Width = (int)(Width * 0.1);

            Step.Top = (int)(Height / 1.54 - Step.Height / 2);
            Step.Left = (int)(Width / 9.2 - Step.Width / 2);

            //

            InputDigit.Font = new Font("Times New Roman", (int)(Height * 0.04));

            InputDigit.Height = (int)(Height * 0.5);
            InputDigit.Width = (int)(Width * 0.35);

            InputDigit.Top = (int)(Height / 1.9 - InputDigit.Height / 2);
            InputDigit.Left = (int)(Width / 1.32 - InputDigit.Width / 2);

            After.Font = new Font("Times New Roman", (int)(Height * 0.04));

            After.Height = (int)(Height * 0.16);
            After.Width = (int)(Width * 0.18);

            After.Top = (int)(Height / 7.3 - After.Height / 2);
            After.Left = (int)(Width / 1.32 - After.Width / 2);

            Stage1.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Stage1.Height = (int)(Height * 0.1);
            Stage1.Width = (int)(Width * 0.18);

            Stage1.Top = (int)(Height / 9.3 - Stage1.Height / 2);
            Stage1.Left = (int)(Width / 6 - Stage1.Width / 2);

            Stage2.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Stage2.Height = (int)(Height * 0.1);
            Stage2.Width = (int)(Width * 0.18);

            Stage2.Top = (int)(Height / 9.3 - Stage2.Height / 2);
            Stage2.Left = (int)(Width / 2.4 - Stage2.Width / 2);

            Make.Font = new Font("Times New Roman", (int)(Height * 0.05));

            Make.Height = (int)(Height * 0.1);
            Make.Width = (int)(Width * 0.18);

            Make.Top = (int)(Height / 3.9 - Make.Height / 2);
            Make.Left = (int)(Width / 3.4 - Make.Width / 2);

            Made.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Made.Height = (int)(Height * 0.1);
            Made.Width = (int)(Width * 0.13);

            Made.Top = (int)(Height / 2.39 - Made.Height / 2);
            Made.Left = (int)(Width / 2.7 - Made.Width / 2);

            Digit.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Digit.Height = (int)(Height * 0.09);
            Digit.Width = (int)(Width * 0.1);

            Digit.Top = (int)(Height / 2.39 - Digit.Height / 2);
            Digit.Left = (int)(Width / 4.5 - Digit.Width / 2);

            Symbol.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Symbol.Height = (int)(Height * 0.09);
            Symbol.Width = (int)(Width * 0.1);

            Symbol.Top = (int)(Height / 1.73 - Symbol.Height / 2);
            Symbol.Left = (int)(Width / 2.5 - Symbol.Width / 2);

            Move.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Move.Height = (int)(Height * 0.1);
            Move.Width = (int)(Width * 0.1);

            Move.Top = (int)(Height / 1.77 - Move.Height / 2);
            Move.Left = (int)(Width / 5.4 - Move.Width / 2);

            Less.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Less.Height = (int)(Height * 0.1);
            Less.Width = (int)(Width * 0.14);

            Less.Top = (int)(Height / 1.37 - Less.Height / 2);
            Less.Left = (int)(Width / 2.13 - Less.Width / 2);

            Guessed.Font = new Font("Times New Roman", (int)(Height * 0.04));

            Guessed.Height = (int)(Height * 0.1);
            Guessed.Width = (int)(Width * 0.14);

            Guessed.Top = (int)(Height / 1.37 - Guessed.Height / 2);
            Guessed.Left = (int)(Width / 3.45 - Guessed.Width / 2);

            More.Font = new Font("Times New Roman", (int)(Height * 0.04));

            More.Height = (int)(Height * 0.1);
            More.Width = (int)(Width * 0.14);

            More.Top = (int)(Height / 1.37 - More.Height / 2);
            More.Left = (int)(Width / 9.2 - More.Width / 2);
        }
        #endregion

        #region Function
        int k = 0;
        int pg = 0;
        int n = 1;
        string Num;
        bool lvl2 = false;
        bool lvl1 = true;
        bool st1 = true;
        bool st2 = false;
        string numeral;
        int quantity;
        int digit = 0;
        int divisible = 0;

        private void PeopleGuesses()
        {
            if (k == 0)
            {
                Random RG = new Random();
                pg = RG.Next(1, 100);
                k = 1;
            }
            string symbol = Number.Text;
            int character = Convert.ToInt32(symbol);
            n += 1;
            Step.Text = "Шаг " + n;
            if (character > 100 || character < 1)
            {
                Error.Text = "         Ошибка";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character < pg)
            {
                Error.Text = "Мое число больше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character > pg)
            {
                Error.Text = "Мое число меньше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character == pg)
            {
                Error.Text = "Вы угадали";
                Num = Number.Text;
                Number.Text = "";
                k = 0;
                if ((n - 1) <= 7)
                {
                    Level2.Enabled = true;
                    Choose.Enabled = false;
                }
                else
                    More.Text = "Вы не прошли уровень";
            }
        }

        private void GuessesPeople()
        {
            if (k == 0)
            {
                Random RG = new Random();
                pg = RG.Next(1, 1000);
                k = 1;
            }
            string symbol = Number.Text;
            int character = Convert.ToInt32(symbol);
            n += 1;
            Step.Text = "Шаг " + n;
            if (character > 1000 || character < 1)
            {
                Error.Text = "         Ошибка";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character < pg)
            {
                Error.Text = "Мое число больше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character > pg)
            {
                Error.Text = "Мое число меньше";
                Num = Number.Text;
                Number.Text = "";
            }
            else if (character == pg)
            {
                Error.Text = "Вы угадали";
                Num = Number.Text;
                Number.Text = "";
                k = 0;
                if ((n - 1) > 10)
                    More.Text = "Вы не прошли уровень";
                else
                    Choose.Enabled = false;
            }
        }

        private void NumberOutput()
        {
            if (Num != "")
            {
                string[] s = Num.Split('\n');
                int a = Convert.ToInt32(s[s.Length - 1]);
                if (InputNumber.Text != "") InputNumber.Text += ",\t";
                InputNumber.Text += Convert.ToString(a);
            }
        }

        private void Level1_Click_1(object sender, EventArgs e)
        {
            lvl2 = false;
            Level2.BackColor = Color.FromArgb(255, 255, 192);
            Choose.Enabled = true;
            Error.Text = " ";
            n = 1;
            Step.Text = "Шаг " + n;
            lvl1 = true;
            Level1.BackColor = Color.Yellow;
            Think.Text = "Я загадал число от 1 до 100";
            InputNumber.Text = "";
        }

        private void Level2_Click_1(object sender, EventArgs e)
        {
            lvl1 = false;
            Level1.BackColor = Color.FromArgb(255, 255, 192);
            Choose.Enabled = true;
            Error.Text = " ";
            n = 1;
            Step.Text = "Шаг " + n;
            lvl2 = true;
            Level2.BackColor = Color.Yellow;
            Think.Text = "Я загадал число от 1 до 1000";
            InputNumber.Text = "";
        }

        private void Choose_Click_1(object sender, EventArgs e)
        {
            if (lvl1 == true)
            {
                PeopleGuesses();
                NumberOutput();
            }

            if (lvl2 == true)
            {
                GuessesPeople();
                NumberOutput();
            }
        }

        //

        private void AndroidGuesses()
        {
            n = 0;
            if (k == 0)
            {
                numeral = Digit.Text;
                quantity = Convert.ToInt32(numeral);
                k = 1;
            }
            digit = 100 / 2;
            if (InputDigit.Text != "") InputDigit.Text += ",  ";
            InputDigit.Text += Convert.ToString(digit);
            Symbol.Text = Convert.ToString(digit);
            n += 1;
            Move.Text = "Шаг " + n;
            divisible = 50;            
        }

        private void GuessesAndroid()
        {
            n = 0;
            if (k == 0)
            {
                numeral = Digit.Text;
                quantity = Convert.ToInt32(numeral);
                k = 1;
            }
            digit = 1000 / 2;
            if (InputDigit.Text != "") InputDigit.Text += ",  ";
            InputDigit.Text += Convert.ToString(digit);
            Symbol.Text = Convert.ToString(digit);
            n += 1;
            Move.Text = "Шаг " + n;
            divisible = 500;
        }

        private void One()
        {
            Symbol.Text = "";
            divisible = divisible / 2;
            digit = digit + divisible;
            if (InputDigit.Text != "") InputDigit.Text += ",  ";
            InputDigit.Text += Convert.ToString(digit);
            Symbol.Text = Convert.ToString(digit);
            n += 1;
            Move.Text = "Шаг " + n;
        }

        private void Two()
        {
            k = 0;
            digit = 0;
            divisible = 0;
            Digit.Text = "";
            InputDigit.Text = "";
            Symbol.Text = "";
            Stage2.Enabled = true;
            More.Enabled = false;
            More.BackColor = Color.FromArgb(192, 255, 192);
            Guessed.Enabled = false;
            Guessed.BackColor = Color.FromArgb(192, 255, 192);
            Less.Enabled = false;
            Less.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Trio()
        {
            Symbol.Text = "";
            divisible = divisible / 2;
            digit = digit - divisible;
            if (InputDigit.Text != "") InputDigit.Text += ",  ";
            InputDigit.Text += Convert.ToString(digit);
            Symbol.Text = Convert.ToString(digit);
            n += 1;
            Move.Text = "Шаг " + n;
        }     

        private void More_Click(object sender, EventArgs e)
        {
            More.BackColor = Color.Lime;
            Guessed.BackColor = Color.FromArgb(192, 255, 192);
            Less.BackColor = Color.FromArgb(192, 255, 192);
            if (st1 == true)
                One();
            if (st2 == true)
                One();
        }

        private void Guessed_Click(object sender, EventArgs e)
        {
            Guessed.BackColor = Color.Lime;
            Made.BackColor = Color.CornflowerBlue;
            //More.BackColor = Color.FromArgb(192, 255, 192);
            //Less.BackColor = Color.FromArgb(192, 255, 192);
            if (st1 == true)
                Two();
            if (st2 == true)
                Two();
        }

        private void Less_Click(object sender, EventArgs e)
        {
            Less.BackColor = Color.Lime;
            Guessed.BackColor = Color.FromArgb(192, 255, 192);
            More.BackColor = Color.FromArgb(192, 255, 192);
            if (st1 == true)
                Trio();
            if (st2 == true)
                Trio();
        }

        private void Stage1_Click_1(object sender, EventArgs e)
        {
            More.Enabled = true;
            Guessed.Enabled = true;
            Less.Enabled = true;
            st2 = false;
            Stage2.BackColor = Color.FromArgb(255, 255, 192);
            Digit.Enabled = true;
            //Symbol.Text = " ";
            n = 1;
            Move.Text = "Шаг " + n;
            st1 = true;
            Stage1.BackColor = Color.Yellow;
            Make.Text = "Загадайте число от 1 до 100";
            //InputDigit.Text = "";
        }

        private void Stage2_Click_1(object sender, EventArgs e)
        {
            st1 = false;
            Stage1.BackColor = Color.FromArgb(255, 255, 192);
            Digit.Enabled = true;
            More.Enabled = true;        
            Guessed.Enabled = true;
            Less.Enabled = true;      
            //Symbol.Text = " ";
            n = 1;
            Move.Text = "Шаг " + n;
            st2 = true;
            Stage2.BackColor = Color.Yellow;
            Make.Text = "Загадайте число от 1 до 1000";
            //InputDigit.Text = "";
        }

        private void Made_Click(object sender, EventArgs e)
        {
            Made.BackColor = Color.Blue;
            if (st1 == true)
                AndroidGuesses();
            if (st2 == true)

                GuessesAndroid();
        }

        /*private void Drive(object sender, EventArgs e)
        {
            FailStream fail = new FileStream("Maker.txt");
            Law.Text = file.ToString();

        }*/

        #endregion

        #region Call
        #endregion

        public TheInitialWindow()
        {
            InitializeComponent();
            //Basic.ItemSize = new Size(0, 1); Basic.SizeMode = TabSizeMode.Fixed;
        }

        private void TheInitialWindow_Load(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void TheInitialWindow_Resize(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManGuessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Regulation.Click += new System.EventHandler(this.Regulation.Click);
        }
        /*private void Drive(object sender, EventArgs e)
{
   FailStream fail = new FileStream("Maker.txt");
   Law.Text = file.ToString();

}*/
    }
}