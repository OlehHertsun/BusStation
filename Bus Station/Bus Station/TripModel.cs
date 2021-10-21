using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Station
{
    public class TripModel
    {
        public int Id { get; }

        public DateTime DepartureTime { get; }

        public string TripFrom { get; }

        public DateTime ArrivalTime { get; }

        public string TripTo { get; }


    }
}
