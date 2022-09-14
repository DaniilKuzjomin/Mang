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


        double summ;
        public string info() // метод Info возвращает информацию о персонаже в виде текста, показывающего имя персонажа, количество предметов и количество очков
        {
            Console.WriteLine($"Nimi: {nimi}");
            foreach (string line in File.ReadLines(@"..\..\..\esemed.txt"))
            {
                string[] row = line.Split(';');
                summ += Double.Parse(row[1]);
                Ese ese = new Ese(row[0], Int32.Parse(row[1]));
                EseList.Add(ese);
                Console.WriteLine($"Nimetus: {row[0]}, Punktide arvu: {row[1]}");
            }
            Console.WriteLine($"Esemete arvu: {EseList.Count}, Summa: {summ}");
            return $"{nimi}";
        }

        
        public void väljastaEsemed() // метод valjastaEsemed где предметы персонажа выводятся на экран так, чтобы каждый предмет находился на отдельной строке.
        {
            foreach (Ese item in EseList)
            {
                Console.WriteLine(item.info() + " " + item.PunktideArv());
            }
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
