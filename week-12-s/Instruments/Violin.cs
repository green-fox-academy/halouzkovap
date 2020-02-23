namespace Instruments
{
    public class Violin : StringedInstrument
    {
        public Violin()
        {
            NameOfInstrument = "Violin";
            numberOfStrings = 6;
        }
        public Violin(int number)
        {
            NameOfInstrument = "Violin";
            numberOfStrings = number;
        }
        protected override string Sound()
        {
            return "Screech";
        }

    }
}
