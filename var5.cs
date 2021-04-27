using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace orientiring_test
{
    public partial class var5 : Form
    {
        public int Id;
        public bool end = false;
        public bool c = true;
        public bool u = true;
        public int point = 0;
        public int numb_test = 1;
        public bool check = false;
        public double seconds = 59;
        public int minutes = 9;
        public bool time = false;
        public int n1p;
        public int n1r = 1;
        public int n2p;
        public int n2r = 2;
        public int n3p;
        public int n3r = 3;
        public int n4p;
        public int n4r = 2;
        public int n5p;
        public int n5r = 3;
        public int n6p;
        public int n6r = 3;
        public int n7p;
        public int n7r = 2;
        public int n8p;
        public int n8r = 1;
        public int n9p;
        public int n9r = 3;
        public int n10p;
        public int n10r = 3;
        public int alltime;
        public int starttime;
        public var5()
        {
            InitializeComponent();
            if (!time)
            {
                timer1.Start();
                time = true;
            }
            button1.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            seconds = seconds - 0.1;//каждый тик таймера, отнимаем 0,1 десятую секунды

            if (seconds == -1 || seconds < 0)//когда заканчиваются секунды
            {
                minutes = minutes - 1;//отнимаем минуту
                seconds = 59;//обновляем секунды
            }
            if (minutes == -1)//если все по нулям
            {
                timer1.Stop();//останавливаем таймер
                label4.Text = "00";
                label5.Text = "00";
                MessageBox.Show("время вышло");//сообщаем, что время вышло
                if (!File.Exists(@"C:\data_orientiring\name\results\5_var"))//если папки данного варианта нет, создаем ее
                {
                    Directory.CreateDirectory(@"C:\data_orientiring\name\results\5_var");
                    File.Create(@"C:\data_orientiring\name\results\5_var\time.txt").Close();//создаем файл для времени
                }
                //включаем и выключаем  кнопки
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                //------------------------------
                File.WriteAllText(@"C:\data_orientiring\name\results\5_var\time.txt", "600");//говорим, что тест пройден за 10 минут не до конца
                //выход, так как время закончилось
                uslov_znaky f = new uslov_znaky();
                f.Show();
                this.Close();
                //-----------------

            }
            //обновляем поля
            label4.Text = Convert.ToString(Convert.ToInt64(minutes));
            label5.Text = Convert.ToString(Convert.ToInt64(seconds));
            if (minutes <= 9.5)
            {
                label4.Text = "0" + Convert.ToString(Convert.ToInt64(minutes));
            }
            if (seconds <= 9.5)
            {
                label5.Text = "0" + Convert.ToString(Convert.ToInt64(seconds));
            }
            if (minutes == -1)
            {
                label4.Text = "00";
                label5.Text = "00";
            }
            //---------------
        }

        private void var5_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(1556, 864);
            FormBorderStyle = FormBorderStyle.None;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            pictureBox11.Visible = false;
            starttime = minutes;
            switch (numb_test)
            {
                case 1:
                    radioButton1.Text = "Узкое болото";
                    radioButton2.Text = "Преодолимый водный поток шириной менее 2 метров";
                    radioButton3.Text = "Непреодолимая река";
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    radioButton1.Text = "Грунтовый обрыв";
                    radioButton2.Text = "Непреодолимая скала";
                    radioButton3.Text = "Преодолимый забор";
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    break;
                case 3:
                    radioButton1.Text = "Просека без тропы, медленно пробегаемая";
                    radioButton2.Text = "Граница растительности";
                    radioButton3.Text = "Просека без тропы, легко пробегаемая";
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    break;
                case 4:
                    radioButton1.Text = "Преодолимая скала";
                    radioButton2.Text = "Непреодолимая стена";
                    radioButton3.Text = "Земляной вал";
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 5:
                    radioButton1.Text = "Фонтан";
                    radioButton2.Text = "Непреодолимая река";
                    radioButton3.Text = "Родник";
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    break;
                case 6:
                    radioButton1.Text = "Открытый песчаный грунт";
                    radioButton2.Text = "Неудобь";
                    radioButton3.Text = "Фруктовый сад";
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    break;
                case 7:
                    radioButton1.Text = "Исчезающая тропа";
                    radioButton2.Text = "Дорожка, тропа";
                    radioButton3.Text = "Разрушенная ограда";
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 8:
                    radioButton1.Text = "Закрытая территория";
                    radioButton2.Text = "Труднопреодолимый лес";
                    radioButton3.Text = "Болото";
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    break;
                case 9:
                    radioButton1.Text = "Финиш";
                    radioButton2.Text = "Горка";
                    radioButton3.Text = "Контрольный пункт";
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    break;
                case 10:
                    radioButton1.Text = "Ямы";
                    radioButton2.Text = "Холмы";
                    radioButton3.Text = "Микронеровности";
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            end = true;
            pictureBox11.Visible = true;
            if (!Directory.Exists(@"C:\data_orientiring\name\results\5_var"))
            {
                Directory.CreateDirectory(@"C:\data_orientiring\name\results\5_var");
                File.Create(@"C:\data_orientiring\name\results\5_var\time.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\1_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\1_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\2_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\2_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\3_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\3_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\4_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\4_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\5_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\5_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\6_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\6_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\7_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\7_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\8_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\8_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\9_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\9_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\10_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\10_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\5_var\complete.txt").Close();

                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\1_true.txt", "2");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\2_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\3_true.txt", "3");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\4_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\5_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\6_true.txt", "3");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\7_true.txt", "2");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\8_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\9_true.txt", "2");
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\10_true.txt", "3");
            }
            if (n1p == n1r)
            {
                point++;
            }
            if (n2p == n2r)
            {
                point++;
            }
            if (n3p == n3r)
            {
                point++;
            }
            if (n4p == n4r)
            {
                point++;
            }
            if (n5p == n5r)
            {
                point++;
            }
            if (n6p == n6r)
            {
                point++;
            }
            if (n7p == n7r)
            {
                point++;
            }
            if (n8p == n8r)
            {
                point++;
            }
            if (n9p == n9r)
            {
                point++;
            }
            if (n10p == n10r)
            {
                point++;
            }
            timer1.Stop();
            int min = Convert.ToInt32(minutes);
            int sec = Convert.ToInt32(seconds);
            alltime = ((starttime + 1) * 60) - (min * 60 + sec);
            textBox1.Visible = true;
            string Out = "Вы прошли тест за ";
            File.AppendAllText(@"C:\data_orientiring\name\results\5_var\time.txt", Convert.ToString(alltime));
            char[] time_mass = new char[5];
            time_mass = alltime.ToString().ToCharArray();
            string pre_last = "z";
            if (alltime >= 10)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (time_mass[i].ToString() == time_mass.Last().ToString() && i != 0)
                    {
                        pre_last = time_mass[i - 1].ToString();
                        break;
                    }
                }
            }
            textBox1.Text = Out;
            textBox1.Text = textBox1.Text + Convert.ToString(alltime);
            if (time_mass.Last().ToString() == "1" && pre_last != "1")
            {
                textBox1.Text = textBox1.Text + " секунду";
            }
            else if ((time_mass.Last().ToString() == "2" || time_mass.Last().ToString() == "3" || time_mass.Last().ToString() == "4") && pre_last != "1")
            {
                textBox1.Text = textBox1.Text + " секунды";
            }
            else if (time_mass.Last().ToString() == "5" || time_mass.Last().ToString() == "6" || time_mass.Last().ToString() == "7" || time_mass.Last().ToString() == "8" || time_mass.Last().ToString() == "9" || time_mass.Last().ToString() == "0")
            {
                textBox1.Text = textBox1.Text + " секунд";
            }
            else if (pre_last == "1")
            {
                textBox1.Text = textBox1.Text + " секунд";
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Ваше количество баллов- ";
            textBox1.Text = textBox1.Text + point;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В первом вопросе Вы ";
            if (n1p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\1_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n1p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\1_ans.txt", Convert.ToString(n1p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n1r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "Во втором вопросе Вы ";
            if (n2p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\2_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n2p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\2_ans.txt", Convert.ToString(n2p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n2r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В третьем вопросе Вы ";
            if (n3p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\3_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n3p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\3_ans.txt", Convert.ToString(n3p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n3r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В четвертом вопросе Вы ";
            if (n4p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\4_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n4p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\4_ans.txt", Convert.ToString(n4p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n4r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В пятом вопросе Вы ";
            if (n5p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\5_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n5p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\5_ans.txt", Convert.ToString(n5p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n5r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В шестом вопросе Вы ";
            if (n6p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\6_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n6p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\6_ans.txt", Convert.ToString(n6p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n6r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В седьмом вопросе Вы ";
            if (n7p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\7_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n7p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\7_ans.txt", Convert.ToString(n7p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n7r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В восьмом вопросе Вы ";
            if (n8p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\8_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n8p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\8_ans.txt", Convert.ToString(n8p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n8r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В девятом вопросе Вы ";
            if (n9p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\9_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n9p;
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\9_ans.txt", Convert.ToString(n9p));
            }
            textBox1.Text = textBox1.Text + Environment.NewLine + "Правильный ответ ";
            textBox1.Text = textBox1.Text + n9r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "В десятом вопросе Вы ";
            if (n10p == 4)
            {
                textBox1.Text = textBox1.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\10_ans.txt", "4");
            }
            else
            {
                textBox1.Text = textBox1.Text + "ответили ";
                textBox1.Text = textBox1.Text + n10p;

                File.AppendAllText(@"C:\data_orientiring\name\results\5_var\10_ans.txt", Convert.ToString(n10p));
            }
            textBox1.Text = textBox1.Text + "\n Правильный ответ ";
            textBox1.Text = textBox1.Text + n10r;
            textBox1.Text = textBox1.Text + Environment.NewLine + "Вы ответили правильно на следующее количество вопросов: ";
            textBox1.Text = textBox1.Text + point;
            button2.Visible = false;
            if (n1p == n1r && n2p == n2r && n3p == n3r && n4p == n4r && n5p == n5r && n6p == n6r && n7p == n7r && n8p == n8r && n9p == n9r && n10p == n10r)
            {
                MessageBox.Show("Вы прошли тест правильно", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Question);
                File.WriteAllText(@"C:\data_orientiring\name\results\5_var\complete.txt", "true");
            }
            else
            {
                File.WriteAllText(@"C:\data_orientiring\name\results\5_var\complete.txt", "false");
                end = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numb_test++;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button1.Visible = false;
            if (numb_test == 11)
            {
                button2.Visible = true;
                pictureBox10.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                label1.Visible = false;
            }
            switch (numb_test)
            {
                case 1:
                    radioButton1.Text = "Узкое болото";
                    radioButton2.Text = "Преодолимый водный поток шириной менее 2 метров";
                    radioButton3.Text = "Непреодолимая река";
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    radioButton1.Text = "Грунтовый обрыв";
                    radioButton2.Text = "Непреодолимая скала";
                    radioButton3.Text = "Преодолимый забор";
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    break;
                case 3:
                    radioButton1.Text = "Просека без тропы, медленно пробегаемая";
                    radioButton2.Text = "Граница растительности";
                    radioButton3.Text = "Просека без тропы, легко пробегаемая";
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    break;
                case 4:
                    radioButton1.Text = "Преодолимая скала";
                    radioButton2.Text = "Непреодолимая стена";
                    radioButton3.Text = "Земляной вал";
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 5:
                    radioButton1.Text = "Фонтан";
                    radioButton2.Text = "Непреодолимая река";
                    radioButton3.Text = "Родник";
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    break;
                case 6:
                    radioButton1.Text = "Открытый песчаный грунт";
                    radioButton2.Text = "Неудобь";
                    radioButton3.Text = "Фруктовый сад";
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    break;
                case 7:
                    radioButton1.Text = "Исчезающая тропа";
                    radioButton2.Text = "Дорожка, тропа";
                    radioButton3.Text = "Разрушенная ограда";
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 8:
                    radioButton1.Text = "Закрытая территория";
                    radioButton2.Text = "Труднопреодолимый лес";
                    radioButton3.Text = "Болото";
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    break;
                case 9:
                    radioButton1.Text = "Финиш";
                    radioButton2.Text = "Горка";
                    radioButton3.Text = "Контрольный пункт";
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    break;
                case 10:
                    radioButton1.Text = "Ямы";
                    radioButton2.Text = "Холмы";
                    radioButton3.Text = "Микронеровности";
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                switch (numb_test)
                {
                    case 1:
                        n1p = 1;
                        break;
                    case 2:
                        n2p = 1;
                        break;
                    case 3:
                        n3p = 1;
                        break;
                    case 4:
                        n4p = 1;
                        break;
                    case 5:
                        n5p = 1;
                        break;
                    case 6:
                        n6p = 1;
                        break;
                    case 7:
                        n7p = 1;
                        break;
                    case 8:
                        n8p = 1;
                        break;
                    case 9:
                        n9p = 1;
                        break;
                    case 10:
                        n10p = 1;
                        break;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                switch (numb_test)
                {
                    case 1:
                        n1p = 2;
                        break;
                    case 2:
                        n2p = 2;
                        break;
                    case 3:
                        n3p = 2;
                        break;
                    case 4:
                        n4p = 2;
                        break;
                    case 5:
                        n5p = 2;
                        break;
                    case 6:
                        n6p = 2;
                        break;
                    case 7:
                        n7p = 2;
                        break;
                    case 8:
                        n8p = 2;
                        break;
                    case 9:
                        n9p = 2;
                        break;
                    case 10:
                        n10p = 2;
                        break;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            if (radioButton3.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
                switch (numb_test)
                {
                    case 1:
                        n1p = 3;
                        break;
                    case 2:
                        n2p = 3;
                        break;
                    case 3:
                        n3p = 3;
                        break;
                    case 4:
                        n4p = 3;
                        break;
                    case 5:
                        n5p = 3;
                        break;
                    case 6:
                        n6p = 3;
                        break;
                    case 7:
                        n7p = 3;
                        break;
                    case 8:
                        n8p = 3;
                        break;
                    case 9:
                        n9p = 3;
                        break;
                    case 10:
                        n10p = 3;
                        break;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            {
                button1.Visible = true;
                if (radioButton4.Checked == true)
                {
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton1.Checked = false;
                    switch (numb_test)
                    {
                        case 1:
                            n1p = 4;
                            break;
                        case 2:
                            n2p = 4;
                            break;
                        case 3:
                            n3p = 4;
                            break;
                        case 4:
                            n4p = 4;
                            break;
                        case 5:
                            n5p = 4;
                            break;
                        case 6:
                            n6p = 4;
                            break;
                        case 7:
                            n7p = 4;
                            break;
                        case 8:
                            n8p = 4;
                            break;
                        case 9:
                            n9p = 4;
                            break;
                        case 10:
                            n10p = 4;
                            break;
                    }
                    if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                    {
                        button1.Visible = false;
                    }
                    else
                    {
                        button1.Visible = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!end)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    uslov_znaky f = new uslov_znaky();
                    f.Show();
                    this.Close();
                }
            }
            else
            {
                uslov_znaky f = new uslov_znaky();
                f.Show();
                this.Close();
            }
        }
    }
}
