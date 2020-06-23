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
    public partial class Material : Form
    {
        string anima = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Animal.txt";
        string multik = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Multiks.txt";
        string geo = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Geograf.txt";
        string istoria = @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\History.txt";
        string fizika= @"C:\Users\Александр\source\repos\Тестирование\Тестирование\Information\Phisiks.txt";
        StreamWriter sw;
        StreamReader sr;
        public Material()
        {
            InitializeComponent();
            this.ControlBox = false;
           // anima += selectSaveAnimal();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.s.Show();
            this.Close();
        }
        #region События по загрузке файла в Листбокс
        private void btnAnimal_Click(object sender, EventArgs e) // подгрузка файла с данными для темы по животным
        {
            listInfo.Items.Clear();
            string[] lines = File.ReadAllLines(anima, Encoding.UTF8);
            foreach(string str in lines)
            {
                listInfo.Items.Add(str);// (strun);
            }

            }

        private void btnMults_Click(object sender, EventArgs e) // подгрузка файла с данными для темы по мультикам
        {
            listInfo.Items.Clear();
            string[] lines = File.ReadAllLines(multik, Encoding.UTF8);
            foreach (string str in lines)
            {
                listInfo.Items.Add(str);// (strun);
            }

        }
        
        private void btnGeograph_Click(object sender, EventArgs e)
        {
            listInfo.Items.Clear();
            string[] lines = File.ReadAllLines(geo, Encoding.UTF8);
            foreach (string str in lines)
            {
                listInfo.Items.Add(str);// (strun);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            listInfo.Items.Clear();
            string[] lines = File.ReadAllLines(istoria, Encoding.UTF8);
            foreach (string str in lines)
            {
                listInfo.Items.Add(str);// (strun);
            }
        }

        private void btnPhisik_Click(object sender, EventArgs e)
        {
            listInfo.Items.Clear();
            string[] lines = File.ReadAllLines(fizika, Encoding.UTF8);
            foreach (string str in lines)
            {
                listInfo.Items.Add(str);// (strun);
            }
        }
        #endregion


        private void Material_Load(object sender, EventArgs e) // Устанавливаем для пользователя запрет на видимость для след. элементов
        {
            if (RoleClass.type == "U")
            {
                btnRedactTxt.Visible = false;
            }
        }

        private void btnRedactTxt_Click(object sender, EventArgs e)
        {
            RedactMaterial red = new RedactMaterial();
            red.Show();

        }
    }
    }
    

