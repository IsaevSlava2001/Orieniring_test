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
  
    public partial class uslov_znaky : Form
    {
        public int Id;
        public int t;
        public int count;
        public int time_count;
        public int time_count_hour;
        public int time_count_min;
        public int time_count_sec;
        public uslov_znaky()
        {
            InitializeComponent();
        }

        private void uslov_znaky_Load(object sender, EventArgs e)
        {
            //подгрузка нужных полей
            this.WindowState = FormWindowState.Maximized;
            button17.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false; 
            //--------------------------------
            //считывание данных о правильности тестов для подсчета баллов
            FileStream file1 = new FileStream(@"C:\data_orientiring\name\name.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string a = reader.ReadToEnd();
            reader.Close();
            label12.Text = a;
            if (File.Exists(@"C:\data_orientiring\name\results\1_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\1_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\2_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\2_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\3_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\3_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\4_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\4_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\5_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\5_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\6_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\6_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\7_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\7_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            if (File.Exists(@"C:\data_orientiring\name\results\8_var\complete.txt"))
            {
                FileStream file2 = new FileStream(@"C:\data_orientiring\name\results\8_var\complete.txt", FileMode.Open);
                StreamReader reader1 = new StreamReader(file2);
                string compl = reader1.ReadToEnd();
                reader1.Close();
                if (compl == "true")
                {
                    count++;
                }
            }
            //---------------------------------------------------------
            if (count == 8)//счет общего времени всех тестов
            {
                if (!File.Exists(@"C:\data_orientiring\name\result\complete.txt"))
                {
                    FileStream file = new FileStream(@"C:\data_orientiring\name\results\1_var\time.txt", FileMode.Open);
                    StreamReader reader8 = new StreamReader(file);
                    string b = reader8.ReadToEnd();
                    reader8.Close();
                    time_count = Convert.ToInt32(b);
                    FileStream file5 = new FileStream(@"C:\data_orientiring\name\results\2_var\time.txt", FileMode.Open);
                    StreamReader reader5 = new StreamReader(file5);
                    string c = reader5.ReadToEnd();
                    reader5.Close();
                    time_count = time_count + Convert.ToInt32(c);
                    FileStream file6 = new FileStream(@"C:\data_orientiring\name\results\3_var\time.txt", FileMode.Open);
                    StreamReader reader6 = new StreamReader(file6);
                    string d = reader6.ReadToEnd();
                    reader6.Close();
                    time_count = time_count + Convert.ToInt32(b);
                    FileStream fourth = new FileStream(@"C:\data_orientiring\name\results\4_var\time.txt", FileMode.Open);
                    StreamReader fourthh = new StreamReader(fourth);
                    string f = fourthh.ReadToEnd();
                    fourthh.Close();
                    time_count = time_count + Convert.ToInt32(f);
                    FileStream fifth = new FileStream(@"C:\data_orientiring\name\results\5_var\time.txt", FileMode.Open);
                    StreamReader fifthh = new StreamReader(fifth);
                    string s = fifthh.ReadToEnd();
                    fifthh.Close();
                    time_count = time_count + Convert.ToInt32(s);
                    FileStream sixth = new FileStream(@"C:\data_orientiring\name\results\6_var\time.txt", FileMode.Open);
                    StreamReader sixthh = new StreamReader(sixth);
                    string h = sixthh.ReadToEnd();
                    sixthh.Close();
                    time_count = time_count + Convert.ToInt32(h);
                    FileStream seventh = new FileStream(@"C:\data_orientiring\name\results\7_var\time.txt", FileMode.Open);
                    StreamReader seventhh = new StreamReader(seventh);
                    string l = seventhh.ReadToEnd();
                    seventhh.Close();
                    time_count = time_count + Convert.ToInt32(l);
                    FileStream eigth = new FileStream(@"C:\data_orientiring\name\results\8_var\time.txt", FileMode.Open);
                    StreamReader eigthh = new StreamReader(eigth);
                    string v = eigthh.ReadToEnd();
                    eigthh.Close();
                    time_count = time_count + Convert.ToInt32(v);
                    time_count++;
                    Directory.CreateDirectory(@"C:\data_orientiring\name\result");
                    Directory.CreateDirectory(@"C:\data_orientiring\name\result\time");
                    File.WriteAllText(@"C:\data_orientiring\name\result\time\time.txt", Convert.ToString(time_count));
                    //считаем общее время

                    MessageBox.Show("Ура!!! Вы прошли все тесты на текущий момент. Если у вас остались вопросы и/или предложения, просьба написать их на почту sportorientiringtest@yandex.ru");//вывод поздравления пользователю
                    MessageBox.Show("Вы прошли все тесты за " +time_count+ " секунд.");//вывод времени пользователю
                    File.WriteAllText(@"C:\data_orientiring\name\result\complete.txt", "true");//запись в файл информации о том, что все пройдено
                }
            }
            label10.Text = Convert.ToString(count);//выводим в поле счета
        }

        private void button1_Click(object sender, EventArgs e)
        {//при нажатии на кнопку показать, нужные картинки
            pictureBox1.Visible = true;
            button17.Visible = true;
            t = 1;//выбор картинки, чтобы закрыть
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //проверяем, какая картинка открыта, и ее закрываем
            if(t==1)
            {
                pictureBox1.Visible = false;
                button17.Visible = false;
            }
            if(t==2)
            {
                pictureBox2.Visible = false;
                button17.Visible = false;
            }
            if (t==3)
            {
                pictureBox3.Visible = false;
                button17.Visible = false;
            }
            if(t==4)
            {
                pictureBox4.Visible = false;
                button17.Visible = false;
            }
            if (t == 5)
            {
                pictureBox5.Visible = false;
                button17.Visible = false;
            }
            if (t == 6)
            {
                pictureBox6.Visible = false;
                button17.Visible = false;
            }
            if (t == 7)
            {
                pictureBox7.Visible = false;
                button17.Visible = false;
            }
            if (t == 8)
            {
                pictureBox8.Visible = false;
                button17.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            button17.Visible = true;
            t = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button17.Visible = true;
            t = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            button17.Visible = true;
            t = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            button17.Visible = true;
            t = 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            button17.Visible = true;
            t = 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            button17.Visible = true;
            t = 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            pictureBox6.Visible = true;
            button17.Visible = true;
            t = 6;
    }

        private void button6_Click(object sender, EventArgs e)
        {
            //дальнейшие пункты однотипные, комментирую один
            //проеряем, пройден ли тест, если нет, открываем, если да, то спрашиваем, хочет ли участник удалить данные
            if (Directory.Exists(@"C:\data_orientiring\name\results\2_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\2_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    _2_var f = new _2_var();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\2_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        _2_var f = new _2_var();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                _2_var f = new _2_var();
                f.Show();
                this.Hide();
            }
        }
        //---------------------------------------------------------------------

        private void button7_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\3_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\3_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var_3 f = new var_3();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\3_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var_3 f = new var_3();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var_3 f = new var_3();
                f.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\4_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\4_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var4 f = new var4();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\4_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var4 f = new var4();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var4 f = new var4();
                f.Show();
                this.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\5_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\5_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var5 f = new var5();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\5_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var5 f = new var5();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var5 f = new var5();
                f.Show();
                this.Hide();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\6_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\6_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var6 f = new var6();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\6_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var6 f = new var6();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var6 f = new var6();
                f.Show();
                this.Hide();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\7_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\7_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var7 f = new var7();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\7_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var7 f = new var7();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var7 f = new var7();
                f.Show();
                this.Hide();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\8_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\8_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var8 f = new var8();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\8_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var8 f = new var8();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var8 f = new var8();
                f.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\1_var"))
            { 
            FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\1_var\complete.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string a = reader.ReadToEnd();
            reader.Close();
            if (a == "false")
            {
                _1 f = new _1();
                f.Id = this.Id;
                f.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(@"C:\data_orientiring\name\results\1_var", true);
                        _1 f = new _1();
                        f.Id = this.Id;
                        f.Show();
                        this.Hide();
                    }
            }
        }
            else
            {
                _1 f = new _1();
                f.Id = this.Id;
                f.Show();
                this.Hide();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            choosetest f = new choosetest();
            f.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\data_orientiring\name\results\8_var"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\name\results\8_var\complete.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "false")
                {
                    var8 f = new var8();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уже прошли этот тест идеально. Вы уверены, что хотите его перепройти? Все предыдущие результаты для данного теста будут удалены", "Подтверждение перепрохождения теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\data_orientiring\name\results\8_var", true);
                        if (Directory.Exists(@"C:\data_orientiring\name\result"))
                        {
                            Directory.Delete(@"C:\data_orientiring\name\result", true);

                        }
                        var8 f = new var8();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                var8 f = new var8();
                f.Show();
                this.Hide();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
