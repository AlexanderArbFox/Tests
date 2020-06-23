using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Тестирование
{
    public partial class Avtorization : Form
    {
        RoleClass db = new RoleClass();
        public static string logginO;
        public static int UsScoore;
        public Avtorization()
        {
            InitializeComponent();
        }
        private void VhodBut_Click(object sender, EventArgs e) // кнопка входа
        {
            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("roles", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@ylog", TBLog.Text);
                    cmd.Parameters.AddWithValue("@ypass", TBPar.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[8].ToString() == "Admin")
                        {
                            RoleClass.type = "A";
                        }
                        else if (rd[8].ToString() == "User")
                        {
                            RoleClass.type = "U";
                        }
                        logginO = TBLog.Text;
                        FormApps fa = new FormApps();
                        fa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль или логин");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CbVlan_CheckedChanged(object sender, EventArgs e) // функция видимости символов в textbox Parol
        {
             if(CbVlan.Checked)
             {
                 TBPar.UseSystemPasswordChar = false;
             }
             else 
             {
                 TBPar.UseSystemPasswordChar = true;
             }
        }

        private void btnRegistration_Click(object sender, EventArgs e) // Кнопка регистрации
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
           this.Hide();
        }
        
    }
}
