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
    public partial class student_registr : Form
    {

        public string path = Directory.GetCurrentDirectory();
        public student_registr()
        {
            InitializeComponent();
        }

        private void student_registr_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            //фокус на форме ввода
            if (nametextBox.Text.Equals("введите имя и фамилию"))
            {
                nametextBox.Text = "";
            }

        }

        private void nametextBox_Leave(object sender, EventArgs e)
        {
            //покидание формы ввода
            if (nametextBox.Text.Equals(""))
            {
                nametextBox.Text = "введите логин";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nametextBox.Text == "введите имя и фамилию" || nametextBox.Text == "\0" || nametextBox.Text == "" || nametextBox.Text == "Введите логин" || nametextBox.Text == "введите логин")
            {
                //если в поле нет данных, сообщаем об этом
                MessageBox.Show("Введите ваши данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nametextBox.Text = "";
                return;
            }

            else
            {
                //иначе уточняем не ошибся ли пользователь и переходим на новую форму
                string name = nametextBox.Text;
                DialogResult result=MessageBox.Show("Вас действительно зовут "+name+"? Если да, нажмите да. Иначе, нажмите нет", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!Directory.Exists(@"C:\data_orientiring\name"))//если папки для пользователя нет, создаем ее
                    {
                        Directory.CreateDirectory(@"C:\data_orientiring");
                        Directory.CreateDirectory(@"C:\data_orientiring\name");
                        File.Create(@"C:\data_orientiring\name\name.txt").Close();
                        File.WriteAllText(@"C:\data_orientiring\name\name.txt", name);
                        choosetest f = new choosetest();
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        //иначе уточняем, хочет ли пользователь удалить все данные, и, если хочет, удаляем и пересоздаем имя
                        DialogResult result1 = MessageBox.Show("Вы хотите перезаписать имя и удалить все данные?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            string name1 = nametextBox.Text;
                            Directory.Delete(@"C:\data_orientiring\name",true);
                            Directory.CreateDirectory(@"C:\data_orientiring\name");
                            File.WriteAllText(@"C:\data_orientiring\name\name.txt", name1);
                            choosetest f = new choosetest();
                            f.Show();
                            this.Close();
                        }
                        else
                        {
                            //иначе переходим на форму
                            choosetest f = new choosetest();
                            f.Show();
                            this.Close();
                        }
                    }
                }
                else
                {
                    //если пользователь говорит, что ошибся, возвращаем строку
                    nametextBox.Text = "введите имя и фамилию";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
