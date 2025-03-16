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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


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
            J_textBox.Text = ""; // Значение веса принятой кодовой комбинации
            mistake_textBox.Text = ""; // Кратность ошибки
            m_star_textBox.Text = ""; // Контрольное число
            result_textBox.Text = ""; // Исправленный код
            n_textBox.Text = ""; // Количество символов в информационной последовательности
            R2_textBox.Text = ""; // Проверочная последовательность
            a_star_comboBox.Items.Clear(); // а*
            a_comboBox.Items.Clear(); // a
        }
        private void acceptcode_textBox_TextChanged(object sender, EventArgs e)
        {

           
            J_textBox.Text = ""; // Позиция ошибки
            mistake_textBox.Text = ""; // Количество ошибок
            m_star_textBox.Text = ""; // Контрольное число
            result_textBox.Text = ""; // Исправленный код
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
        private string CalculateRedundantBits(string input)
        {
            // string input = inf_textBox.Text;
            int n = input.Length;

            int R = 0;
            for(int i=0; i < n; i++)
            {
                if (input[i] == '1')
                {
                    R += i;
                }
            }
            /*
            int lowerPower = (int)Math.Pow(2, (int)Math.Log(R, 2));

            // Находим ближайшую степень двойки, которая больше числа
            int higherPower = lowerPower * 2;

            // Вычисляем разницу с ближайшей степенью двойки
            int differenceWithLower = Math.Abs(R - lowerPower);
            int differenceWithHigher = Math.Abs(R - higherPower);

            // Возвращаем минимальную разницу
            int temp = Math.Min(differenceWithLower, differenceWithHigher); */

            R = (R % n + n) % n;

            return Convert.ToString(R, 2);
        }

        // КНОПКА КОДИРОВАТЬ
        private void encode_button_Click(object sender, EventArgs e)
        {
            J_textBox.Text = ""; // Позиция ошибки
            mistake_textBox.Text = ""; // Количество ошибок
            m_star_textBox.Text = ""; // Контрольное число
            result_textBox.Text = ""; // Исправленный код
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
            string R = CalculateRedundantBits(input);

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

            string receivedCode = acceptcode_textBox.Text;
            string R = R_textBox.Text;
            if ((receivedCode.Length < 1 || receivedCode.Length > 26) || (acceptcode_textBox.Text.Length != code_textBox.Text.Length) || !IsBinaryString((receivedCode)))
            {
                MessageBox.Show("Принятая кодовая комбинация не совпадает по длине с кодовой комбинацией или содержит недопустимые символы. ");
                a_star_comboBox.Items.Clear();
                return;
            }

            int m = 0;
            int j = 1;
            for (int i = 0; i < receivedCode.Length - R.Length; i++)
            {
                if (receivedCode[i] == '1')
                {
                    a_star_comboBox.Items.Add($"a*{j} = {i}");
                    m++;
                    j++;
                }
            }
            m_star_textBox.Text = m.ToString();

            string inf_posl_new = receivedCode.Substring(0, inf_textBox.Text.Length);
            string R_new = receivedCode.Substring(inf_textBox.Text.Length, R.Length);//lculateRedundantBits(inf_posl_new);

            R2_textBox.Text = R_new.ToString();

            int old_m = int.Parse(m_textBox.Text);
            UpdateTextBoxes(old_m, m, receivedCode);

        }

        private int CalculateJ(int k, string input, string R)
        {
            int n = input.Length;
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == '1')
                {
                    t += i;
                }
            }

            t = (t % n + n) % n;

            int J = 0;
            if (k == 1)
            {
                J = t - Convert.ToInt32(R, 2);
            }
            else if (k == 2)
            {
                J = Convert.ToInt32(R, 2) - t;
            }
            J = (J % n + n) % n;
            return J;
        }

        // РАСЧЁТ r N и результата
        private void UpdateTextBoxes(int old_m, int m, string code)
        {
            string R = R2_textBox.Text;
            string old_R = R_textBox.Text;
            int raz = 0;
            int raz_ind = 8;

            for (int i = 0; i < old_R.Length; i++)
            {
                if (R[i] != old_R[i])
                {
                    raz++;
                    raz_ind+=i;
                }
            }

            int razlichie = 0;
            int J = 0;
            string code_old = inf_textBox.Text;
            for (int i = 0; i < code_old.Length; i++)
            {
                if (code[i] != code_old[i])
                {
                    J = i;
                    razlichie++;
                }
            }
        
            if (Math.Abs(m - old_m) == 1 || raz == 1)
            {
                mistake_textBox.Text = "1";
                if (raz == 1 && razlichie == 1)
                {
                    mistake_textBox.Text = "2";
                    result_textBox.Text = "Один информационный и один проверочный символы.";
                }
                else if (m - old_m == 1)
                {
                    J_textBox.Text = J.ToString();//CalculateJ(2, code, old_R).ToString();
                    result_textBox.Text = inf_textBox.Text;
                }
                else if (m - old_m == -1)
                {
                    J_textBox.Text = J.ToString();//CalculateJ(1, code, old_R).ToString();
                    result_textBox.Text = inf_textBox.Text;
                }
                else if (raz == 1)
                {
                    J_textBox.Text = raz_ind.ToString();
                    result_textBox.Text = inf_textBox.Text;
                }
            }
            else if(code_textBox.Text == acceptcode_textBox.Text)
            {
                mistake_textBox.Text = "0";
                result_textBox.Text = inf_textBox.Text;
            }
            else if(razlichie == 2 && raz==0)
            {
                mistake_textBox.Text = "2";
                result_textBox.Text = "Симметричная ошибка в информационной части.";
            }
        }

        //ВЫБОР ЭЛЕМЕНТА ИЗ ВЫПАДАЮЩЕГО СПИСКА E1..Em
        private void a_star_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            result_textBox.Clear();

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