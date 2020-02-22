using System;

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
        protected override void Sound()
        {
            Console.WriteLine(" Duum-duum-duum");
        }

        public override void Play()
        {
            base.Play();
            Sound();
        }
    }
}
