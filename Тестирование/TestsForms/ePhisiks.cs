﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
    public partial class ePhisiks : Form
    {
        string phi = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\Phisiksa.txt";
        string[,] mass;
        int total, numberQuestion, trueAsk, falseAsk;
        static Random rand = new Random();
        Timer myTimer = new Timer();
        int timeLeft = 420;
        Registration reg = new Registration();
        public ePhisiks()
        {
            InitializeComponent();
            this.ControlBox = false;
            initializationTxt();
            tim();
        }
        private void initializationTxt()
        {
            numberQuestion = 10; // количество вопросов, которые будут отбражены в программе
            trueAsk = 0;
            falseAsk = 0;
            Downl();
            rbtnChecked();
            numberQuestion--;
            allQuestions();
        }

        private void btnNextQustions_Click(object sender, EventArgs e)
        {
            if (numberQuestion < 0) { initializationTxt();  return; }

            if (!(rbtnFirst.Checked || rbtnSecond.Checked || rbtnThird.Checked || rbtnFourth.Checked)) // если не отмечен рбтн, Ошибка
            {
                MessageBox.Show("Выберите вариант ответа");
                return;
            }
            if ((rbtnFirst.Checked & Convert.ToInt16(rbtnFirst.Tag) == 1) || // если мы сделали правильный выбор
                (rbtnSecond.Checked & Convert.ToInt16(rbtnSecond.Tag) == 1) ||
                (rbtnThird.Checked & Convert.ToInt16(rbtnThird.Tag) == 1) ||
                 (rbtnFourth.Checked & Convert.ToInt16(rbtnFourth.Tag) == 1))
            {
                trueAsk++; // вопрос засчитан как праильный
                numberQuestion--; // количество вопросов -1
            }
            else
            {
                MessageBox.Show("Правильный вариант ответа: " + mass[numberQuestion, 1]);
                falseAsk++;
                numberQuestion--;
            }
            if (numberQuestion < 0)
            {
                gameIsend();
                return;
            }
            allQuestions();
        }

        private void Downl()
        {
            try
            {

                string[] lines = File.ReadAllLines(phi, Encoding.UTF8);
                total = lines.Length / 5; // считывание по 5 строк
                mass = new string[numberQuestion, 5];

                int[] temp = new int[numberQuestion]; // создание массива вопросов
                int j; // 5
                int k = 0;
                do
                {
                    j = rand.Next(0, total) * 5;
                    if (!temp.Contains(j)) // возвращает true, если соответствует условиям
                    {
                        mass[k, 0] = lines[j];
                        for (int i = 1; i < 5; i++)
                            mass[k, i] = lines[j + i];
                        temp[k] = j;
                        k++;
                    }
                }
                while (!(k == numberQuestion));
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allQuestions()
        {
            lbIsQuestion.Text = "Вопросов осталось " + numberQuestion + " из 10"; //отображение номера вопроса
            rbtnChecked();
            lbQuestr.Text = mass[numberQuestion, 0];
            radio_tags(rand.Next(1, 9)); // разное отображение вопросов
            rbtnFirst.Text = mass[numberQuestion, Convert.ToInt16(rbtnFirst.Tag)];
            rbtnSecond.Text = mass[numberQuestion, Convert.ToInt16(rbtnSecond.Tag)];
            rbtnThird.Text = mass[numberQuestion, Convert.ToInt16(rbtnThird.Tag)];
            rbtnFourth.Text = mass[numberQuestion, Convert.ToInt16(rbtnFourth.Tag)];
        }

        private void btnEnds_Click(object sender, EventArgs e)
        {
            MyNowResults results = new MyNowResults();
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите завершить тестирование?", "Внимание!", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                gameIsend();
            }
            else if (dialog == DialogResult.Cancel)
            {
            }
        }

        private void timeStart_Tick(object sender, EventArgs e)
        {
            lbTimeStart.Text = timeLeft.ToString();
            timeLeft -= 1;

            if (timeLeft < 0 )
            {
                myTimer.Stop();
                gameIsend();
            }
        }

        private void rbtnChecked()
        {
            rbtnFirst.Checked = false;
            rbtnSecond.Checked = false;
            rbtnThird.Checked = false;
            rbtnFourth.Checked = false;
        }

        private void ePhisiks_Load(object sender, EventArgs e)
        {
            myTimer.Enabled = true;
       
        }

        private void radio_tags(int i) // вариации для отображения вопросов
        {
            switch (i)
            {
                case 1: rbtnFirst.Tag = 1; rbtnSecond.Tag = 2; rbtnThird.Tag = 3; rbtnFourth.Tag = 4; break;
                case 2: rbtnFirst.Tag = 1; rbtnSecond.Tag = 3; rbtnThird.Tag = 2; rbtnFourth.Tag = 4; break;
                case 3: rbtnFirst.Tag = 2; rbtnSecond.Tag = 1; rbtnThird.Tag = 3; rbtnFourth.Tag = 4; break;
                case 4: rbtnFirst.Tag = 2; rbtnSecond.Tag = 3; rbtnThird.Tag = 1; rbtnFourth.Tag = 4; break;
                case 5: rbtnFirst.Tag = 3; rbtnSecond.Tag = 1; rbtnThird.Tag = 2; rbtnFourth.Tag = 4; break;
                case 6: rbtnFirst.Tag = 3; rbtnSecond.Tag = 2; rbtnThird.Tag = 1; rbtnFourth.Tag = 4; break;
                case 7: rbtnFirst.Tag = 3; rbtnSecond.Tag = 4; rbtnThird.Tag = 1; rbtnFourth.Tag = 2; break;
                case 8: rbtnFirst.Tag = 4; rbtnSecond.Tag = 3; rbtnThird.Tag = 2; rbtnFourth.Tag = 1; break;
            }
        }

        public void tim()
        {
            myTimer.Interval = 1000;
            myTimer.Enabled = true;
            myTimer.Tick += timeStart_Tick;
            myTimer.Start();
            lbTimeStart.Text = timeLeft.ToString();
        }

        public void gameIsend() // Функция, которая выполняет действия, в случае, если игра прекращается
        {
            MyNowResults results = new MyNowResults();
            try
            {
                using (Context db = new Context())
                {
                    reg = db.Registrations.Where(d => d.Login == Avtorization.logginO).FirstOrDefault(); // Добавление Баллов
                    reg.Score += trueAsk;
                    db.InfoPlayers.Add(new InfoPlayer { Id_игрока = reg.id, id_достижения = 23, Наличие = true });
                    db.SaveChanges();
                }
            }
            catch
            {
            }
            results.Show();
            results.listBoxTrue.Items.Add(trueAsk.ToString()); // вывод кол-ва верных ответов
            results.listBoxFalse.Items.Add(falseAsk.ToString()); // вывод кол-ва неверных ответов
            btnNextQustions.Visible = false;
            this.Hide();
        }
    }
}
