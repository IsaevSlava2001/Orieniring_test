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
    public partial class Form1 : Form
    {
        public bool documentation = false;
        public Form1()
        {
            Directory.CreateDirectory(@"C:\data_orientiring");//создаем папку
            InitializeComponent();
        }

        public int f = 0;
        //если есть фокус на поле логин
        private void logintextBox_Enter(object sender, EventArgs e)
        {
            //меняем данные
            if (logintextBox.Text.Equals("введите логин"))
            {
                logintextBox.Text = "";
            }
            //--------------
        }

        private void logintextBox_Leave(object sender, EventArgs e)
        {
            if (logintextBox.Text.Equals(""))
            {
                logintextBox.Text = "введите логин";

            }
        }

        private void passworrdtextBox_Enter(object sender, EventArgs e)
        {
            if (passworrdtextBox.Text.Equals("введите пароль"))
            {
                passworrdtextBox.Text = "";
                passworrdtextBox.PasswordChar = '*';//изменение символа для пароля
            }
        }

        private void passworrdtextBox_Leave(object sender, EventArgs e)
        {
            if (passworrdtextBox.Text.Equals(""))
            {
                passworrdtextBox.Text = "введите пароль";
                passworrdtextBox.PasswordChar = '\0';
            }
            else
            {
                passworrdtextBox.PasswordChar = '*';
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {//удаляем папку с именем текущего тренера если она присутствует
            if (File.Exists(@"C:\data_orientiring\name\coach_name.txt"))
            {
                File.Delete(@"C:\data_orientiring\name\coach_name.txt");
            }
            student_registr f = new student_registr();
            f.Close();
            Environment.Exit(1);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)//если стоит галочка на показать пароль
            {
                passworrdtextBox.PasswordChar = '\0';//показываем
            }
            else if (!passworrdtextBox.Equals("Введите пароль"))//если текст не содержит Введите пароль
            {
                if (passworrdtextBox.Text.Equals("введите пароль"))//если текст содержит Введите пароль
                {
                    passworrdtextBox.PasswordChar = '\0';//меняем символ
                }
                else
                {
                    passworrdtextBox.PasswordChar = '*';//меняем символ на пароль
                }
            }
        }

        private void enterstudentbutton_Click(object sender, EventArgs e)
        {
            //Считваем данные из папки
            if (File.Exists(@"C:\data_orientiring\documentation\checkdocumentation.txt"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\documentation\checkdocumentation.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                //считываем файл
                if (a == "true")
                {
                    //если в файле True, значит документация уже прочитана
                    documentation = true;
                }
                else
                {
                    //иначе, выводим ошибку
                    MessageBox.Show("Сначала прочитайте документацию", "Внимание");
                }
            }
            else//Создаем нужные папки
            {
                Directory.CreateDirectory(@"C:\data_orientiring");
                Directory.CreateDirectory(@"C:\data_orientiring\documentation");
                File.Create(@"C:\data_orientiring\documentation\checkdocumentation.txt").Close();
                MessageBox.Show("Сначала прочитайте документацию", "Внимание");
            }
            if (documentation)//если документация прочитана
            {
                if (File.Exists(@"C:\data_orientiring\name\name.txt"))//если файл с именем есть
                {//открываем окно с выбором теста
                    choosetest f = new choosetest();
                    f.Show();
                    this.Hide();
                }
                else//Иначе
                {
                    //открываем окно с регистрацией
                    student_registr f = new student_registr();
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            //повтор процедуры, как выше
            if (Directory.Exists(@"C:\data_orientiring\documentation\checkdocumentation"))
            {
                FileStream file1 = new FileStream(@"C:\data_orientiring\documentation\checkdocumentation.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "true")
                {
                    documentation = true;
                }
                else
                {
                    MessageBox.Show("Сначала прочитайте документацию", "Внимание");
                }
            }
            else
            {
                Directory.CreateDirectory(@"C:\data_orientiring");
                Directory.CreateDirectory(@"C:\data_orientiring\documentation");
                Directory.CreateDirectory(@"C:\data_orientiring\documentation\checkdocumentation");
                File.Create(@"C:\data_orientiring\documentation\checkdocumentation.txt").Close();
                    MessageBox.Show("Сначала прочитайте документацию", "Внимание");
            }
                if (documentation)
            {
                //считываем логин и пароль
                string s = logintextBox.Text;
                s = s.ToLower();
                string g = passworrdtextBox.Text;
                g = g.ToLower();
                //-------------------------
                //проверка на вход и заполнение нужных файлов, а также переход в другие формы
                if (s != "bannikovaelena" && g == "256b872r927")
                {
                    MessageBox.Show("Банникова Елена. Логин неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "bannikovaelena" && g != "256b872r927")
                {
                    MessageBox.Show("Банникова Елена. Пароль неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passworrdtextBox.Text = "";
                }
                else if (s == "bannikovaelena" && g == "256b872r927")
                {
                    MessageBox.Show("Логин и пароль верны. Здраствуйте, Банникова Елена", "Здравствуйте, Банникова Елена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(!Directory.Exists(@"C:\data_orientiring\name"))
                    {
                        Directory.CreateDirectory(@"C:\data_orientiring\name");
                    }
                    File.WriteAllText(@"C:\data_orientiring\name\coach_name.txt","Банникова Елена Геннадьевна");
                    trener_dostyp f = new trener_dostyp();
                    f.Show();
                    this.Hide();
                }
                else if (s != "dementyevkonstantin" && g == "98732h357sf")
                {
                    MessageBox.Show("Дементьев Константин. Логин неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "dementyevkonstantin" && g != "98732h357sf")
                {
                    MessageBox.Show("Дементьев Константин. Пароль неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "dementyevkonstantin" && g == "98732h357sf")
                {
                    MessageBox.Show("Логин и пароль верны. Здраствуйте, Дементьев Константин", "Здравствуйте, Дементьев Константин", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!Directory.Exists(@"C:\data_orientiring\name"))
                    {
                        Directory.CreateDirectory(@"C:\data_orientiring\name");
                    }
                    File.WriteAllText(@"C:\data_orientiring\name\coach_name.txt", "Дементьев Константин Юрьевич");
                    trener_dostyp f = new trener_dostyp();
                    f.Show();
                    this.Hide();
                }
                else if (s != "tester" && g == "123ret65v4c9b1")
                {
                    MessageBox.Show("Тестер. Логин неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "tester" && g != "123ret65v4c9b1")
                {
                    MessageBox.Show("Тестер. Пароль неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "tester" && g == "123ret65v4c9b1")
                {
                    MessageBox.Show("Логин и пароль верны. Здраствуйте, Тестер", "Здравствуйте, Тестер", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!Directory.Exists(@"C:\data_orientiring\name"))
                    {
                        Directory.CreateDirectory(@"C:\data_orientiring\name");
                    }
                    File.WriteAllText(@"C:\data_orientiring\name\coach_name.txt", "Тестер");
                    trener_dostyp f = new trener_dostyp();
                    f.Show();
                    this.Hide();
                }

                else if (s != "ivanovaleksey" && g == "mdb156frt12Gh5")
                {
                    MessageBox.Show("Иванов Алексей. Логин неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "ivanovaleksey" && g == "mdb156frt12Gh5")
                {
                    MessageBox.Show("Иванов Алексей. Пароль неверный", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logintextBox.Text = "";
                }
                else if (s == "ivanovaleksey" && g == "mdb156frt12Gh5")
                {
                    MessageBox.Show("Логин и пароль верны. Здраствуйте, Иванов Алексей", "Здравствуйте, Иванов Алексей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!Directory.Exists(@"C:\data_orientiring\name"))
                    {
                        Directory.CreateDirectory(@"C:\data_orientiring\name");
                    }
                    File.WriteAllText(@"C:\data_orientiring\name\coach_name.txt", "Иванов Алексей");
                    trener_dostyp f = new trener_dostyp();
                    f.Show();
                    this.Hide();
                }
                //-------------------------------------------------------------------------
                //если ни один из if-ов не совпал, значит и логин и пароль неправильный
                else
                {
                    //сообщаем об этом и чистим поля
                    MessageBox.Show("Логин и пароль неверны");
                    logintextBox.Text = "";
                    passworrdtextBox.Text = "";
                    //-----------------------------
                }
            }
        }

    private void passwordforgetbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пожалуйста обратитесь к администратору приложения","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(1556, 864);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //если нет файлов и папок создаем их
            if (!File.Exists(@"C:\data_orientiring\documentation\checkdocumentation.txt"))
            {
                Directory.CreateDirectory(@"C:\data_orientiring");
                Directory.CreateDirectory(@"C:\data_orientiring\documentation");
                Directory.CreateDirectory(@"C:\data_orientiring\documentation\checkdocumentation");
                File.Create(@"C:\data_orientiring\documentation\checkdocumentation.txt").Close();
                File.WriteAllText(@"C:\data_orientiring\documentation\checkdocumentation.txt", "true");
                Directory.CreateDirectory(@"C:\data_orientiring\name");
                Directory.CreateDirectory(@"C:\data_orientiring\documentation");
                File.Create(@"C:\data_orientiring\documentation\documentation.txt").Close();
                File.WriteAllText(@"C:\data_orientiring\documentation\documentation.txt", "Данная программа является версией тестов по спортивному ориентированию.\r\nЕсли у вас возникнут вопросы, предложения или исправления,\r\nпросьба обращаться на почту sportorientiringtest@yandex.ru.\r\nЕсли у вас Предложение, в письме напишите #Предложение и ваше предложение.\r\nЕсли у вас проблема, укажите в письме #Проблема, и опишите суть проблемы\r\nЕсли у вас вопрос, укажите в письме #Вопрос, и напишите ваш вопрос.\r\nПолезные функции данной версии:\r\n - наличие восьми тестов по условным знакам.\r\n - сохранение данных на одного пользователя.\r\nДля тренера-\r\nВы можете зайти через свой аккаунт и создать свой тест на любое количество вопросов и  максимум 6 ответов.\r\nДля обучаемых-\r\nВы можете выбрать тест, присланный Вам тренером.\r\nДля этого в меню выбора тестов выбрать \"тест, присланный тренером\", и ввести там все данные.\r\nПри открытии программы, если вы хотите пройти тест, вам необходимо:\r\n1 - нажать на кнопку вход для обучаемого, там ввести свое имя и фамилию,\r\nнажать на кнопку войти.\r\n2 - выбрать тест, который вы хотите пройти.\r\n3 - пройти тест\r\n4 - увидеть сбоку свои результаты.\r\nТакже, вы всегда сможете найти этот файл по адресу\r\nC:\\data_orientiring\\documentation\r\nЕсли остались вопросы, задавайте их на нашу почту\r\nКомпания Dictus Games желает Вам успешного прохождения тестов.\r\n\r\nВНИМАНИЕ!!!\r\n\r\nКомпания Dictus Games На данный момент не гарантирует полностью рабочую программу.\r\nЕсли вы заметили какую-либо ошибку, пожалуйста, сообщите нам о ней на почту\r\nИнформация по удалению файла.\r\nНайдите данное приложение в меню приложений и нажмите удалить.");
                System.Diagnostics.Process txt = new System.Diagnostics.Process();//новый процесс
                txt.StartInfo.FileName = "notepad.exe";//через что открывать
                txt.StartInfo.Arguments = @"C:\data_orientiring\documentation\documentation.txt";//что открывать
                txt.Start();//запуск процесса
            }
            //-------------------------------------------------------------
            else
            {
                //проверяем прочитана ли документация и если нет, создаем ее и выводим
                FileStream file1 = new FileStream(@"C:\data_orientiring\documentation\checkdocumentation.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);
                string a = reader.ReadToEnd();
                reader.Close();
                if (a == "true")
                {
                    documentation = true;
                    File.WriteAllText(@"C:\data_orientiring\documentation\checkdocumentation.txt", "true");
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = @"C:\data_orientiring\documentation\documentation.txt";
                    txt.Start();
                }
                else
                {
                    File.Create(@"C:\data_orientiring\documentation\documentation.txt").Close();
                    File.WriteAllText(@"C:\data_orientiring\documentation\documentation.txt", "Данная программа является версией тестов по спортивному ориентированию.\r\nЕсли у вас возникнут вопросы, предложения или исправления,\r\nпросьба обращаться на почту sportorientiringtest@yandex.ru.\r\nЕсли у вас Предложение, в письме напишите #Предложение и ваше предложение.\r\nЕсли у вас проблема, укажите в письме #Проблема, и опишите суть проблемы\r\nЕсли у вас вопрос, укажите в письме #Вопрос, и напишите ваш вопрос.\r\nПолезные функции данной версии:\r\n - наличие восьми тестов по условным знакам.\r\n - сохранение данных на одного пользователя.\r\nДля тренера-\r\nВы можете зайти через свой аккаунт и создать свой тест на любое количество вопросов и  максимум 6 ответов.\r\nДля обучаемых-\r\nВы можете выбрать тест, присланный Вам тренером.\r\nДля этого в меню выбора тестов выбрать \"тест, присланный тренером\", и ввести там все данные.\r\nПри открытии программы, если вы хотите пройти тест, вам необходимо:\r\n1 - нажать на кнопку вход для обучаемого, там ввести свое имя и фамилию,\r\nнажать на кнопку войти.\r\n2 - выбрать тест, который вы хотите пройти.\r\n3 - пройти тест\r\n4 - увидеть сбоку свои результаты.\r\nТакже, вы всегда сможете найти этот файл по адресу\r\nC:\\data_orientiring\\documentation\r\nЕсли остались вопросы, задавайте их на нашу почту\r\nКомпания Dictus Games желает Вам успешного прохождения тестов.\r\n\r\nВНИМАНИЕ!!!\r\n\r\nКомпания Dictus Games На данный момент не гарантирует полностью рабочую программу.\r\nЕсли вы заметили какую-либо ошибку, пожалуйста, сообщите нам о ней на почту\r\nИнформация по удалению файла.\r\nНайдите данное приложение в меню приложений и нажмите удалить.");
                    documentation = true;
                    File.WriteAllText(@"C:\data_orientiring\documentation\checkdocumentation.txt", "true");
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = @"C:\data_orientiring\documentation\documentation.txt";
                    txt.Start();
                }
                //-----------------------------------------------------------------------------
                    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
