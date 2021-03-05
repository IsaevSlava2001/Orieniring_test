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
    public partial class test_create : Form
    {
        public Image image;
        OpenFileDialog openDialog = new OpenFileDialog();
        public string name;
        public bool pict;
        public int count;
        public int local_count = 1;
        public int true_ans;
        public string rar_to;
        public static string num;
        public string date_over;
        public test_create()
        {
            InitializeComponent();
        }
        
        private void test_create_Load(object sender, EventArgs e)
        {
            //считваем необходимые данные из логов и создаем переменных
            pass_textBox.Visible = false;
            zipbutton.Visible = false;
            progressBarconv.Visible = false;
            button_conv.Visible = false;
            DirectoryInfo dir = new DirectoryInfo(@"C:/data_orientiring/users_test/logs");
            FileStream f1 = new FileStream($@"{dir}/numb.txt",FileMode.Open);
            FileStream f2 = new FileStream($@"{dir}/havepict.txt",FileMode.Open);
            FileStream f3 = new FileStream($@"{dir}/name.txt", FileMode.Open);
            StreamReader r1 = new StreamReader(f1);
            StreamReader r2 = new StreamReader(f2);
            StreamReader r3 = new StreamReader(f3);
            name = r3.ReadToEnd();
            pict = Convert.ToBoolean(r2.ReadToEnd());
            count = Convert.ToInt32(r1.ReadToEnd());
            if(!pict)
            {
                label1.Visible = false;
                img_textBox.Visible = false;
                button1.Visible = false;
            }
            f1.Close();
            f2.Close();
            f3.Close();
            r1.Close();
            r2.Close();
            r3.Close();
            date_over = File.ReadAllText(@"C:/data_orientiring/users_test/logs/date_over.txt");
            Directory.CreateDirectory(@"C:/data_orientiring/users_test/local_test");
            Directory.CreateDirectory($@"C:/data_orientiring/users_test/local_test/{name}");
            Directory.CreateDirectory($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}");
        }
        //-------------------------------------------------------------

        private void save_Click(object sender, EventArgs e)
        {
            //проверяем сколько кнопок заполнено
            string img = img_textBox.Text;
            int max;
                if (ans_TB_5.Text == "")
                {
                    if (ans_TB_4.Text == "")
                    {
                        if (ans_TB_3.Text == "")
                        {
                            if (ans_TB_2.Text == "")
                            {
                            //если заполнено только одно поле сообщаем об этом
                                MessageBox.Show("Заполните хотя бы два поля для ответов","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                max = 1;
                            }
                            else
                            {
                                max = 2;
                            }
                        }
                        else
                        {
                            max = 3;
                        }
                    }
                    else
                    {
                        max = 4;
                    }
                }
                else
                {
                    max = 5;
                }
            if (max != 1)
            {
                //отключаем/включаем нужные чекбоксы
                if (radioButton1.Checked == true)
                {
                    recheck_rb(1);
                }
                if (radioButton2.Checked == true)
                {
                    recheck_rb(2);
                }
                if (radioButton3.Checked == true)
                {
                    recheck_rb(3);
                }
                if (radioButton4.Checked == true)
                {
                    recheck_rb(4);
                }
                if (radioButton5.Checked == true)
                {
                    recheck_rb(5);
                }
                //--------------------------------------
                if (true_ans <= max)
                {
                    //если выбран ответ, который заполнен
                    if (quest_text_box.Text != "")
                    {
                        //если вопрос не пуст, то создаем нужные папки
                        Directory.CreateDirectory($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}");
                        File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}/q.txt", quest_text_box.Text);
                        File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}/r.txt", Convert.ToString(true_ans));
                        File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/time_over.txt", date_over);
                        File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/coach_name.txt",File.ReadAllText(@"C:/data_orientiring/name/coach_name.txt"));
                        File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/all_time.txt", File.ReadAllText($@"C:/data_orientiring/users_test/logs/all_time.txt"));
                        if (img != "")//если картинка есть
                        {
                            //копируем ее в нужную папку
                            string[] a = img.Split('.');
                            File.Copy(img, $@"C:/data_orientiring/users_test/local_test/{name}/{local_count}/photo.{a[a.Length-1]}");
                        }
                        //создаем папки и заполняем их
                        Directory.CreateDirectory($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}/ans");
                        string[] answers = new string[max + 1];
                        try
                        {
                            //пытаемся заполнить масисив
                            answers[1] = ans_TB_1.Text;
                            answers[2] = ans_TB_2.Text;
                            answers[3] = ans_TB_3.Text;
                            answers[4] = ans_TB_4.Text;
                            answers[5] = ans_TB_5.Text;
                        }
                        catch//ждем исключений
                        {

                        }
                        //заполняем файлы
                        int num_skip=1;
                        for (int i = 1; i != max + 1; i++)
                        {
                            File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}/ans/{i}.txt", answers[i]);
                            num_skip++;
                        }
                        File.WriteAllText($@"C:/data_orientiring/users_test/local_test/{name}/{local_count}/ans/{num_skip}.txt", "пропустить вопрос");//заполняем последний ответ
                        recheck_rb(0);//отключаем все чекбоксы
                        if (img_textBox.Text != "")//убираем картинку, если нужно
                        {
                            img_textBox.Text = "";
                        }
                        //убираем текст в полях
                        ans_TB_1.Text = "";
                        ans_TB_2.Text = "";
                        ans_TB_3.Text = "";
                        ans_TB_4.Text = "";
                        ans_TB_5.Text = "";
                        quest_text_box.Text = "";
                        //------------------------
                        local_count++;//увеличиваем номер вопроса
                        num_q_lab.Text = "Вопрос " + local_count;

                        if (local_count == count+1)//если введен последний вопрос
                        {
                            //отключаем все и включаем запись массива
                            quest_text_box.Enabled = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            radioButton3.Enabled = false;
                            radioButton4.Enabled = false;
                            radioButton5.Enabled = false;
                            ans_TB_1.Enabled = false;
                            ans_TB_2.Enabled = false;
                            ans_TB_3.Enabled = false;
                            ans_TB_4.Enabled = false;
                            ans_TB_5.Enabled = false;
                            num_q_lab.Enabled = false;
                            label1.Enabled = false;
                            img_textBox.Enabled = false;
                            button1.Enabled = false;
                            label2.Enabled = false;
                            label3.Enabled = false;
                            save.Enabled = false;
                            pass_textBox.Visible = true;
                            zipbutton.Visible = true;
                            progressBarconv.Visible = true;
                            button_conv.Visible = true;
                            button_conv.Enabled = false;
                            save.Visible = false;
                            //----------------------------------
                            if (Directory.Exists(@"C:\data_orientiring\users_test\logs"))
                            {
                                Directory.Delete(@"C:\data_orientiring\users_test\logs", true);//удаляем логи, если нужно
                            }
                        }
                    }
                    //сообщения об ошибках
                    else
                    {
                        MessageBox.Show("Введите вопрос!","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите правильным ответом тот, который заполнен","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                //---------------------------------
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//выбираем картинку
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";//фильтр расширения
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                image = Image.FromFile(openDialog.FileName);//пытаемся скопировать картинку
            }
            catch (OutOfMemoryException ex)//ждем ошибку превышения памяти
            {
                MessageBox.Show("Ошибка чтения картинки","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            img_textBox.Text = openDialog.FileName;//выводим информацию о картике в поле
        }
        public void recheck_rb(int i)
        {
            //включаем/выключаем нужые чекбоксы
            switch(i)
            {
                case 0:

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    true_ans = 1;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    true_ans = 2;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    true_ans = 3;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    radioButton5.Checked = false;
                    true_ans = 4;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = true;
                    true_ans = 5;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    true_ans = 6;
                    break;
            }
            //---------------------------------------
        }

        private void zipbutton_Click(object sender, EventArgs e)
        {
            //место сохранения файла
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите место для файла с тестом";//ткст, котрый будет в поле
            if(fbd.ShowDialog()==DialogResult.OK)//когда место выбрано
            {
                rar_to = fbd.SelectedPath;//записываем информацию о месте  сохранения
            }
            button_conv.Enabled = true;//включаем кнопку конвертировать
        }

        private void button_conv_Click(object sender, EventArgs e)
        {
            if(pass_textBox.Text==""||pass_textBox.Text=="пароль для архива")//если пароль не изменен
            {
                MessageBox.Show("Введите пароль","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);//сообщаем об этом
            }
            else
            {
                using (ZipFile zip = new ZipFile(Encoding.GetEncoding("cp866")))//используем библиотеку ionic.zip
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;//уровень сжатия
                    zip.Password = pass_textBox.Text;//записываем пароль
                    zip.AddDirectory($@"C:/data_orientiring/users_test/local_test/{name}");//добавляем папку назначения
                    zip.SaveProgress += Zip_SaveProgress;//обновляем прогрессбар
                    zip.Save($@"{rar_to}/{name}.zip");//сохраняем
                }
                File.Move($@"{rar_to}/{name}.zip", $@"{rar_to}/{name}.tso");//переименовываем для красоты
                File.Delete($@"{rar_to}/{name}.zip");//удаляем zip-файл для красоты
                MessageBox.Show("Тест создан","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Information);//сообщаем, что тест создан
            }
        }
        private void Zip_SaveProgress(object sender,Ionic.Zip.SaveProgressEventArgs e)//метод для обновления данных 
        {
            if(e.EventType==Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)//если поступили новые данные
            {
                progressBarconv.Invoke(new MethodInvoker(delegate//обновляем поле новым делегатом
               {
                   progressBarconv.Maximum = e.EntriesTotal;//максимум-все данные
                   progressBarconv.Value = e.EntriesSaved + 1;//текущиая-количество сохраненных
               }
                ));
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //выход с подтверждением и удалением логов если нужно
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?","Внимание!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (Directory.Exists(@"C:\data_orientiring\users_test\logs"))
                {
                    Directory.Delete(@"C:\data_orientiring\users_test\logs", true);
                }
                test_create_settings a = new test_create_settings();
                a.Show();
                this.Hide();
                //------------------------------------
            }
        }

        private void pass_textBox_Enter(object sender, EventArgs e)
        {
            //фокус на пароле
            pass_textBox.Text = "";
        }

        private void pass_textBox_Leave(object sender, EventArgs e)
        {
            //покидание пароля
            if (pass_textBox.Text == "")
            {
                pass_textBox.Text = "пароль для архива";
            }
        }
    }
}
