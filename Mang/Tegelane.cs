using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Tegelane : IUksus, IComparable<Tegelane> // Класс Tegelane реализует интерфейс IUksus 
    {
        public string nimi; // частное свойство nimi
        List<Ese> EseList; // список элементов List<Ese>

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


        double summ;
        public string info() // метод Info возвращает информацию о персонаже в виде текста, показывающего имя персонажа, количество предметов и количество очков
        {
            string tegelase_info;
            tegelase_info = nimi + ", " + EseList.Count() + ", " + PunktideArv();
            return tegelase_info;
        }

        
        public void väljastaEsemed() // метод valjastaEsemed где предметы персонажа выводятся на экран так, чтобы каждый предмет находился на отдельной строке.
        {
            foreach (Ese item in EseList)
            {
                Console.WriteLine(item.info());
            }
        }


        public int CompareTo(Tegelane? other) 
        {
            if (other == null) return 1;
            return this.EseList.Count - other.EsesKogus();
        }

        public int EsesKogus() { return this.EseList.Count; }
    }
}




//while ((text = sr.ReadLine()) != null)
//{
//    string[] rida = text.Split(';');
//    item.Add(new Ese());
//}
//sr.Close();
