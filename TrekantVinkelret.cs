
namespace Dyhrman.Figurer
{
    public class TrekantVinkelret : Trekant
    {
        public decimal SidelængdeA { get; set; }
        public decimal SidelængdeB { get; set; }
        public TrekantVinkelret(string navn, decimal sidelængdeA, decimal sidelængdeB):base(navn)
        {
            SidelængdeA = sidelængdeA;
            SidelængdeB = sidelængdeB;
        }

        public override decimal Omkreds()
        {
            var c2 = (double)(SidelængdeA * SidelængdeA + SidelængdeB * SidelængdeB);
            var sidelængdeC = (decimal)System.Math.Sqrt(c2);
            return SidelængdeA + SidelængdeB + sidelængdeC;
        }

        public override decimal Areal()
        {
            return SidelængdeA * SidelængdeB*(decimal)0.5;
        }
    }
}
