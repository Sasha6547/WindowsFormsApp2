using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    // ПОДВИЖНОЕ ОКНО
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
        }


        private bool dragging = false; // Флаг, указывающий, перетаскивается ли окно
        private Point dragCursor; // Точка курсора мыши при нажатии
        private Point dragForm; // Положение окна относительно курсора
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // перетаскивание, если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                dragging = true; 
                dragCursor = Cursor.Position; 
                dragForm = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Если окно перетаскивается, обновление его положение
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursor)); 
                this.Location = Point.Add(dragForm, new Size(dif)); 
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Завершение перетаскивания при отпускании кнопки мыши
            dragging = false; 
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        // ОЧИЩЕНИЕ ПОЛЕЙ
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            textBox2.Text = ""; // Количество информационных символов
            textBox3.Text = ""; // Количество проверочных символов
            textBox4.Text = ""; // Общее число символов
            textBox5.Text = ""; // Кодовая комбинация
            textBox6.Text = ""; // Кодовая комбинация для проверки
            textBox7.Text = ""; // Позиция ошибки
            textBox8.Text = ""; // Количество ошибок
            textBox9.Text = ""; // Контрольное число
            textBox10.Text = ""; // Исправленный код
            comboBox1.Items.Clear(); // E
            comboBox2.Items.Clear(); // a
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

           
            textBox7.Text = ""; // Позиция ошибки
            textBox8.Text = ""; // Количество ошибок
            textBox9.Text = ""; // Контрольное число
            textBox10.Text = ""; // Исправленный код
            comboBox1.Items.Clear(); // E
            
        }

        // КНОПКА ВВОД
        private void button1_Click(object sender, EventArgs e)
        {
           
            string input = textBox1.Text;
          
           
            
           
            if (input.Length < 1 || input.Length > 20 || !IsBinaryString(input))
            {
                MessageBox.Show("Введите двоичную последовательность длиной от 1 до 20 символов (только 0 и 1).");
                return;
            }

           
            int k = input.Length;

           
            int m = CalculateRedundantBits(k);

            
            int n = k + m + 1; 

            
            textBox2.Text = k.ToString(); // Количество информационных символов
            textBox3.Text = m.ToString(); // Количество проверочных символов
            textBox4.Text = n.ToString(); // Общее число символов
        }

        // ЯВЛЯЕТСЯ ЛИ СТРОКА ДВОИЧНОЙ
        private bool IsBinaryString(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        // ВЫЧИСЛЕНИЕ ПРОВЕРОЧНЫХ СИМВОЛОВ М
        private int CalculateRedundantBits(int k)
        {
            int m = 0;
            while (Math.Pow(2, m) < (k + m + 1))
            {
                m++;
            }
            return m;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        // КНОПКА ВЫХОДА
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // КНОПКА ВЫХОДА






        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }


        // КНОПКА КОДИРОВАТЬ
        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Text = ""; // Позиция ошибки
            textBox8.Text = ""; // Количество ошибок
            textBox9.Text = ""; // Контрольное число
            textBox10.Text = ""; // Исправленный код
            comboBox1.Items.Clear(); // E
            if (textBox2.Text == "")
            {
                MessageBox.Show("Сначала введите информационную последовательность");
                return;
            }
            string input = textBox1.Text;

           
            if (input.Length < 1 || input.Length > 20 || !IsBinaryString(input))
            {
                MessageBox.Show("Введите двоичную последовательность длиной до 20 символов (только 0 и 1).");
                return;
            }

           
            int k = input.Length;
           
            int m = CalculateRedundantBits(k);

            int n = k + m;

           
            char[] codeword = new char[n + 1];

           
            int j = 0; 
            for (int i = 1; i <= n; i++)
            {
                if (IsPowerOfTwo(i)) 
                {
                    codeword[i] = '0'; 
                }
                else
                {
                    codeword[i] = input[j]; 
                    j++;
                }
            }

            // ВЫЧИСЛЕНИЕ ЗНАЧЕНИЙ ПРОВЕРОЧНЫХ СИМВОЛОВ
            for (int i = 0; i < m; i++)
            {
                int pos = (int)Math.Pow(2, i); 
                codeword[pos] = CalculateParity(codeword, pos, n); 
            }

            // a0 - сумма всех символов
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (codeword[i] == '1')
                {
                    sum++;
                }
            }
            codeword[0] = (sum % 2 == 0) ? '0' : '1'; 

            // СТРОКА КОДОВОЙ КОМБИНАЦИИ
            string result = new string(codeword, 0, codeword.Length); 

            
            textBox5.Text = result;

            
            comboBox2.Items.Clear();

            // Добавление a0 в ComboBox
            comboBox2.Items.Add($"a0 = {codeword[0]}");

            // Добавление элементы a1, a2 .. am
            for (int i = 0; i < m; i++)
            {
                int pos = (int)Math.Pow(2, i);
                comboBox2.Items.Add($"a{pos} = {codeword[pos]}"); 
            }


            // Выбор первого элемента для поля ввода a0=...
            /*
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
            */
        }




        // ЯВЛЯЕТСЯ ЛИ ЧИСЛО СТЕПЕНЬЮ ДВОЙКИ
        private bool IsPowerOfTwo(int x)
        {
            return (x & (x - 1)) == 0;
        }

        // ВЫЧИСЛЕНИЕ ПРОВЕРОЧНОГО СИМВОЛА
        private char CalculateParity(char[] codeword, int pos, int n)
        {
            int parity = 0;
            for (int i = 1; i <= n; i++)
            {

                if ((i & pos) != 0)
                {
                    parity ^= (codeword[i] == '1') ? 1 : 0; 
                }
            }
            return parity == 1 ? '1' : '0';
        }




        // ПОЛУЧЕНИЕ ЗНАЧЕНИЯ ИЗ ВЫПАДАЮЩЕГО СПИСКА ОТ A0.. AM
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string selectedValue = comboBox2.SelectedItem.ToString();


        }


        // ОБНОВЛЕНИЕ ПРИНЯТОЙ КОДОВОЙ КОМБИНАЦИИ ПРИ ВВЕДЕНИИ КОДОВОЙ КОМБИНАЦИИ ЧТОБЫ ОТОБРАЖАЛОСЬ ТО ЖЕ ЗНАЧЕНИЕ
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            string generatedCode = textBox5.Text;

            
            textBox6.Text = generatedCode;


        }





        /////////////////
        /////////////////////////////////


        // КНОПКА ДЕКАДИРОВАНИЯ
        private void button3_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayChecks();
        }

       

        // ВЫЧИСЛЕНИЕ ЗНАЧЕНИЙ ПРОВЕРОЧНЫЙХ СИМВОЛОВ E0 .. Em
        private void CalculateAndDisplayChecks()
        {

            string receivedCode = textBox6.Text;


            if ((receivedCode.Length < 1 || receivedCode.Length > 26) || (textBox6.Text.Length != textBox5.Text.Length) || !IsBinaryString((receivedCode)))
            {
                MessageBox.Show("Принятая кодовая комбинация не совпадает по длине с кодовой комбинацией или содержит недопустимые символы. ");
                comboBox1.Items.Clear();
                return;
            }
            

            int m = CalculateRedundantBits(receivedCode.Length) - 1;


            int[] checks = new int[m + 1];


            checks[0] = CalculateErrorCheck(receivedCode, 0);


            for (int i = 0; i < m; i++)
            {
                int pos = (int)Math.Pow(2, i);
                checks[i + 1] = CalculateErrorCheck(receivedCode, pos);
            }


            comboBox1.Items.Clear();
            for (int i = 0; i < checks.Length; i++)
            {
                comboBox1.Items.Add($"E{i} = {checks[i]}");
            }


            if (comboBox1.Items.Count > 0)
            {
               // comboBox1.SelectedIndex = 0;
            }
            // КОНТРОЛЬНОЕ ЧИСЛО S   

            string controlNumber = string.Join("", checks.Skip(1).Reverse().Select(c => c.ToString()));
            textBox9.Text = controlNumber;


            UpdateTextBoxes(checks[0], controlNumber);
        }

        // РАСЧЁТ r N и результата
        private void UpdateTextBoxes(int e0, string controlNumber)
        {

            int controlNumberDecimal = Convert.ToInt32(controlNumber, 2);

            // Нет ошибок
            if (controlNumberDecimal == 0 && e0 == 0)
            {
                textBox8.Text = "0";
                textBox7.Text = "";
                textBox10.Text = RemoveBits(textBox6.Text);
            }
            // Однократная ошибка
            else if (controlNumberDecimal != 0 && e0 == 1)
            {
                textBox8.Text = "1";
                textBox7.Text = controlNumberDecimal.ToString();
                textBox10.Text = "";


                string correctedCode = CorrectError(textBox6.Text, controlNumberDecimal); // Исправляет ошибку
                textBox10.Text = RemoveBits(correctedCode); // Убирает контрольные биты
            }

            // Двукратная ошибка
            else if (controlNumberDecimal != 0 && e0 == 0)
            {
                textBox8.Text = "2";
                textBox10.Text = "Повторная передача";
                textBox7.Text = "";
            }

            // Трехкратная ошибка  ????????????????
            else if (controlNumberDecimal == 0 && e0 == 1)
            {
                textBox8.Text = "3 и более";
                textBox7.Text = "";
                textBox10.Text = "";


                textBox10.Text = "Трёхкратная ошибка";
            }
        }

        // Метод для исправления однократной ошибки
        private string CorrectError(string receivedCode, int errorPosition)
        {

            int index = errorPosition;

            char[] codeArray = receivedCode.ToCharArray();

            // Инверсия бита
            codeArray[index] = (codeArray[index] == '0') ? '1' : '0';


            return new string(codeArray);
        }

        // Метод для удаления контрольных битов
        private string RemoveBits(string correctedCode)
        {
            // Список для хранения битов
            List<char> infoBits = new List<char>();

            // Добавить в список только информационные
            for (int i = 1; i < correctedCode.Length; i++)
            {
                if (!IsPowerOfTwo2(i)) // Если позиция не является степенью двойки
                {
                    infoBits.Add(correctedCode[i]);
                }
            }


            return new string(infoBits.ToArray());
        }

        // Проверка степени двойки
        private bool IsPowerOfTwo2(int x)
        {
            return (x > 0) && ((x & (x - 1)) == 0);
        }




        // ВЫЧИСЛЕНИЕ ЗНАЧЕНИЯ ПРОВЕРОЧНОГО СИМВОЛА E0...Em
        private int CalculateErrorCheck(string code, int pos)
        {
            int parity = 0;


            if (pos == 0)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    parity ^= (code[i] == '1') ? 1 : 0;
                }
            }
            else
            {
                for (int i = 1; i < code.Length; i++)
                {

                    if ((i & pos) != 0)
                    {
                        parity ^= (code[i] == '1') ? 1 : 0;
                    }
                }
            }
            return parity;
        }

        //ВЫБОР ЭЛЕМЕНТА ИЗ ВЫПАДАЮЩЕГО СПИСКА E1..Em
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Clear();

            if (comboBox1.SelectedItem != null)
            {
                string selectedValue = comboBox1.SelectedItem.ToString();

            }
        }





        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}