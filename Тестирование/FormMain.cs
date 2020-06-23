using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Globalization;
using System.Data.Entity.Infrastructure;
using Тестирование.Properties;

namespace Тестирование
{
    public partial class FormApps : Form
    {
        Random rnd = new Random();
        int firstPolite; // переменная к массиву Вежливости
        int firstMultiplication; // переменная к массиву умножения
        String title = "Вопрошайка";
        String curTitle;
        int multyInts;
        string[] str;
        int[] maas = new int[11];
        string knowl = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\BehaviorMain.txt";
        List<string> lines = new List<string>();
        int total;
        string[] sl;
        int[,] mas;
        public static int UsScoore;

        public FormApps()
        {
            InitializeComponent();
            this.Text = ""; //отвечает за надпись текста на форме
            curTitle = "";
            listBoxMultiplication.DrawMode = DrawMode.OwnerDrawFixed; // Выравниваем таблицу умножения по центру
            listBoxMultiplication.DrawItem += listBoxMultiplication_DrawItem;// Выравниваем таблицу умножения по центру
            GetMyScore();
            ser();
        }

        private void FormApps_Load(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            MultiplicationPage(multyInts);
            GetMyScore();
        }

        public void GetMyScore() // Функция отображения количества очков
        {
            try
            {
                using (Context db = new Context())
                {
                    string sfa;
                    sfa = Avtorization.logginO; // переменная с формы авторизации
                    Registration user = db.Registrations.Where(d => d.Login == Avtorization.logginO).FirstOrDefault();
                    UsScoore = (int)user.Score;
                    Settings.Default.Score = UsScoore;
                    Settings.Default.Save();
                    ImageScore.Visible = true;
                    lbScore.Text = Settings.Default.Score.ToString();
                }
            }
            catch
            {
            }
        }

        #region кнопки открытия формы
        private void информацияОРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            SelectedAge selectedAge = new SelectedAge(); // открытие формы "Начать"
            selectedAge.Show();
            this.Hide();
        }

        private void btnExitAvtoriz_Click(object sender, EventArgs e)
        {
            Avtorization avtorization = new Avtorization();// открытие формы "Авторизация"
            avtorization.Show();
            this.Hide();
        }

        private void бонусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BonusForm bonusForm = new BonusForm();
            bonusForm.Show();

        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsAllPlayers resultsAll = new ResultsAllPlayers();
            resultsAll.Show();
        }


        private void btnGameEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Show();
            this.Hide();
        }
        private void FormApps_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // полное закрытие приложения
        }
        #endregion


        #region  Правила поведения
       
        private void ser()
        {
            int[] n = new int[4]; 
            n[0] = 0;
            n[1] = 1;
            n[2] = 2;
            n[3] = 3;
            lbPraviloPoved.Text = File.ReadAllLines(knowl)[n[0]];
            lbNum2.Text = File.ReadAllLines(knowl)[n[1]];
            lbNum3.Text = File.ReadAllLines(knowl)[n[2]];
            lbNum4.Text = File.ReadAllLines(knowl)[n[3]];
            

        }
        #endregion

        #region Таблица умножения
        public void MultiplicationPage(int multyInts) // Массив таблицы умножения
        {
            int numMulty = multyInts + 1;
                for (multyInts = 1; multyInts < 11; multyInts++)
            {
                    maas[0] = listBoxMultiplication.Items.Add("1*" + multyInts + "=" + (1 * multyInts).ToString());
                    maas[1] = listBoxMultiplication.Items.Add("2*" + multyInts + "=" + (2 * multyInts).ToString());
                    maas[2] = listBoxMultiplication.Items.Add("3*" + multyInts + "=" + (3 * multyInts).ToString());
                    maas[3] = listBoxMultiplication.Items.Add("4*" + multyInts + "=" + (4 * multyInts).ToString());
                    maas[4] = listBoxMultiplication.Items.Add("5*" + multyInts + "=" + (5 * multyInts).ToString());
                    maas[5] = listBoxMultiplication.Items.Add("6*" + multyInts + "=" + (6 * multyInts).ToString());
                    maas[6] = listBoxMultiplication.Items.Add("7*" + multyInts + "=" + (7 * multyInts).ToString());
                    maas[7] = listBoxMultiplication.Items.Add("8*" + multyInts + "=" + (8 * multyInts).ToString());
                    maas[8] = listBoxMultiplication.Items.Add("9*" + multyInts + "=" + (9 * multyInts).ToString());
                    maas[9] = listBoxMultiplication.Items.Add("10*" + multyInts + "=" + (10 * multyInts).ToString());
                }
            }
        
      

         private void listBoxMultiplication_DrawItem(object sender, DrawItemEventArgs e) // Выравниваем таблицу умножения по центру
        {
            TextRenderer.DrawText(e.Graphics, listBoxMultiplication.Items[e.Index].ToString(), e.Font,
                e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }
        #endregion


        private void timerText_Tick(object sender, EventArgs e) // задаем таймер со скоростью движения текста заголовка
        {
            if (curTitle.Length == title.Length) curTitle = "";
            curTitle += title[curTitle.Length];
            this.Text = curTitle;
        }

        private void MusOffMenu_Click(object sender, EventArgs e) // Работа с музыкой в приложении
        {
            Sounds_Class sc = new Sounds_Class();
            if (MusOffMenu.Enabled = true) // Подключаем функцию по отключению звука
            {
                MusOffMenu.Text = "Отключить музыку";
                sc.MusOffeded();
            }
            else if(!MusOffMenu.Enabled) // Включаем звук
            {
                MusOffMenu.Text = "Включить музыку";
                sc.MainMusiik();
            }
            return;
        }

      
    }
}
