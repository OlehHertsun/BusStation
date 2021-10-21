using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Station
{
    public class InputComponent
    {
        public int GetInputInt()
        {
            Console.WriteLine("Enter integer, and press Enter");
            var userChoice = Console.ReadLine();
            var isParsed = int.TryParse(userChoice, out var intValue);
            if(isParsed)
            {
                return intValue;
            }
        }
    }
}
