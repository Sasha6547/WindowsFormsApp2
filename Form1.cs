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

        // ОЧИЩЕНИЕ ПОЛЕЙ
        private void inf_textBox_TextChanged(object sender, EventArgs e)
        {
          
            m_textBox.Text = ""; // Количество единиц(вес кода)
            l_textBox.Text = ""; // Число проверочных символов
            R_textBox.Text = ""; // Значение проверочных символов
            code_textBox.Text = ""; // Кодовая комбинация
            acceptcode_textBox.Text = ""; // Кодовая комбинация для проверки
            textBox7.Text = ""; // Значение веса принятой кодовой комбинации
            textBox.Text = ""; // Кратность ошибки
            m_star_textBox.Text = ""; // Контрольное число
            textBox10.Text = ""; // Исправленный код
            n_textBox.Text = ""; // Количество символов в информационной последовательности
            R2_textBox.Text = ""; // Проверочная последовательность
            a_star_comboBox.Items.Clear(); // а*
            a_comboBox.Items.Clear(); // a
        }
        private void acceptcode_textBox_TextChanged(object sender, EventArgs e)
        {

           
            textBox7.Text = ""; // Позиция ошибки
            textBox.Text = ""; // Количество ошибок
            m_star_textBox.Text = ""; // Контрольное число
            textBox10.Text = ""; // Исправленный код
            R2_textBox.Text = "";
            a_star_comboBox.Items.Clear(); // а*
            
        }

        // КНОПКА ВВОД
        private void enter_button_Click(object sender, EventArgs e)
        {
           
            string input = inf_textBox.Text;
           
            if (input.Length < 1 || input.Length > 10 || !IsBinaryString(input))
            {
                MessageBox.Show("Введите двоичную последовательность длиной от 1 до 10 символов (только 0 и 1).");
                return;
            }

            int n = input.Length;
            int m = input.Count(c => c == '1');
            double l = Math.Log(n) / Math.Log(2);
            
            m_textBox.Text = m.ToString(); // Количество единиц в последовательности
            l_textBox.Text = l.ToString(); // Количество проверочных символов
            n_textBox.Text = n.ToString(); // Общее число символов
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
        private string CalculateRedundantBits()
        {
            string input = inf_textBox.Text;
            int n = input.Length;

            int R = 0;
            for(int i=0; i < n; i++)
            {
                if (input[i] == '1')
                {
                    R += i;
                }
            }

            int lowerPower = (int)Math.Pow(2, (int)Math.Log(R, 2));

            // Находим ближайшую степень двойки, которая больше числа
            int higherPower = lowerPower * 2;

            // Вычисляем разницу с ближайшей степенью двойки
            int differenceWithLower = Math.Abs(R - lowerPower);
            int differenceWithHigher = Math.Abs(R - higherPower);

            // Возвращаем минимальную разницу
            int temp = Math.Min(differenceWithLower, differenceWithHigher);

            R = (R % n + n) % n;

            return Convert.ToString(R, 2);
        }

        // КНОПКА КОДИРОВАТЬ
        private void encode_button_Click(object sender, EventArgs e)
        {
            textBox7.Text = ""; // Позиция ошибки
            textBox.Text = ""; // Количество ошибок
            m_star_textBox.Text = ""; // Контрольное число
            textBox10.Text = ""; // Исправленный код
            R2_textBox.Text = "";
            a_star_comboBox.Items.Clear(); // a*
            if (m_textBox.Text == "")
            {
                MessageBox.Show("Сначала введите информационную последовательность");
                return;
            }
            string input = inf_textBox.Text;

            if (input.Length < 1 || input.Length > 10 || !IsBinaryString(input))
            {
                MessageBox.Show("Введите двоичную последовательность длиной до 20 символов (только 0 и 1).");
                return;
            }

            int n = input.Length;
            int m = input.Count(c => c == '1');
            double l = Math.Log(n) / Math.Log(2);
            string R = CalculateRedundantBits();

            // СТРОКА КОДОВОЙ КОМБИНАЦИИ
            string result = input + R; 
            code_textBox.Text = result;
            a_comboBox.Items.Clear();
            int j = 1;

            // Добавление элементы a1, a2 .. am
            for (int i = 0; i < n; i++)
            {
                if (input[i] == '1')
                {
                    a_comboBox.Items.Add($"a{j} = {i}");
                    j++;
                }                
            }

            R_textBox.Text = R;
        }

        // ПОЛУЧЕНИЕ ЗНАЧЕНИЯ ИЗ ВЫПАДАЮЩЕГО СПИСКА ОТ A0.. AM
        private void a_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = a_comboBox.SelectedItem.ToString();
        }

        // ОБНОВЛЕНИЕ ПРИНЯТОЙ КОДОВОЙ КОМБИНАЦИИ ПРИ ВВЕДЕНИИ КОДОВОЙ КОМБИНАЦИИ ЧТОБЫ ОТОБРАЖАЛОСЬ ТО ЖЕ ЗНАЧЕНИЕ
        private void code_textBox_TextChanged(object sender, EventArgs e)
        {

            string generatedCode = code_textBox.Text;


            acceptcode_textBox.Text = generatedCode;


        }

        // КНОПКА ДЕКОДИРОВАНИЯ
        private void decode_button_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayChecks();
        }

        // ВЫЧИСЛЕНИЕ ЗНАЧЕНИЙ ПРОВЕРОЧНЫЙХ СИМВОЛОВ E0 .. Em
        private void CalculateAndDisplayChecks()
        {
            /*
            string receivedCode = textBox6.Text;


            if ((receivedCode.Length < 1 || receivedCode.Length > 26) || (textBox6.Text.Length != textBox5.Text.Length) || !IsBinaryString((receivedCode)))
            {
                MessageBox.Show("Принятая кодовая комбинация не совпадает по длине с кодовой комбинацией или содержит недопустимые символы. ");
                comboBox1.Items.Clear();
                return;
            }
            

            int m = CalculateRedundantBits() - 1;


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


            UpdateTextBoxes(checks[0], controlNumber); */
        }

        //ВЫБОР ЭЛЕМЕНТА ИЗ ВЫПАДАЮЩЕГО СПИСКА E1..Em
        private void a_star_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Clear();

            if (a_star_comboBox.SelectedItem != null)
            {
                string selectedValue = a_star_comboBox.SelectedItem.ToString();
            }
        }

        // КНОПКА ВЫХОДА
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}