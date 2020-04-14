namespace Instruments
{
    public abstract class Instrument
    {
        protected string NameOfInstrument { get; set; }
        public abstract void Play();

    }
}
