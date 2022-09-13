using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Tegelane : IUksus // Класс Tegelane реализует интерфейс IUksus
    {
        public string nimi; // частное свойство nimi
        List<Ese> item; // список элементов List<Ese>

        public Tegelane(string nimi) // конструктор с одним параметром который используется для установки имени
        {
            this.nimi = nimi;
        }



        public string info()
        {
            throw new NotImplementedException();
        }

        public int PunktideArv()
        {
            throw new NotImplementedException();
        }


        public void lisaEse() // метод lisaEse который запоминает элемент переданный в качестве элемента
        {
            Tegelane tegelane = new Tegelane(nimi);
        }

        public void punktideArv()
        {


        }

    }
}
