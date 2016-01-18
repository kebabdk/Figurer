
namespace Dyhrman.Figurer
{
    public class TrekantLigebenet : Trekant
    {
        public decimal SidelængdeEns { get; set; }
        public decimal SidelængdeB { get; set; }
        public TrekantLigebenet(string navn, decimal sidelængdeEns, decimal sidelængdeB):base(navn)
        {
            SidelængdeEns = sidelængdeEns;
            SidelængdeB = sidelængdeB;
        }

        public override decimal Omkreds()
        {
            return 2 * SidelængdeEns + SidelængdeB;
        }

        public override decimal Areal()
        {
            var s = Omkreds() / 2;
            var tmp = (double)(s * (s - SidelængdeEns) * (s - SidelængdeEns) * (s - SidelængdeB));
            return (decimal)System.Math.Sqrt(tmp);
        }
    }
}
