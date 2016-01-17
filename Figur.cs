using System;

namespace Dyhrman.Figurer
{
    public abstract class Figur
    {
        public Figur()
        {
        }
        public abstract decimal Omkreds();

        public abstract decimal Areal();

        public decimal Rumfang(decimal højde)
        {
            return Areal() * højde;
        }

    }
}
