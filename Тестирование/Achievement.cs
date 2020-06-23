using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
  static class Achievement
    {
        
        public static void getAchievement(string login, int id, PictureBox PictureStarrt ) // отображение достижений на форме Достижения
        {
            try
            {
                using (Context db = new Context())
                {
                    InfoPlayer info = db.InfoPlayers.Where(d => d.Registration.Login == login && d.id_достижения == id).FirstOrDefault();
                    if (info.Наличие = true) PictureStarrt.Visible = true;
                }
            }
            catch(Exception e)
            {
                
            }
        }

    }
}
