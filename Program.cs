using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyhrman.Figurer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var figurliste = new List<Figur>();
            var figur1 = new Kvardrat("Kvardrat 1",10);
            var figur2 = new Rektangle("Rektangle 1",10, 20);

            figurliste.Add(figur1);
            figurliste.Add(figur2);

            foreach (var figur in figurliste)
            {
                Udskriv(figur);
            }
            Console.WriteLine("Tryk return");
            Console.ReadLine();
        }

        private static void Udskriv(Figur figur)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(figur.Navn);
            Console.WriteLine("Omkreds: " + figur.Omkreds());
            Console.WriteLine("Areal  : " + figur.Areal());
            Console.WriteLine("Rumfang: " + figur.Rumfang(10));
        }
    }
}
