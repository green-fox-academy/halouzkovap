using System;

namespace Flyable
{
    class Bird : IFlyable
    {
        public string Name { get; set; }
        public Bird(string name)
        {
            Name = name;
        }
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
