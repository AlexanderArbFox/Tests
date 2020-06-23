using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
    public partial class BonusForm : Form
    {
        public BonusForm()
        {
            InitializeComponent();
            this.ControlBox = false;
           Achievement.getAchievement(Avtorization.logginO, 18, pictureStarrt);
            Achievement.getAchievement(Avtorization.logginO, 19, pictureMults);
            Achievement.getAchievement(Avtorization.logginO, 20, pictureAnimal);
            Achievement.getAchievement(Avtorization.logginO, 21, pictureGeographik);
            Achievement.getAchievement(Avtorization.logginO, 22, pictureHistory);
            Achievement.getAchievement(Avtorization.logginO, 23, picturePhisiks);
        }

        private void btnMenuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}