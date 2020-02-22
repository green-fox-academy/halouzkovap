using System;

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
        protected override void Sound()
        {
            Console.WriteLine(" Twang");
        }

        public override void Play()
        {
            base.Play();
            Sound();
        }
    }
}
