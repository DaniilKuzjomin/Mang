using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Ese : IUksus // класс Ese реализует интерфейс IUksus
    {

        private int punktideArv; // частное свойство punktideArv
         private string nimi; // частное свойство nimi

        public Ese(int punktideArv, string nimetus) // Конструктор с двумя параметрами по которым можно определить Имя и кол-во Точек
        {
            this.punktideArv = punktideArv;
            this.nimi = nimetus;
        }


        public string info() { return nimi; } // метод info возвращает Имя
        public int PunktideArv() { return punktideArv; } // метод PunktideArv возвращает Кол-во строчек
    }
}
