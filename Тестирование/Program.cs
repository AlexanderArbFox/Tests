using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Тестирование.Properties;

namespace Тестирование
{
    static class Program
    {
        public static Avtorization a;
        public static FormApps s;
        public static Sounds_Class sc = new Sounds_Class() ;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            s = new FormApps();
            a = new Avtorization();
            sc.MainMusiik();
            s.GetMyScore();
            Application.Run(a);
            
        }
    }
}
