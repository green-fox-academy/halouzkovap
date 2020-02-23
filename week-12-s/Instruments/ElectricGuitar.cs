namespace Instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        //Violin(4 strings, "Screech")
        public ElectricGuitar()
        {
            NameOfInstrument = "Electric guitar";
            numberOfStrings = 6;
        }
        public ElectricGuitar(int number)
        {
            NameOfInstrument = "Electric Guitar";
            numberOfStrings = number;
        }
        protected override string Sound()
        {
            return "twangs";
        }

    }
}
