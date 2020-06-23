using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Media;
using System.Threading;

namespace Тестирование
{

    class Sounds_Class
    {
        SoundPlayer sound = new SoundPlayer();
        public void MusOffeded() // Функция для отключения музыки
        {
            Sounds_Class soundp = new Sounds_Class();
            sound.Stop();
        }

        public void MainMusiik() //музыка для фона
        {
            FormApps fa = new FormApps();
            Assembly assembly = Assembly.GetExecutingAssembly(); //встроенная функция для получения музыки
            Stream stream = assembly.GetManifestResourceStream(@"Тестирование.Sounds.MainMus.wav");
            SoundPlayer sound = new SoundPlayer(stream);
            sound.PlayLooping(); // играет без перерыва (бесконечно)
        }
    }
 }

