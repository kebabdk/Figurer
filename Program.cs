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
            figurliste.Add(new Kvardrat("Kvardrat 1", 10));
            figurliste.Add(new Rektangle("Rektangle 1", 10, 20));
            figurliste.Add(new TrekantVinkelret("Vinkelret 1", 10, 20));
            figurliste.Add(new TrekantLigebenet("Ligebenet 1", 15, 20));

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
            Console.WriteLine($"Omkreds: {figur.Omkreds(),12:N2}");
            Console.WriteLine($"Areal  : {figur.Areal(),12:N2}");
            Console.WriteLine($"Rumfang: {figur.Rumfang(10),12:N2}");
        }
    }
}
