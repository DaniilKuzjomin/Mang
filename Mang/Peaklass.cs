using Mang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal static class Peaklass
    {
        public static Random rnd = new Random();
        public static List<Ese> LoeEsemed()
        {
            List<Ese> EseList = new List<Ese>();
            using(StreamReader sr = new StreamReader(@"../../Andmed.txt"))
            {
                while (!sr.EndOfStream)
                {
                    String[] rida = sr.ReadLine().Split(";");
                    Ese ese = new Ese(StoI(rida[1]), rida[0]);
                    EseList.Add(ese);
                }
            }
            return EseList;

            static string Names()
            {
                string[] names = { "Deniska", "Artjomka", "Timofeika", "Sanjka", "Danjka" };
                return names[rnd.Next(names.Length)];
            }

            static int StoI(string s)
            {
                int y = 0;
                int total = 0;
                for (int i = 0; i < s.Length; i++)
                    y = y * 10 + (s[i] - '0');
                
                total += y;
                return total;
            }

            public static void Shuffle<T>(this IList<T> list)
            {
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rnd.Next(n + 1);
                    T value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }


            static Tegelane[] Players(int playercount)
            {
                if (playercount < 2) throw new Exception();
                Tegelane[] players = new Tegelane[playercount];
                for (int i = 0; i < playercount; i++)
                {
                    Tegelane player = new Tegelane(Names());
                    players[i] = player;
                }

                return giveOutItems(players);
            }


            static Tegelane[] giveOutItems(Tegelane[] players)
            {
                List<Ese> itemList = LoeEsemed();
                if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
                foreach (Tegelane player in players)
                {
                    Shuffle(itemList);
                    int amount = rnd.Next(2, 10); //Iga tegelase jaoks genereeritakse juhuslik arv n vahemikust [2,10]
                    for (int i = 0; i < amount; i++)
                    {
                        player.lisaEse(itemList[i]);
                    }
                }
                return players;
            }





        }
    }
}
