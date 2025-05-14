using System;
using System.Text;
using System.Windows.Forms;
using NCalc;
using System.IO;


namespace Kurs_Ishi_4_sem
{
    public partial class Form1 : Form
    {
        bool isNewEntry = true;
        bool lastInputWasFunction = false;
        bool isDegreeMode = true;
        int currentBase = 10;

        string userExpression = "";
        string calcExpression = "";

        string pendingFunction = "";
        string pendingArgument = "";

        string historyFilePath = @"C:\Users\user\Desktop\Paritdinov_Samariddin_Kurs_ishi_2-kurs_4-sem\history.txt";

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private void AddInput(string value)
        {
            if (isNewEntry || txtResult.Text == "0")
                txtResult.Text = value;
            else
                txtResult.Text += value;

            userExpression += value;

            lblHistory.Text = userExpression;
            isNewEntry = false;
        }


        private void AddScientificFunc(string name, Func<double, double> mathFunc)
        {
            if (!isNewEntry)
            {
                string input = txtResult.Text;
                double inputVal = ConvertBaseToDecimal(input, currentBase);

                string degreeSuffix = "";
                if (isDegreeMode && (name == "Sin" || name == "Cos" || name == "Tan"))
                {
                    inputVal = inputVal * Math.PI / 180;
                    degreeSuffix = "°";
                }

                double computed = mathFunc(inputVal);
                // agar juda kichik qiymat chiqsa uni 0 deb olish maqsad sin(180) dan juda kichik son chiqadi shuni 0 deb olib ketish
                if (Math.Abs(computed) < 1e-6) computed = 0;


                // Oldingi sonni olib tashlash
                if (userExpression.EndsWith(input))
                    userExpression = userExpression.Substring(0, userExpression.Length - input.Length);

                userExpression += name + "(" + input + degreeSuffix + ")";
                calcExpression += computed;

                txtResult.Text = ConvertBase(computed.ToString(), 10, currentBase);
                lblHistory.Text = userExpression;
                isNewEntry = true;
                lastInputWasFunction = true;
            }
        }


        private void btnSin_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Sin", Math.Sin);
        }


        private void btnCos_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Cos", Math.Cos);
        }


        private void btnTan_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Tan", Math.Tan);
        }


        private void btnCtg_Click(object sender, EventArgs e)
        {
            string input = txtResult.Text;
            double angle = ConvertBaseToDecimal(input, currentBase);
            if (isDegreeMode) angle = angle * Math.PI / 180;
            if (Math.Tan(angle) == 0)
            {
                MessageBox.Show("ctg aniqlanmagan");
                return;
            }
            double val = 1 / Math.Tan(angle);
            userExpression += "ctg(" + input + (isDegreeMode ? "°" : "") + ")";
            calcExpression += "1/Tan(" + ConvertBaseToDecimal(input, currentBase).ToString() + ")";
            txtResult.Text = val.ToString();
            lblHistory.Text = userExpression;
            isNewEntry = true;
            lastInputWasFunction = true;
        }


        private void btnSqrt_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Sqrt", Math.Sqrt);
        }


        private void btnAbs_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Abs", Math.Abs);
        }


        private void btnLg_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Log10", Math.Log10);
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            pendingFunction = "Log";
            pendingArgument = txtResult.Text;
            string inputDecimal = ConvertBaseToDecimal(pendingArgument, currentBase).ToString();

            if (userExpression.EndsWith(pendingArgument))
                userExpression = userExpression.Substring(0, userExpression.Length - pendingArgument.Length);

            if (calcExpression.EndsWith(inputDecimal))
                calcExpression = calcExpression.Substring(0, calcExpression.Length - inputDecimal.Length);

            userExpression += "Log(" + pendingArgument + ",";
            calcExpression += "Log(" + inputDecimal + ",";

            txtResult.Text = "0";
            lblHistory.Text = userExpression;
            isNewEntry = true;
            lastInputWasFunction = true;
        }


        private void btnLn_Click(object sender, EventArgs e)
        {
            AddScientificFunc("Log", Math.Log);
        }


        private void btnPow_Click(object sender, EventArgs e)
        {
            pendingFunction = "Pow";
            pendingArgument = txtResult.Text;
            string inputDecimal = ConvertBaseToDecimal(pendingArgument, currentBase).ToString();

            // eski sonni o'chirish
            if (userExpression.EndsWith(pendingArgument))
                userExpression = userExpression.Substring(0, userExpression.Length - pendingArgument.Length);

            if (calcExpression.EndsWith(inputDecimal))
                calcExpression = calcExpression.Substring(0, calcExpression.Length - inputDecimal.Length);

            userExpression += "Pow(" + pendingArgument + ",";
            calcExpression += "Pow(" + inputDecimal + ",";

            txtResult.Text = "0";
            lblHistory.Text = userExpression;
            isNewEntry = true;
            lastInputWasFunction = true;
        }


        private void btnE_Click(object sender, EventArgs e)
        {
            string val = Math.E.ToString();
            userExpression += "e";
            calcExpression += val;
            txtResult.Text = val;
            lblHistory.Text = userExpression;
            isNewEntry = true;
        }


        private void btnPi_Click(object sender, EventArgs e)
        {
            string val = Math.PI.ToString();
            userExpression += "π";
            calcExpression += val;
            txtResult.Text = val;
            lblHistory.Text = userExpression;
            isNewEntry = true;
        }


        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            AddInput(btn.Text.ToUpper());
        }


        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string opSymbol = btn.Text;

            if (pendingFunction != "")
            {
                string secondVal = txtResult.Text;
                userExpression += ")";
                calcExpression += ConvertBaseToDecimal(secondVal, currentBase).ToString() + ")";

                pendingFunction = "";
                pendingArgument = "";

                txtResult.Text = "0";
                isNewEntry = true;
                lastInputWasFunction = true; // Bu yer muhim!
            }
            else if (!isNewEntry && !lastInputWasFunction)
            {
                string lastInput = txtResult.Text;
                string decimalVal = ConvertBaseToDecimal(lastInput, currentBase).ToString();
                calcExpression += decimalVal;
            }

            //  Ketma-ket operatorlarni tekshirish va almashtirish
            if (userExpression.Length > 0)
            {
                char lastChar = userExpression[userExpression.Length - 1];

                // Agar oxirgi belgilar operator bo‘lsa uni yangisiga almashtiramiz
                if ("+-*/".IndexOf(lastChar) >= 0)
                {
                    userExpression = userExpression.Substring(0, userExpression.Length - 1);
                    calcExpression = calcExpression.Substring(0, calcExpression.Length - 1);
                }
            }
            userExpression += opSymbol;
            calcExpression += opSymbol;
            lblHistory.Text = userExpression;

            txtResult.Text = "0";
            isNewEntry = true;
            lastInputWasFunction = false;
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Agar pendingFunction bo'lsa, ikkinchi argumentni yakunlab qo'shamiz
            if (pendingFunction != "")
            {
                string secondVal = txtResult.Text;
                userExpression += secondVal + ")";
                calcExpression += ConvertBaseToDecimal(secondVal, currentBase).ToString() + ")";

                pendingFunction = "";
                pendingArgument = "";
            }
            try
            {
                if (!isNewEntry && !lastInputWasFunction)
                {
                    string lastInput = txtResult.Text;
                    string decimalVal = ConvertBaseToDecimal(lastInput, currentBase).ToString();
                    calcExpression += decimalVal;
                }

                Expression exp = new Expression(calcExpression);
                object result = exp.Evaluate();

                string finalResult = result.ToString();
                if (currentBase != 10)
                    finalResult = ConvertBase(finalResult, 10, currentBase);

                string historyLine = userExpression + " = " + finalResult + "  ;  Base=" + currentBase;
                File.AppendAllText(historyFilePath, historyLine + Environment.NewLine);

                txtResult.Text = finalResult;
                userExpression = "";
                calcExpression = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hisoblashda xatolik: " + ex.Message);
            }

            isNewEntry = true;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            userExpression = "";
            calcExpression = "";
            lblHistory.Text = "";
            isNewEntry = true;
        }


        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            else
                txtResult.Text = "0";

            if (userExpression.Length > 0)
                userExpression = userExpression.Substring(0, userExpression.Length - 1);

            if (calcExpression.Length > 0)
                calcExpression = calcExpression.Substring(0, calcExpression.Length - 1);

            lblHistory.Text = userExpression;
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
                userExpression += ".";
                lblHistory.Text = userExpression;
            }
        }


        private void btnLeftPar_Click(object sender, EventArgs e)
        {
            string input = txtResult.Text;
            if (!string.IsNullOrEmpty(input) && input != "0")
            {
                string inputDecimal = ConvertBaseToDecimal(input, currentBase).ToString();
                calcExpression += inputDecimal + "*";
                userExpression += input + "*";
            }
            userExpression += "(";
            calcExpression += "(";
            txtResult.Text = "0";
            isNewEntry = true;
            lastInputWasFunction = false;
            lblHistory.Text = userExpression;
        }


        private void btnRightPar_Click(object sender, EventArgs e)
        {
            string input = txtResult.Text;

            if (pendingFunction != "")
            {
                userExpression += ")";
                calcExpression += ConvertBaseToDecimal(input, currentBase) + ")";
                pendingFunction = "";
                pendingArgument = "";
            }
            else
            {
                if (!string.IsNullOrEmpty(input) && input != "0")
                {
                    string inputDecimal = ConvertBaseToDecimal(input, currentBase).ToString();
                    calcExpression += inputDecimal;
                }
                userExpression += ")";
                calcExpression += ")";
            }
            txtResult.Text = "0";
            isNewEntry = true;
            lastInputWasFunction = true;
            lblHistory.Text = userExpression;
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
            MessageBox.Show("Natija nusxalandi: " + txtResult.Text);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                int key = e.KeyCode - Keys.D0;
                AddInput(key.ToString());
                return;
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                int key = e.KeyCode - Keys.NumPad0;
                AddInput(key.ToString());
                return;
            }
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.F)
            {
                char letter = (char)('A' + (e.KeyCode - Keys.A));
                AddInput(letter.ToString());
                return;
            }

            if (e.KeyCode == Keys.Back) btnBackspace.PerformClick();
            if (e.KeyCode == Keys.Enter) btnEqual.PerformClick();
            if (e.KeyCode == Keys.Escape) btnClear.PerformClick();
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) btnDot.PerformClick();
            if (e.KeyCode == Keys.Add) btnAdd.PerformClick();
            if (e.KeyCode == Keys.Subtract) btnSub.PerformClick();
            if (e.KeyCode == Keys.Multiply) btnMul.PerformClick();
            if (e.KeyCode == Keys.Divide) btnDiv.PerformClick();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBin.Checked) numericBase.Value = 2;
            if (rbtOct.Checked) numericBase.Value = 8;
            if (rbtDec.Checked) numericBase.Value = 10;
            if (rbtHex.Checked) numericBase.Value = 16;
        }

        private void numericBase_ValueChanged(object sender, EventArgs e)
        {
            int oldbase = currentBase;
            currentBase = (int)numericBase.Value;
            userExpression = "";
            calcExpression = "";
            string txt = txtResult.Text;
            if (txt != "" && txt != "0")
            {
                string natija = ConvertBase(txt.ToString(), oldbase, currentBase);
                txtResult.Text = natija;
                userExpression = natija;
                lblHistory.Text = "";
                isNewEntry = false;
            }

            if (currentBase == 2) rbtBin.Checked = true; 
            if (currentBase == 8) rbtOct.Checked = true;
            if (currentBase == 10) rbtDec.Checked = true;
            if (currentBase == 16) rbtHex.Checked = true;

            foreach (Control ctrl in this.Controls)
            {
                Button btn = ctrl as Button;
                if (btn != null && btn.Tag != null)
                {
                    string tag = btn.Tag.ToString();
                    int value;
                    if (int.TryParse(tag, out value)) // Raqamlar
                    {
                        btn.Enabled = value < currentBase;
                    }
                    else if (tag.Length == 1 && char.IsLetter(tag[0])) // Harflar (A-F)
                    {
                        value = 10 + (char.ToUpper(tag[0]) - 'A');
                        btn.Enabled = value < currentBase;
                    }
                }
            }
        }


        public static string ConvertBase(string input, int fromBase, int toBase)
        {
            input = input.ToUpper().Trim();
            string[] parts = input.Split('.');

            // Butun qismini o'qib olish
            long integerPart = ParseFromBase(parts[0], fromBase);
            string resultInt = ConvertIntegerPart(integerPart, toBase);

            // Kasr qismi yo‘q bo‘lsa
            if (parts.Length == 1)
                return resultInt;

            // Kasr qismi
            string frac = parts[1];
            double fractional = 0;

            for (int i = 0; i < frac.Length; i++)
            {
                int digitValue = GetDigitValue(frac[i]);
                if (digitValue >= fromBase)
                    throw new ArgumentException("Noto‘g‘ri raqam kasr qismida");
                fractional += digitValue / Math.Pow(fromBase, i + 1);
            }

            // Kasrni yangi sanoq tizimiga o‘tkazish
            StringBuilder resultFrac = new StringBuilder();
            int maxDigits = 12;

            while (fractional > 0 && resultFrac.Length < maxDigits)
            {
                fractional *= toBase;
                int digit = (int)fractional;
                resultFrac.Append(GetCharFromDigit(digit));
                fractional -= digit;
            }

            return resultFrac.Length > 0 ? resultInt + "." + resultFrac.ToString() : resultInt;
        }


        private static int GetDigitValue(char c)
        {
            if (char.IsDigit(c))
                return c - '0';
            return char.ToUpper(c) - 'A' + 10;
        }

        private static char GetCharFromDigit(int digit)
        {
            return digit < 10 ? (char)(digit + '0') : (char)(digit - 10 + 'A');
        }


        private static long ParseFromBase(string input, int fromBase)
        {
            if (fromBase < 2 || fromBase > 16)
                throw new ArgumentException("Sanoq tizimi 2–16 oralig‘ida bo‘lishi kerak.");

            input = input.ToUpper();
            string chars = "0123456789ABCDEF";

            long result = 0;
            foreach (char c in input)
            {
                int digit = chars.IndexOf(c);
                if (digit < 0 || digit >= fromBase)
                    throw new ArgumentException("Noto‘g‘ri raqam butun qismda");
                result = result * fromBase + digit;
            }
            return result;
        }


        private static string ConvertIntegerPart(long value, int toBase)
        {
            if (toBase < 2 || toBase > 36)
                throw new ArgumentException("Sanoq tizimi 2–36 oralig‘ida bo‘lishi kerak.");

            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder();

            do
            {
                int remainder = (int)(value % toBase);
                result.Insert(0, chars[remainder]);
                value /= toBase;
            } while (value > 0);

            return result.ToString();
        }


        private static double ConvertBaseToDecimal(string input, int fromBase)
        {
            input = input.ToUpper().Trim();
            string[] parts = input.Split('.');
            double result = Convert.ToDouble(ConvertBase(parts[0], fromBase, 10));

            if (parts.Length == 1)
                return result;

            string frac = parts[1];
            for (int i = 0; i < frac.Length; i++)
            {
                int digitValue = char.IsDigit(frac[i]) ? frac[i] - '0' : 10 + (frac[i] - 'A');
                result += digitValue / Math.Pow(fromBase, i + 1);
            }

            return result;
        }


        private void rbtfordagree_CheckedChanged(object sender, EventArgs e)
        {
            isDegreeMode = rbtDegree.Checked;
        }


        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
