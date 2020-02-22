using System;

namespace Reservations
{
    class ReservationUpdate : IReservations
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        public ReservationUpdate()
        {

        }
        public void MyReservation()
        {
            Console.WriteLine($"Booking# {GetCodeBooking()} for {GetDowBooking()}");
        }
        public string GetCodeBooking()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[RandomNumber(0, chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }
        public string GetDowBooking()
        {
            string[] days = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            return days[RandomNumber(0, days.Length)];
        }
    }
}


