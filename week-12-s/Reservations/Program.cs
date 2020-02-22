using System;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            var reserve = new Reservation(dayInWeek.MON);

            Console.WriteLine(reserve.GetDowBooking());

            var reserveUpdate = new ReservationUpdate();

            reserveUpdate.MyReservation();
        }
    }
}
