namespace Dyhrman.Figurer
{
    public class Kvardrat : Firkant
    {
        public decimal Sidelængde { get; set; }
        public Kvardrat(string navn, decimal sidelængde):base(navn)
        {
            Sidelængde = sidelængde;
        }

        public override decimal Omkreds()
        {
            return Sidelængde * 4;
        }

        public override decimal Areal()
        {
            return Sidelængde * Sidelængde;
        }
    }
}
