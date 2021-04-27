using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace orientiring_test
{
    public partial class test_create_settings : Form
    {
        public bool picthave;
        public test_create_settings()
        {
            InitializeComponent();
        }
        public void check()
        {
            //если хотя бы одно полне не заполнено
            if (name_test.Text == "" || (yes_radioButton.Checked == false && no_radioButton.Checked == false) || Convert.ToInt32(numericUpDown_count_question.Value)==0)
            {
                button1.Enabled = false;//кнопка выключена
            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //по нажатию на кнопку
            //записываем данные из полей в переменные и файлы
            int year = datetimePicker.Value.Year;
            int month = datetimePicker.Value.Month;
            int day = datetimePicker.Value.Day;
            int hour = datetimePicker.Value.Hour;
            int min = datetimePicker.Value.Minute;
            DateTime date_over = new DateTime(year,month,day,hour,min,00);
            DateTime now = new DateTime();
            now = DateTime.Now;
            if (now.AddMinutes(1) > date_over)//проверка не меньше ли введенное время текущего
            {
                MessageBox.Show("дата  и время завершения не могут быть раньше текущей","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (all_time_test.Value.Minute == 0 && all_time_test.Value.Second == 0)
                {
                    MessageBox.Show("Время на прохождение теста должно быть отличным от нуля","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    string name = name_test.Text;
                    if (yes_radioButton.Checked == true)
                    {

                        picthave = true;
                    }
                    else
                    {
                        picthave = false;
                    }
                    int count = Convert.ToInt32(numericUpDown_count_question.Value);
                    if (!Directory.Exists(@"C:/data_orientiring/users_test"))
                    {
                        Directory.CreateDirectory(@"C:/data_orientiring/users_test");
                    }
                    Directory.CreateDirectory(@"C:/data_orientiring/users_test/logs");
                    File.AppendAllText(@"C:/data_orientiring/users_test/logs/name.txt", name);
                    File.AppendAllText(@"C:/data_orientiring/users_test/logs/havepict.txt", Convert.ToString(picthave));
                    File.AppendAllText(@"C:/data_orientiring/users_test/logs/numb.txt", Convert.ToString(count));
                    File.AppendAllText(@"C:/data_orientiring/users_test/logs/date_over.txt", Convert.ToString(datetimePicker.Text));
                    File.AppendAllText(@"C:/data_orientiring/users_test/logs/all_time.txt", all_time_test.Text);
                    //-----------------------------------------
                    MessageBox.Show("Тест создан.\nПосле нажатия кнопки, Вы перейдете к заполнению теста", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    test_create r = new test_create();
                    r.Show();
                    this.Hide();

                }
            }
        }

        private void test_create_settings_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;//при загрузке отключаем кнопку
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(1556, 864);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void name_test_TextChanged(object sender, EventArgs e)
        {
            check();//вызов проверки
        }

        private void yes_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            no_radioButton.Checked = false;//меняем кнопки
            check();//вызываем проверку
        }

        private void no_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            yes_radioButton.Checked = false;//меняем кнопки
            check();//вызываем проверку
        }

        private void numericUpDown_count_question_Click(object sender, EventArgs e)
        {
            check();//вызываем проверку
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //новое поле
            trener_dostyp f = new trener_dostyp();
            f.Show();
            this.Close();
        }
    }
}
