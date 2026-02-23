
namespace _25_2_Kozii_Lab1AtP_TOPCALC_
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            textBox1 = new TextBox();
            lblOperat = new Label();
            btnTheme = new Button();
            btnToBinary = new Button();
            btnToOct = new Button();
            btnToHex = new Button();
            btnPow = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(70, 323);
            btn1.Name = "btn1";
            btn1.Size = new Size(47, 48);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Digit_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(116, 323);
            btn2.Name = "btn2";
            btn2.Size = new Size(47, 48);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Digit_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(160, 323);
            btn3.Name = "btn3";
            btn3.Size = new Size(47, 48);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Digit_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(70, 276);
            btn4.Name = "btn4";
            btn4.Size = new Size(47, 48);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Digit_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(116, 276);
            btn5.Name = "btn5";
            btn5.Size = new Size(47, 48);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Digit_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(160, 276);
            btn6.Name = "btn6";
            btn6.Size = new Size(47, 48);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Digit_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(70, 230);
            btn7.Name = "btn7";
            btn7.Size = new Size(47, 48);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Digit_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(116, 230);
            btn8.Name = "btn8";
            btn8.Size = new Size(47, 48);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Digit_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(160, 230);
            btn9.Name = "btn9";
            btn9.Size = new Size(47, 48);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Digit_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(116, 367);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(47, 48);
            btnZero.TabIndex = 9;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += Digit_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(160, 367);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(47, 48);
            btnDot.TabIndex = 10;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Dot_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(70, 367);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 48);
            btnClear.TabIndex = 11;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += Clear_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(203, 230);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(47, 48);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += Operation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(203, 276);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(47, 48);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Operation_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(203, 323);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(47, 48);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += Operation_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(203, 367);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(47, 48);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Operation_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(116, 184);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(134, 48);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += Equals_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(70, 156);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(180, 32);
            textBox1.TabIndex = 18;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // lblOperat
            // 
            lblOperat.AutoSize = true;
            lblOperat.Font = new Font("Segoe UI", 18F);
            lblOperat.Location = new Point(70, 113);
            lblOperat.Name = "lblOperat";
            lblOperat.Size = new Size(165, 32);
            lblOperat.TabIndex = 19;
            lblOperat.Text = "Знак операції";
            // 
            // btnTheme
            // 
            btnTheme.Location = new Point(39, 16);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(94, 23);
            btnTheme.TabIndex = 20;
            btnTheme.Text = "Switch Theme";
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
            // 
            // btnToBinary
            // 
            btnToBinary.Location = new Point(60, 73);
            btnToBinary.Name = "btnToBinary";
            btnToBinary.Size = new Size(75, 23);
            btnToBinary.TabIndex = 21;
            btnToBinary.Text = "Двійкова";
            btnToBinary.UseVisualStyleBackColor = true;
            btnToBinary.Click += btnToBinary_Click;
            // 
            // btnToOct
            // 
            btnToOct.Location = new Point(126, 73);
            btnToOct.Name = "btnToOct";
            btnToOct.Size = new Size(75, 23);
            btnToOct.TabIndex = 22;
            btnToOct.Text = "Вісімкова";
            btnToOct.UseVisualStyleBackColor = true;
            btnToOct.Click += btnToOct_Click;
            // 
            // btnToHex
            // 
            btnToHex.Location = new Point(194, 73);
            btnToHex.Name = "btnToHex";
            btnToHex.Size = new Size(75, 23);
            btnToHex.TabIndex = 23;
            btnToHex.Text = "Шістнадцяткова";
            btnToHex.UseVisualStyleBackColor = true;
            btnToHex.Click += btnToHex_Click;
            // 
            // btnPow
            // 
            btnPow.Location = new Point(70, 184);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(47, 48);
            btnPow.TabIndex = 24;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += Operation_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 480);
            Controls.Add(textBox1);
            Controls.Add(btnPow);
            Controls.Add(btnToHex);
            Controls.Add(btnToOct);
            Controls.Add(btnToBinary);
            Controls.Add(btnTheme);
            Controls.Add(lblOperat);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Calculator";
            Text = "Calculator 1.0";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Можна ініціалізувати тему за замовчуванням
            SetTheme(false); // світла тема
        }

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnZero;
        private Button btnDot;
        private Button btnClear;
        private Button btnDiv;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEquals;
        private TextBox textBox1;
        private Label lblOperat;
        private Button btnTheme;
        private Button btnToBinary;
        private Button btnToOct;
        private Button btnToHex;
        private Button btnPow;
        private System.Windows.Forms.Timer hideTimer;
    }
}
#endregion