using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public void btnStarted_Click(object sender, EventArgs e)
        {
            string gender; // создаем переменную для выбора пола
                if (rbtnMen.Enabled) 
                gender = "М";
            else gender = "Ж";

            using (Context db = new Context()) //устанавливам связь с EF context
            {
                try
                {
                    if ((txtBoxSurname.Text.Equals("")) || (txtBoxName.Text.Equals("")) || (txtBoxPatronymic.Text.Equals("")) || (txtBoxLogin.Text.Equals("")) || (txtBoxParol.Text.Equals(""))) // проверка на заполненость полей
                    {
                        MessageBox.Show("Заполните все поля");
                        return;
                    }
                    else
                    {
                        Registration reg = new Registration(
                        )
                        {
                            Surname = txtBoxSurname.Text,
                            Name = txtBoxName.Text,
                            Patronymic = txtBoxPatronymic.Text,
                            Gender = gender,
                            Дата_рождения = dateTP.Value.Date,
                            Login = txtBoxLogin.Text,
                            Parol = txtBoxParol.Text,
                            Roless = "User",
                            Score = 0};
                        db.Registrations.Add(reg);// добавляем в поля данные из ячеек
                        db.InfoPlayers.Add(new InfoPlayer { Id_игрока = reg.id, id_достижения = 18, Наличие = true});
                        Avtorization.logginO = reg.Login;
                        db.SaveChanges(); //сохраняем данные
                        Program.s.Show();
                        Hide();
                    }
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Игрок с таким логином уже есть, придумайте другой!");
                }
            }
            
        }

        private void btnStepBack_Click(object sender, EventArgs e)
        {
            Program.a.Show();
            this.Close();
        }
    }
}
