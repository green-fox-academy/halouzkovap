using System;

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
        protected override void Sound()
        {
            Console.WriteLine("Screech");
        }

        public override void Play()
        {
            base.Play();
            Sound();
        }
    }
}
