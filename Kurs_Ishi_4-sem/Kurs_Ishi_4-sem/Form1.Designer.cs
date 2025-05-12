namespace Kurs_Ishi_4_sem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.rbtBin = new System.Windows.Forms.RadioButton();
            this.rbtOct = new System.Windows.Forms.RadioButton();
            this.rbtDec = new System.Windows.Forms.RadioButton();
            this.rbtHex = new System.Windows.Forms.RadioButton();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.grpScientific = new System.Windows.Forms.GroupBox();
            this.btnRightPar = new System.Windows.Forms.Button();
            this.rbtDegree = new System.Windows.Forms.RadioButton();
            this.btnLeftPar = new System.Windows.Forms.Button();
            this.rbtRadian = new System.Windows.Forms.RadioButton();
            this.btnEyler = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLg = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.numericBase = new System.Windows.Forms.NumericUpDown();
            this.btnHistory = new System.Windows.Forms.Button();
            this.grpScientific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(10, 30);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(236, 40);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(10, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(145, 80);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(100, 35);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<-";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // rbtBin
            // 
            this.rbtBin.AutoSize = true;
            this.rbtBin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtBin.Location = new System.Drawing.Point(10, 125);
            this.rbtBin.Name = "rbtBin";
            this.rbtBin.Size = new System.Drawing.Size(51, 24);
            this.rbtBin.TabIndex = 0;
            this.rbtBin.Text = "Bin";
            this.rbtBin.UseVisualStyleBackColor = true;
            this.rbtBin.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtOct
            // 
            this.rbtOct.AutoSize = true;
            this.rbtOct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtOct.Location = new System.Drawing.Point(70, 125);
            this.rbtOct.Name = "rbtOct";
            this.rbtOct.Size = new System.Drawing.Size(53, 24);
            this.rbtOct.TabIndex = 1;
            this.rbtOct.Text = "Oct";
            this.rbtOct.UseVisualStyleBackColor = true;
            this.rbtOct.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtDec
            // 
            this.rbtDec.AutoSize = true;
            this.rbtDec.Checked = true;
            this.rbtDec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtDec.Location = new System.Drawing.Point(130, 125);
            this.rbtDec.Name = "rbtDec";
            this.rbtDec.Size = new System.Drawing.Size(56, 24);
            this.rbtDec.TabIndex = 2;
            this.rbtDec.TabStop = true;
            this.rbtDec.Text = "Dec";
            this.rbtDec.UseVisualStyleBackColor = true;
            this.rbtDec.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtHex
            // 
            this.rbtHex.AutoSize = true;
            this.rbtHex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtHex.Location = new System.Drawing.Point(190, 125);
            this.rbtHex.Name = "rbtHex";
            this.rbtHex.Size = new System.Drawing.Size(56, 24);
            this.rbtHex.TabIndex = 3;
            this.rbtHex.Text = "Hex";
            this.rbtHex.UseVisualStyleBackColor = true;
            this.rbtHex.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(10, 190);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 4;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(60, 190);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 5;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(110, 190);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 6;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(180, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSub.Location = new System.Drawing.Point(180, 240);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(45, 45);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(110, 240);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 10;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(60, 240);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 9;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(10, 240);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 8;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMul.Location = new System.Drawing.Point(180, 290);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(45, 45);
            this.btnMul.TabIndex = 15;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(110, 290);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 14;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(60, 290);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 13;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(10, 290);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 12;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiv.Location = new System.Drawing.Point(180, 340);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 45);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDot.Location = new System.Drawing.Point(110, 340);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(45, 45);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(10, 340);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(95, 45);
            this.btn0.TabIndex = 17;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEqual.Location = new System.Drawing.Point(180, 390);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(45, 45);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(110, 390);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 45);
            this.btnC.TabIndex = 22;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnB.Location = new System.Drawing.Point(60, 390);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(45, 45);
            this.btnB.TabIndex = 21;
            this.btnB.Tag = "B";
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnA.Location = new System.Drawing.Point(10, 390);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(45, 45);
            this.btnA.TabIndex = 20;
            this.btnA.Tag = "A";
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnF
            // 
            this.btnF.Enabled = false;
            this.btnF.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF.Location = new System.Drawing.Point(110, 440);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(45, 45);
            this.btnF.TabIndex = 26;
            this.btnF.Tag = "F";
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(60, 440);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(45, 45);
            this.btnE.TabIndex = 25;
            this.btnE.Tag = "E";
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnD.Location = new System.Drawing.Point(10, 440);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(45, 45);
            this.btnD.TabIndex = 24;
            this.btnD.Tag = "D";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.Number_Click);
            // 
            // grpScientific
            // 
            this.grpScientific.Controls.Add(this.btnRightPar);
            this.grpScientific.Controls.Add(this.rbtDegree);
            this.grpScientific.Controls.Add(this.btnLeftPar);
            this.grpScientific.Controls.Add(this.rbtRadian);
            this.grpScientific.Controls.Add(this.btnEyler);
            this.grpScientific.Controls.Add(this.btnCtg);
            this.grpScientific.Controls.Add(this.btnTg);
            this.grpScientific.Controls.Add(this.btnPi);
            this.grpScientific.Controls.Add(this.btnCos);
            this.grpScientific.Controls.Add(this.btnSin);
            this.grpScientific.Controls.Add(this.btnLg);
            this.grpScientific.Controls.Add(this.btnLn);
            this.grpScientific.Controls.Add(this.btnLog);
            this.grpScientific.Controls.Add(this.btnPow);
            this.grpScientific.Controls.Add(this.btnSqrt);
            this.grpScientific.Controls.Add(this.btnAbs);
            this.grpScientific.Location = new System.Drawing.Point(250, 80);
            this.grpScientific.Name = "grpScientific";
            this.grpScientific.Size = new System.Drawing.Size(200, 375);
            this.grpScientific.TabIndex = 27;
            this.grpScientific.TabStop = false;
            this.grpScientific.Text = "Scientific";
            // 
            // btnRightPar
            // 
            this.btnRightPar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightPar.Location = new System.Drawing.Point(104, 311);
            this.btnRightPar.Name = "btnRightPar";
            this.btnRightPar.Size = new System.Drawing.Size(75, 40);
            this.btnRightPar.TabIndex = 31;
            this.btnRightPar.Text = ")";
            this.btnRightPar.UseVisualStyleBackColor = true;
            this.btnRightPar.Click += new System.EventHandler(this.btnRightPar_Click);
            // 
            // rbtDegree
            // 
            this.rbtDegree.AutoSize = true;
            this.rbtDegree.Checked = true;
            this.rbtDegree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtDegree.Location = new System.Drawing.Point(104, 44);
            this.rbtDegree.Name = "rbtDegree";
            this.rbtDegree.Size = new System.Drawing.Size(79, 24);
            this.rbtDegree.TabIndex = 30;
            this.rbtDegree.TabStop = true;
            this.rbtDegree.Text = "Degree";
            this.rbtDegree.UseVisualStyleBackColor = true;
            this.rbtDegree.CheckedChanged += new System.EventHandler(this.rbtfordagree_CheckedChanged);
            // 
            // btnLeftPar
            // 
            this.btnLeftPar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeftPar.Location = new System.Drawing.Point(10, 311);
            this.btnLeftPar.Name = "btnLeftPar";
            this.btnLeftPar.Size = new System.Drawing.Size(75, 40);
            this.btnLeftPar.TabIndex = 30;
            this.btnLeftPar.Text = "(";
            this.btnLeftPar.UseVisualStyleBackColor = true;
            this.btnLeftPar.Click += new System.EventHandler(this.btnLeftPar_Click);
            // 
            // rbtRadian
            // 
            this.rbtRadian.AutoSize = true;
            this.rbtRadian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtRadian.Location = new System.Drawing.Point(10, 44);
            this.rbtRadian.Name = "rbtRadian";
            this.rbtRadian.Size = new System.Drawing.Size(76, 24);
            this.rbtRadian.TabIndex = 29;
            this.rbtRadian.Text = "Radian";
            this.rbtRadian.UseVisualStyleBackColor = true;
            this.rbtRadian.CheckedChanged += new System.EventHandler(this.rbtfordagree_CheckedChanged);
            // 
            // btnEyler
            // 
            this.btnEyler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEyler.Location = new System.Drawing.Point(130, 260);
            this.btnEyler.Name = "btnEyler";
            this.btnEyler.Size = new System.Drawing.Size(50, 45);
            this.btnEyler.TabIndex = 18;
            this.btnEyler.TabStop = false;
            this.btnEyler.Text = "e";
            this.btnEyler.UseVisualStyleBackColor = true;
            this.btnEyler.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnCtg
            // 
            this.btnCtg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCtg.Location = new System.Drawing.Point(70, 260);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(50, 45);
            this.btnCtg.TabIndex = 17;
            this.btnCtg.TabStop = false;
            this.btnCtg.Text = "ctg";
            this.btnCtg.UseVisualStyleBackColor = true;
            this.btnCtg.Click += new System.EventHandler(this.btnCtg_Click);
            // 
            // btnTg
            // 
            this.btnTg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTg.Location = new System.Drawing.Point(10, 260);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(50, 45);
            this.btnTg.TabIndex = 16;
            this.btnTg.TabStop = false;
            this.btnTg.Text = "tg";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPi.Location = new System.Drawing.Point(130, 200);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(50, 45);
            this.btnPi.TabIndex = 15;
            this.btnPi.TabStop = false;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCos.Location = new System.Drawing.Point(70, 200);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(50, 45);
            this.btnCos.TabIndex = 14;
            this.btnCos.TabStop = false;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSin.Location = new System.Drawing.Point(10, 200);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(50, 45);
            this.btnSin.TabIndex = 13;
            this.btnSin.TabStop = false;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnLg
            // 
            this.btnLg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLg.Location = new System.Drawing.Point(130, 140);
            this.btnLg.Name = "btnLg";
            this.btnLg.Size = new System.Drawing.Size(50, 45);
            this.btnLg.TabIndex = 12;
            this.btnLg.TabStop = false;
            this.btnLg.Text = "lg";
            this.btnLg.UseVisualStyleBackColor = true;
            this.btnLg.Click += new System.EventHandler(this.btnLg_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLn.Location = new System.Drawing.Point(70, 140);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(50, 45);
            this.btnLn.TabIndex = 11;
            this.btnLn.TabStop = false;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(10, 140);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 45);
            this.btnLog.TabIndex = 10;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPow.Location = new System.Drawing.Point(130, 80);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(50, 45);
            this.btnPow.TabIndex = 9;
            this.btnPow.TabStop = false;
            this.btnPow.Text = "xʸ";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqrt.Location = new System.Drawing.Point(70, 80);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(50, 45);
            this.btnSqrt.TabIndex = 8;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbs.Location = new System.Drawing.Point(10, 80);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(50, 45);
            this.btnAbs.TabIndex = 7;
            this.btnAbs.TabStop = false;
            this.btnAbs.Text = "|x|";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHistory.ForeColor = System.Drawing.Color.Gray;
            this.lblHistory.Location = new System.Drawing.Point(10, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(236, 20);
            this.lblHistory.TabIndex = 28;
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopy.BackgroundImage")));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(265, 30);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(40, 40);
            this.btnCopy.TabIndex = 29;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // numericBase
            // 
            this.numericBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBase.Location = new System.Drawing.Point(10, 150);
            this.numericBase.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericBase.Name = "numericBase";
            this.numericBase.Size = new System.Drawing.Size(100, 34);
            this.numericBase.TabIndex = 30;
            this.numericBase.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericBase.ValueChanged += new System.EventHandler(this.numericBase_ValueChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.Location = new System.Drawing.Point(320, 30);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(130, 40);
            this.btnHistory.TabIndex = 31;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 503);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.numericBase);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.grpScientific);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.rbtHex);
            this.Controls.Add(this.rbtDec);
            this.Controls.Add(this.rbtOct);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.rbtBin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.grpScientific.ResumeLayout(false);
            this.grpScientific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.RadioButton rbtHex;
        private System.Windows.Forms.RadioButton rbtDec;
        private System.Windows.Forms.RadioButton rbtOct;
        private System.Windows.Forms.RadioButton rbtBin;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.GroupBox grpScientific;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLg;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnEyler;
        private System.Windows.Forms.Button btnCtg;
        private System.Windows.Forms.Button btnTg;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.RadioButton rbtDegree;
        private System.Windows.Forms.RadioButton rbtRadian;
        private System.Windows.Forms.Button btnRightPar;
        private System.Windows.Forms.Button btnLeftPar;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.NumericUpDown numericBase;
        private System.Windows.Forms.Button btnHistory;
    }
}

