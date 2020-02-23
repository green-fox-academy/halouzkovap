namespace Instruments
{
    public class BasseGuitare : StringedInstrument
    {
        public BasseGuitare()
        {
            NameOfInstrument = "Base guitare";
            numberOfStrings = 6;
        }
        public BasseGuitare(int number)
        {
            NameOfInstrument = "Base guitare";
            numberOfStrings = number;
        }
        protected override string Sound()
        {
            return "Duum-duum-duum";
        }


    }
}
