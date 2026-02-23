namespace _25_2_Kozii_Lab1AtP_TOPCALC_
{
    public partial class Calculator : Form
    {
        double firstNumber = 0;  // Перше число для операції
        string operation = ""; // Поточна операція (+, -, *, /, ^)
        bool isNewNumber = true; // Ознака початку введення нового числа
        private bool isDark = false; // Поточна тема (false — світла, true — темна)


        public Calculator()
        {
            InitializeComponent(); // Ініціалізація всіх елементів форми, створених у Designer

            // === Налаштування таймера приховування кнопок ===
            hideTimer = new System.Windows.Forms.Timer();
            hideTimer.Interval = 500; // Затримка 0.5 секунди
            hideTimer.Tick += HideTimer_Tick; // Обробник події спрацювання таймера

            // === Початковий стан кнопок конвертації ===
            //(Кнопки BIN / HEX / OCT приховані до наведення миші)
            btnToBinary.Visible = false;
            btnToHex.Visible = false;
            btnToOct.Visible = false;

            // === Події для поля введення ===
            textBox1.MouseEnter += ShowConversionButtons; // При наведенні миші показуємо кнопки
            textBox1.MouseLeave += StartHideTimer; // При відведенні миші запускаємо таймер приховування

            // === Події для кнопок конвертації (Поки курсор над кнопками — таймер не працює) ===
            btnToBinary.MouseEnter += (s, e) => hideTimer.Stop();
            btnToHex.MouseEnter += (s, e) => hideTimer.Stop();
            btnToOct.MouseEnter += (s, e) => hideTimer.Stop();

            // При відведенні курсора з кнопок запускається таймер
            btnToBinary.MouseLeave += StartHideTimer;
            btnToHex.MouseLeave += StartHideTimer;
            btnToOct.MouseLeave += StartHideTimer;
        } // КОНСТРУКТОР ФОРМИ

//      ************************************************************************************
//      АРИФМЕТИЧНІ ДІЇ КАЛЬКУЛЯТОРА
        private void Digit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Кнопка, яку натиснули

            if (isNewNumber)
            {
                // Початок нового числа
                textBox1.Text = btn.Text;
                isNewNumber = false;
            }
            else
            {
                // Додавання цифри до поточного числа
                textBox1.Text += btn.Text;
            }
        } // ОБРОБКА ЧИСЕЛ

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!string.IsNullOrEmpty(textBox1.Text)) // Захист від пустого поля
            {
                firstNumber = GetValue(); // Зберігаємо перше число
                operation = btn.Text;  // Запам’ятовуємо операцію
                isNewNumber = true;
                lblOperat.Text = operation; // Відображаємо знак операції
            }
        } // ОБРОБКА АРИФМЕТИЧНИХ ДІЙ

        private void Equals_Click(object sender, EventArgs e)
        {
            double secondNumber = GetValue(); // Друге число
            double result = 0;

            switch (operation)
            {
                // Виконання відповідної операції
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/": result = firstNumber / secondNumber; break;
                case "^": result = Math.Pow(firstNumber, secondNumber); break;
            }

            textBox1.Text = result.ToString();
            lblOperat.Text = "";
            isNewNumber = true;              
        } // ОБРОБКА ДОРІВНЮЄ

        private void Dot_Click(object sender, EventArgs e)
        {
            if (isNewNumber) // Додає десяткову крапку
            {
                textBox1.Text = "0.";
                isNewNumber = false;
            }
            else if (!textBox1.Text.Contains(".") && !textBox1.Text.Contains(','))
            {
                textBox1.Text += ".";
            }
        } // ОБРОБКА ТОЧКИ (ДЛЯ ДЕСЯТКОВИХ ДРОБІВ)

        private void Clear_Click(object sender, EventArgs e)
        {
            // Повне очищення калькулятора
            textBox1.Clear();
            lblOperat.Text = "";
            firstNumber = 0;
            operation = "";
            isNewNumber = true;
        } // ОБРОБКА ОЧИЩЕННЯ

//      ****************************************************************************************


//      ****************************************************************************************
//      ЗМІНА ТЕМИ
        private void SetTheme(bool dark)
        {
            // Вибір кольорів залежно від теми (тернарний оператор)
            Color backForm = dark ? Color.FromArgb(30, 30, 30) : Color.White;
            Color backButton = dark ? Color.FromArgb(58, 58, 58) : Color.LightGray;
            Color foreButton = dark ? Color.White : Color.Black;
            Color foreLabel = dark ? Color.White : Color.Black;

            // Фон форми
            this.BackColor = backForm;

            // Label
            lblOperat.ForeColor = foreLabel;

            // TextBox
            textBox1.BackColor = dark ? Color.FromArgb(45, 45, 48) : Color.White;
            textBox1.ForeColor = foreLabel;

            // Кнопки
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = backButton;
                    btn.ForeColor = foreButton;
                }
            }
        } // НАЛАШТУВАННЯ КОЛЬОРІВ ЧЕРЕЗ TRUE/FALSE

        private void btnTheme_Click(object sender, EventArgs e)
        {
            isDark = !isDark;      // Перемикач
            SetTheme(isDark);
        } // КНОПКА-ПЕРЕМИКАЧ

//      *****************************************************************************************



//      *****************************************************************************************
//      КОНВЕРТАЦІЯ В ІНШІ ЧИСЛОВІ СИСТЕМИ
        private void ShowConversionButtons(object sender, EventArgs e)
        {
            btnToBinary.Visible = true;
            btnToHex.Visible = true;
            btnToOct.Visible = true;
            hideTimer.Stop();
        } // ПОКАЗ КНОПОК КОНВЕРТАЦІЇ

        private void StartHideTimer(object sender, EventArgs e) 
        {
            hideTimer.Start(); // Запускає таймер перед приховуванням кнопок
        } // ПРИХОВУВАННЯ КНОПОК КОНВЕРТАЦІЇ ЧЕРЕЗ ТАЙМЕР (ІНІЦІАЛІЗАЦІЯ)

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            // Приховує кнопки конвертації після затримки
            hideTimer.Stop(); // таймер одноразовий
            btnToBinary.Visible = false;
            btnToHex.Visible = false;
            btnToOct.Visible = false;
        } // ПРИХОВУВАННЯ КНОПОК КОНВЕРТАЦІЇ ЧЕРЕЗ ТАЙМЕР

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

            btnToBinary.Visible = true;
            btnToHex.Visible = true;
            btnToOct.Visible = true;
            hideTimer.Stop(); // Кнопки не зникають, поки миша над textbox
        }// ПОКАЗ КНОПОК КОНВЕРТАЦІЇ ПРИ НАВЕДЕННІ НА ПОЛЕ ВВЕДЕННЯ

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start(); // почати відлік 0.5 сек
        } // ЗАПУСК ТАЙМЕРА ДЛЯ ПРИХОВУВАННЯ КНОПОК

        private void btnToBinary_Click(object sender, EventArgs e)
        {
            int number = (int)GetValue(); // GetValue() твоїй функції для textbox
            textBox1.Text = Convert.ToString(number, 2);
            isNewNumber = true;
        } // КОНВЕРТАЦІЯ В БІНАРНУ СИСТЕМУ

        private void btnToOct_Click(object sender, EventArgs e)
        {
            int number = (int)GetValue();
            textBox1.Text = Convert.ToString(number, 8);
            isNewNumber = true;
        } // КОНВЕРТАЦІЯ В ВІСІМКОВУ СИСТЕМУ

        private void btnToHex_Click(object sender, EventArgs e)
        {
            int number = (int)GetValue();
            textBox1.Text = Convert.ToString(number, 16).ToUpper();
            isNewNumber = true;
        } // КОНВЕРТАЦІЯ В ШІСТНАДЦЯТКОВУ СИСТЕМУ


        //      *********************************************************************************************
        private double GetValue()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return 0; // Якщо поле порожнє або містить пробіли — повертаємо 0

            return double.Parse(textBox1.Text); // Перетворюємо текст у число
        } // ОТРИМАННЯ ЧИСЛА З ПОЛЯ ВВЕДЕННЯ (ПЕРЕВІРКА НА ПОМИЛКИ)

    }
}
