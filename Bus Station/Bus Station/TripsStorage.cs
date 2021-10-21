using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Station
{
    
    public class TripsStorage
    {
        public static List <TripModel> Trips = new List<TripModel>
        {
            new TripModel(1, new DateTime(2022,1,1), "Vinnitsa", new DateTime(2022,1,2), "Harkiv", new BusModel("Ikarus", 40),1500),
        };
    }
}
