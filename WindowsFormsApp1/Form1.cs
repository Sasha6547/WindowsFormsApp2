using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Выполняем сложение 2 + 3
            int result = 2 + 3;

            // Преобразуем результат в строку и выводим в textBox1
            textBox1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым, если он не нужен
        }
    }
}
