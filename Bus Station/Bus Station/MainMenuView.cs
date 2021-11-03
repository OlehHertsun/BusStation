using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    class MainMenuView
    {
        public void ShowHeader()
        {
            Console.WriteLine("Hello Human, how can I help you?");
        }

        public void ShowTripsTable(List<TripModel>trips)
        {
            ShowTripsHeader();
            foreach (var oneTrip in trips)
            {
                Console.WriteLine($"{oneTrip.Id} : {oneTrip.DepartureTime.ToShortDateString()} : {oneTrip.TripFrom}");
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("1 - Show all");
            Console.WriteLine("2 - Find by Id");
            Console.WriteLine("3 - Finde by destination");
        }

        private void ShowTripsHeader()
        {
            Console.WriteLine("N     DEPARTURE    FROM ");
        }
    }
}
