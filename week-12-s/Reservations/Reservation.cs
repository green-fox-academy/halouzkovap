using System;
using System.Text;

namespace Reservations
{
    public enum dayInWeek { THU, WED, MON, SAT, THR, FRI, SUD };
    class Reservation : IReservations
    {
        private dayInWeek ReservationDay { get; set; }
        private string reservationNumber;

        public Reservation(dayInWeek day)
        {
            ReservationDay = day;
            reservationNumber = GetCodeBooking();
        }
        public int MyProperty { get; set; }
        public string GetCodeBooking()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(3, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(1, false));
            return builder.ToString();
        }

        public string GetDowBooking()
        {
            return $"Booking# {reservationNumber} for {ReservationDay}";
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToUpper();
            return builder.ToString();
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
