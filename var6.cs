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
    public partial class var6 : Form
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
        public int n3r = 2;
        public int n4p;
        public int n4r = 2;
        public int n5p;
        public int n5r = 1;
        public int n6p;
        public int n6r = 3;
        public int n7p;
        public int n7r = 3;
        public int n8p;
        public int n8r = 1;
        public int n9p;
        public int n9r = 1;
        public int n10p;
        public int n10r = 2;
        public int alltime;
        public int starttime;
        public var6()
        {
            InitializeComponent();
            if (!time)
            {
                timer1.Start();
                time = true;
            }
            button1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                if (!File.Exists(@"C:\data_orientiring\name\results\6_var"))//если папки данного варианта нет, создаем ее
                {
                    Directory.CreateDirectory(@"C:\data_orientiring\name\results\6_var");
                    File.Create(@"C:\data_orientiring\name\results\6_var\time.txt").Close();//создаем файл для времени
                }
                //включаем и выключаем  кнопки
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                //------------------------------
                File.WriteAllText(@"C:\data_orientiring\name\results\6_var\time.txt", "600");//говорим, что тест пройден за 10 минут не до конца
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

        private void var6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            label6.Visible = false;
            pictureBox11.Visible = false;
            starttime = minutes;
            switch (numb_test)
            {
                case 1:
                    radioButton1.Text = "Внемасштабная ямка";
                    radioButton2.Text = "Воронка";
                    radioButton3.Text = "Лощина";
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    radioButton1.Text = "Непреодолимый забор";
                    radioButton2.Text = "Непреодолимый искусственный линейный объект";
                    radioButton3.Text = "Преодолимая стена";
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    break;
                case 3:
                    radioButton1.Text = "Навес";
                    radioButton2.Text = "Асфальтированная область";
                    radioButton3.Text = "Преодолимая скала";
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    break;
                case 4:
                    radioButton1.Text = "Неудобь";
                    radioButton2.Text = "Открытое пространство";
                    radioButton3.Text = "Фруктовый сад";
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 5:
                    radioButton1.Text = "Непреодолимая растительность";
                    radioButton2.Text = "Лес, легкопробегаемый";
                    radioButton3.Text = "Подлесок с хорошей видимостью, преодолимый пешком";
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    break;
                case 6:
                    radioButton1.Text = "Лес, пробегемый в одном направлении";
                    radioButton2.Text = "Опасный район";
                    radioButton3.Text = "Закрытая территория";
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    break;
                case 7:
                    radioButton1.Text = "Дорога с плохим покрытием";
                    radioButton2.Text = "Маркированный участок";
                    radioButton3.Text = "Запрещенный пункт";
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 8:
                    radioButton1.Text = "Мелководье";
                    radioButton2.Text = "Непреодолимое болото";
                    radioButton3.Text = "Непреодолимый водоем";
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    break;
                case 9:
                    radioButton1.Text = "Полуоткрытое пространство";
                    radioButton2.Text = "Непреодолимая растительность";
                    radioButton3.Text = "Болото";
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    break;
                case 10:
                    radioButton1.Text = "Высокая башня";
                    radioButton2.Text = "Гигантский валун";
                    radioButton3.Text = "Постройка";
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
            if (!Directory.Exists(@"C:\data_orientiring\name\results\6_var"))
            {
                Directory.CreateDirectory(@"C:\data_orientiring\name\results\6_var");
                File.Create(@"C:\data_orientiring\name\results\6_var\time.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\1_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\1_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\2_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\2_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\3_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\3_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\4_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\4_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\5_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\5_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\6_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\6_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\7_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\7_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\8_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\8_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\9_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\9_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\10_ans.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\10_true.txt").Close();
                File.Create(@"C:\data_orientiring\name\results\6_var\complete.txt").Close();

                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\1_true.txt", "2");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\2_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\3_true.txt", "3");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\4_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\5_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\6_true.txt", "3");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\7_true.txt", "2");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\8_true.txt", "1");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\9_true.txt", "2");
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\10_true.txt", "3");
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
            label6.Visible = true;
            string Out = "Вы прошли тест за ";
            File.AppendAllText(@"C:\data_orientiring\name\results\6_var\time.txt", Convert.ToString(alltime));
            label6.Text = Out;
            label6.Text = label6.Text + Convert.ToString(alltime);
            label6.Text = label6.Text + " секунд";
            label6.Text = label6.Text + "\n Ваше количество баллов- ";
            label6.Text = label6.Text + point;
            label6.Text = label6.Text + "\n В первом вы ";
            if (n1p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\1_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n1p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\1_ans.txt", Convert.ToString(n1p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n1r;
            label6.Text = label6.Text + "\n Во втором вы ";
            if (n2p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\2_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n2p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\2_ans.txt", Convert.ToString(n2p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n2r;
            label6.Text = label6.Text + "\n В третьем вы ";
            if (n3p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\3_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n3p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\3_ans.txt", Convert.ToString(n3p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n3r;
            label6.Text = label6.Text + "\n В четвертом вы ";
            if (n4p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\4_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n4p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\4_ans.txt", Convert.ToString(n4p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n4r;
            label6.Text = label6.Text + "\n В пятом вы ";
            if (n5p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\5_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n5p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\5_ans.txt", Convert.ToString(n5p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n5r;
            label6.Text = label6.Text + "\n В шестом вы ";
            if (n6p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\6_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n6p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\6_ans.txt", Convert.ToString(n6p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n6r;
            label6.Text = label6.Text + "\n В седьмом вы ";
            if (n7p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\7_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n7p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\7_ans.txt", Convert.ToString(n7p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n7r;
            label6.Text = label6.Text + "\n В восьмом вы ";
            if (n8p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\8_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n8p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\8_ans.txt", Convert.ToString(n8p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n8r;
            label6.Text = label6.Text + "\n В девятом вы ";
            if (n9p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\9_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n9p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\9_ans.txt", Convert.ToString(n9p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n9r;
            label6.Text = label6.Text + "\n В десятом вы ";
            if (n10p == 4)
            {
                label6.Text = label6.Text + "пропустили вопрос";
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\10_ans.txt", "4");
            }
            else
            {
                label6.Text = label6.Text + "ответили ";
                label6.Text = label6.Text + n10p;
                File.AppendAllText(@"C:\data_orientiring\name\results\6_var\10_ans.txt", Convert.ToString(n10p));
            }
            label6.Text = label6.Text + "\n Правильный ответ ";
            label6.Text = label6.Text + n10r;
            button2.Visible = false;
            if (n1p == n1r && n2p == n2r && n3p == n3r && n4p == n4r && n5p == n5r && n6p == n6r && n7p == n7r && n8p == n8r && n9p == n9r && n10p == n10r)
            {
                MessageBox.Show("Вы прошли тест правильно", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Question);
                File.WriteAllText(@"C:\data_orientiring\name\results\6_var\complete.txt", "true");
            }
            else
            {
                File.WriteAllText(@"C:\data_orientiring\name\results\6_var\complete.txt", "false");
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
                radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = radioButton4.Visible = false;
            }
            switch (numb_test)
            {
                case 1:
                    radioButton1.Text = "Внемасштабная ямка";
                    radioButton2.Text = "Воронка";
                    radioButton3.Text = "Лощина";
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    radioButton1.Text = "Непреодолимый забор";
                    radioButton2.Text = "Непреодолимый искусственный линейный объект";
                    radioButton3.Text = "Преодолимая стена";
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    break;
                case 3:
                    radioButton1.Text = "Навес";
                    radioButton2.Text = "Асфальтированная область";
                    radioButton3.Text = "Преодолимая скала";
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    break;
                case 4:
                    radioButton1.Text = "Неудобь";
                    radioButton2.Text = "Открытое пространство";
                    radioButton3.Text = "Фруктовый сад";
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 5:
                    radioButton1.Text = "Непреодолимая растительность";
                    radioButton2.Text = "Лес, легкопробегаемый";
                    radioButton3.Text = "Подлесок с хорошей видимостью, преодолимый пешком";
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    break;
                case 6:
                    radioButton1.Text = "Лес, пробегемый в одном направлении";
                    radioButton2.Text = "Опасный район";
                    radioButton3.Text = "Закрытая территория";
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    break;
                case 7:
                    radioButton1.Text = "Дорога с плохим покрытием";
                    radioButton2.Text = "Маркированный участок";
                    radioButton3.Text = "Запрещенный пункт";
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 8:
                    radioButton1.Text = "Мелководье";
                    radioButton2.Text = "Непреодолимое болото";
                    radioButton3.Text = "Непреодолимый водоем";
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    break;
                case 9:
                    radioButton1.Text = "Полуоткрытое пространство";
                    radioButton2.Text = "Непреодолимая растительность";
                    radioButton3.Text = "Болото";
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    break;
                case 10:
                    radioButton1.Text = "Высокая башня";
                    radioButton2.Text = "Гигантский валун";
                    radioButton3.Text = "Постройка";
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
