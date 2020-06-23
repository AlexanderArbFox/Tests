using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
    public partial class RedactMaterial : Form
    {
        string line;
        string anima = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Animal.txt";
        string multik = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Multiks.txt";
        string geo = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Geograf.txt";
        string istoria = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\History.txt";
        string fizika = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Phisiks.txt";
        StreamWriter sw;
        StreamReader sr;
        public RedactMaterial()
        {
            InitializeComponent();
     
        }

        #region Мультики
        private void btnDownlMult_Click(object sender, EventArgs e)
        {
            listMult.Items.Clear();
            using (sr = new StreamReader(multik, Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    listMult.Items.Add(line);

                }
            }
        }
        private void txtAdssMult_TextChanged(object sender, EventArgs e)
        {
            if (txtAdssMult.Text.Length >= 133) // проверка на количество символов, если больше 132, то запрет на запись
            {
                txtAdssMult.Enabled = false;
                btnAddsMult.Visible = false;
                MessageBox.Show("Количество символов превысило допустимое значение");
                txtAdssMult.Text = txtAdssMult.Text.Remove(txtAdssMult.Text.Length - 1); // убираем один символ из текстбокса, когда дляна превышена допустимое количество
            }
            else if (txtAdssMult.Text.Length <= 132)
            {
                txtAdssMult.Enabled = true;
                btnAddsMult.Visible = true;
            }
            lbKolvoMult.Text = "Количество символов " + txtAdssMult.Text.Length.ToString(CultureInfo.InvariantCulture); // отображение количества символов набранных в textbox

        }

        private void btnAddsMult_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(multik)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAdssMult.Text);
                sw.Close();
            }
            txtAdssMult.Clear();
        }

        private void btnDelMult_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(multik).ToList();
                lines.Add("");
                lines.RemoveAt(listMult.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(multik, string.Join(Environment.NewLine, lines));

                listMult.ClearSelected();
                listMult.Items.Clear();

                sr = new StreamReader(multik); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!sr.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = sr.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listMult.Items.Add(str);
                }
                sr.Close();
            }

            catch (Exception ex)
            {
            }
        }
        #endregion

        #region Животные

        private void btnDownlAnimal_Click(object sender, EventArgs e)
        {
            listAnimal.Items.Clear();
            using (sr = new StreamReader(anima, Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    listAnimal.Items.Add(line);
                }
            }
        }

        private void txtAddsAnimal_TextChanged(object sender, EventArgs e)
        {
            if (txtAddsAnimal.Text.Length >= 133) // проверка на количество символов, если больше 132, то запрет на запись
            {
                txtAddsAnimal.Enabled = false;
                btnAddsAnimal.Visible = false;
                MessageBox.Show("Количество символов превысило допустимое значение");
                txtAddsAnimal.Text = txtAddsAnimal.Text.Remove(txtAddsAnimal.Text.Length - 1); // убираем один символ из текстбокса, когда дляна превышена допустимое количество
            }
            else if (txtAddsAnimal.Text.Length <= 132)
            {
                txtAddsAnimal.Enabled = true;
                btnAddsAnimal.Visible = true;
            }
            lbKolvoAnimal.Text = "Количество символов " + txtAddsAnimal.Text.Length.ToString(CultureInfo.InvariantCulture); // отображение количества символов набранных в textbox

        }

        private void btnDelAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(anima).ToList();
                lines.Add("");
                lines.RemoveAt(listAnimal.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(anima, string.Join(Environment.NewLine, lines));

                listAnimal.ClearSelected();
                listAnimal.Items.Clear();

                sr = new StreamReader(anima); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!sr.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = sr.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listAnimal.Items.Add(str);
                }
                sr.Close();
            }

            catch (Exception ex)
            {
            }
        }

        private void btnAddsAnimal_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(anima)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAddsAnimal.Text);
                sw.Close();
            }
            txtAddsAnimal.Clear();
        }


        #endregion

        #region География
        private void btnDownlGeo_Click(object sender, EventArgs e)
        {
            listGeo.Items.Clear();
            using (StreamReader r = new StreamReader(geo, Encoding.UTF8))
            {
                while ((line = r.ReadLine()) != null)
                {
                    listGeo.Items.Add(line);
                }
            }
        }

        private void btnDelGeo_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(geo).ToList();
                lines.Add("");
                lines.RemoveAt(listGeo.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(geo, string.Join(Environment.NewLine, lines));

                listGeo.ClearSelected();
                listGeo.Items.Clear();

                StreamReader streamReader = new StreamReader(geo); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!streamReader.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = streamReader.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listGeo.Items.Add(str);
                }
                streamReader.Close();
            }

            catch (Exception ex)
            {
            }
        }

        private void btnAddsGeo_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(geo)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAddsGeo.Text);
                sw.Close();
            }
            txtAddsGeo.Clear();
        }

        private void txtAddsGeo_TextChanged(object sender, EventArgs e)
        {
            if (txtAddsGeo.Text.Length >= 133) // проверка на количество символов, если больше 132, то запрет на запись
            {
                txtAddsGeo.Enabled = false;
                btnAddsGeo.Visible = false;
                MessageBox.Show("Количество символов превысило допустимое значение");
                txtAddsGeo.Text = txtAddsGeo.Text.Remove(txtAddsGeo.Text.Length - 1); // убираем один символ из текстбокса, когда дляна превышена допустимое количество
            }
            else if (txtAddsGeo.Text.Length <= 132)
            {
                txtAddsGeo.Enabled = true;
                btnAddsGeo.Visible = true;
            }
            lbkolvoGeo.Text = "Количество символов " + txtAddsGeo.Text.Length.ToString(CultureInfo.InvariantCulture); // отображение количества символов набранных в textbox

        }


        #endregion

        #region История
        private void btnDownlHist_Click(object sender, EventArgs e)
        {
            listHist.Items.Clear();
            using (sr = new StreamReader(istoria, Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    listHist.Items.Add(line);
                }
            }
        }

        private void btnDelHist_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(istoria).ToList();
                lines.Add("");
                lines.RemoveAt(listHist.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(istoria, string.Join(Environment.NewLine, lines));

                listHist.ClearSelected();
                listHist.Items.Clear();

                sr = new StreamReader(istoria); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!sr.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = sr.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listHist.Items.Add(str);
                }
                sr.Close();
            }

            catch (Exception ex)
            {
            }
        }

        private void btnAddsHist_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(istoria)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAddsHist.Text);
                sw.Close();
            }
            txtAddsHist.Clear();
        }

        private void txtAddsHist_TextChanged(object sender, EventArgs e)
        {
            if (txtAddsHist.Text.Length >= 133) // проверка на количество символов, если больше 132, то запрет на запись
            {
                txtAddsHist.Enabled = false;
                btnAddsHist.Visible = false;
                MessageBox.Show("Количество символов превысило допустимое значение");
                txtAddsHist.Text = txtAddsHist.Text.Remove(txtAddsHist.Text.Length - 1); // убираем один символ из текстбокса, когда дляна превышена допустимое количество
            }
            else if (txtAddsHist.Text.Length <= 132)
            {
                txtAddsHist.Enabled = true;
                btnAddsHist.Visible = true;
            }
            lbKlolvoHist.Text = "Количество символов " + txtAddsHist.Text.Length.ToString(CultureInfo.InvariantCulture); // отображение количества символов набранных в textbox

        }

        #endregion

        #region Физика
        private void btnDownlPhis_Click(object sender, EventArgs e)
        {
            listPhis.Items.Clear();
            using (sr = new StreamReader(fizika, Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    listPhis.Items.Add(line);
                }
            }
        }

        private void btnDelPhis_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadLines(fizika).ToList();
                lines.Add("");
                lines.RemoveAt(listPhis.SelectedIndex); // удалить выбранную строку
                File.WriteAllText(fizika, string.Join(Environment.NewLine, lines));

                listPhis.ClearSelected();
                listPhis.Items.Clear();

                sr = new StreamReader(fizika); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                while (!sr.EndOfStream) //Цикл длится пока не будет достигнут конец файла
                {
                    str = sr.ReadLine(); //В переменную str построчно записываем содержимое файла
                    listPhis.Items.Add(str);
                }
                sr.Close();
            }

            catch (Exception ex)
            {
            }
        }

        private void btnAddsPhis_Click(object sender, EventArgs e)
        {
            using (sw = File.AppendText(fizika)) // добавляем текст поверх имеющегося
            {
                sw.WriteLine(txtAddsPhis.Text);
                sw.Close();
            }
           txtAddsPhis.Clear();
        }

        private void txtAddsPhis_TextChanged(object sender, EventArgs e)
        {
            if (txtAddsPhis.Text.Length >= 133) // проверка на количество символов, если больше 132, то запрет на запись
            {
                txtAddsPhis.Enabled = false;
                btnAddsPhis.Visible = false;
                MessageBox.Show("Количество символов превысило допустимое значение");
                txtAddsPhis.Text = txtAddsPhis.Text.Remove(txtAddsPhis.Text.Length - 1); // убираем один символ из текстбокса, когда дляна превышена допустимое количество
            }
            else if (txtAddsPhis.Text.Length <= 132)
            {
                txtAddsPhis.Enabled = true;
                btnAddsPhis.Visible = true;
            }
            lbKolvoPhis.Text = "Количество символов " + txtAddsPhis.Text.Length.ToString(CultureInfo.InvariantCulture); // отображение количества символов набранных в textbox
        }
        #endregion
    }
}
