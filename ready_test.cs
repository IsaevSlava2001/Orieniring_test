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
using Ionic.Zip;

namespace orientiring_test
{
    public partial class ready_test : Form
    {
        public static string dir="";
        public Image image;
        OpenFileDialog openDialog = new OpenFileDialog();
        public ready_test()
        {
            InitializeComponent();
        }

        private void choosetest_Click(object sender, EventArgs e)
        {
            //если пароль введен
            if (pass_text_Box.Text != "Введите пароль" && pass_text_Box.Text != "")
            {
                //открываем для пользователя диалоговое окно с ыыбором файла
                openDialog.Filter = "Файлы тестов tso|*.tso;";//фильтр расширений
                if (openDialog.ShowDialog() != DialogResult.OK)//если нажато OK
                    return;//закрываем окно

                try
                {
                    dir = openDialog.FileName;//пытаемся это открыть
                }
                catch (OutOfMemoryException ex)//ждем ошибку превышения памяти
                {
                    MessageBox.Show("Ошибка чтения файла","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);//сообщаем об  этом
                    return;
                }
                choosetest.Visible = false;
                pass_text_Box.Visible = false;
                //окна пароля и выбора тест выключаем
                //если нужно, создаем папку
                if (!Directory.Exists(@"C:/data_orientiring/users_test"))
                {
                    Directory.CreateDirectory(@"C:/data_orientiring/users_test");
                }
                //-------------------------
                //создаем папку с логами
                Directory.CreateDirectory(@"C:/data_orientiring/users_test/logs");
                string[] a = dir.Split('\\','.');//разделяем путь
                string name = a[a.Length - 2];//чтобы получить имя файла
                File.Copy(dir, $@"C:/data_orientiring/users_test/{name}.zip");//копируем его в нашу папку
                Directory.CreateDirectory($@"C:/data_orientiring/users_test/{name}");//создаем папку для данных этого теста
                string dest = $@"C:/data_orientiring/users_test/{name}";
                using (ZipFile zip = ZipFile.Read($@"C:/data_orientiring/users_test/{name}.zip"))//используем библиотеку Ionic.Zip
                {
                    foreach (ZipEntry zipe in zip)//пока есть данные в архиве
                    {
                        zipe.ExtractWithPassword(dest, ExtractExistingFileAction.OverwriteSilently, pass_text_Box.Text);//распаковываем с паролем
                    }
                }
                File.Delete($@"C:/data_orientiring/users_test/{name}.zip");//удаляем zip-архив для красоты
                //данные теста
                File.Create(@"C:/data_orientiring/users_test/logs/ispicture.txt").Close();
                File.Create(@"C:/data_orientiring/users_test/logs/muchquestion.txt").Close();
                File.Create(@"C:/data_orientiring/users_test/logs/name.txt").Close();
                File.WriteAllText(@"C:/data_orientiring/users_test/logs/coach_name.txt", File.ReadAllText($@"C:/data_orientiring/users_test/{name}/coach_name.txt"));
                File.WriteAllText(@"C:/data_orientiring/users_test/logs/data_over.txt", File.ReadAllText($@"C:/data_orientiring/users_test/{name}/time_over.txt"));
                File.WriteAllText(@"C:/data_orientiring/users_test/logs/all_time.txt", File.ReadAllText($@"C:/data_orientiring/users_test/{name}/all_time.txt"));
                string data = File.ReadAllText(@"C:/data_orientiring/users_test/logs/data_over.txt");
                //-------------------------
                //определяем, закончился ли срок действия теста
                string[] nums_s = data.Split('.', ':', ' ');
                int[] nums_i = new int[nums_s.Length]; ;
                for (int i = 0; i < nums_s.Length; i++)
                {
                    nums_i[i] = Convert.ToInt32(nums_s[i]);
                }
                DateTime dateover = new DateTime(nums_i[2], nums_i[1], nums_i[0], nums_i[3], nums_i[4], 00);//создаем новый объект структуры datetime с данными о завершении теста
                DateTime now = new DateTime();
                now = DateTime.Now;//текущее время
                if (now.AddMinutes(1) > dateover)//определяем, вышло ли время на тест
                {
                    DialogResult result = MessageBox.Show("Извините, срок действия этого теста уже закончился.\nУдалить его?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(dir);
                    }
                    Directory.Delete(@"C:/data_orientiring/users_test/logs",true);
                }
                //---------------------------------------------------
                else
                {
                    //данные для теста
                    int muchquestion = 0;
                    bool isphoto = false;
                    DirectoryInfo direct = new DirectoryInfo($@"C:/data_orientiring/users_test/{name}");//создание переменной для пути к файлу
                    foreach (var item in direct.GetDirectories())//проход по всем папками в только что созданной переменной
                    {
                        muchquestion++;
                        if (!isphoto)
                        {
                            try//определяем есть ли фото в файле методом копирования до исключения
                            {
                                File.Copy($@"C:/data_orientiring/users_test/{name}/{muchquestion}/photo.png", $@"C:/data_orientiring/users_test/{name}/{muchquestion}/photo1.png");
                                isphoto = true;
                                File.Delete($@"C:/data_orientiring/users_test/{name}/{muchquestion}/photo1.png");
                            }
                            catch
                            {

                            }
                        }
                    }
                    File.WriteAllText(@"C:/data_orientiring/users_test/logs/muchquestion.txt", Convert.ToString(muchquestion));
                    if (isphoto)
                    {
                        File.WriteAllText(@"C:/data_orientiring/users_test/logs/ispicture.txt", "true");
                    }
                    else
                    {
                        File.WriteAllText(@"C:/data_orientiring/users_test/logs/ispicture.txt", "false");
                    }
                    File.WriteAllText(@"C:/data_orientiring/users_test/logs/name.txt", Convert.ToString(name));
                    //---------------------------------------
                    //вывод данных пользователю
                    much_question_label.Text = File.ReadAllText(@"C:/data_orientiring/users_test/logs/muchquestion.txt");
                    if (File.ReadAllText(@"C:/data_orientiring/users_test/logs/ispicture.txt") == "false")
                    {
                        label_have_pictures.Text = "нет";
                    }
                    else
                    {
                        label_have_pictures.Text = "есть";
                    }
                    name_label.Text = File.ReadAllText(@"C:/data_orientiring/users_test/logs/name.txt");
                    coach_name.Text = File.ReadAllText(@"C:/data_orientiring/users_test/logs/coach_name.txt");
                    time_for_test.Text = File.ReadAllText(@"C:/data_orientiring/users_test/logs/all_time.txt");
                    //включаем все кнопки
                    start.Enabled = true;
                    choosetest.Visible = true;
                    pass_text_Box.Visible = true;
                    File.Delete($@"C:/data_orientiring/users_test/{name}.zip");//удаляем файл для красоты
                }
            }

            else
            {
                //если пароль не введен, сообщаем об этом
                MessageBox.Show("Сначала введите пароль","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ready_test_Load(object sender, EventArgs e)
        {
            start.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?\nВсе данные будут удалены.", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Directory.Exists(@"C:/data_orientiring/users_test/logs"))
                {
                    Directory.Delete(@"C:/data_orientiring/users_test/logs", true);
                }
                choosetest a = new choosetest();
                a.Show();
                this.Hide();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            ready_test_go a = new ready_test_go();
            a.Show();
            this.Hide();
        }

        private void pass_text_Box_Enter(object sender, EventArgs e)
        {
            pass_text_Box.Text = "";
        }

        private void pass_text_Box_Leave(object sender, EventArgs e)
        {
            if (pass_text_Box.Text == "")
            {
                pass_text_Box.Text = "Введите пароль";
            }
        }
    }
}
