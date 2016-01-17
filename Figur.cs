using System;

namespace Dyhrman.Figurer
{
    public abstract class Figur
    {
        public string Navn { get; private set; }

        public Figur(string navn)
        {
            Navn = navn;
        }
        public abstract decimal Omkreds();

        public abstract decimal Areal();

        public decimal Rumfang(decimal højde)
        {
            return Areal() * højde;
        }

    }
}
