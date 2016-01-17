
namespace Dyhrman.Figurer
{
    public class Rektangle : Firkant
    {
        public decimal SidelængdeA { get; set; }
        public decimal SidelængdeB { get; set; }
        public Rektangle(string navn, decimal sidelængdeA, decimal sidelængdeB):base(navn)
        {
            SidelængdeA = sidelængdeA;
            SidelængdeB = sidelængdeB;
        }

        public override decimal Omkreds()
        {
            return SidelængdeA * 2 + SidelængdeB * 2;
        }

        public override decimal Areal()
        {
            return SidelængdeA * SidelængdeB;
        }
    }
}
