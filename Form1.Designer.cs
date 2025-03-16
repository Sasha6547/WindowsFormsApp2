
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.a_star_comboBox = new System.Windows.Forms.ComboBox();
            this.a_comboBox = new System.Windows.Forms.ComboBox();
            this.inf_textBox = new System.Windows.Forms.TextBox();
            this.m_textBox = new System.Windows.Forms.TextBox();
            this.l_textBox = new System.Windows.Forms.TextBox();
            this.R_textBox = new System.Windows.Forms.TextBox();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.acceptcode_textBox = new System.Windows.Forms.TextBox();
            this.J_textBox = new System.Windows.Forms.TextBox();
            this.mistake_textBox = new System.Windows.Forms.TextBox();
            this.m_star_textBox = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.encode_button = new System.Windows.Forms.Button();
            this.decode_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.R2_textBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a_star_comboBox
            // 
            this.a_star_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_star_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_star_comboBox.FormattingEnabled = true;
            this.a_star_comboBox.Location = new System.Drawing.Point(558, 343);
            this.a_star_comboBox.Name = "a_star_comboBox";
            this.a_star_comboBox.Size = new System.Drawing.Size(148, 27);
            this.a_star_comboBox.TabIndex = 0;
            this.a_star_comboBox.SelectedIndexChanged += new System.EventHandler(this.a_star_comboBox_SelectedIndexChanged);
            // 
            // a_comboBox
            // 
            this.a_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.a_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_comboBox.FormattingEnabled = true;
            this.a_comboBox.Location = new System.Drawing.Point(553, 217);
            this.a_comboBox.Name = "a_comboBox";
            this.a_comboBox.Size = new System.Drawing.Size(153, 27);
            this.a_comboBox.TabIndex = 1;
            this.a_comboBox.SelectedIndexChanged += new System.EventHandler(this.a_comboBox_SelectedIndexChanged);
            // 
            // inf_textBox
            // 
            this.inf_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inf_textBox.Location = new System.Drawing.Point(72, 99);
            this.inf_textBox.Name = "inf_textBox";
            this.inf_textBox.Size = new System.Drawing.Size(400, 26);
            this.inf_textBox.TabIndex = 2;
            this.inf_textBox.TextChanged += new System.EventHandler(this.inf_textBox_TextChanged);
            // 
            // m_textBox
            // 
            this.m_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_textBox.Location = new System.Drawing.Point(72, 157);
            this.m_textBox.Name = "m_textBox";
            this.m_textBox.ReadOnly = true;
            this.m_textBox.Size = new System.Drawing.Size(74, 26);
            this.m_textBox.TabIndex = 3;
            // 
            // l_textBox
            // 
            this.l_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_textBox.Location = new System.Drawing.Point(296, 157);
            this.l_textBox.Name = "l_textBox";
            this.l_textBox.ReadOnly = true;
            this.l_textBox.Size = new System.Drawing.Size(74, 26);
            this.l_textBox.TabIndex = 4;
            // 
            // R_textBox
            // 
            this.R_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.R_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R_textBox.Location = new System.Drawing.Point(397, 157);
            this.R_textBox.Name = "R_textBox";
            this.R_textBox.ReadOnly = true;
            this.R_textBox.Size = new System.Drawing.Size(75, 26);
            this.R_textBox.TabIndex = 5;
            // 
            // code_textBox
            // 
            this.code_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.code_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code_textBox.Location = new System.Drawing.Point(72, 218);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.ReadOnly = true;
            this.code_textBox.Size = new System.Drawing.Size(400, 26);
            this.code_textBox.TabIndex = 6;
            this.code_textBox.TextChanged += new System.EventHandler(this.code_textBox_TextChanged);
            // 
            // acceptcode_textBox
            // 
            this.acceptcode_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptcode_textBox.Location = new System.Drawing.Point(72, 277);
            this.acceptcode_textBox.Name = "acceptcode_textBox";
            this.acceptcode_textBox.Size = new System.Drawing.Size(400, 26);
            this.acceptcode_textBox.TabIndex = 7;
            this.acceptcode_textBox.TextChanged += new System.EventHandler(this.acceptcode_textBox_TextChanged);
            // 
            // J_textBox
            // 
            this.J_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.J_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J_textBox.Location = new System.Drawing.Point(397, 344);
            this.J_textBox.Name = "J_textBox";
            this.J_textBox.ReadOnly = true;
            this.J_textBox.Size = new System.Drawing.Size(75, 26);
            this.J_textBox.TabIndex = 10;
            // 
            // mistake_textBox
            // 
            this.mistake_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mistake_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mistake_textBox.Location = new System.Drawing.Point(296, 343);
            this.mistake_textBox.Name = "mistake_textBox";
            this.mistake_textBox.ReadOnly = true;
            this.mistake_textBox.Size = new System.Drawing.Size(74, 26);
            this.mistake_textBox.TabIndex = 9;
            // 
            // m_star_textBox
            // 
            this.m_star_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_star_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_star_textBox.Location = new System.Drawing.Point(72, 344);
            this.m_star_textBox.Name = "m_star_textBox";
            this.m_star_textBox.ReadOnly = true;
            this.m_star_textBox.Size = new System.Drawing.Size(74, 26);
            this.m_star_textBox.TabIndex = 8;
            // 
            // result_textBox
            // 
            this.result_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_textBox.Location = new System.Drawing.Point(72, 401);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(400, 26);
            this.result_textBox.TabIndex = 11;
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.White;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enter_button.Location = new System.Drawing.Point(553, 99);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(153, 31);
            this.enter_button.TabIndex = 12;
            this.enter_button.Text = "ВВОД";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // encode_button
            // 
            this.encode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encode_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encode_button.Location = new System.Drawing.Point(553, 155);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(153, 29);
            this.encode_button.TabIndex = 13;
            this.encode_button.Text = "КОДИРОВАТЬ";
            this.encode_button.UseVisualStyleBackColor = false;
            this.encode_button.Click += new System.EventHandler(this.encode_button_Click);
            // 
            // decode_button
            // 
            this.decode_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decode_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode_button.Location = new System.Drawing.Point(558, 277);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(148, 26);
            this.decode_button.TabIndex = 14;
            this.decode_button.Text = "ДЕКОДИРОВАТЬ";
            this.decode_button.UseVisualStyleBackColor = false;
            this.decode_button.Click += new System.EventHandler(this.decode_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(558, 401);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(148, 26);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "ВЫХОД";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(289, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Информационная последовательность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(325, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "l";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(427, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(207, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Кодовая комбинация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(179, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Принятая кодовая комбинация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(95, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "m*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(335, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "r";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(427, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "J";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(237, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Результат";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(68, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Расширенный код Хэмминга";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(-6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(913, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "_________________________________________________________________________________" +
    "________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(618, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "а";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(618, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "a*";
            // 
            // n_textBox
            // 
            this.n_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_textBox.Location = new System.Drawing.Point(195, 157);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.ReadOnly = true;
            this.n_textBox.Size = new System.Drawing.Size(73, 26);
            this.n_textBox.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(223, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "n";
            // 
            // R2_textBox
            // 
            this.R2_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.R2_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2_textBox.Location = new System.Drawing.Point(183, 344);
            this.R2_textBox.Name = "R2_textBox";
            this.R2_textBox.ReadOnly = true;
            this.R2_textBox.Size = new System.Drawing.Size(73, 26);
            this.R2_textBox.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(152, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 19);
            this.label17.TabIndex = 41;
            this.label17.Text = "  из";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(207, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 19);
            this.label16.TabIndex = 43;
            this.label16.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.R2_textBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.decode_button);
            this.Controls.Add(this.encode_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.J_textBox);
            this.Controls.Add(this.mistake_textBox);
            this.Controls.Add(this.m_star_textBox);
            this.Controls.Add(this.acceptcode_textBox);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.R_textBox);
            this.Controls.Add(this.l_textBox);
            this.Controls.Add(this.m_textBox);
            this.Controls.Add(this.inf_textBox);
            this.Controls.Add(this.a_comboBox);
            this.Controls.Add(this.a_star_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox a_star_comboBox;
        private System.Windows.Forms.ComboBox a_comboBox;
        private System.Windows.Forms.TextBox inf_textBox;
        private System.Windows.Forms.TextBox m_textBox;
        private System.Windows.Forms.TextBox l_textBox;
        private System.Windows.Forms.TextBox R_textBox;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.TextBox acceptcode_textBox;
        private System.Windows.Forms.TextBox J_textBox;
        private System.Windows.Forms.TextBox mistake_textBox;
        private System.Windows.Forms.TextBox m_star_textBox;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox R2_textBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

