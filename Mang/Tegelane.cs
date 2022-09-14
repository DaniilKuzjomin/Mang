using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Tegelane : IUksus, IComparable<Tegelane> // Класс Tegelane реализует интерфейс IUksus и 
    {
        public string nimi; // частное свойство nimi
        List<Ese> EseList = new List<Ese>(); // список элементов List<Ese>

        public Tegelane(string nimi) // конструктор с одним параметром который используется для установки имени
        {
            this.nimi = nimi;
        }

        public int PunktideArv() // метод PunktideArv возвращает сумму количества очков предметов персонажа.
        {
            int psum = 0;
            foreach (Ese item in EseList)
            {
                psum += item.PunktideArv();
            }
            return psum;
        }
        public int lisaEse(int item){ return item; } // метод lisaEse который запоминает элемент переданный в качестве элемента



        public string Info(int esemeteArv) // метод Info возвращает информацию о персонаже в виде текста, показывающего имя персонажа, количество предметов и количество очков
        {
            string info = $"nimi - {nimi}, esemetr arv - {esemeteArv}, punktide arv - {PunktideArv()}";
            return info;
        }
        

        public string valjastaEsemed() // метод valjastaEsemed где предметы персонажа выводятся на экран так, чтобы каждый предмет находился на отдельной строке.
        {
            foreach (Ese item in EseList)
            {
                Console.WriteLine(item);
            }
            return valjastaEsemed(); 
        }

        public string info()
        {
            throw new NotImplementedException();
        }


        public int CompareTo(Tegelane? other) 
        {
            if (other == null) return 1;
            return this.eses.Count - other.ItemCount();
        }

        public int ItemCount() { return eses.Count; }
    }
}




//while ((text = sr.ReadLine()) != null)
//{
//    string[] rida = text.Split(';');
//    item.Add(new Ese());
//}
//sr.Close();
