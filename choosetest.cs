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
    public partial class choosetest : Form
    {
        public int Id;
        public int time_count;
        public int count=0;

        public choosetest()
        {
            InitializeComponent();
        }

        private void choosetest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FileStream file1 = new FileStream(@"C:\data_orientiring\name\name.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string a = reader.ReadToEnd();
            reader.Close();
            label4.Text = a;
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
                    MessageBox.Show("Вы прошли все тесты за " + time_count + " секунд.");//вывод времени пользователю
                    File.WriteAllText(@"C:\data_orientiring\name\result\complete.txt", "true");//запись в файл информации о том, что все пройдено
                }
            }
            label6.Text = Convert.ToString(count);

            //if(File.Exists(@"C:\data_orientiring\name\results\1_var\time.txt"))
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //переход по нужным формам
            uslov_znaky f1 = new uslov_znaky();
            f1.Id = this.Id;
            f1.Show();
            this.Hide();
            //---------------------------
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //переход по нужным формам
            Form1 f = new Form1();
            f.Show();
            this.Close();
            //---------------------------
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //переход по нужным формам
            student_registr f = new student_registr();
            f.Show();
            this.Hide();
            //---------------------------
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //переход по нужным формам
            ready_test a = new ready_test();
            a.Show();
            this.Hide();
            //---------------------------
        }
    }
}
