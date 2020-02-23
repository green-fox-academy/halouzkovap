namespace Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings { get; set; }
        public StringedInstrument()
        {
            NameOfInstrument = NameOfInstrument;
            numberOfStrings = numberOfStrings;

        }
        protected abstract string Sound();

        public override void Play()
        {
            System.Console.Write($"{NameOfInstrument}, a {numberOfStrings} - stringed instrument that {Sound()}.\n");

        }

        //but with the help of the Sound() the Play() method is fully implementable
        //StingedInstrumenthas 3 descendants, namely:


    }
}
