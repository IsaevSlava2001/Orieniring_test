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
    public partial class ready_test_go : Form
    {
        public int numb_test=0;
        public double time_go = 0;
        public int[] u;
        public int[] r;
        public int point = 0;
        public string much_question_label;
        public string label_have_pictures;
        public bool have_pictures;
        public string name;
        public double seconds;
        public int minutes;
        public bool time = false;
        public int alltime;
        public int starttime;
        public bool end = false;
        public ready_test_go()
        {
            InitializeComponent();
            if (!time)
            {
                timer1.Start();
                time = true;
            }
            button1.Visible = false;
        }

        private void ready_test_go_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(1556, 864);
            FormBorderStyle = FormBorderStyle.None;
            error_img_label.Visible = false;
            //считывание данных о тесте и заполнение нужных переменных и полей
            much_question_label = File.ReadAllText(@"C:/data_orientiring/users_test/logs/muchquestion.txt");
            label_have_pictures = File.ReadAllText(@"C:/data_orientiring/users_test/logs/ispicture.txt");
            name = File.ReadAllText(@"C:/data_orientiring/users_test/logs/name.txt");
            string time = File.ReadAllText($@"C:/data_orientiring/users_test/logs/all_time.txt");
            Directory.Delete(@"C:/data_orientiring/users_test/logs", true);
            string[] time_s_m = time.Split(':');
            minutes = Convert.ToInt32(time_s_m[0]);
            seconds= Convert.ToInt32(time_s_m[1]);
            button2.Visible = false;
            starttime = minutes;
            if (label_have_pictures == "true")
            {
                pictureBox.Visible = true;
                have_pictures = true;
            }
            else
            {
                pictureBox.Visible = false;
                have_pictures = false;
            }
            if (have_pictures)//если в тесте есть картинки, пытаемся достать для текущего вопроса
            {
                try
                {
                    Bitmap image = new Bitmap($@"C:/data_orientiring/users_test/{name}/1/photo.png");//создаем новый битмап с картинкой
                    pictureBox.Image = image;//заполняем PictureBox
                }
                catch//если картинки для этого вопроса нет, включаем label и выводим в него информацию об этом
                {
                    error_img_label.Visible = true;
                    error_img_label.Font = new Font("SegoeScript", 14);
                    error_img_label.ForeColor = Color.ForestGreen;
                    error_img_label.Text = "В данном вопросе нет картинки";
                }
                //-----------------------------------------------------------------
            }
            //считывание вопросов
            string[] answers = new string[7];
            int count = 0;
            string[] answers_arr = Directory.GetFiles($@"C:/data_orientiring/users_test/{name}/1/ans");
            foreach (string item in answers_arr)//проход по всем папками в только что созданной переменной
            {
                answers[count] = File.ReadAllText(item);
                count++;
            }
            //-------------------------------
            muchquest(count);//включение нужного кол-ва textBox-ов
            zap(count, answers);//заполняем textBox-ы
            u = new int[Convert.ToInt32(much_question_label)];//ответы пользователя
            r = new int[Convert.ToInt32(much_question_label)];//правильные ответы
            count = 0;
            DirectoryInfo directory = new DirectoryInfo($@"C:/data_orientiring/users_test/{name}");//создание переменной для пути к файлу
            foreach (var item in directory.GetDirectories())//проход по всем папками в только что созданной переменной
                //проходим по всем файлам с правильными ответами и записываем их
            {
                r[count] = Convert.ToInt32(File.ReadAllText($@"C:/data_orientiring/users_test/{name}/{count+1}/r.txt"));
                Console.WriteLine(count+"\n"+r[count]);
                count++;
                //-------------------------------------------------------
            }
            textBox2.Text = File.ReadAllText($@"C:/data_orientiring/users_test/{name}/1/q.txt");//вывод вопроса
        }
        public void muchquest(int i)//метод вывода нужного количества чекбоксов по числу
        {
            switch (i)
            {
                case 2:
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton7.Visible = false;
                    break;
                case 3:
                    radioButton3.Visible = true;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton7.Visible = false;
                    break;
                case 4:
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton7.Visible = false;
                    break;
                case 5:
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = false;
                    radioButton7.Visible = false;
                    break;
                case 6:
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = false;
                    break;
                case 7:
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    break;
            }
        }
        public void zap(int i,string[]k)//метод заполнения чекбоксов по данным из массива вопросов
        {
            //выводим вопрос в чекбокс и проверяем есть ли следующий вопрос. Если есть, выводим, в противном случае, выходим из метода
            radioButton1.Text = k[0];
            radioButton2.Text = k[1];
            if(i!=1)
            {
                radioButton3.Text = k[2];
                if (i != 2)
                {
                    radioButton4.Text = k[3];
                    if (i != 3)
                    {
                        radioButton5.Text = k[4];
                        if (i != 4)
                        {
                            radioButton6.Text = k[5];
                            if (i != 5)
                            {
                                radioButton7.Text = k[6];
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
        //дальнейшие методы однотипны, прокомментирую только один
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;//выключаем кнопку
            if (radioButton1.Checked == true)//если данный чекбокс включен
            {
                //выключаем остальные
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                //------------------------
                //если текст этого поля пропустить вопрос
                if (radioButton1.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;//записываем в ответ число 10(больше остальных), для отметки о пропуске вопроса
                }
                else//иначе
                {
                    u[numb_test] = 1;//записываем номер чекбокса в ответ
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false&& radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
                {
                    button1.Visible = false;//если все чекбоксы выключены, кнопка тоже выключена
                }
                else
                {
                    button1.Visible = true;//иначе, включаем ее
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                if (radioButton2.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;
                }
                else
                {
                    u[numb_test] = 2;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
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
            button1.Visible = false;
            if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                if (radioButton3.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;
                }
                else
                {
                    u[numb_test] = 3;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
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
            button1.Visible = false;
            if (radioButton4.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                if (radioButton4.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;
                }
                else
                {
                    u[numb_test] = 4;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (radioButton5.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                if (radioButton5.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;
                }
                else
                {
                    u[numb_test] = 5;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (radioButton6.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton7.Checked = false;
                if (radioButton6.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;
                }
                else
                {
                    u[numb_test] = 6;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (radioButton7.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                if (radioButton7.Text == "пропустить вопрос")
                {
                    u[numb_test] = 10;
                }
                else
                {
                    u[numb_test] = 7;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
                {
                    button1.Visible = false;
                }
                else
                {
                    button1.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //выключаем все поля
            error_img_label.Visible = false;
            pictureBox.Image = null;
            numb_test++;//увеличиваем номер вопрса
            button1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            //-----------------------------------------
            if (numb_test ==Convert.ToInt32(much_question_label))//если номер теста равен максимальному числу, значит тест закончен
            {
                button2.Visible = true;//включаем кнопку закончить тест
                //остальное выключаем
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                pictureBox.Visible = false;
                error_img_label.Visible = false;
                textBox2.Visible = false;
                //-----------------------------------
            }
            else//тест не закончен
            {
                DirectoryInfo dir = new DirectoryInfo($@"C:/data_orientiring/users_test/{name}/{numb_test+1}");//берем новую папку
                string question_to_see = File.ReadAllText($@"{dir}/q.txt");//считываем вопрос
                textBox2.Text = question_to_see;//выводим его
                if (have_pictures)//если есть картинки
                {
                    try//пытаемся вывести текущую через битмап
                    {
                        Bitmap image = new Bitmap($@"C:/data_orientiring/users_test/{name}/{numb_test+1}/photo.png");
                        pictureBox.Image = image;
                    }
                    catch//ждем любое исключение
                    {
                        //выводим информацию о том, что нет картинки
                        error_img_label.Visible = true;
                        error_img_label.Font = new Font("SegoeScript", 14);
                        error_img_label.ForeColor=Color.ForestGreen;
                        error_img_label.Text="В данном вопросе нет картинки";
                        //------------------------------------------
                    }
                }
                string[] answers = new string[7];//определяем новые вопросы
                int count = 0;//обнуляем счетчик
                string[] answers_arr = Directory.GetFiles($@"C:/data_orientiring/users_test/{name}/{numb_test+1}/ans");//получаем все ответы из текущего вопроса
                foreach (string item in answers_arr)//проход по всем папками в только что созданной переменной
                {
                    answers[count] = File.ReadAllText(item);//записываем их в массив
                    count++;
                }
                //обновляем чекбоксы
                muchquest(count);
                zap(count, answers);
                //------------------
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds = seconds - 0.1;//каждый тик таймера, отнимаем 0,1 десятую секунды
            time_go = time_go + 0.1;
            
            if (seconds == -1 || seconds < 0)
            {
                //если секунды закончились, обновляем время
                minutes = minutes - 1;
                seconds = 59;
            }
            if (minutes == -1)//если все по нулям
            {

                //если время закончилось обновляем все и записываем информацию об этом
                timer1.Stop();
                MessageBox.Show("время вышло", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!Directory.Exists($@"C:\data_orientiring\name\results\user_test\{name}"))
                {
                    Directory.CreateDirectory($@"C:\data_orientiring\name\results\user_test\{name}");
                    File.Create($@"C:\data_orientiring\name\results\user_test\{name}\time.txt").Close();
                }
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                MessageBox.Show(Convert.ToString(time_go));
                File.WriteAllText($@"C:\data_orientiring\name\results\user_test\{name}\time.txt", Convert.ToString(time_go));
                ready_test f = new ready_test();
                f.Show();
                this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            //выход из теста с уточнением и проверкой, закончен ли тест
            if (!end)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ready_test f = new ready_test();
                    f.Show();
                    this.Close();
                }
            }
            else
            {
                ready_test f = new ready_test();
                f.Show();
                this.Close();
            }
            //---------------------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка завершить тест нажата
            button1.Visible = false;//выключаем кнопку ответить
            error_img_label.Visible = false;
            pictureBox.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            end = true;//сообщаем, что тест закончен
            //pictureBox.Visible = true;//картинку включаем
            if (!Directory.Exists($@"C:\data_orientiring\name\results\user_test\{name}"))//если пакпи нет, создаем ее и нужные подпапки
            {
                Directory.CreateDirectory($@"C:\data_orientiring\name\results\user_test\{name}");
                File.Create($@"C:\data_orientiring\name\results\user_test\{name}\time.txt").Close();
                File.Create($@"C:\data_orientiring\name\results\user_test\{name}\complete.txt").Close();
                int sd = 1;
                foreach (var i in r)
                {
                    //создаем папки для ответов и заполняем ответы реальные
                    File.Create($@"C:\data_orientiring\name\results\user_test\{name}\{sd}_ans.txt").Close();
                    File.Create($@"C:\data_orientiring\name\results\user_test\{name}\{sd}_true.txt").Close();
                    File.AppendAllText($@"C:\data_orientiring\name\results\user_test\{name}\{sd}_true.txt", Convert.ToString(r[sd-1]));
                    sd++;//увеличиваем счетчик
                }
                //--------------------------------------------------------  
            }
            //-------------------------------------------------------
            int df = 0;
            foreach(var i in r)
            {
                if(u[df]==r[df])
                {
                    //если ответ пользователя совпадает с правильным
                    point++;//увеличиваем количество баллов
                }
                df++;
            }
            timer1.Stop();//останавливаем таймер
            //считаем время прохождения
            int min = Convert.ToInt32(minutes);
            int sec = Convert.ToInt32(seconds);
            alltime = (((starttime + 1) * 60) - (min * 60 + sec))-60;
            alltime = Convert.ToInt32(time_go);
            //------------------------------
            textBox1.Visible = true;//включаем textBox
            string Out = "Вы прошли тест за ";//создаем сообщение для вывода
            File.AppendAllText($@"C:\data_orientiring\name\results\user_test\{name}\time.txt", Convert.ToString(alltime));//дополняем файлик временем
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
            textBox1.Text = textBox1.Text + Environment.NewLine+"Ваше количество баллов- ";
            textBox1.Text = textBox1.Text + point;
            int er = 1;
            foreach (var i in r)
            {
                textBox1.Text = textBox1.Text + Environment.NewLine+"В вопросе "+er+" Вы ";
                if (u[er-1] == 10)
                {
                    textBox1.Text = textBox1.Text + "пропустили вопрос";
                    File.AppendAllText($@"C:\data_orientiring\name\results\user_test\{name}\{er}_ans.txt", "10");
                }
                else
                {
                    textBox1.Text = textBox1.Text + "ответили ";
                    textBox1.Text = textBox1.Text + u[er-1];
                    File.AppendAllText($@"C:\data_orientiring\name\results\user_test\{name}\{i+1}_ans.txt", Convert.ToString(u[er-1]));
                }
                textBox1.Text = textBox1.Text + Environment.NewLine+"Правильный ответ ";
                textBox1.Text = textBox1.Text + r[er-1];
                button2.Visible = false;
                er++;
            }
            //----------------------------------------------------
            textBox1.Text = textBox1.Text + Environment.NewLine + "Вы ответили правильно на следующее количество вопросов: ";
            textBox1.Text = textBox1.Text + point;
            if (point==Convert.ToInt32(much_question_label))//если количество баллов совпадает с количеством ответов, значит тест пройден правильно
            {
                MessageBox.Show("Вы прошли тест правильно", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Question);
                File.WriteAllText($@"C:\data_orientiring\name\results\user_test\{name}\complete.txt", "true");
            }
            else
            {
                File.WriteAllText($@"C:\data_orientiring\name\results\user_test\{name}\complete.txt", "false");
                end = true;
            }
        }
    }
}
