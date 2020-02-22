using System;

namespace Flyable
{
    class Helicopter : Vehicle, IFlyable
    {
        public Helicopter()
        {
            MaxSpeed = 200;
            Name = "Helicopter";
            NumberOfSeats = 4;
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
