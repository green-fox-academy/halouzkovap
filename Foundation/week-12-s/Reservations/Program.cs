using System;
using System.Text;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var reserve = new Reservation(dayInWeek.MON);

            Console.WriteLine(reserve.GetDowBooking());

            var reserveUpdate = new ReservationUpdate();

            reserveUpdate.MyReservation();
        }
    }
}
