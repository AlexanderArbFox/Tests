using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Тестирование
{
    public partial class RedactTests : Form
    {
        string fl = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\Animaals.txt";
        string prav = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\BehaviorMain.txt"; // таблица правила поведения
        string mul = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\Mult.txt";
        string phis = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\Phisiksa.txt";
        string Geo = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\Geography.txt";
        string hist = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\AllQuestion\Historic.txt";
        StreamWriter sw;
        StreamReader sr;

        public RedactTests()
        {
            InitializeComponent();
        }

        #region работа с Мультиками

       private void btnDownlMult_Click(object sender, EventArgs e)
        {
            listMult.Items.Clear();
            using (StreamReader r = new StreamReader(mul, Encoding.UTF8))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listMult.Items.Add(line);

                }
            }
        }

        private void btnAddsMults_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(mul)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtQuestAddsMult.Text);
                sw.WriteLine(txtTrueAskAddsMult.Text);
                sw.WriteLine(txtAskAddsMult1.Text);
                sw.WriteLine(txtAskAddsMult2.Text);
                sw.WriteLine(txtAskAddsMult3.Text);
                sw.Close(); // останавливаем поток 
            }

            if ((txtQuestAddsMult.Text.Equals("")) || (txtTrueAskAddsMult.Text.Equals("")) || (txtAskAddsMult1.Text.Equals("")) || (txtAskAddsMult2.Text.Equals("")) || (txtAskAddsMult3.Text.Equals(""))) // проверка на заполненость полей
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            clmul();
        }

       private void btnDelMult_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(mul).ToList();
                lines.Add("");
                lines.RemoveAt(listMult.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(mul, string.Join(Environment.NewLine, lines));

                listMult.ClearSelected();
                listMult.Items.Clear();

                StreamReader streamReader = new StreamReader(mul); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listMult.Items.Add(str);
                }
                streamReader.Close();
            }

            catch (Exception ex)
            {
            }
        }


        private void clmul()
        {
            txtQuestAddsMult.Text = "";
            txtTrueAskAddsMult.Text = "";
            txtAskAddsMult1.Text = "";
            txtAskAddsMult2.Text = "";
            txtAskAddsMult3.Text = "";

        }

      
        #endregion

        #region работа с Животными

        private void btnDownlAnimal_Click(object sender, EventArgs e)
        {
            listAnimal.Items.Clear();
            using (StreamReader r = new StreamReader(fl, Encoding.UTF8))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listAnimal.Items.Add(line);

                }
            }
        }
        
       
        private void btnDelAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(fl).ToList();
                lines.Add("");
                lines.RemoveAt(listAnimal.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(fl, string.Join(Environment.NewLine, lines));

                listAnimal.ClearSelected();
                listAnimal.Items.Clear();

                StreamReader streamReader = new StreamReader(fl); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listAnimal.Items.Add(str);
                }
                streamReader.Close();
            }

            catch (Exception ex)
            {
            }
        }
        
     
        private void btnAddst_Click(object sender, EventArgs e) // добавить для Постарше
        {

            using (sw = File.AppendText(fl)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtQuest.Text);
                sw.WriteLine(txtAnswer1.Text);
                sw.WriteLine(txtAnswer2.Text);
                sw.WriteLine(txtAnswer3.Text);
                sw.WriteLine(txtAnswer4.Text);
                sw.Close(); // останавливаем поток 
            }

            if ((txtQuest.Text.Equals("")) || (txtAnswer1.Text.Equals("")) || (txtAnswer2.Text.Equals("")) || (txtAnswer3.Text.Equals("")) || (txtAnswer4.Text.Equals(""))) // проверка на заполненость полей
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            cls();
        }

        
       private void cls()
        {
           txtQuest.Text = "";
            txtAnswer1.Text = "";
            txtAnswer2.Text = "";
            txtAnswer3.Text = "";
            txtAnswer4.Text = "";
        }

        

        
       
        #endregion


        #region География
        private void btnDownlGeo_Click(object sender, EventArgs e)
        {
            listGeograph.Items.Clear();
            using (StreamReader r = new StreamReader(Geo, Encoding.UTF8))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                    listGeograph.Items.Add(line);

                    }
                }
            
        }

        private void btnAddGeo_Click(object sender, EventArgs e) // Добавление в файл Географии
        {

            using (sw = File.AppendText(Geo)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtQuestionAddGeo.Text);
                sw.WriteLine(txtTrueAskGeo.Text);
                sw.WriteLine(txtFalseAskGeo1.Text);
                sw.WriteLine(txtFalseAskGeo2.Text);
                sw.WriteLine(txtFalseAskGeo3.Text);
                sw.Close(); // останавливаем поток 
            }

            if ((txtQuestionAddGeo.Text.Equals("")) || (txtTrueAskGeo.Text.Equals("")) || (txtFalseAskGeo1.Text.Equals("")) || (txtFalseAskGeo2.Text.Equals("")) || (txtFalseAskGeo3.Text.Equals(""))) // проверка на заполненость полей
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            clGeo();
        }

        private void clGeo()
        {
            txtQuestionAddGeo.Text = "";
            txtTrueAskGeo.Text = "";
            txtFalseAskGeo1.Text = "";
            txtFalseAskGeo2.Text = "";
            txtFalseAskGeo3.Text = "";
        }

       

        private void btnDelGeo_Click(object sender, EventArgs e) // Удаление строки с перезаписью файла
        {
                try
                {
                    List<string> lines = File.ReadLines(Geo).ToList();
                    lines.Add("");
                    lines.RemoveAt(listGeograph.SelectedIndex); // удалить выбранную строку
                    File.WriteAllText(Geo, string.Join(Environment.NewLine, lines));

                    listGeograph.ClearSelected();
                    listGeograph.Items.Clear();

                    StreamReader streamReader = new StreamReader(Geo); //Открываем файл для чтения
                    string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                    while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                    {
                        str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                        listGeograph.Items.Add(str);
                    }
                    streamReader.Close();
                }

                catch (Exception ex)
                {
                }
            }

        #endregion

        #region История

        private void btnAddsHistory_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(hist)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAddsQuestHistory.Text);
                sw.WriteLine(txtHistory1.Text);
                sw.WriteLine(txtHistory2.Text);
                sw.WriteLine(txtHistory3.Text);
                sw.WriteLine(txtHistory4.Text);
                sw.Close(); // останавливаем поток 
            }

            if ((txtAddsQuestHistory.Text.Equals("")) || (txtHistory1.Text.Equals("")) || (txtHistory2.Text.Equals("")) || (txtHistory3.Text.Equals("")) || (txtHistory4.Text.Equals(""))) // проверка на заполненость полей
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            clHis();
        }

        private void btnDownlHistory_Click(object sender, EventArgs e)
        {
            listHistory.Items.Clear();
            using (StreamReader r = new StreamReader(hist, Encoding.UTF8))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listHistory.Items.Add(line);

                }
            }
        }

        private void btnDelHistory_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(hist).ToList();
                lines.Add("");
                lines.RemoveAt(listHistory.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(hist, string.Join(Environment.NewLine, lines));

                listHistory.ClearSelected();
                listHistory.Items.Clear();

                StreamReader streamReader = new StreamReader(hist); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listHistory.Items.Add(str);
                }
                streamReader.Close();
            }

            catch (Exception ex)
            {
            }
        }

       

        private void clHis()
        {
            txtAddsQuestHistory.Text = "";
            txtHistory1.Text = "";
            txtHistory2.Text = "";
            txtHistory3.Text = "";
            txtHistory4.Text = "";
        }

      

        #endregion

        #region Физика

        private void btnDownlPhis_Click(object sender, EventArgs e)
        {
            listPhisiks.Items.Clear();
            using (StreamReader r = new StreamReader(phis, Encoding.UTF8))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listPhisiks.Items.Add(line);
                }
            }
        }

         private void btnAddsPhisik_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(phis)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtPhisik1.Text);
                sw.WriteLine(txtPhisik2.Text);
                sw.WriteLine(txtPhisik3.Text);
                sw.WriteLine(txtPhisik4.Text);
                sw.WriteLine(txtPhisik5.Text);
                sw.Close(); // останавливаем поток 
            }

            if ((txtPhisik1.Text.Equals("")) || (txtPhisik2.Text.Equals("")) || (txtPhisik3.Text.Equals("")) || (txtPhisik4.Text.Equals("")) || (txtPhisik5.Text.Equals(""))) // проверка на заполненость полей
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            clPhis();
        }

        private void btnDelPhisik_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(phis).ToList();
                lines.Add("");
                lines.RemoveAt(listPhisiks.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(phis, string.Join(Environment.NewLine, lines));

                listPhisiks.ClearSelected();
                listPhisiks.Items.Clear();

                StreamReader streamReader = new StreamReader(phis); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listPhisiks.Items.Add(str);
                }
                streamReader.Close();
            }

            catch (Exception ex)
            {
            }
        }

        private void clPhis()
        {
            txtPhisik1.Text = "";
            txtPhisik2.Text = "";
            txtPhisik3.Text = "";
            txtPhisik4.Text = "";
            txtPhisik5.Text = "";
        }

       

        #endregion

        #region  Реализуем  Действия с таблицей Правила поведения

        private void btnAddsPravilo_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(prav)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAddsPrav.Text);
                sw.Close(); // останавливаем поток 
            }

            if ((txtAddsPrav.Text.Equals("")) ) // проверка на заполненость полей
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            txtAddsPrav.Text = "";
        }

        private void btnDelPravilo_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(prav).ToList();
                lines.Add("");
                lines.RemoveAt(listPravilo.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(prav, string.Join(Environment.NewLine, lines));

                listPravilo.ClearSelected();
                listPravilo.Items.Clear();

                StreamReader streamReader = new StreamReader(prav); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listPravilo.Items.Add(str);
                }
                streamReader.Close();
            }

            catch (Exception ex)
            {
            }
        }

        private void btnDownlPravilo_Click(object sender, EventArgs e)
        {
            listPravilo.Items.Clear();
            using (StreamReader r = new StreamReader(prav, Encoding.UTF8))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listPravilo.Items.Add(line);
                }
            }
        }

   

                   
        #endregion

    }
    }

    


